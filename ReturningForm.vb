Public Class ReturningForm

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Dim id As String
    Dim bookcopy2 As Integer
    Dim bal As Integer


    Dim Bal2 As Integer

    Dim Copy As Integer
    Dim copy2 As Integer

    Dim status As String



    Private Sub ReturningForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Loadgrid("")


    End Sub

    Private Sub Loadgrid(ByVal SearchString As String)

     
        con.Open()


        Dim dt As New DataTable("tblBookBorrowed")
        Dim rs As OleDb.OleDbDataAdapter
        If SearchString = "" Then

            rs = New OleDb.OleDbDataAdapter("SELECT * FROM tblBookBorrowed", con)

        Else

            rs = New OleDb.OleDbDataAdapter("SELECT * FROM tblBookBorrowed  WHERE BID LIKE '%" & SearchString & "%' ", con)


        End If

        rs.Fill(dt)

        Dim indx As Integer
        lstReturn.Items.Clear()

        For indx = 0 To dt.Rows.Count - 1

            Dim lst As New ListViewItem

            lst.Text = dt.Rows(indx).Item("ID3")
            lst.SubItems.Add(dt.Rows(indx).Item("BookTitle"))
            lst.SubItems.Add(dt.Rows(indx).Item("Author"))
            lst.SubItems.Add(dt.Rows(indx).Item("DueDate"))
            lst.SubItems.Add(dt.Rows(indx).Item("BID"))
            lst.SubItems.Add(dt.Rows(indx).Item("BName"))
            lst.SubItems.Add(dt.Rows(indx).Item("BookCopy2"))
            lst.SubItems.Add(dt.Rows(indx).Item("Balance2"))


            lstReturn.Items.Add(lst)

        Next

        rs.Dispose()
        con.Close()



    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged


        Loadgrid(txtSearch.Text)


    End Sub

    Private Sub lstReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstReturn.Click

        With lstReturn.SelectedItems(0)

            txtid3.Text = .SubItems(0).Text
            txtBookTitle.Text = .SubItems(1).Text
            txtAuthor.Text = .SubItems(2).Text
            txtDate.Text = .SubItems(3).Text
            txtBName.Text = .SubItems(5).Text
            id = .SubItems(4).Text
            bookcopy2 = .SubItems(6).Text
            bal = .SubItems(7).Text


        End With



    End Sub

    Private Sub lstReturn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReturn.SelectedIndexChanged

    
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click



        If bookcopy2 > 1 Then

            status = "Available"

        Else

            status = "Not Available"

        End If


        Bal2 = bal - 1

        Copy = bookcopy2 + 1

        copy2 = bookcopy2

        If txtid3.Text = "" Then Exit Sub

        con.Open()


        Dim rs As New OleDb.OleDbCommand("DELETE * FROM tblBookBorrowed WHERE ID3 = " & txtid3.Text & " ", con)

        rs.ExecuteNonQuery()

        Dim rsb As New OleDb.OleDbCommand("UPDATE tblBorrowers SET Balance = " & Bal2 & " WHERE IDno = '" & id & "' ", con)

        rsb.ExecuteNonQuery()

        Dim rsc As New OleDb.OleDbCommand("UPDATE tblBooks SET BookCopy = " & Copy & ", Status = '" & status & "' WHERE Title = '" & txtBookTitle.Text & "' ", con)

        rsc.ExecuteNonQuery()

        con.Close()

        MsgBox("Book Succesfully Returned", vbInformation)

        Loadgrid("")


    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub btnDamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDamage.Click

        con.Open()

        If bookcopy2 > 1 Then

            status = "Available"

        Else

            status = "Not Available"

        End If


        Bal2 = bal - 1

        Copy = bookcopy2 + 1

        copy2 = bookcopy2


        If txtid3.Text = "" Then Exit Sub


        Dim rsd As New OleDb.OleDbCommand(
            " INSERT INTO tblDamage (Title, Author, BName) VALUES ('" & txtBookTitle.Text & "', '" & txtAuthor.Text & "', '" & txtBName.Text & "' )", con)


        rsd.ExecuteNonQuery()

        Dim rs As New OleDb.OleDbCommand("DELETE * FROM tblBookBorrowed WHERE ID3 = " & txtid3.Text & " ", con)

        rs.ExecuteNonQuery()

        Dim rsb As New OleDb.OleDbCommand("UPDATE tblBorrowers SET Balance = " & Bal2 & " WHERE IDno = '" & id & "' ", con)

        rsb.ExecuteNonQuery()

        Dim rsc As New OleDb.OleDbCommand("UPDATE tblBooks SET BookCopy = " & copy2 & ", Status = '" & status & "' WHERE Title = '" & txtBookTitle.Text & "' ", con)

        rsc.ExecuteNonQuery()

        con.Close()

        MsgBox("Book Add to Damage list", vbInformation)

        Loadgrid("")


    End Sub


End Class