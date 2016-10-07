
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim stringvariable As String = "Breakpoint Example"
        Dim i As Integer = 100
        Dim a As Integer = 5

        WriteToBrowser(stringvariable)
    End Sub

    Protected Sub WriteToBrowser(ByVal whattowrite As String)
        Response.Write(whattowrite)
        Trace.Write(whattowrite)
        Trace.Warn(whattowrite)
    End Sub
End Class
