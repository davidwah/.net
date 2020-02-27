Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProses.Click
        output.Text = boxInput.Text
    End Sub


    Private Sub btKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKeluar.Click
        End
    End Sub

    Private Sub merah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merah.CheckedChanged
        output.ForeColor = Color.Red
    End Sub

    Private Sub hijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hijau.CheckedChanged
        output.ForeColor = Color.Green
    End Sub

    Private Sub biru_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biru.CheckedChanged
        output.ForeColor = Color.Blue
    End Sub

    Private Sub hitam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitam.CheckedChanged
        output.ForeColor = Color.Black
    End Sub

    Private Sub bold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bold.CheckedChanged
        output.Font = New Font("Arial", output.Font.Size, output.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub italic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles italic.CheckedChanged
        output.Font = New Font("Arial", output.Font.Size, output.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub underline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles underline.CheckedChanged
        output.Font = New Font("Arial", output.Font.Size, output.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub strikeout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles strikeout.CheckedChanged
        output.Font = New Font("Arial", output.Font.Size, output.Font.Style Xor FontStyle.Strikeout)
    End Sub
End Class
