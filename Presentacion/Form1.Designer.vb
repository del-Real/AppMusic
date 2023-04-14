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
        comboBoxTipo = New ComboBox()
        Label8 = New Label()
        TB_Artist_Sitio = New TextBox()
        Label5 = New Label()
        lstSitios = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label3 = New Label()
        TB_Name_Sitio = New TextBox()
        Label4 = New Label()
        TB_ID_Sitio = New TextBox()
        ofdRuta = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
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
        TabPage1.Padding = New Padding(3, 3, 3, 3)
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
        TabPage2.Padding = New Padding(3, 3, 3, 3)
        TabPage2.Size = New Size(540, 342)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Artist"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 3, 3, 3)
        TabPage3.Size = New Size(540, 342)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Song"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3, 3, 3, 3)
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
        TabPage5.Padding = New Padding(3, 3, 3, 3)
        TabPage5.Size = New Size(540, 342)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Country"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' lstPaises
        ' 
        lstPaises.Location = New Point(319, 34)
        lstPaises.MultiSelect = False
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(192, 264)
        lstPaises.TabIndex = 22
        lstPaises.UseCompatibleStateImageBehavior = False
        ' 
        ' ButtonClearAll
        ' 
        ButtonClearAll.FlatStyle = FlatStyle.System
        ButtonClearAll.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClearAll.Location = New Point(20, 184)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(272, 40)
        ButtonClearAll.TabIndex = 21
        ButtonClearAll.Text = "Clear all"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonDelete.Location = New Point(198, 236)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 35)
        ButtonDelete.TabIndex = 20
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonModify.Location = New Point(109, 236)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(91, 35)
        ButtonModify.TabIndex = 19
        ButtonModify.Text = "Modify"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonAdd.Location = New Point(20, 236)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(92, 35)
        ButtonAdd.TabIndex = 18
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(32, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 17
        Label2.Text = "Country Name"
        ' 
        ' TB_Name
        ' 
        TB_Name.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name.Location = New Point(32, 115)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(247, 23)
        TB_Name.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(32, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 19)
        Label1.TabIndex = 15
        Label1.Text = "Country ID"
        ' 
        ' TB_Id
        ' 
        TB_Id.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id.Location = New Point(32, 64)
        TB_Id.Name = "TB_Id"
        TB_Id.Size = New Size(247, 23)
        TB_Id.TabIndex = 14
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(comboBoxTipo)
        TabPage6.Controls.Add(Label8)
        TabPage6.Controls.Add(TB_Artist_Sitio)
        TabPage6.Controls.Add(Label5)
        TabPage6.Controls.Add(lstSitios)
        TabPage6.Controls.Add(Button1)
        TabPage6.Controls.Add(Button2)
        TabPage6.Controls.Add(Button3)
        TabPage6.Controls.Add(Button4)
        TabPage6.Controls.Add(Label3)
        TabPage6.Controls.Add(TB_Name_Sitio)
        TabPage6.Controls.Add(Label4)
        TabPage6.Controls.Add(TB_ID_Sitio)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3, 3, 3, 3)
        TabPage6.RightToLeft = RightToLeft.No
        TabPage6.Size = New Size(540, 342)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Site"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' comboBoxTipo
        ' 
        comboBoxTipo.FormattingEnabled = True
        comboBoxTipo.Location = New Point(38, 142)
        comboBoxTipo.Margin = New Padding(3, 2, 3, 2)
        comboBoxTipo.Name = "comboBoxTipo"
        comboBoxTipo.Size = New Size(133, 23)
        comboBoxTipo.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(38, 175)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 19)
        Label8.TabIndex = 35
        Label8.Text = "Artist"
        ' 
        ' TB_Artist_Sitio
        ' 
        TB_Artist_Sitio.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Artist_Sitio.Location = New Point(38, 195)
        TB_Artist_Sitio.Name = "TB_Artist_Sitio"
        TB_Artist_Sitio.Size = New Size(247, 23)
        TB_Artist_Sitio.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(38, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 19)
        Label5.TabIndex = 33
        Label5.Text = "Type"
        ' 
        ' lstSitios
        ' 
        lstSitios.Location = New Point(325, 41)
        lstSitios.MultiSelect = False
        lstSitios.Name = "lstSitios"
        lstSitios.Size = New Size(192, 264)
        lstSitios.TabIndex = 31
        lstSitios.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(26, 225)
        Button1.Name = "Button1"
        Button1.Size = New Size(272, 40)
        Button1.TabIndex = 30
        Button1.Text = "Clear all"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(204, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 35)
        Button2.TabIndex = 29
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(116, 278)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 35)
        Button3.TabIndex = 28
        Button3.Text = "Modify"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(26, 278)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 35)
        Button4.TabIndex = 27
        Button4.Text = "Add"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(38, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 19)
        Label3.TabIndex = 26
        Label3.Text = "Site Name"
        ' 
        ' TB_Name_Sitio
        ' 
        TB_Name_Sitio.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Sitio.Location = New Point(38, 90)
        TB_Name_Sitio.Name = "TB_Name_Sitio"
        TB_Name_Sitio.Size = New Size(247, 23)
        TB_Name_Sitio.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(38, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 19)
        Label4.TabIndex = 24
        Label4.Text = "Site ID"
        ' 
        ' TB_ID_Sitio
        ' 
        TB_ID_Sitio.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ID_Sitio.Location = New Point(38, 40)
        TB_ID_Sitio.Name = "TB_ID_Sitio"
        TB_ID_Sitio.Size = New Size(247, 23)
        TB_ID_Sitio.TabIndex = 23
        ' 
        ' ofdRuta
        ' 
        ofdRuta.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.ImageLocation = "AppMusic/Spotifake_logo.png"
        PictureBox1.Location = New Point(234, 12)
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
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
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
    Friend WithEvents lstSitios As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Name_Sitio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_ID_Sitio As TextBox
    Friend WithEvents comboBoxTipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Artist_Sitio As TextBox
    Friend WithEvents Label5 As Label
End Class
