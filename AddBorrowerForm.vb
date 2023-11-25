Public Class AddBorrowerForm

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.Close()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

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


End Class