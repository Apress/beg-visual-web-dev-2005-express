
Partial Class Products
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            Dim displaytext As String

            displaytext = "Current Page: " & SiteMap.CurrentNode.ToString & "<br>"

            If Not SiteMap.CurrentNode.NextSibling Is Nothing Then
                displaytext += "Next Page: " & SiteMap.CurrentNode.NextSibling.ToString & "<br>"
            End If

            If Not SiteMap.CurrentNode.PreviousSibling Is Nothing Then
                displaytext += "Previous Page: " & SiteMap.CurrentNode.PreviousSibling.ToString & "<br>"
            End If

            displaytext += "Url: " & SiteMap.CurrentNode.Url & "<br>"
            displaytext += "Title: " & SiteMap.CurrentNode.Title & "<br>"
            displaytext += "Description: " & SiteMap.CurrentNode.Description

            labelNavInfo.Text = displaytext
        End If
    End Sub
End Class
