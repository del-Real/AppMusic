<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        lstAlbumes = New ListBox()
        ButtonClearAll = New Button()
        ButtonDelete = New Button()
        ButtonModify = New Button()
        ButtonAdd = New Button()
        Label2 = New Label()
        TB_Name = New TextBox()
        Label1 = New Label()
        TB_Id = New TextBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        Label3 = New Label()
        ofdRuta = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Location = New Point(26, 75)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(548, 358)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(lstAlbumes)
        TabPage1.Controls.Add(ButtonClearAll)
        TabPage1.Controls.Add(ButtonDelete)
        TabPage1.Controls.Add(ButtonModify)
        TabPage1.Controls.Add(ButtonAdd)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(TB_Name)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(TB_Id)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(540, 330)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Album"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(45, 156)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(80, 23)
        DateTimePicker1.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(47, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 12
        Label7.Text = "Artist name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(47, 208)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(237, 23)
        TextBox2.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(44, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 15)
        Label6.TabIndex = 10
        Label6.Text = "Year"
        ' 
        ' lstAlbumes
        ' 
        lstAlbumes.FormattingEnabled = True
        lstAlbumes.ItemHeight = 15
        lstAlbumes.Location = New Point(312, 27)
        lstAlbumes.Name = "lstAlbumes"
        lstAlbumes.Size = New Size(195, 274)
        lstAlbumes.TabIndex = 8
        ' 
        ' ButtonClearAll
        ' 
        ButtonClearAll.Location = New Point(45, 284)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(237, 23)
        ButtonClearAll.TabIndex = 7
        ButtonClearAll.Text = "Clear all"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(206, 251)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(75, 23)
        ButtonDelete.TabIndex = 6
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Location = New Point(125, 251)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(75, 23)
        ButtonModify.TabIndex = 5
        ButtonModify.Text = "Modify"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Location = New Point(45, 251)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(75, 23)
        ButtonAdd.TabIndex = 4
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' TB_Name
        ' 
        TB_Name.Location = New Point(47, 100)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(237, 23)
        TB_Name.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        ' 
        ' TB_Id
        ' 
        TB_Id.Location = New Point(46, 43)
        TB_Id.Name = "TB_Id"
        TB_Id.Size = New Size(237, 23)
        TB_Id.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(540, 330)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Artist"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(540, 330)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Song"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(540, 330)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Concert"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(540, 330)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Country"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.RightToLeft = RightToLeft.No
        TabPage6.Size = New Size(540, 330)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Site"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(26, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 3
        Label3.Text = "🎵 Spotifake"
        ' 
        ' ofdRuta
        ' 
        ofdRuta.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 457)
        Controls.Add(Label3)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Id As TextBox
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstAlbumes As ListBox
    Friend WithEvents ofdRuta As OpenFileDialog
End Class
