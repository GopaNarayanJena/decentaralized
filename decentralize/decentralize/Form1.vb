Imports System.Drawing
Imports System.IO
Public Class Form1
    Dim a, b As Label
    Function click(p1 As Label, p2 As Label)
        p1.Text = p1.Text - 1
        If p1.Text = 0 Then
            p1.Text = "NIL"
            p1.Enabled = False
        End If
        p2.Text = p2.Text - 1
        If p2.Text = 0 Then
            p2.Text = "NIL"
            p2.Enabled = False
        End If
        a = p1
        b = p2
    End Function
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        click(Label13, Label14)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        click(Label19, Label20)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        click(Label18, Label20)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        click(Label16, Label20)
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        click(Label25, Label26)
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        click(Label23, Label26)
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        click(Label30, Label32)
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        click(Label29, Label32)
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        click(Label28, Label32)
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        click(Label36, Label38)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        upgrade.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim maxHeight As Integer = 0
        Dim maxWidth As Integer = 0
        For Each scr As Screen In Screen.AllScreens
            maxWidth += scr.Bounds.Width
            If scr.Bounds.Height > maxHeight Then maxHeight = scr.Bounds.Height
        Next
        Dim AllScreensCapture As New Bitmap(maxWidth, maxHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
        Dim screenGrab As Bitmap
        Dim screenSize As Size
        Dim g As Graphics
        Dim g2 As Graphics = Graphics.FromImage(AllScreensCapture)
        Dim a As New Point(0, 0)
        For Each scr As Screen In Screen.AllScreens
            screenSize = New Size(scr.Bounds.Width, scr.Bounds.Height)
            screenGrab = New Bitmap(scr.Bounds.Width, scr.Bounds.Height)
            g = Graphics.FromImage(screenGrab)
            g.CopyFromScreen(a, New Point(0, 0), screenSize)
            g2.DrawImage(screenGrab, a)
            a.X += scr.Bounds.Width
        Next
        Dim Screenshot = "C:\Users\Gopa Narayan Jena\Desktop\s1.png"
        If System.IO.File.Exists(Screenshot) Then
            System.IO.File.Delete(Screenshot)
        End If
        Dim sfd As New SaveFileDialog
        sfd.FileName = Screenshot
        sfd.Filter = "png|*.png*"
        If sfd.ShowDialog = DialogResult.OK Then
            AllScreensCapture.Save(sfd.FileName.ToString)
        End If
        '  AllScreensCapture.Save("C:\Users\a.png", Imaging.ImageFormat.Png)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        click(Label12, Label14)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        click(Label11, Label14)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        click(Label10, Label14)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        click(Label9, Label14)
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        click(Label17, Label20)
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        click(Label15, Label20)
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        click(Label24, Label26)
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        click(Label22, Label26)
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        click(Label21, Label26)
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
        click(Label31, Label32)
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        click(Label27, Label32)
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        click(Label37, Label38)
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        click(Label35, Label38)
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        click(Label34, Label38)
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        click(Label33, Label38)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If a.Text = "NIL" Then
            a.Text = 1
            a.Enabled = True
        Else
            a.Text = a.Text + 1
        End If
        If b.Text = "NIL" Then
            b.Text = 1
            b.Enabled = True
        Else
            b.Text = b.Text + 1
        End If
    End Sub
End Class
