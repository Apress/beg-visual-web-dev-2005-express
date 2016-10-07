Imports System.Web.Security
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Membership.ValidateUser(textUsername.Text, textPassword.Text) Then
            FormsAuthentication.RedirectFromLoginPage(textUsername.Text, False)
        Else
            Response.Write("Invalid Login!")
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        panelNewUser.Visible = True
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim createresult As MembershipCreateStatus
        Membership.CreateUser(textNewUsername.Text, textNewPassword.Text, textEmail.Text, dropdownlistQuestion.SelectedItem.Value, textAnswer.Text, True, createresult)

        Select Case createresult
            Case MembershipCreateStatus.Success
                Label1.Text = "The user was created successfully!"
            Case MembershipCreateStatus.InvalidUserName
                Label1.Text = "The username format was invalid."
            Case MembershipCreateStatus.InvalidPassword
                Label1.Text = "The password format was invalid."
            Case MembershipCreateStatus.InvalidAnswer
                Label1.Text = "The password answer format was invalid."
            Case MembershipCreateStatus.DuplicateUserName
                Label1.Text = "The username is already in use."
            Case MembershipCreateStatus.InvalidEmail
                Label1.Text = "The email format was invalid."
            Case MembershipCreateStatus.InvalidQuestion
                Label1.Text = "The password question format was invalid."
            Case MembershipCreateStatus.DuplicateEmail
                Label1.Text = "The email address is already in use."
            Case Else
                Label1.Text = "An error occurred while creating the user."
        End Select
    End Sub
End Class
