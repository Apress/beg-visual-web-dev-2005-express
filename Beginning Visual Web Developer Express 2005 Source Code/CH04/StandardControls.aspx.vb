
Partial Class StandardControls
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonCopy.Click
        'labelDisplay.Text = textDisplay.Text
        dropdownlistDisplay.Items.Add(textDisplay.Text)
    End Sub
End Class
