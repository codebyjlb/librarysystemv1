Public Class frmCatalogue

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Dim ID As Integer

    Shared Property Minimized As Boolean

    Private Sub Loadgrid(ByVal SearchString As String)

        con.Open()

        ID = 0

        Dim dtb As New DataTable("tblBorrowers")
        Dim rsb As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM tblBorrowers", con)

        rsb.Fill(dtb)

        Dim index As Integer
        lstviewBorrowers.Items.Clear()

        For index = 0 To dtb.Rows.Count - 1

            Dim lst As New ListViewItem

            lst.Text = dtb.Rows(index).Item("ID")
            lst.SubItems.Add(dtb.Rows(index).Item("IDno"))
            lst.SubItems.Add(dtb.Rows(index).Item("BName"))
            lst.SubItems.Add(dtb.Rows(index).Item("YearSec"))
            lst.SubItems.Add(dtb.Rows(index).Item("Address"))
            lst.SubItems.Add(dtb.Rows(index).Item("ContactNo"))
            lst.SubItems.Add(dtb.Rows(index).Item("Balance"))

            lstviewBorrowers.Items.Add(lst)

        Next

        rsb.Dispose()
        con.Close()




    End Sub

    Private Sub Loadgrid2(ByVal SearchString As String)

        con.Open()

        ID = 0

        Dim dta As New DataTable("tblBooks")
        Dim rsa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM tblBooks", con)

        rsa.Fill(dta)

        Dim index As Integer
        lstviewInventory.Items.Clear()

        For index = 0 To dta.Rows.Count - 1

            Dim lst As New ListViewItem

            lst.Text = dta.Rows(index).Item("ID2")
            lst.SubItems.Add(dta.Rows(index).Item("Title"))
            lst.SubItems.Add(dta.Rows(index).Item("Author"))
            lst.SubItems.Add(dta.Rows(index).Item("Publisher"))
            lst.SubItems.Add(dta.Rows(index).Item("Status"))
            lst.SubItems.Add(dta.Rows(index).Item("DateReleased"))
            lst.SubItems.Add(dta.Rows(index).Item("BookCopy"))
            lst.SubItems.Add(dta.Rows(index).Item("Shelve"))

            lstviewInventory.Items.Add(lst)

        Next

        rsa.Dispose()
        con.Close()


    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub BorrowersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowersToolStripMenuItem.Click



        statuslabel1.Text = "Your Viewing Inventory List"

        lstviewBorrowers.Hide()
        lstviewInventory.Show()

    End Sub

    Private Sub BorrowersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowersToolStripMenuItem1.Click

        statuslabel1.Text = "Your Viewing Borrowing List"

        lstviewInventory.Hide()
        lstviewBorrowers.Show()


    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub frmCatalogue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Loadgrid("")
        Loadgrid2("")
        StatusBar()


    End Sub

    Private Sub StatusBar()

        statuslabel1.Text = "Your Viewing Inventory List"

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub



    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        AddingForm.Show()


    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddingForm.Show()



    End Sub



    Private Sub lstviewInventory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewInventory.Click

        Panel1.Visible = True

        With lstviewInventory.SelectedItems(0)

            ID = .SubItems(0).Text
            txtTitle.Text = .SubItems(1).Text
            txtAuthor.Text = .SubItems(2).Text
            txtPublisher.Text = .SubItems(3).Text
            txtStatus.Text = .SubItems(4).Text
            txtDate.Text = .SubItems(5).Text
            txtCopy.Text = .SubItems(6).Text
            txtShelve.Text = .SubItems(7).Text

        End With

     

    End Sub



    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

     

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "UPDATE tblBooks SET Title = '" & txtTitle.Text & "', Author = '" & txtAuthor.Text & "', Publisher = '" & txtPublisher.Text & "', Status= '" & txtStatus.Text & "', DateReleased = '" & txtDate.Text & "', BookCopy = '" & txtCopy.Text & "', Shelve = '" & txtShelve.Text & "' WHERE ID2 = " & ID & " ", con)

        rs.ExecuteNonQuery()

        con.Close()

        Loadgrid2("")

        Clear()

        Panel1.Visible = False



    End Sub

    Private Sub Clear()

        txtTitle.Text = ""
        txtAuthor.Text = ""
        txtPublisher.Text = ""
        txtStatus.Text = ""
        txtDate.Text = ""
        txtCopy.Text = ""
        txtShelve.Text = ""

    End Sub



    
    Private Sub lstviewInventory_ItemMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemMouseHoverEventArgs) Handles lstviewInventory.ItemMouseHover



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Panel1.Visible = False



    End Sub

    Private Sub lstviewBorrowers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewBorrowers.Click


        Panel2.Visible = True


        With lstviewBorrowers.SelectedItems(0)

            ID = .SubItems(0).Text
            txtID.Text = .SubItems(1).Text
            txtName.Text = .SubItems(2).Text
            txtYr.Text = .SubItems(3).Text
            txtAddress.Text = .SubItems(4).Text
            txtContact.Text = .SubItems(5).Text
            txtBal.Text = .SubItems(6).Text



        End With

    End Sub




    Private Sub btnUpdate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate2.Click

        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "UPDATE tblBorrowers SET IDno = '" & txtID.Text & "', BName = '" & txtName.Text & "', YearSec = '" & txtYr.Text & "', Address= '" & txtAddress.Text & "', ContactNo = '" & txtContact.Text & "', Balance = '" & txtBal.Text & "' WHERE ID = " & ID & " ", con)

        rs.ExecuteNonQuery()

        con.Close()

        Loadgrid("")

        Clear()

        Panel2.Visible = False


    End Sub

    Private Sub btnDel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel2.Click

        If ID = 0 Then

            MsgBox("Please select first a record from the list!")
            Exit Sub

        End If

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

            con.Open()


            Dim rs As New OleDb.OleDbCommand("DELETE FROM tblBorrowers WHERE ID=" & ID & "", con)


            rs.ExecuteNonQuery()
            con.Close()
            Loadgrid("")

            Panel2.Visible = False



        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Panel2.Visible = False


    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel1.Visible = False



    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "UPDATE tblBooks SET Title = '" & txtTitle.Text & "', Author = '" & txtAuthor.Text & "', Publisher = '" & txtPublisher.Text & "', Status= '" & txtStatus.Text & "', DateReleased = '" & txtDate.Text & "', BookCopy = '" & txtCopy.Text & "', Shelve = '" & txtShelve.Text & "' WHERE ID2 = " & ID & " ", con)

        rs.ExecuteNonQuery()

        con.Close()

        Loadgrid2("")

        Clear()

        Panel1.Visible = False


    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If ID = 0 Then

            MsgBox("Please select first a record from the list!")
            Exit Sub

        End If

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

            con.Open()


            Dim rs As New OleDb.OleDbCommand("DELETE FROM tblBooks WHERE ID2=" & ID & "", con)


            rs.ExecuteNonQuery()
            con.Close()
            Loadgrid2("")

            Panel1.Visible = False



        End If

    End Sub

    Private Sub lstviewInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewInventory.SelectedIndexChanged

    End Sub
End Class
