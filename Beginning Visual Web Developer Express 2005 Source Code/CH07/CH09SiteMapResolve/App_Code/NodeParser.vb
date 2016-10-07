Imports System
Imports System.Web

Public Class NodeParser
    Public Shared Function ParseQuerystrings(ByVal sender As Object, ByVal e As SiteMapResolveEventArgs) As SiteMapNode

        'Make a copy of the current SiteMapNode so that we can alter it in memmory.
        Dim nodeClone As SiteMapNode = SiteMap.CurrentNode.Clone(True)
        Dim tempNode As SiteMapNode = nodeClone

        'Check if there is an invoiceID value in the query string and that it is not null.
        Dim invoiceID As String = Nothing
        Dim invoiceIDUrlEncoded As String = Nothing
        If Not String.IsNullOrEmpty(e.Context.Request.QueryString("InvoiceID")) Then
            invoiceID = e.Context.Server.HtmlEncode(e.Context.Request.QueryString("InvoiceID"))
            invoiceIDUrlEncoded = e.Context.Server.UrlEncode(e.Context.Request.QueryString("InvoiceID"))
        End If

        If Not String.IsNullOrEmpty(e.Context.Request.QueryString("InvoiceID")) Then
            Dim ID As String = _
                e.Context.Server.HtmlEncode(e.Context.Request.QueryString("InvoiceID"))
            Dim IDUrlEncoded As String = _
                e.Context.Server.UrlEncode(e.Context.Request.QueryString("InvoiceID"))

            Dim NewUrl As String = tempNode.Url + "?InvoiceID=" + IDUrlEncoded
            Dim NewTitle As String = tempNode.Title + ": " + ID

            tempNode.Url = NewUrl
            tempNode.Title = NewTitle
            tempNode = tempNode.ParentNode
        End If

        'Return the node that has been cloned and altered.
        Return nodeClone

    End Function

End Class
