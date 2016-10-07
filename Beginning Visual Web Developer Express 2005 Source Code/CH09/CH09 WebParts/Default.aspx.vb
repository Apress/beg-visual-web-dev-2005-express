
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim _wpmmngr As WebPartManager

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
        _wpmmngr = WebPartManager.GetCurrentWebPartManager(Page)

        Dim browseModeName As String = _
          WebPartManager.BrowseDisplayMode.Name

        ' Populate the drop-down list with the names of supported display modes.
        Dim displaymode As WebPartDisplayMode
        For Each displaymode In _wpmmngr.SupportedDisplayModes
            Dim modeName As String = displaymode.Name
            ' Ensure a mode is enabled before adding it.
            If displaymode.IsEnabled(_wpmmngr) Then
                Dim item As New ListItem(modeName, modeName)
                DropDownList1.Items.Add(item)
            End If
        Next displaymode
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim dropdownSelectedMode As String = DropDownList1.SelectedValue
        Dim md As WebPartDisplayMode = _
          _wpmmngr.SupportedDisplayModes(dropdownSelectedMode)
        If Not (md Is Nothing) Then
            _wpmmngr.DisplayMode = md
        End If
    End Sub
End Class
