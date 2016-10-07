
Partial Class Update
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim config As System.Configuration.Configuration

            config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/CH10API")

            Dim element As KeyValueConfigurationElement = CType(config.AppSettings.Settings("SearchEngine"), KeyValueConfigurationElement)
            labelAppSetting.Text = "Search Engine: " & element.Value
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim config As System.Configuration.Configuration
        config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/CH10API")
        
        Dim element As KeyValueConfigurationElement = CType(config.AppSettings.Settings("SearchEngine"), KeyValueConfigurationElement)
        element.Value = TextBox1.Text

        Try
            config.Save()
            Response.Redirect(Request.CurrentExecutionFilePath)
        Catch ex As Exception
            Response.Write("An error has occured saving the configuration settings.  Make sure the ASP.NET process account has write permissions enabled.")
        End Try
    End Sub
End Class
