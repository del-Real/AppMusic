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
        lstSong2 = New ListView()
        lstSetlist = New ListView()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ButtonAddSong = New Button()
        ButtonRemoveSong = New Button()
        SuspendLayout()
        ' 
        ' lstSong2
        ' 
        lstSong2.Location = New Point(457, 57)
        lstSong2.Name = "lstSong2"
        lstSong2.Size = New Size(249, 295)
        lstSong2.TabIndex = 0
        lstSong2.UseCompatibleStateImageBehavior = False
        ' 
        ' lstSetlist
        ' 
        lstSetlist.Location = New Point(101, 57)
        lstSetlist.Name = "lstSetlist"
        lstSetlist.Size = New Size(249, 295)
        lstSetlist.TabIndex = 1
        lstSetlist.UseCompatibleStateImageBehavior = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(101, 396)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 3
        Label1.Text = "Concert Songs"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(457, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 4
        Label2.Text = "Song List"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 5
        Label3.Text = "Select Concert"
        ' 
        ' ButtonAddSong
        ' 
        ButtonAddSong.Location = New Point(366, 164)
        ButtonAddSong.Name = "ButtonAddSong"
        ButtonAddSong.Size = New Size(75, 23)
        ButtonAddSong.TabIndex = 6
        ButtonAddSong.Text = "<"
        ButtonAddSong.UseVisualStyleBackColor = True
        ' 
        ' ButtonRemoveSong
        ' 
        ButtonRemoveSong.Location = New Point(366, 217)
        ButtonRemoveSong.Name = "ButtonRemoveSong"
        ButtonRemoveSong.Size = New Size(75, 23)
        ButtonRemoveSong.TabIndex = 9
        ButtonRemoveSong.Text = "Remove"
        ButtonRemoveSong.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonRemoveSong)
        Controls.Add(ButtonAddSong)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(lstSetlist)
        Controls.Add(lstSong2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstSong2 As ListView
    Friend WithEvents lstSetlist As ListView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAddSong As Button
    Friend WithEvents ButtonRemoveSong As Button
End Class
