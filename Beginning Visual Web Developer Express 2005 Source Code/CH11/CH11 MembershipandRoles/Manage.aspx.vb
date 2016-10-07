
Partial Class Manage
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Membership.DeleteUser(textUsername.Text) Then
            labelMessage.Text = "User deleted!"
        Else
            labelMessage.Text = "An error has occured!"
        End If
    End Sub
End Class
