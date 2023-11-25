Public Class LoginForm

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\db1.mdb;")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtPassword.Text = "john" Then

            MDIParent1.Show()

            Me.Visible = False



        Else

            MsgBox("Please Enter The Correct Password", MsgBoxStyle.SystemModal + vbInformation, "Worng Password!")

        End If


    End Sub
End Class