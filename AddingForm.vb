Public Class AddingForm


    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")



   
    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click

        If txtID.Text = "" OrElse txtAddress.Text = "" OrElse txtYrSec.Text = "" OrElse txtContact.Text = "" OrElse txtBalance.Text = "" Then Exit Sub

        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "INSERT INTO tblBorrowers (IDno, BName, YearSec, Address, ContactNo, Balance) VALUES ('" &
                StrConv(txtID.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtBName.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtYrSec.Text, VbStrConv.Uppercase) & "', '" &
                StrConv(txtAddress.Text, VbStrConv.Uppercase) & "', " &
                Val(txtContact.Text) & "," &
                Val(txtBalance.Text) & ")", con)

        rs.ExecuteNonQuery()
        con.Close()

        MsgBox("Borrower Account Succesfully Added", vbInformation)

        txtID.Text = ""
        txtBName.Text = ""
        txtYrSec.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtBalance.Text = ""


    End Sub

    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click

        If txtTitle.Text = "" OrElse txtAuthor.Text = "" OrElse txtPublisher.Text = "" OrElse txtDate.Text = "" OrElse txtCopy.Text = "" Then Exit Sub

        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "INSERT INTO tblBooks (Title, Author, Publisher, Status, DateReleased, BookCopy, Shelve) VALUES ('" &
                StrConv(txtTitle.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtAuthor.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtPublisher.Text, VbStrConv.Uppercase) & "', '" &
                StrConv(txtStatus.Text, VbStrConv.Uppercase) & "', " &
                StrConv(txtDate.Text, VbStrConv.Uppercase) & ", " &
                Val(txtCopy.Text) & ", " &
                Val(txtShelves.Text) & " )", con)

        rs.ExecuteNonQuery()
        con.Close()

        MsgBox("New Book Succesfully Added", vbInformation)

        txtTitle.Text = ""
        txtAuthor.Text = ""
        txtPublisher.Text = ""
        txtDate.Text = ""
        txtCopy.Text = ""

    End Sub

    Private Sub MenuForms_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuForms.ItemClicked

    End Sub
End Class