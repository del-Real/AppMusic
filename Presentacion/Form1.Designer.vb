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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabAlbum = New System.Windows.Forms.TabPage()
        Me.lstAlbumes = New System.Windows.Forms.ListView()
        Me.CB_Artist_Album = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_ID_Album = New System.Windows.Forms.TextBox()
        Me.TB_Name_Album = New System.Windows.Forms.TextBox()
        Me.DTP_Year_Album = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabArtist = New System.Windows.Forms.TabPage()
        Me.CB_Country_Artist = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstArtist = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_Name_Artist = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_Id_Artist = New System.Windows.Forms.TextBox()
        Me.TabSong = New System.Windows.Forms.TabPage()
        Me.TabConcert = New System.Windows.Forms.TabPage()
        Me.TabCountry = New System.Windows.Forms.TabPage()
        Me.lstContries = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Name_Country = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Id_Country = New System.Windows.Forms.TextBox()
        Me.TabSite = New System.Windows.Forms.TabPage()
        Me.CB_Country_Site = New System.Windows.Forms.ComboBox()
        Me.CB_Type_Site = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstSites = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Name_Site = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Id_Site = New System.Windows.Forms.TextBox()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabAlbum.SuspendLayout()
        Me.TabArtist.SuspendLayout()
        Me.TabCountry.SuspendLayout()
        Me.TabSite.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabAlbum)
        Me.TabControl.Controls.Add(Me.TabArtist)
        Me.TabControl.Controls.Add(Me.TabSong)
        Me.TabControl.Controls.Add(Me.TabConcert)
        Me.TabControl.Controls.Add(Me.TabCountry)
        Me.TabControl.Controls.Add(Me.TabSite)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabControl.Location = New System.Drawing.Point(41, 88)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(18, 3)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(626, 429)
        Me.TabControl.TabIndex = 0
        '
        'TabAlbum
        '
        Me.TabAlbum.Controls.Add(Me.lstAlbumes)
        Me.TabAlbum.Controls.Add(Me.CB_Artist_Album)
        Me.TabAlbum.Controls.Add(Me.Label13)
        Me.TabAlbum.Controls.Add(Me.Label12)
        Me.TabAlbum.Controls.Add(Me.TB_ID_Album)
        Me.TabAlbum.Controls.Add(Me.TB_Name_Album)
        Me.TabAlbum.Controls.Add(Me.DTP_Year_Album)
        Me.TabAlbum.Controls.Add(Me.Label7)
        Me.TabAlbum.Controls.Add(Me.Label6)
        Me.TabAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabAlbum.Location = New System.Drawing.Point(4, 33)
        Me.TabAlbum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabAlbum.Name = "TabAlbum"
        Me.TabAlbum.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabAlbum.Size = New System.Drawing.Size(618, 392)
        Me.TabAlbum.TabIndex = 0
        Me.TabAlbum.Text = "Album"
        Me.TabAlbum.UseVisualStyleBackColor = True
        '
        'lstAlbumes
        '
        Me.lstAlbumes.Location = New System.Drawing.Point(339, 26)
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.Size = New System.Drawing.Size(249, 334)
        Me.lstAlbumes.TabIndex = 41
        Me.lstAlbumes.UseCompatibleStateImageBehavior = False
        '
        'CB_Artist_Album
        '
        Me.CB_Artist_Album.FormattingEnabled = True
        Me.CB_Artist_Album.Location = New System.Drawing.Point(33, 279)
        Me.CB_Artist_Album.Name = "CB_Artist_Album"
        Me.CB_Artist_Album.Size = New System.Drawing.Size(184, 32)
        Me.CB_Artist_Album.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 24)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Album ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 24)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Album Name"
        '
        'TB_ID_Album
        '
        Me.TB_ID_Album.Location = New System.Drawing.Point(33, 66)
        Me.TB_ID_Album.Name = "TB_ID_Album"
        Me.TB_ID_Album.Size = New System.Drawing.Size(273, 29)
        Me.TB_ID_Album.TabIndex = 32
        '
        'TB_Name_Album
        '
        Me.TB_Name_Album.Location = New System.Drawing.Point(33, 138)
        Me.TB_Name_Album.Name = "TB_Name_Album"
        Me.TB_Name_Album.Size = New System.Drawing.Size(273, 29)
        Me.TB_Name_Album.TabIndex = 31
        '
        'DTP_Year_Album
        '
        Me.DTP_Year_Album.CustomFormat = "yyyy"
        Me.DTP_Year_Album.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Year_Album.Location = New System.Drawing.Point(33, 208)
        Me.DTP_Year_Album.Name = "DTP_Year_Album"
        Me.DTP_Year_Album.ShowUpDown = True
        Me.DTP_Year_Album.Size = New System.Drawing.Size(91, 29)
        Me.DTP_Year_Album.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 24)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Artist name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Year"
        '
        'TabArtist
        '
        Me.TabArtist.Controls.Add(Me.CB_Country_Artist)
        Me.TabArtist.Controls.Add(Me.Label11)
        Me.TabArtist.Controls.Add(Me.lstArtist)
        Me.TabArtist.Controls.Add(Me.Label9)
        Me.TabArtist.Controls.Add(Me.TB_Name_Artist)
        Me.TabArtist.Controls.Add(Me.Label10)
        Me.TabArtist.Controls.Add(Me.TB_Id_Artist)
        Me.TabArtist.Location = New System.Drawing.Point(4, 33)
        Me.TabArtist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabArtist.Name = "TabArtist"
        Me.TabArtist.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabArtist.Size = New System.Drawing.Size(618, 392)
        Me.TabArtist.TabIndex = 1
        Me.TabArtist.Text = "Artist"
        Me.TabArtist.UseVisualStyleBackColor = True
        '
        'CB_Country_Artist
        '
        Me.CB_Country_Artist.FormattingEnabled = True
        Me.CB_Country_Artist.Location = New System.Drawing.Point(28, 206)
        Me.CB_Country_Artist.Name = "CB_Country_Artist"
        Me.CB_Country_Artist.Size = New System.Drawing.Size(151, 32)
        Me.CB_Country_Artist.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(28, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 23)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Country"
        '
        'lstArtist
        '
        Me.lstArtist.Location = New System.Drawing.Point(339, 34)
        Me.lstArtist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstArtist.MultiSelect = False
        Me.lstArtist.Name = "lstArtist"
        Me.lstArtist.Size = New System.Drawing.Size(251, 325)
        Me.lstArtist.TabIndex = 27
        Me.lstArtist.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(28, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 24)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Artist Name"
        '
        'TB_Name_Artist
        '
        Me.TB_Name_Artist.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Artist.Location = New System.Drawing.Point(28, 130)
        Me.TB_Name_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Artist.Name = "TB_Name_Artist"
        Me.TB_Name_Artist.Size = New System.Drawing.Size(282, 27)
        Me.TB_Name_Artist.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(28, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Artist ID"
        '
        'TB_Id_Artist
        '
        Me.TB_Id_Artist.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Artist.Location = New System.Drawing.Point(28, 62)
        Me.TB_Id_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Artist.Name = "TB_Id_Artist"
        Me.TB_Id_Artist.Size = New System.Drawing.Size(282, 27)
        Me.TB_Id_Artist.TabIndex = 23
        '
        'TabSong
        '
        Me.TabSong.Location = New System.Drawing.Point(4, 33)
        Me.TabSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSong.Name = "TabSong"
        Me.TabSong.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSong.Size = New System.Drawing.Size(618, 392)
        Me.TabSong.TabIndex = 2
        Me.TabSong.Text = "Song"
        Me.TabSong.UseVisualStyleBackColor = True
        '
        'TabConcert
        '
        Me.TabConcert.Location = New System.Drawing.Point(4, 33)
        Me.TabConcert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabConcert.Name = "TabConcert"
        Me.TabConcert.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabConcert.Size = New System.Drawing.Size(618, 392)
        Me.TabConcert.TabIndex = 3
        Me.TabConcert.Text = "Concert"
        Me.TabConcert.UseVisualStyleBackColor = True
        '
        'TabCountry
        '
        Me.TabCountry.Controls.Add(Me.lstContries)
        Me.TabCountry.Controls.Add(Me.Label2)
        Me.TabCountry.Controls.Add(Me.TB_Name_Country)
        Me.TabCountry.Controls.Add(Me.Label1)
        Me.TabCountry.Controls.Add(Me.TB_Id_Country)
        Me.TabCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabCountry.Location = New System.Drawing.Point(4, 33)
        Me.TabCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabCountry.Name = "TabCountry"
        Me.TabCountry.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabCountry.Size = New System.Drawing.Size(618, 392)
        Me.TabCountry.TabIndex = 4
        Me.TabCountry.Text = "Country"
        Me.TabCountry.UseVisualStyleBackColor = True
        '
        'lstContries
        '
        Me.lstContries.Location = New System.Drawing.Point(342, 33)
        Me.lstContries.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstContries.MultiSelect = False
        Me.lstContries.Name = "lstContries"
        Me.lstContries.Size = New System.Drawing.Size(251, 325)
        Me.lstContries.TabIndex = 22
        Me.lstContries.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(31, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Country Name"
        '
        'TB_Name_Country
        '
        Me.TB_Name_Country.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Country.Location = New System.Drawing.Point(31, 129)
        Me.TB_Name_Country.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Country.Name = "TB_Name_Country"
        Me.TB_Name_Country.Size = New System.Drawing.Size(282, 27)
        Me.TB_Name_Country.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Country ID"
        '
        'TB_Id_Country
        '
        Me.TB_Id_Country.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Country.Location = New System.Drawing.Point(31, 61)
        Me.TB_Id_Country.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Country.Name = "TB_Id_Country"
        Me.TB_Id_Country.Size = New System.Drawing.Size(282, 27)
        Me.TB_Id_Country.TabIndex = 14
        '
        'TabSite
        '
        Me.TabSite.Controls.Add(Me.CB_Country_Site)
        Me.TabSite.Controls.Add(Me.CB_Type_Site)
        Me.TabSite.Controls.Add(Me.Label8)
        Me.TabSite.Controls.Add(Me.Label5)
        Me.TabSite.Controls.Add(Me.lstSites)
        Me.TabSite.Controls.Add(Me.Label3)
        Me.TabSite.Controls.Add(Me.TB_Name_Site)
        Me.TabSite.Controls.Add(Me.Label4)
        Me.TabSite.Controls.Add(Me.TB_Id_Site)
        Me.TabSite.Location = New System.Drawing.Point(4, 33)
        Me.TabSite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSite.Name = "TabSite"
        Me.TabSite.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabSite.Size = New System.Drawing.Size(618, 392)
        Me.TabSite.TabIndex = 5
        Me.TabSite.Text = "Site"
        Me.TabSite.UseVisualStyleBackColor = True
        '
        'CB_Country_Site
        '
        Me.CB_Country_Site.FormattingEnabled = True
        Me.CB_Country_Site.Location = New System.Drawing.Point(43, 259)
        Me.CB_Country_Site.Name = "CB_Country_Site"
        Me.CB_Country_Site.Size = New System.Drawing.Size(151, 32)
        Me.CB_Country_Site.TabIndex = 37
        '
        'CB_Type_Site
        '
        Me.CB_Type_Site.FormattingEnabled = True
        Me.CB_Type_Site.Location = New System.Drawing.Point(43, 189)
        Me.CB_Type_Site.Name = "CB_Type_Site"
        Me.CB_Type_Site.Size = New System.Drawing.Size(151, 32)
        Me.CB_Type_Site.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(43, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 23)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(43, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Type"
        '
        'lstSites
        '
        Me.lstSites.Location = New System.Drawing.Point(339, 55)
        Me.lstSites.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSites.MultiSelect = False
        Me.lstSites.Name = "lstSites"
        Me.lstSites.Size = New System.Drawing.Size(265, 311)
        Me.lstSites.TabIndex = 31
        Me.lstSites.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(43, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Site Name"
        '
        'TB_Name_Site
        '
        Me.TB_Name_Site.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Site.Location = New System.Drawing.Point(43, 120)
        Me.TB_Name_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Site.Name = "TB_Name_Site"
        Me.TB_Name_Site.Size = New System.Drawing.Size(282, 27)
        Me.TB_Name_Site.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(43, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Site ID"
        '
        'TB_Id_Site
        '
        Me.TB_Id_Site.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Site.Location = New System.Drawing.Point(43, 53)
        Me.TB_Id_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Site.Name = "TB_Id_Site"
        Me.TB_Id_Site.Size = New System.Drawing.Size(282, 27)
        Me.TB_Id_Site.TabIndex = 23
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = "AppMusic/Spotifake_logo.png"
        Me.PictureBox1.Location = New System.Drawing.Point(275, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 47)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonClearAll.Location = New System.Drawing.Point(41, 537)
        Me.ButtonClearAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(107, 47)
        Me.ButtonClearAll.TabIndex = 25
        Me.ButtonClearAll.Text = "Clear all"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonDelete.Location = New System.Drawing.Point(155, 537)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(107, 47)
        Me.ButtonDelete.TabIndex = 24
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAdd.Location = New System.Drawing.Point(384, 537)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(283, 47)
        Me.ButtonAdd.TabIndex = 22
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonModify.Location = New System.Drawing.Point(270, 537)
        Me.ButtonModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(107, 47)
        Me.ButtonModify.TabIndex = 23
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 609)
        Me.Controls.Add(Me.ButtonClearAll)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.TabAlbum.ResumeLayout(False)
        Me.TabAlbum.PerformLayout()
        Me.TabArtist.ResumeLayout(False)
        Me.TabArtist.PerformLayout()
        Me.TabCountry.ResumeLayout(False)
        Me.TabCountry.PerformLayout()
        Me.TabSite.ResumeLayout(False)
        Me.TabSite.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabAlbum As TabPage
    Friend WithEvents TabArtist As TabPage
    Friend WithEvents TabSong As TabPage
    Friend WithEvents TabConcert As TabPage
    Friend WithEvents TabCountry As TabPage
    Friend WithEvents TabSite As TabPage
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents DTP_Year_Album As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Name_Country As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Id_Country As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstContries As ListView
    Friend WithEvents lstSites As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Name_Site As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Id_Site As TextBox
    Friend WithEvents CB_Type_Site As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents CB_Country_Site As ComboBox
    Friend WithEvents lstArtist As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_Name_Artist As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_Id_Artist As TextBox
    Friend WithEvents CB_Country_Artist As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CB_Artist_Album As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TB_ID_Album As TextBox
    Friend WithEvents TB_Name_Album As TextBox
    Friend WithEvents lstAlbumes As ListView
End Class
