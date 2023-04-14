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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        lstPaises = New ListView()
        ButtonClearAll = New Button()
        ButtonDelete = New Button()
        ButtonModify = New Button()
        ButtonAdd = New Button()
        Label2 = New Label()
        TB_Name = New TextBox()
        Label1 = New Label()
        TB_Id = New TextBox()
        TabPage6 = New TabPage()
        ofdRuta = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Location = New Point(26, 62)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(548, 370)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label6)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(540, 342)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Album"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(59, 161)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(80, 23)
        DateTimePicker1.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(61, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 29
        Label7.Text = "Artist name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(61, 213)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(237, 23)
        TextBox2.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(58, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 15)
        Label6.TabIndex = 27
        Label6.Text = "Year"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(540, 342)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Artist"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(540, 342)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Song"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(540, 342)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Concert"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(lstPaises)
        TabPage5.Controls.Add(ButtonClearAll)
        TabPage5.Controls.Add(ButtonDelete)
        TabPage5.Controls.Add(ButtonModify)
        TabPage5.Controls.Add(ButtonAdd)
        TabPage5.Controls.Add(Label2)
        TabPage5.Controls.Add(TB_Name)
        TabPage5.Controls.Add(Label1)
        TabPage5.Controls.Add(TB_Id)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(540, 342)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Country"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' lstPaises
        ' 
        lstPaises.Location = New Point(324, 44)
        lstPaises.MultiSelect = False
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(180, 264)
        lstPaises.TabIndex = 22
        lstPaises.UseCompatibleStateImageBehavior = False
        ' 
        ' ButtonClearAll
        ' 
        ButtonClearAll.FlatStyle = FlatStyle.System
        ButtonClearAll.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClearAll.Location = New Point(32, 227)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(272, 40)
        ButtonClearAll.TabIndex = 21
        ButtonClearAll.Text = "Clear all"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonDelete.Location = New Point(234, 273)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(70, 35)
        ButtonDelete.TabIndex = 20
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonModify.Location = New Point(32, 273)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(70, 35)
        ButtonModify.TabIndex = 19
        ButtonModify.Text = "Modify"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonAdd.Location = New Point(108, 273)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(120, 35)
        ButtonAdd.TabIndex = 18
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(32, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 18)
        Label2.TabIndex = 17
        Label2.Text = "Country Name"
        ' 
        ' TB_Name
        ' 
        TB_Name.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name.Location = New Point(32, 126)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(272, 23)
        TB_Name.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(32, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 18)
        Label1.TabIndex = 15
        Label1.Text = "Country ID"
        ' 
        ' TB_Id
        ' 
        TB_Id.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id.Location = New Point(32, 65)
        TB_Id.Name = "TB_Id"
        TB_Id.Size = New Size(272, 23)
        TB_Id.TabIndex = 14
        ' 
        ' TabPage6
        ' 
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.RightToLeft = RightToLeft.No
        TabPage6.Size = New Size(540, 342)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Site"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' ofdRuta
        ' 
        ofdRuta.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.ImageLocation = "AppMusic/Spotifake_logo.png"
        PictureBox1.Location = New Point(26, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 35)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 457)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Id As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstPaises As ListView
End Class
