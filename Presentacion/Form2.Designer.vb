<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lstSong2 = New System.Windows.Forms.ListView()
        Me.lstSetlist = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAddSong = New System.Windows.Forms.Button()
        Me.ButtonRemoveSong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSong2
        '
        Me.lstSong2.Location = New System.Drawing.Point(522, 76)
        Me.lstSong2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSong2.Name = "lstSong2"
        Me.lstSong2.Size = New System.Drawing.Size(284, 392)
        Me.lstSong2.TabIndex = 0
        Me.lstSong2.UseCompatibleStateImageBehavior = False
        '
        'lstSetlist
        '
        Me.lstSetlist.Location = New System.Drawing.Point(115, 76)
        Me.lstSetlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSetlist.Name = "lstSetlist"
        Me.lstSetlist.Size = New System.Drawing.Size(284, 392)
        Me.lstSetlist.TabIndex = 1
        Me.lstSetlist.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Concert Songs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Song List"
        '
        'ButtonAddSong
        '
        Me.ButtonAddSong.Location = New System.Drawing.Point(418, 219)
        Me.ButtonAddSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddSong.Name = "ButtonAddSong"
        Me.ButtonAddSong.Size = New System.Drawing.Size(86, 31)
        Me.ButtonAddSong.TabIndex = 6
        Me.ButtonAddSong.Text = "<"
        Me.ButtonAddSong.UseVisualStyleBackColor = True
        '
        'ButtonRemoveSong
        '
        Me.ButtonRemoveSong.Location = New System.Drawing.Point(418, 289)
        Me.ButtonRemoveSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRemoveSong.Name = "ButtonRemoveSong"
        Me.ButtonRemoveSong.Size = New System.Drawing.Size(86, 31)
        Me.ButtonRemoveSong.TabIndex = 9
        Me.ButtonRemoveSong.Text = "Remove"
        Me.ButtonRemoveSong.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.ButtonRemoveSong)
        Me.Controls.Add(Me.ButtonAddSong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSetlist)
        Me.Controls.Add(Me.lstSong2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSong2 As ListView
    Friend WithEvents lstSetlist As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAddSong As Button
    Friend WithEvents ButtonRemoveSong As Button
End Class
