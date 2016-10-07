
Partial Class Encrypt
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim config As System.Configuration.Configuration
        config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/CH10API")

        Dim appSettings As ConfigurationSection = config.GetSection("appSettings")
        If (appSettings.SectionInformation.IsProtected) Then
            appSettings.SectionInformation.UnprotectSection()
        Else
            appSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
        End If
        Try
            config.Save()
            Response.Redirect(Request.CurrentExecutionFilePath)
        Catch ex As Exception
            Response.Write("An error has occured saving the configuration settings.  Make sure the ASP.NET process account has write permissions enabled.")
        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim config As System.Configuration.Configuration
            config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/CH10API")

            Dim appSettings As ConfigurationSection = config.GetSection("appSettings")
            labelAppSetting.Text = "Search Engine: " & Server.HtmlEncode(appSettings.SectionInformation.GetRawXml())
        End If
    End Sub
End Class
