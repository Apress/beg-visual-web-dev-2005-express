
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Name: " & User.Identity.Name & "<br>")
        Response.Write("Authentication Type: " & User.Identity.AuthenticationType & "<br>")
        Response.Write("Is Authenticated: " & User.Identity.IsAuthenticated & "<br>")

        If User.IsInRole("Administrators") Then
            Response.Write("User is an Administrator")
        Else
            Response.Write("User is NOT an Administrator")
        End If
    End Sub
End Class
