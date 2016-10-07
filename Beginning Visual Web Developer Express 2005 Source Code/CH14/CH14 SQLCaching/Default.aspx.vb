
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = DateTime.Now.ToShortDateString & " " & DateTime.Now.ToLongTimeString
    End Sub
End Class
