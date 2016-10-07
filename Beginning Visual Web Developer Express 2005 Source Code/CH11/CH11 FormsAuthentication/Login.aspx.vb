Imports System.Web.Security
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FormsAuthentication.Authenticate(textUsername.Text, textPassword.Text) Then
            FormsAuthentication.RedirectFromLoginPage(textUsername.Text, False)
        Else
            Response.Write("Invalid Login!")
        End If
    End Sub
End Class
