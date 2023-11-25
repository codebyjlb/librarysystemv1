Public Class BorrowingForm


    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Dim ID As Integer
    Dim ID2 As Integer


    Dim lstIDno As String
    Dim lstName As String
    Dim YrSec As String
    Dim Address As String
    Dim Contact As Double
    Dim Balance As Integer

    Dim Title As String
    Dim Author As String
    Dim Publisher As String
    Dim Bookcopy As Integer
    Dim Status As String
    Dim idtemp As Integer




    Dim ids As Integer


    Private Sub BorrowingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBorrowBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BorrowBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub brnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub lstviewBorrowers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewBorrowers.Click



        lstviewBorrowers.Size = New Size(783, 167)

        lstviewInventory.Visible = True
        Label3.Show()
        txtBook.Show()
        txtSearch2.Show()
        btnBrw.Show()





        With lstviewBorrowers.SelectedItems(0)

            ID = .SubItems(0).Text
            lstIDno = .SubItems(1).Text
            lstName = .SubItems(2).Text
            YrSec = .SubItems(3).Text
            Address = .SubItems(4).Text
            Contact = .SubItems(5).Text
            Balance = .SubItems(6).Text

            statusborrower.Text = lstName
            statusid.Text = ID

        End With


    End Sub



    Sub Clear()


    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click



        con.Open()

        Dim dt As New DataTable("tblBorrowers")
        Dim rs As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * From tblBorrowers WHERE IDno LIKE '" & txtSearch.Text & "%' ", con)


        rs.Fill(dt)

        Dim index As Integer
        lstviewBorrowers.Items.Clear()


        For index = 0 To dt.Rows.Count - 1

            Dim lst As New ListViewItem

            lst.Text = dt.Rows(index).Item("ID")
            lst.SubItems.Add(dt.Rows(index).Item("IDno"))
            lst.SubItems.Add(dt.Rows(index).Item("BName"))
            lst.SubItems.Add(dt.Rows(index).Item("YearSec"))
            lst.SubItems.Add(dt.Rows(index).Item("Address"))
            lst.SubItems.Add(dt.Rows(index).Item("ContactNo"))
            lst.SubItems.Add(dt.Rows(index).Item("Balance"))

            lstviewBorrowers.Items.Add(lst)

        Next

        rs.Dispose()
        con.Close()






    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch2.Click


        con.Open()

        Dim dtb As New DataTable("tblBooks")
        Dim rsb As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * From tblBooks WHERE ID2 LIKE '" & txtBook.Text & "%' or Title Like '&" & txtBook.Text & "' ", con)


        rsb.Fill(dtb)


        Dim index As Integer
        lstviewInventory.Items.Clear()


        For index = 0 To dtb.Rows.Count - 1

            Dim lst As New ListViewItem


            lst.Text = dtb.Rows(index).Item("ID2")
            lst.SubItems.Add(dtb.Rows(index).Item("Title"))
            lst.SubItems.Add(dtb.Rows(index).Item("Author"))
            lst.SubItems.Add(dtb.Rows(index).Item("Publisher"))
            lst.SubItems.Add(dtb.Rows(index).Item("Status"))
            lst.SubItems.Add(dtb.Rows(index).Item("DateReleased"))
            lst.SubItems.Add(dtb.Rows(index).Item("BookCopy"))
            lst.SubItems.Add(dtb.Rows(index).Item("Shelve"))

            lstviewInventory.Items.Add(lst)

        Next

        rsb.Dispose()
        con.Close()


    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBorrow.Paint

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnBrw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrw.Click


        If Bookcopy = 0 Then

            MsgBox("Book is not Available", vbMsgBoxSetForeground + vbInformation, "Borrow Book")

            Exit Sub


        End If



        pnlBorrow.Show()

        txtId.Text = lstIDno
        txtName.Text = lstName
        txtYr.Text = YrSec
        txtAddress.Text = Address
        txtContact.Text = Contact
        txtBal.Text = Balance + 1

        txtAcq.Text = ID2
        txtBookTitle.Text = Title
        txtAuthor.Text = Author
        txtPublisher.Text = Publisher



    End Sub



    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        pnlBorrow.Visible = False

    End Sub

    Private Sub btnComfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComfirm.Click



        borrow()



    End Sub

    Private Sub borrow()

        con.Open()

        With lstviewInventory.SelectedItems(0)

            Bookcopy = .SubItems(6).Text


        End With

        Bookcopy = Bookcopy - 1

        If Bookcopy = 0 Then

            Status = "Not Available"

        Else

            Status = "Available"

        End If




        Dim rsc As New OleDb.OleDbCommand(
            " INSERT INTO tblBookBorrowed (BookTitle, Author, Publisher, DueDate, BID, BName, BookCopy2, Balance2 ) VALUES ('" & Title & "', '" & Author & "', '" & Publisher & "', '" & txtDate.Text & "', '" & lstIDno & "', '" & lstName & "', " & Bookcopy & ", " & txtBal.Text & " )", con)


        rsc.ExecuteNonQuery()

        Dim rsb As New OleDb.OleDbCommand("UPDATE tblBorrowers SET Balance = " & Val(txtBal.Text) & "  WHERE ID = " & ID & " ", con)


        rsb.ExecuteNonQuery()

        Dim rsa As New OleDb.OleDbCommand("UPDATE tblBooks SET Status = '" & Status & "', BookCopy = " & Bookcopy & "  WHERE ID2 = " & ID2 & " ", con)


        rsa.ExecuteNonQuery()



        con.Close()

        lstviewBorrowers.Items.Clear()
        lstviewInventory.Items.Clear()

        MsgBox("Transaction Succesful", vbInformation)

        pnlBorrow.Visible = False

    End Sub

    Private Sub lstviewInventory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewInventory.Click


        With lstviewInventory.SelectedItems(0)

            ID2 = .SubItems(0).Text
            Title = .SubItems(1).Text
            Author = .SubItems(2).Text
            Publisher = .SubItems(3).Text
            Bookcopy = .SubItems(6).Text


        End With

    End Sub



    Private Sub lstviewBorrowers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstviewBorrowers.SelectedIndexChanged

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim hPrintPos As Single = 50
        Dim vPrintPos As Single = 50
        Dim printFont As Font

        printFont = New Font("Arial", 16)
        Dim title As String = "Library System Report"
        e.Graphics.DrawString(title, printFont, Brushes.Black, 250, hPrintPos)
        printFont = New Font("Calibri", 12)
        e.Graphics.DrawString("Borrower ID No" & Space(10) & txtId.Text, printFont, Brushes.Black, vPrintPos, 100)

        e.Graphics.DrawString("Borrower Name" & Space(10) & txtName.Text, printFont, Brushes.Black, vPrintPos, 120)

        e.Graphics.DrawString("Book Borrowed Acquisition No." & Space(5) & txtAcq.Text, printFont, Brushes.Black, vPrintPos, 140)

        e.Graphics.DrawString("Book Borrowed Title" & Space(10) & txtBook.Text, printFont, Brushes.Black, vPrintPos, 160)

        e.Graphics.DrawString("Book Borrowed Author" & Space(10) & txtAuthor.Text, printFont, Brushes.Black, vPrintPos, 180)

        e.Graphics.DrawString("Due Date " & Space(10) & txtDate.Text, printFont, Brushes.Black, vPrintPos, 200)
        hPrintPos = 120

       


    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load


    End Sub

    Private Sub btnComPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComPrint.Click

        borrow()

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


    End Sub
End Class