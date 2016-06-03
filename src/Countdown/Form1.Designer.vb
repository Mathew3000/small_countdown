<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.l_hour = New System.Windows.Forms.Label()
        Me.l_min = New System.Windows.Forms.Label()
        Me.l_sec = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.t_sec = New System.Windows.Forms.TextBox()
        Me.t_min = New System.Windows.Forms.TextBox()
        Me.t_hour = New System.Windows.Forms.TextBox()
        Me.countdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_msec = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'l_hour
        '
        Me.l_hour.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_hour.ForeColor = System.Drawing.Color.White
        Me.l_hour.Location = New System.Drawing.Point(277, 13)
        Me.l_hour.Margin = New System.Windows.Forms.Padding(0)
        Me.l_hour.Name = "l_hour"
        Me.l_hour.Size = New System.Drawing.Size(110, 78)
        Me.l_hour.TabIndex = 0
        Me.l_hour.Text = "00"
        Me.l_hour.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_min
        '
        Me.l_min.AutoSize = True
        Me.l_min.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_min.ForeColor = System.Drawing.Color.White
        Me.l_min.Location = New System.Drawing.Point(387, 13)
        Me.l_min.Name = "l_min"
        Me.l_min.Size = New System.Drawing.Size(107, 78)
        Me.l_min.TabIndex = 1
        Me.l_min.Text = "00"
        '
        'l_sec
        '
        Me.l_sec.AutoSize = True
        Me.l_sec.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_sec.ForeColor = System.Drawing.Color.White
        Me.l_sec.Location = New System.Drawing.Point(501, 13)
        Me.l_sec.Name = "l_sec"
        Me.l_sec.Size = New System.Drawing.Size(107, 78)
        Me.l_sec.TabIndex = 2
        Me.l_sec.Text = "00"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(480, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 78)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(758, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Set Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        't_sec
        '
        Me.t_sec.Location = New System.Drawing.Point(832, 10)
        Me.t_sec.Name = "t_sec"
        Me.t_sec.Size = New System.Drawing.Size(31, 20)
        Me.t_sec.TabIndex = 6
        Me.t_sec.Text = "0"
        '
        't_min
        '
        Me.t_min.Location = New System.Drawing.Point(795, 10)
        Me.t_min.Name = "t_min"
        Me.t_min.Size = New System.Drawing.Size(31, 20)
        Me.t_min.TabIndex = 7
        Me.t_min.Text = "0"
        '
        't_hour
        '
        Me.t_hour.Location = New System.Drawing.Point(758, 10)
        Me.t_hour.Name = "t_hour"
        Me.t_hour.Size = New System.Drawing.Size(31, 20)
        Me.t_hour.TabIndex = 8
        Me.t_hour.Text = "0"
        '
        'countdown
        '
        Me.countdown.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(589, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 78)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        'l_msec
        '
        Me.l_msec.AutoSize = True
        Me.l_msec.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_msec.ForeColor = System.Drawing.Color.White
        Me.l_msec.Location = New System.Drawing.Point(608, 13)
        Me.l_msec.Name = "l_msec"
        Me.l_msec.Size = New System.Drawing.Size(144, 78)
        Me.l_msec.TabIndex = 10
        Me.l_msec.Text = "000"
        Me.l_msec.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 78)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 78)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start in"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.Location = New System.Drawing.Point(869, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 76)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Start"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(983, 99)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_msec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t_hour)
        Me.Controls.Add(Me.t_min)
        Me.Controls.Add(Me.t_sec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.l_sec)
        Me.Controls.Add(Me.l_min)
        Me.Controls.Add(Me.l_hour)
        Me.Name = "Form1"
        Me.Text = "Countdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_hour As Label
    Friend WithEvents l_min As Label
    Friend WithEvents l_sec As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents t_sec As TextBox
    Friend WithEvents t_min As TextBox
    Friend WithEvents t_hour As TextBox
    Friend WithEvents countdown As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents l_msec As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
