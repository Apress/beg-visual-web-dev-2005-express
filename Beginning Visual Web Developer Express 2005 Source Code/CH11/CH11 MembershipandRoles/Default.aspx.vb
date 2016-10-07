
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim currentuser As MembershipUser = Membership.GetUser()
        labelWelcome.Text = "Welcome " & currentuser.UserName
    End Sub
End Class
