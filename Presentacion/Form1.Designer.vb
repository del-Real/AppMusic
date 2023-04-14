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
        DTP_Year_Album = New DateTimePicker()
        Label7 = New Label()
        TB_Artist_Album = New TextBox()
        Label6 = New Label()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        lstPaises = New ListView()
        Label2 = New Label()
        TB_Name = New TextBox()
        Label1 = New Label()
        Id_Country = New TextBox()
        TabPage6 = New TabPage()
        CB_Type_Site = New ComboBox()
        Label8 = New Label()
        TB_Artist_Site = New TextBox()
        Label5 = New Label()
        lstSitios = New ListView()
        Label3 = New Label()
        TB_Name_Site = New TextBox()
        Label4 = New Label()
        TB_ID_Site = New TextBox()
        ofdRuta = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        ButtonClearAll = New Button()
        ButtonDelete = New Button()
        ButtonAdd = New Button()
        ButtonModify = New Button()
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
        TabControl1.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(36, 66)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(18, 3)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(548, 322)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DTP_Year_Album)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(TB_Artist_Album)
        TabPage1.Controls.Add(Label6)
        TabPage1.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(540, 291)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Album"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DTP_Year_Album
        ' 
        DTP_Year_Album.CustomFormat = "yyyy"
        DTP_Year_Album.Format = DateTimePickerFormat.Custom
        DTP_Year_Album.Location = New Point(59, 82)
        DTP_Year_Album.Margin = New Padding(3, 2, 3, 2)
        DTP_Year_Album.Name = "DTP_Year_Album"
        DTP_Year_Album.ShowUpDown = True
        DTP_Year_Album.Size = New Size(80, 25)
        DTP_Year_Album.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(59, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 18)
        Label7.TabIndex = 29
        Label7.Text = "Artist name"
        ' 
        ' TB_Artist_Album
        ' 
        TB_Artist_Album.Location = New Point(59, 154)
        TB_Artist_Album.Name = "TB_Artist_Album"
        TB_Artist_Album.Size = New Size(237, 25)
        TB_Artist_Album.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 18)
        Label6.TabIndex = 27
        Label6.Text = "Year"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(540, 291)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Artist"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(540, 291)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Song"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 27)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(540, 291)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Concert"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(lstPaises)
        TabPage5.Controls.Add(Label2)
        TabPage5.Controls.Add(TB_Name)
        TabPage5.Controls.Add(Label1)
        TabPage5.Controls.Add(Id_Country)
        TabPage5.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage5.Location = New Point(4, 27)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(540, 291)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Country"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' lstPaises
        ' 
        lstPaises.Location = New Point(299, 25)
        lstPaises.MultiSelect = False
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(220, 245)
        lstPaises.TabIndex = 22
        lstPaises.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(27, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 18)
        Label2.TabIndex = 17
        Label2.Text = "Country Name"
        ' 
        ' TB_Name
        ' 
        TB_Name.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name.Location = New Point(27, 97)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(247, 23)
        TB_Name.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(27, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 18)
        Label1.TabIndex = 15
        Label1.Text = "Country ID"
        ' 
        ' Id_Country
        ' 
        Id_Country.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Id_Country.Location = New Point(27, 46)
        Id_Country.Name = "Id_Country"
        Id_Country.Size = New Size(247, 23)
        Id_Country.TabIndex = 14
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(CB_Type_Site)
        TabPage6.Controls.Add(Label8)
        TabPage6.Controls.Add(TB_Artist_Site)
        TabPage6.Controls.Add(Label5)
        TabPage6.Controls.Add(lstSitios)
        TabPage6.Controls.Add(Label3)
        TabPage6.Controls.Add(TB_Name_Site)
        TabPage6.Controls.Add(Label4)
        TabPage6.Controls.Add(TB_ID_Site)
        TabPage6.Location = New Point(4, 27)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.RightToLeft = RightToLeft.No
        TabPage6.Size = New Size(540, 291)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Site"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' CB_Type_Site
        ' 
        CB_Type_Site.FormattingEnabled = True
        CB_Type_Site.Location = New Point(38, 142)
        CB_Type_Site.Margin = New Padding(3, 2, 3, 2)
        CB_Type_Site.Name = "CB_Type_Site"
        CB_Type_Site.Size = New Size(133, 26)
        CB_Type_Site.TabIndex = 36
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
        ' TB_Artist_Site
        ' 
        TB_Artist_Site.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Artist_Site.Location = New Point(38, 195)
        TB_Artist_Site.Name = "TB_Artist_Site"
        TB_Artist_Site.Size = New Size(247, 23)
        TB_Artist_Site.TabIndex = 34
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
        lstSitios.Size = New Size(192, 234)
        lstSitios.TabIndex = 31
        lstSitios.UseCompatibleStateImageBehavior = False
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
        ' TB_Name_Site
        ' 
        TB_Name_Site.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Site.Location = New Point(38, 90)
        TB_Name_Site.Name = "TB_Name_Site"
        TB_Name_Site.Size = New Size(247, 23)
        TB_Name_Site.TabIndex = 25
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
        ' TB_ID_Site
        ' 
        TB_ID_Site.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ID_Site.Location = New Point(38, 40)
        TB_ID_Site.Name = "TB_ID_Site"
        TB_ID_Site.Size = New Size(247, 23)
        TB_ID_Site.TabIndex = 23
        ' 
        ' ofdRuta
        ' 
        ofdRuta.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.ImageLocation = "AppMusic/Spotifake_logo.png"
        PictureBox1.Location = New Point(241, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 35)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ButtonClearAll
        ' 
        ButtonClearAll.FlatStyle = FlatStyle.System
        ButtonClearAll.Font = New Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClearAll.Location = New Point(36, 403)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(94, 35)
        ButtonClearAll.TabIndex = 25
        ButtonClearAll.Text = "Clear all"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonDelete.Location = New Point(136, 403)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 35)
        ButtonDelete.TabIndex = 24
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonAdd.Location = New Point(336, 403)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(248, 35)
        ButtonAdd.TabIndex = 22
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Font = New Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonModify.Location = New Point(236, 403)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(94, 35)
        ButtonModify.TabIndex = 23
        ButtonModify.Text = "Modify"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 457)
        Controls.Add(ButtonClearAll)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonModify)
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
    Friend WithEvents DTP_Year_Album As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_Artist_Album As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Id_Country As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstPaises As ListView
    Friend WithEvents lstSitios As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Name_Site As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_ID_Site As TextBox
    Friend WithEvents CB_Type_Site As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Artist_Site As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
End Class
