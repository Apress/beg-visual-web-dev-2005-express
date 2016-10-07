
Partial Class ChangePassword
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim currentuser As MembershipUser = Membership.GetUser()

        If currentuser.ChangePassword(textOldPassword.Text, textNewPassword.Text) Then
            labelMessage.Text = "Password changed!"
        Else
            labelMessage.Text = "An error has occured!"
        End If
    End Sub
End Class
