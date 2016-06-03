Public Class Form1

    Dim msec As Int32 = 0
    Dim sec As Int32 = 0
    Dim min As Int32 = 0
    Dim hour As Int32 = 0

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick
        If sec < 1 Then
            If min < 1 Then
                If hour < 1 Then
                    countdown.Enabled = False
                    CheckBox1.Text = "Start"
                    CheckBox1.Checked = False
                    MessageBox.Show("DONE!",
                        "Finish!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
                Else
                    sec = 59
                    min = 59
                    hour = hour - 1
                End If
            Else
                sec = 59
                min = min - 1
            End If
        Else
            sec = sec - 1
        End If
        l_hour.Text = hour.ToString("D2")
        l_min.Text = min.ToString("D2")
        l_sec.Text = sec.ToString("D2")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        countdown.Enabled = False
        sec = Int(t_sec.Text)
        min = Int(t_min.Text)
        hour = Int(t_hour.Text)
        l_hour.Text = hour.ToString("D2")
        l_min.Text = min.ToString("D2")
        l_sec.Text = sec.ToString("D2")
        CheckBox1.Text = "Start"
        CheckBox1.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TransparencyKey = Color.White 'if this doesn't work you try:
        'Me.TransparencyKey = Me.BackColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        countdown.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            countdown.Enabled = True
            CheckBox1.Text = "Stop"
        Else
            countdown.Enabled = False
            CheckBox1.Text = "Start"
        End If
    End Sub
End Class
