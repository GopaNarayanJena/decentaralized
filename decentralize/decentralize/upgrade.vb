Public Class upgrade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each cntrl As Control In Form1.Controls
            If cntrl.Text = ComboBox1.Text Then
                For Each cn As Control In cntrl.Controls
                    If cn.TabIndex = getin(ComboBox2) Then
                        If cn.Text = "NIL" Then
                            cn.Text = 1
                            cn.Enabled = True
                        Else
                            cn.Text = cn.Text + 1
                        End If
                        For Each b As Control In cntrl.Controls
                            If b.TabIndex = 0 Then
                                If b.Text = "NIL" Then
                                    b.Text = 1
                                    b.Enabled = True
                                Else
                                    b.Text = b.Text + 1
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
        Me.Hide()
    End Sub
    Function getin(a As ComboBox)
        If ComboBox2.Text = "GENERAL" Then
            Return 1
        ElseIf ComboBox2.Text = "SC"
            Return 2
        ElseIf ComboBox2.Text = "ST"
            Return 3
        ElseIf ComboBox2.Text = "OBC-A"
            Return 4
        ElseIf ComboBox2.Text = "OBC-B"
            Return 5
        End If
    End Function
End Class