Public Class InventoryForm


    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Dim ID As Integer




    Private Sub btnBorrowed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowed.Click

        lstviewBorrowed.Visible = True
        lstAll.Visible = False
        lstDamage.Visible = False


        statusView.Text = "Your Viewing Borrowed Books List"

    End Sub

    Private Sub btnDamaged_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDamaged.Click

        DamageGrid()

        lstDamage.Visible = True

        lstviewBorrowed.Visible = False


        statusView.Text = "Your Viewing Damaged Books List"

    End Sub


    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        AllGrid()
        lstAll.Visible = True

        lstDamage.Visible = False

        statusView.Text = "Your Viewing All Books List"

    End Sub

    Private Sub InventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BorrowedGrid("")

        statusView.Text = "Your Viewing Borrowed Books List"

    End Sub

    Private Sub BorrowedGrid(ByVal StringSearch As String)

        con.Open()

        Dim ID = 0

        Dim dt As New DataTable("tblBookBorrowed")
        Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM tblBookBorrowed", con)

        rs.Fill(dt)

        For index = 0 To dt.Rows.Count - 1

            Dim lst As New ListViewItem


            lst.Text = dt.Rows(index).Item("ID3")
            lst.SubItems.Add(dt.Rows(index).Item("BookTitle"))
            lst.SubItems.Add(dt.Rows(index).Item("Author"))
            lst.SubItems.Add(dt.Rows(index).Item("Publisher"))
            lst.SubItems.Add(dt.Rows(index).Item("DueDate"))
            lst.SubItems.Add(dt.Rows(index).Item("BID"))
            lst.SubItems.Add(dt.Rows(index).Item("BName"))

            lstviewBorrowed.Items.Add(lst)



        Next

        rs.Dispose()
        con.Close()




    End Sub

    Private Sub DamageGrid()

        con.Open()

        Dim ID = 0

        Dim dtb As New DataTable("tblDamage")
        Dim rsb As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM tblDamage", con)

        rsb.Fill(dtb)

        Dim index As Integer

        lstDamage.Items.Clear()

        For index = 0 To dtb.Rows.Count - 1



            Dim lst As New ListViewItem


            lst.Text = dtb.Rows(index).Item("ID4")
            lst.SubItems.Add(dtb.Rows(index).Item("Title"))
            lst.SubItems.Add(dtb.Rows(index).Item("Author"))
            lst.SubItems.Add(dtb.Rows(index).Item("BName"))

            lstDamage.Items.Add(lst)



        Next

        rsb.Dispose()
        con.Close()


    End Sub

    Private Sub AllGrid()

        con.Open()

        ID = 0

        Dim dta As New DataTable("tblBooks")
        Dim rsa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM tblBooks", con)

        rsa.Fill(dta)

        Dim index As Integer
        lstAll.Items.Clear()

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

            lstAll.Items.Add(lst)

        Next

        rsa.Dispose()
        con.Close()

    End Sub


   
  
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.Close()


    End Sub

   

End Class