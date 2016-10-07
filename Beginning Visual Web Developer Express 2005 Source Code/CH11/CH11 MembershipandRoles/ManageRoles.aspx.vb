
Partial Class ManageRoles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateRoles()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Roles.CreateRole(textRolename.Text)
        textRolename.Text = ""
        PopulateRoles()
    End Sub
    Protected Sub PopulateRoles()
        listboxRoles.DataSource = Roles.GetAllRoles()
        listboxRoles.DataBind()
    End Sub
End Class
