
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'AddHandler SiteMap.SiteMapResolve, AddressOf Me.ParseNodes2

    End Sub
    Private Function ParseNodes2(ByVal sender As Object, ByVal e As SiteMapResolveEventArgs) As SiteMapNode
        'Obtain a reference to the current node and its ancestors
        Dim nodeCopy As SiteMapNode = SiteMap.CurrentNode.Clone(True)

        'The temporary node is used for walking up the chain of nodes, fixing up Urls and
        'other properties along the way.
        Dim tempNode As SiteMapNode = nodeCopy

        'Check if there is a newsgroup type in the query string
        Dim typeID As String = Nothing
        Dim typeIDUrlEncoded As String = Nothing
        If Not String.IsNullOrEmpty(e.Context.Request.QueryString("type")) Then
            typeID = e.Context.Server.HtmlEncode(e.Context.Request.QueryString("type"))
            typeIDUrlEncoded = e.Context.Server.UrlEncode(e.Context.Request.QueryString("type"))
        End If

        'First perform Url fixups for the postings page
        'If there is a posting ID in the query string, then we know the current node
        'is the postings page.
        If Not String.IsNullOrEmpty(e.Context.Request.QueryString("postingID")) Then
            Dim postingID As String = _
                e.Context.Server.HtmlEncode(e.Context.Request.QueryString("postingID"))
            Dim postingIDUrlEncoded As String = _
                e.Context.Server.UrlEncode(e.Context.Request.QueryString("postingID"))

            Dim NewUrl As String = tempNode.Url + "?type=" + typeIDUrlEncoded + "&postingID=" + postingIDUrlEncoded
            Dim NewTitle As String = tempNode.Title + ": " + postingID

            tempNode.Url = NewUrl
            tempNode.Title = NewTitle

            'Walkup one level to the parent
            tempNode = tempNode.ParentNode
        End If

        'Next, perform fixups for the newsgroup page
        'By this point the nodeCopy variable is pointing at the newsgroup node
        If Not String.IsNullOrEmpty(e.Context.Request.QueryString("type")) Then
            Dim NewUrl As String = tempNode.Url + "?type=" + typeIDUrlEncoded
            Dim NewTitle As String = tempNode.Title + ":  " + typeID

            tempNode.Url = NewUrl
            tempNode.Title = NewTitle
        End If

        'Lastly, return the current node
        Return nodeCopy

    End Function


    Private Function ParseNodes(ByVal sender As Object, ByVal e As SiteMapResolveEventArgs) As SiteMapNode
        ' The current node represents a Post page in a bulletin board forum.
        ' Clone the current node and all of its relevant parents. This
        ' returns a site map node that a developer can then
        ' walk, modifying each node.Url property in turn.
        ' Since the cloned nodes are separate from the underlying
        ' site navigation structure, the fixups that are made do not
        ' effect the overall site navigation structure.

        Dim currentNode As SiteMapNode = SiteMap.CurrentNode.Clone(True)
        Dim tempNode As SiteMapNode = currentNode

        Dim forumGroupID As Integer
        If Not e.Context.Request.QueryString("ForumGroupID") = "" Then
            forumGroupID = Convert.ToInt32(e.Context.Request.QueryString("ForumGroupID"))
        ElseIf e.Context.Request.QueryString("ForumGroupID") = "" Then
            forumGroupID = 0
        End If

        Dim forumID As Integer
        If Not Request.QueryString("ForumID") = "" Then
            forumID = Convert.ToInt32(Request.QueryString("ForumID"))
        ElseIf Request.QueryString("ForumID") = "" Then
            forumID = 0
        End If

        Dim postID As Integer
        If Not Request.QueryString("PostID") = "" Then
            postID = Convert.ToInt32(Request.QueryString("PostID"))
        ElseIf Request.QueryString("PostID") = "" Then
            postID = 0
        End If

        ' The current node, and its parents, can be modified to include
        ' dynamic querystring information relevant to the currently
        ' executing request.
        If Not (0 = postID) Then
            tempNode.Url = tempNode.Url & "?PostID=" & postID.ToString()
        End If

        tempNode = tempNode.ParentNode
        If Not (0 = forumID) And Not (tempNode Is Nothing) Then
            tempNode.Url = tempNode.Url & "?ForumID=" & forumID.ToString()
        End If

        'tempNode = tempNode.ParentNode
        If Not (0 = forumGroupID) And Not (tempNode Is Nothing) Then
            tempNode.Url = tempNode.Url & "?ForumGroupID=" & forumGroupID.ToString()
        End If

        Return currentNode

    End Function
End Class


