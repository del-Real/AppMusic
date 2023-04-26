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
        TabControl = New TabControl()
        TabAlbum = New TabPage()
        lstAlbumes = New ListView()
        CB_Artist_Album = New ComboBox()
        Label13 = New Label()
        Label20 = New Label()
        Label12 = New Label()
        TB_ID_Album = New TextBox()
        TB_Name_Album = New TextBox()
        DTP_Year_Album = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        TabArtist = New TabPage()
        CB_Country_Artist = New ComboBox()
        Label11 = New Label()
        lstArtist = New ListView()
        Label9 = New Label()
        TB_Name_Artist = New TextBox()
        Label10 = New Label()
        TB_Id_Artist = New TextBox()
        TabSong = New TabPage()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        TB_Order_Song = New TextBox()
        TB_Duration_Song = New TextBox()
        lstSong = New ListView()
        CB_Album_Song = New ComboBox()
        Label14 = New Label()
        Label15 = New Label()
        TB_Name_Song = New TextBox()
        Label16 = New Label()
        TB_Id_Song = New TextBox()
        TabConcert = New TabPage()
        CB_Site_Concert = New ComboBox()
        Label24 = New Label()
        CB_Artist_Concert = New ComboBox()
        Label23 = New Label()
        lstConcert = New ListView()
        Label22 = New Label()
        TB_Id_Concert = New TextBox()
        Label21 = New Label()
        DTP_Date_Concert = New DateTimePicker()
        TabCountry = New TabPage()
        lstContries = New ListView()
        Label2 = New Label()
        TB_Name_Country = New TextBox()
        Label1 = New Label()
        TB_Id_Country = New TextBox()
        TabSite = New TabPage()
        CB_Country_Site = New ComboBox()
        CB_Type_Site = New ComboBox()
        Label8 = New Label()
        Label5 = New Label()
        lstSites = New ListView()
        Label3 = New Label()
        TB_Name_Site = New TextBox()
        Label4 = New Label()
        TB_Id_Site = New TextBox()
        ofdRuta = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        ButtonClearAll = New Button()
        ButtonDelete = New Button()
        ButtonAdd = New Button()
        ButtonModify = New Button()
        lstConcertSongs = New ListView()
        lstAllSongs = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label25 = New Label()
        Label26 = New Label()
        TabControl.SuspendLayout()
        TabAlbum.SuspendLayout()
        TabArtist.SuspendLayout()
        TabSong.SuspendLayout()
        TabConcert.SuspendLayout()
        TabCountry.SuspendLayout()
        TabSite.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabAlbum)
        TabControl.Controls.Add(TabArtist)
        TabControl.Controls.Add(TabSong)
        TabControl.Controls.Add(TabConcert)
        TabControl.Controls.Add(TabCountry)
        TabControl.Controls.Add(TabSite)
        TabControl.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl.Location = New Point(36, 71)
        TabControl.Name = "TabControl"
        TabControl.Padding = New Point(17, 3)
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(548, 322)
        TabControl.TabIndex = 0
        ' 
        ' TabAlbum
        ' 
        TabAlbum.Controls.Add(lstAlbumes)
        TabAlbum.Controls.Add(CB_Artist_Album)
        TabAlbum.Controls.Add(Label13)
        TabAlbum.Controls.Add(Label20)
        TabAlbum.Controls.Add(Label12)
        TabAlbum.Controls.Add(TB_ID_Album)
        TabAlbum.Controls.Add(TB_Name_Album)
        TabAlbum.Controls.Add(DTP_Year_Album)
        TabAlbum.Controls.Add(Label7)
        TabAlbum.Controls.Add(Label6)
        TabAlbum.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabAlbum.Location = New Point(4, 29)
        TabAlbum.Name = "TabAlbum"
        TabAlbum.Padding = New Padding(3)
        TabAlbum.Size = New Size(540, 289)
        TabAlbum.TabIndex = 0
        TabAlbum.Text = "Album"
        TabAlbum.UseVisualStyleBackColor = True
        ' 
        ' lstAlbumes
        ' 
        lstAlbumes.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lstAlbumes.Location = New Point(297, 20)
        lstAlbumes.Margin = New Padding(3, 2, 3, 2)
        lstAlbumes.MultiSelect = False
        lstAlbumes.Name = "lstAlbumes"
        lstAlbumes.Size = New Size(218, 252)
        lstAlbumes.TabIndex = 41
        lstAlbumes.UseCompatibleStateImageBehavior = False
        ' 
        ' CB_Artist_Album
        ' 
        CB_Artist_Album.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Artist_Album.FormattingEnabled = True
        CB_Artist_Album.Location = New Point(26, 209)
        CB_Artist_Album.Margin = New Padding(3, 2, 3, 2)
        CB_Artist_Album.Name = "CB_Artist_Album"
        CB_Artist_Album.Size = New Size(162, 26)
        CB_Artist_Album.TabIndex = 40
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(26, 20)
        Label13.Name = "Label13"
        Label13.Size = New Size(67, 18)
        Label13.TabIndex = 34
        Label13.Text = "Album ID"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(26, 83)
        Label20.Name = "Label20"
        Label20.Size = New Size(93, 18)
        Label20.TabIndex = 33
        Label20.Text = "Album Name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(29, 83)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 18)
        Label12.TabIndex = 33
        Label12.Text = "Album Name"
        ' 
        ' TB_ID_Album
        ' 
        TB_ID_Album.Enabled = False
        TB_ID_Album.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ID_Album.Location = New Point(26, 40)
        TB_ID_Album.Margin = New Padding(3, 2, 3, 2)
        TB_ID_Album.Name = "TB_ID_Album"
        TB_ID_Album.Size = New Size(239, 24)
        TB_ID_Album.TabIndex = 32
        ' 
        ' TB_Name_Album
        ' 
        TB_Name_Album.Location = New Point(29, 104)
        TB_Name_Album.Margin = New Padding(3, 2, 3, 2)
        TB_Name_Album.Name = "TB_Name_Album"
        TB_Name_Album.Size = New Size(239, 24)
        TB_Name_Album.TabIndex = 31
        ' 
        ' DTP_Year_Album
        ' 
        DTP_Year_Album.CustomFormat = "yyyy"
        DTP_Year_Album.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DTP_Year_Album.Format = DateTimePickerFormat.Custom
        DTP_Year_Album.Location = New Point(26, 156)
        DTP_Year_Album.Margin = New Padding(3, 2, 3, 2)
        DTP_Year_Album.Name = "DTP_Year_Album"
        DTP_Year_Album.ShowUpDown = True
        DTP_Year_Album.Size = New Size(80, 24)
        DTP_Year_Album.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(26, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 18)
        Label7.TabIndex = 29
        Label7.Text = "Artist name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(26, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 18)
        Label6.TabIndex = 27
        Label6.Text = "Year"
        ' 
        ' TabArtist
        ' 
        TabArtist.Controls.Add(CB_Country_Artist)
        TabArtist.Controls.Add(Label11)
        TabArtist.Controls.Add(lstArtist)
        TabArtist.Controls.Add(Label9)
        TabArtist.Controls.Add(TB_Name_Artist)
        TabArtist.Controls.Add(Label10)
        TabArtist.Controls.Add(TB_Id_Artist)
        TabArtist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabArtist.Location = New Point(4, 29)
        TabArtist.Name = "TabArtist"
        TabArtist.Padding = New Padding(3)
        TabArtist.Size = New Size(540, 289)
        TabArtist.TabIndex = 1
        TabArtist.Text = "Artist"
        TabArtist.UseVisualStyleBackColor = True
        ' 
        ' CB_Country_Artist
        ' 
        CB_Country_Artist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Country_Artist.FormattingEnabled = True
        CB_Country_Artist.Location = New Point(24, 154)
        CB_Country_Artist.Margin = New Padding(3, 2, 3, 2)
        CB_Country_Artist.Name = "CB_Country_Artist"
        CB_Country_Artist.Size = New Size(133, 26)
        CB_Country_Artist.TabIndex = 39
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(24, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 18)
        Label11.TabIndex = 38
        Label11.Text = "Country"
        ' 
        ' lstArtist
        ' 
        lstArtist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lstArtist.Location = New Point(297, 26)
        lstArtist.MultiSelect = False
        lstArtist.Name = "lstArtist"
        lstArtist.Size = New Size(220, 245)
        lstArtist.TabIndex = 27
        lstArtist.UseCompatibleStateImageBehavior = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(24, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 18)
        Label9.TabIndex = 26
        Label9.Text = "Artist Name"
        ' 
        ' TB_Name_Artist
        ' 
        TB_Name_Artist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Artist.Location = New Point(24, 98)
        TB_Name_Artist.Name = "TB_Name_Artist"
        TB_Name_Artist.Size = New Size(247, 24)
        TB_Name_Artist.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(24, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 18)
        Label10.TabIndex = 24
        Label10.Text = "Artist ID"
        ' 
        ' TB_Id_Artist
        ' 
        TB_Id_Artist.Enabled = False
        TB_Id_Artist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id_Artist.Location = New Point(24, 46)
        TB_Id_Artist.Name = "TB_Id_Artist"
        TB_Id_Artist.Size = New Size(247, 24)
        TB_Id_Artist.TabIndex = 23
        ' 
        ' TabSong
        ' 
        TabSong.Controls.Add(Label19)
        TabSong.Controls.Add(Label18)
        TabSong.Controls.Add(Label17)
        TabSong.Controls.Add(TB_Order_Song)
        TabSong.Controls.Add(TB_Duration_Song)
        TabSong.Controls.Add(lstSong)
        TabSong.Controls.Add(CB_Album_Song)
        TabSong.Controls.Add(Label14)
        TabSong.Controls.Add(Label15)
        TabSong.Controls.Add(TB_Name_Song)
        TabSong.Controls.Add(Label16)
        TabSong.Controls.Add(TB_Id_Song)
        TabSong.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabSong.Location = New Point(4, 29)
        TabSong.Name = "TabSong"
        TabSong.Padding = New Padding(3)
        TabSong.Size = New Size(540, 289)
        TabSong.TabIndex = 2
        TabSong.Text = "Song"
        TabSong.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(23, 232)
        Label19.Name = "Label19"
        Label19.Size = New Size(46, 18)
        Label19.TabIndex = 50
        Label19.Text = "Order"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(23, 234)
        Label18.Name = "Label18"
        Label18.Size = New Size(46, 18)
        Label18.TabIndex = 50
        Label18.Text = "Order"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(23, 130)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 18)
        Label17.TabIndex = 49
        Label17.Text = "Duration"
        ' 
        ' TB_Order_Song
        ' 
        TB_Order_Song.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Order_Song.Location = New Point(23, 255)
        TB_Order_Song.Name = "TB_Order_Song"
        TB_Order_Song.Size = New Size(247, 23)
        TB_Order_Song.TabIndex = 48
        ' 
        ' TB_Duration_Song
        ' 
        TB_Duration_Song.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Duration_Song.Location = New Point(23, 147)
        TB_Duration_Song.Name = "TB_Duration_Song"
        TB_Duration_Song.Size = New Size(247, 24)
        TB_Duration_Song.TabIndex = 47
        ' 
        ' lstSong
        ' 
        lstSong.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lstSong.Location = New Point(296, 21)
        lstSong.MultiSelect = False
        lstSong.Name = "lstSong"
        lstSong.Size = New Size(223, 257)
        lstSong.TabIndex = 46
        lstSong.UseCompatibleStateImageBehavior = False
        ' 
        ' CB_Album_Song
        ' 
        CB_Album_Song.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Album_Song.FormattingEnabled = True
        CB_Album_Song.Location = New Point(23, 200)
        CB_Album_Song.Margin = New Padding(3, 2, 3, 2)
        CB_Album_Song.Name = "CB_Album_Song"
        CB_Album_Song.Size = New Size(133, 26)
        CB_Album_Song.TabIndex = 45
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(23, 181)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 18)
        Label14.TabIndex = 44
        Label14.Text = "Album"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(23, 78)
        Label15.Name = "Label15"
        Label15.Size = New Size(87, 18)
        Label15.TabIndex = 43
        Label15.Text = "Song Name"
        ' 
        ' TB_Name_Song
        ' 
        TB_Name_Song.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Song.Location = New Point(23, 96)
        TB_Name_Song.Name = "TB_Name_Song"
        TB_Name_Song.Size = New Size(247, 24)
        TB_Name_Song.TabIndex = 42
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(23, 21)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 18)
        Label16.TabIndex = 41
        Label16.Text = "Song ID"
        ' 
        ' TB_Id_Song
        ' 
        TB_Id_Song.Enabled = False
        TB_Id_Song.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id_Song.Location = New Point(23, 41)
        TB_Id_Song.Name = "TB_Id_Song"
        TB_Id_Song.Size = New Size(247, 24)
        TB_Id_Song.TabIndex = 40
        ' 
        ' TabConcert
        ' 
        TabConcert.Controls.Add(CB_Site_Concert)
        TabConcert.Controls.Add(Label24)
        TabConcert.Controls.Add(CB_Artist_Concert)
        TabConcert.Controls.Add(Label23)
        TabConcert.Controls.Add(lstConcert)
        TabConcert.Controls.Add(Label22)
        TabConcert.Controls.Add(TB_Id_Concert)
        TabConcert.Controls.Add(Label21)
        TabConcert.Controls.Add(DTP_Date_Concert)
        TabConcert.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabConcert.Location = New Point(4, 29)
        TabConcert.Name = "TabConcert"
        TabConcert.Padding = New Padding(3)
        TabConcert.Size = New Size(540, 289)
        TabConcert.TabIndex = 3
        TabConcert.Text = "Concert"
        TabConcert.UseVisualStyleBackColor = True
        ' 
        ' CB_Site_Concert
        ' 
        CB_Site_Concert.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Site_Concert.FormattingEnabled = True
        CB_Site_Concert.Location = New Point(35, 161)
        CB_Site_Concert.Margin = New Padding(3, 2, 3, 2)
        CB_Site_Concert.Name = "CB_Site_Concert"
        CB_Site_Concert.Size = New Size(133, 26)
        CB_Site_Concert.TabIndex = 44
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(35, 142)
        Label24.Name = "Label24"
        Label24.Size = New Size(33, 18)
        Label24.TabIndex = 43
        Label24.Text = "Site"
        ' 
        ' CB_Artist_Concert
        ' 
        CB_Artist_Concert.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Artist_Concert.FormattingEnabled = True
        CB_Artist_Concert.Location = New Point(35, 103)
        CB_Artist_Concert.Margin = New Padding(3, 2, 3, 2)
        CB_Artist_Concert.Name = "CB_Artist_Concert"
        CB_Artist_Concert.Size = New Size(162, 26)
        CB_Artist_Concert.TabIndex = 42
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(35, 83)
        Label23.Name = "Label23"
        Label23.Size = New Size(82, 18)
        Label23.TabIndex = 41
        Label23.Text = "Artist name"
        ' 
        ' lstConcert
        ' 
        lstConcert.Location = New Point(296, 22)
        lstConcert.MultiSelect = False
        lstConcert.Name = "lstConcert"
        lstConcert.Size = New Size(220, 245)
        lstConcert.TabIndex = 23
        lstConcert.UseCompatibleStateImageBehavior = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(35, 22)
        Label22.Name = "Label22"
        Label22.Size = New Size(79, 18)
        Label22.TabIndex = 20
        Label22.Text = "Concert ID"
        ' 
        ' TB_Id_Concert
        ' 
        TB_Id_Concert.Enabled = False
        TB_Id_Concert.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id_Concert.Location = New Point(35, 43)
        TB_Id_Concert.Name = "TB_Id_Concert"
        TB_Id_Concert.Size = New Size(247, 24)
        TB_Id_Concert.TabIndex = 19
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(35, 198)
        Label21.Name = "Label21"
        Label21.Size = New Size(96, 18)
        Label21.TabIndex = 18
        Label21.Text = "Concert Date"
        ' 
        ' DTP_Date_Concert
        ' 
        DTP_Date_Concert.CustomFormat = "yyyy/MM/dd"
        DTP_Date_Concert.Format = DateTimePickerFormat.Custom
        DTP_Date_Concert.Location = New Point(35, 219)
        DTP_Date_Concert.Name = "DTP_Date_Concert"
        DTP_Date_Concert.Size = New Size(200, 24)
        DTP_Date_Concert.TabIndex = 0
        DTP_Date_Concert.Value = New DateTime(2023, 4, 26, 0, 0, 0, 0)
        ' 
        ' TabCountry
        ' 
        TabCountry.Controls.Add(lstContries)
        TabCountry.Controls.Add(Label2)
        TabCountry.Controls.Add(TB_Name_Country)
        TabCountry.Controls.Add(Label1)
        TabCountry.Controls.Add(TB_Id_Country)
        TabCountry.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabCountry.Location = New Point(4, 29)
        TabCountry.Name = "TabCountry"
        TabCountry.Padding = New Padding(3)
        TabCountry.Size = New Size(540, 289)
        TabCountry.TabIndex = 4
        TabCountry.Text = "Country"
        TabCountry.UseVisualStyleBackColor = True
        ' 
        ' lstContries
        ' 
        lstContries.Location = New Point(299, 25)
        lstContries.MultiSelect = False
        lstContries.Name = "lstContries"
        lstContries.Size = New Size(220, 245)
        lstContries.TabIndex = 22
        lstContries.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(24, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 18)
        Label2.TabIndex = 17
        Label2.Text = "Country Name"
        ' 
        ' TB_Name_Country
        ' 
        TB_Name_Country.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Country.Location = New Point(24, 97)
        TB_Name_Country.Name = "TB_Name_Country"
        TB_Name_Country.Size = New Size(247, 24)
        TB_Name_Country.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(24, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 18)
        Label1.TabIndex = 15
        Label1.Text = "Country ID"
        ' 
        ' TB_Id_Country
        ' 
        TB_Id_Country.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id_Country.Location = New Point(24, 46)
        TB_Id_Country.Name = "TB_Id_Country"
        TB_Id_Country.Size = New Size(247, 24)
        TB_Id_Country.TabIndex = 14
        ' 
        ' TabSite
        ' 
        TabSite.Controls.Add(CB_Country_Site)
        TabSite.Controls.Add(CB_Type_Site)
        TabSite.Controls.Add(Label8)
        TabSite.Controls.Add(Label5)
        TabSite.Controls.Add(lstSites)
        TabSite.Controls.Add(Label3)
        TabSite.Controls.Add(TB_Name_Site)
        TabSite.Controls.Add(Label4)
        TabSite.Controls.Add(TB_Id_Site)
        TabSite.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabSite.Location = New Point(4, 29)
        TabSite.Name = "TabSite"
        TabSite.Padding = New Padding(3)
        TabSite.RightToLeft = RightToLeft.No
        TabSite.Size = New Size(540, 289)
        TabSite.TabIndex = 5
        TabSite.Text = "Site"
        TabSite.UseVisualStyleBackColor = True
        ' 
        ' CB_Country_Site
        ' 
        CB_Country_Site.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Country_Site.FormattingEnabled = True
        CB_Country_Site.Location = New Point(28, 206)
        CB_Country_Site.Margin = New Padding(3, 2, 3, 2)
        CB_Country_Site.Name = "CB_Country_Site"
        CB_Country_Site.Size = New Size(133, 26)
        CB_Country_Site.TabIndex = 37
        ' 
        ' CB_Type_Site
        ' 
        CB_Type_Site.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Type_Site.FormattingEnabled = True
        CB_Type_Site.Location = New Point(28, 151)
        CB_Type_Site.Margin = New Padding(3, 2, 3, 2)
        CB_Type_Site.Name = "CB_Type_Site"
        CB_Type_Site.Size = New Size(133, 26)
        CB_Type_Site.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(28, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 18)
        Label8.TabIndex = 35
        Label8.Text = "Country"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(28, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 18)
        Label5.TabIndex = 33
        Label5.Text = "Type"
        ' 
        ' lstSites
        ' 
        lstSites.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lstSites.Location = New Point(297, 20)
        lstSites.MultiSelect = False
        lstSites.Name = "lstSites"
        lstSites.Size = New Size(232, 255)
        lstSites.TabIndex = 31
        lstSites.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(28, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 18)
        Label3.TabIndex = 26
        Label3.Text = "Site Name"
        ' 
        ' TB_Name_Site
        ' 
        TB_Name_Site.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Name_Site.Location = New Point(28, 95)
        TB_Name_Site.Name = "TB_Name_Site"
        TB_Name_Site.Size = New Size(247, 24)
        TB_Name_Site.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(28, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 18)
        Label4.TabIndex = 24
        Label4.Text = "Site ID"
        ' 
        ' TB_Id_Site
        ' 
        TB_Id_Site.Enabled = False
        TB_Id_Site.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Id_Site.Location = New Point(28, 40)
        TB_Id_Site.Name = "TB_Id_Site"
        TB_Id_Site.Size = New Size(247, 24)
        TB_Id_Site.TabIndex = 23
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
        ButtonClearAll.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClearAll.Location = New Point(36, 406)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(94, 35)
        ButtonClearAll.TabIndex = 25
        ButtonClearAll.Text = "Clear all"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonDelete.Location = New Point(136, 406)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 35)
        ButtonDelete.TabIndex = 24
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonAdd.Location = New Point(336, 406)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(248, 35)
        ButtonAdd.TabIndex = 22
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonModify.Location = New Point(236, 406)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(94, 35)
        ButtonModify.TabIndex = 23
        ButtonModify.Text = "Modify"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' lstConcertSongs
        ' 
        lstConcertSongs.Location = New Point(75, 483)
        lstConcertSongs.Name = "lstConcertSongs"
        lstConcertSongs.Size = New Size(186, 201)
        lstConcertSongs.TabIndex = 26
        lstConcertSongs.UseCompatibleStateImageBehavior = False
        ' 
        ' lstAllSongs
        ' 
        lstAllSongs.Location = New Point(378, 483)
        lstAllSongs.Name = "lstAllSongs"
        lstAllSongs.Size = New Size(202, 201)
        lstAllSongs.TabIndex = 27
        lstAllSongs.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(281, 559)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 28
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(281, 588)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 29
        Button2.Text = "Remove"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(40, 483)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 42)
        Button3.TabIndex = 30
        Button3.Text = "↑"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(40, 529)
        Button4.Name = "Button4"
        Button4.Size = New Size(29, 42)
        Button4.TabIndex = 31
        Button4.Text = "↓"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(75, 465)
        Label25.Name = "Label25"
        Label25.Size = New Size(84, 15)
        Label25.TabIndex = 32
        Label25.Text = "Concert Songs"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(378, 465)
        Label26.Name = "Label26"
        Label26.Size = New Size(56, 15)
        Label26.TabIndex = 33
        Label26.Text = "All Songs"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 707)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lstAllSongs)
        Controls.Add(lstConcertSongs)
        Controls.Add(ButtonClearAll)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonModify)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl)
        Name = "Form1"
        Text = "Form1"
        TabControl.ResumeLayout(False)
        TabAlbum.ResumeLayout(False)
        TabAlbum.PerformLayout()
        TabArtist.ResumeLayout(False)
        TabArtist.PerformLayout()
        TabSong.ResumeLayout(False)
        TabSong.PerformLayout()
        TabConcert.ResumeLayout(False)
        TabConcert.PerformLayout()
        TabCountry.ResumeLayout(False)
        TabCountry.PerformLayout()
        TabSite.ResumeLayout(False)
        TabSite.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TB_Order_Song As TextBox
    Friend WithEvents TB_Duration_Song As TextBox
    Friend WithEvents lstSong As ListView
    Friend WithEvents CB_Album_Song As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TB_Name_Song As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TB_Id_Song As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DTP_Date_Concert As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents TB_Id_Concert As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lstConcert As ListView
    Friend WithEvents CB_Artist_Concert As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents CB_Site_Concert As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents lstConcertSongs As ListView
    Friend WithEvents lstAllSongs As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
