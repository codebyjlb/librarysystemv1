Public Class AddBooksForm

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click


        If txtTitle.Text = "" OrElse txtAuthor.Text = "" OrElse txtPublisher.Text = "" OrElse txtDate.Text = "" OrElse txtCopy.Text = "" Then Exit Sub

        con.Open()

        Dim rs As New OleDb.OleDbCommand(
            "INSERT INTO tblBooks (Title, Author, Publisher, Status, DateReleased, BookCopy, Shelve) VALUES ('" &
                StrConv(txtTitle.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtAuthor.Text, VbStrConv.Uppercase) & "','" &
                StrConv(txtPublisher.Text, VbStrConv.Uppercase) & "', '" &
                StrConv(txtStatus.Text, VbStrConv.Uppercase) & "', '" &
                StrConv(txtDate.Text, VbStrConv.Uppercase) & "', " &
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
End Class