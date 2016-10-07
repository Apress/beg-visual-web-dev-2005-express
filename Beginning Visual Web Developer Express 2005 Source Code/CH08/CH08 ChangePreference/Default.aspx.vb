Imports System.Globalization
Imports System.Threading

Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Overrides Sub InitializeCulture()
        ' Override and determine if the profile contains a language setting.
        Dim currentUserCulture As String = Profile.GetPropertyValue("Culture").ToString()

        If currentUserCulture <> "" Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(currentUserCulture)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(currentUserCulture)
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'List of languages.
            Dim languagearray As String() = {"de", "fr", "en"}
            Dim language As String

            For Each language In languagearray
                Dim temporaryCultureInfo As New CultureInfo(language)
                Dim LanguageList As New ListItem(temporaryCultureInfo.NativeName, temporaryCultureInfo.Name)
                If temporaryCultureInfo.Equals(CultureInfo.CurrentUICulture) Then
                    LanguageList.Selected = True
                End If
                dropdownlistLanguages.Items.Add(LanguageList)
            Next language
        End If
        'Write the date to the browser.
        Response.Write(DateTime.Now.ToLongDateString())
    End Sub

    Protected Sub dropdownlistLanguages_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropdownlistLanguages.SelectedIndexChanged
        'Save selected user language in profile 
        Profile.SetPropertyValue("Culture", dropdownlistLanguages.SelectedValue.ToString())

        'Force the page to fire the InitializeCulture() method again to set
        'the newly selected language.
        Response.Redirect(Request.Url.LocalPath)
    End Sub
End Class
