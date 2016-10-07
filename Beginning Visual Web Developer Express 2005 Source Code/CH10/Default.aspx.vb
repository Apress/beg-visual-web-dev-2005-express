
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim config As System.Configuration.Configuration

        config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/CH10API")

        Dim element As KeyValueConfigurationElement = CType(config.AppSettings.Settings("SearchEngine"), KeyValueConfigurationElement)
        Response.Write(element.Value)
    End Sub
End Class
