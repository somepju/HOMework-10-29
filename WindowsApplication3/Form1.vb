Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged, txtpassword.TextChanged
        Dim GD As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(GD.Text)) Then
            GD.BackColor = Color.MistyRose
        Else
            GD.BackColor = Color.White




        End If

    End Sub

    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtusername.Text = "login" Then
            If txtpassword.Text = "abc123" Then
                MessageBox.Show("帳戶密碼正確!!!")
                End

            End If

            If txtusername.Text <> "login" Then
                txtusername.BackColor = Color.MistyRose

            End If

            If txtpassword.Text <> "abc123" Then
                txtpassword.BackColor = Color.MistyRose
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
