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
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_Order_Song = New System.Windows.Forms.TextBox()
        Me.TB_Duration_Song = New System.Windows.Forms.TextBox()
        Me.lstSong = New System.Windows.Forms.ListView()
        Me.CB_Album_Song = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_Name_Song = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_Id_Song = New System.Windows.Forms.TextBox()
        Me.TabConcert = New System.Windows.Forms.TabPage()
        Me.CB_Site_Concert = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CB_Artist_Concert = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lstConcert = New System.Windows.Forms.ListView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_Id_Concert = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DTP_Date_Concert = New System.Windows.Forms.DateTimePicker()
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
        Me.TabNavegation = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CB_Site_Navegation = New System.Windows.Forms.ComboBox()
        Me.lstSetlist_Site = New System.Windows.Forms.ListView()
        Me.lstConcert_Site = New System.Windows.Forms.ListView()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CB_Country_Navegation = New System.Windows.Forms.ComboBox()
        Me.CB_Artist_Navegation = New System.Windows.Forms.ComboBox()
        Me.lstSetlist_Artist = New System.Windows.Forms.ListView()
        Me.lstConcert_Artist = New System.Windows.Forms.ListView()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.TabReports = New System.Windows.Forms.TabControl()
        Me.TabReport1 = New System.Windows.Forms.TabPage()
        Me.lstReport1 = New System.Windows.Forms.ListView()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CB_Artist_Report1 = New System.Windows.Forms.ComboBox()
        Me.TabReport2 = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CB_Artist_Report2 = New System.Windows.Forms.ComboBox()
        Me.lstReport2 = New System.Windows.Forms.ListView()
        Me.TabReport3 = New System.Windows.Forms.TabPage()
        Me.ButtonFind_Report3 = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lstReport3 = New System.Windows.Forms.ListView()
        Me.TabReport4 = New System.Windows.Forms.TabPage()
        Me.ButtonFind_Report4 = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lstReport4 = New System.Windows.Forms.ListView()
        Me.TabReport5 = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.DTP_Start_R5 = New System.Windows.Forms.DateTimePicker()
        Me.DTP_End_R5 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonFind_Report5 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lstReport5 = New System.Windows.Forms.ListView()
        Me.TabReport6 = New System.Windows.Forms.TabPage()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.DTP_Start_R6 = New System.Windows.Forms.DateTimePicker()
        Me.DTP_End_R6 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonFind_Report6 = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lstReport6 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.lstConcertSongs = New System.Windows.Forms.ListView()
        Me.lstAllSongs = New System.Windows.Forms.ListView()
        Me.AddSong = New System.Windows.Forms.Button()
        Me.RemoveSong = New System.Windows.Forms.Button()
        Me.OrderUp = New System.Windows.Forms.Button()
        Me.OrderDown = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ModifySong = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabAlbum.SuspendLayout()
        Me.TabArtist.SuspendLayout()
        Me.TabSong.SuspendLayout()
        Me.TabConcert.SuspendLayout()
        Me.TabCountry.SuspendLayout()
        Me.TabSite.SuspendLayout()
        Me.TabNavegation.SuspendLayout()
        Me.TabReport.SuspendLayout()
        Me.TabReports.SuspendLayout()
        Me.TabReport1.SuspendLayout()
        Me.TabReport2.SuspendLayout()
        Me.TabReport3.SuspendLayout()
        Me.TabReport4.SuspendLayout()
        Me.TabReport5.SuspendLayout()
        Me.TabReport6.SuspendLayout()
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
        Me.TabControl.Controls.Add(Me.TabNavegation)
        Me.TabControl.Controls.Add(Me.TabReport)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabControl.Location = New System.Drawing.Point(41, 104)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(17, 3)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(626, 429)
        Me.TabControl.TabIndex = 0
        '
        'TabAlbum
        '
        Me.TabAlbum.Controls.Add(Me.lstAlbumes)
        Me.TabAlbum.Controls.Add(Me.CB_Artist_Album)
        Me.TabAlbum.Controls.Add(Me.Label13)
        Me.TabAlbum.Controls.Add(Me.Label20)
        Me.TabAlbum.Controls.Add(Me.Label12)
        Me.TabAlbum.Controls.Add(Me.TB_ID_Album)
        Me.TabAlbum.Controls.Add(Me.TB_Name_Album)
        Me.TabAlbum.Controls.Add(Me.DTP_Year_Album)
        Me.TabAlbum.Controls.Add(Me.Label7)
        Me.TabAlbum.Controls.Add(Me.Label6)
        Me.TabAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabAlbum.Location = New System.Drawing.Point(4, 34)
        Me.TabAlbum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabAlbum.Name = "TabAlbum"
        Me.TabAlbum.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabAlbum.Size = New System.Drawing.Size(618, 391)
        Me.TabAlbum.TabIndex = 0
        Me.TabAlbum.Text = "Album"
        Me.TabAlbum.UseVisualStyleBackColor = True
        '
        'lstAlbumes
        '
        Me.lstAlbumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstAlbumes.Location = New System.Drawing.Point(339, 27)
        Me.lstAlbumes.MultiSelect = False
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.Size = New System.Drawing.Size(249, 335)
        Me.lstAlbumes.TabIndex = 41
        Me.lstAlbumes.UseCompatibleStateImageBehavior = False
        '
        'CB_Artist_Album
        '
        Me.CB_Artist_Album.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Artist_Album.FormattingEnabled = True
        Me.CB_Artist_Album.Location = New System.Drawing.Point(30, 279)
        Me.CB_Artist_Album.Name = "CB_Artist_Album"
        Me.CB_Artist_Album.Size = New System.Drawing.Size(185, 32)
        Me.CB_Artist_Album.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(30, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 24)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Album ID"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(30, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 24)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Album Name"
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
        Me.TB_ID_Album.Enabled = False
        Me.TB_ID_Album.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_ID_Album.Location = New System.Drawing.Point(30, 53)
        Me.TB_ID_Album.Name = "TB_ID_Album"
        Me.TB_ID_Album.Size = New System.Drawing.Size(273, 29)
        Me.TB_ID_Album.TabIndex = 32
        '
        'TB_Name_Album
        '
        Me.TB_Name_Album.Location = New System.Drawing.Point(33, 139)
        Me.TB_Name_Album.Name = "TB_Name_Album"
        Me.TB_Name_Album.Size = New System.Drawing.Size(273, 29)
        Me.TB_Name_Album.TabIndex = 31
        '
        'DTP_Year_Album
        '
        Me.DTP_Year_Album.CustomFormat = "yyyy"
        Me.DTP_Year_Album.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP_Year_Album.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Year_Album.Location = New System.Drawing.Point(30, 208)
        Me.DTP_Year_Album.Name = "DTP_Year_Album"
        Me.DTP_Year_Album.ShowUpDown = True
        Me.DTP_Year_Album.Size = New System.Drawing.Size(91, 29)
        Me.DTP_Year_Album.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(30, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 24)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Artist name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(30, 181)
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
        Me.TabArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabArtist.Location = New System.Drawing.Point(4, 34)
        Me.TabArtist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabArtist.Name = "TabArtist"
        Me.TabArtist.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabArtist.Size = New System.Drawing.Size(618, 391)
        Me.TabArtist.TabIndex = 1
        Me.TabArtist.Text = "Artist"
        Me.TabArtist.UseVisualStyleBackColor = True
        '
        'CB_Country_Artist
        '
        Me.CB_Country_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Country_Artist.FormattingEnabled = True
        Me.CB_Country_Artist.Location = New System.Drawing.Point(27, 205)
        Me.CB_Country_Artist.Name = "CB_Country_Artist"
        Me.CB_Country_Artist.Size = New System.Drawing.Size(151, 32)
        Me.CB_Country_Artist.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(27, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Country"
        '
        'lstArtist
        '
        Me.lstArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstArtist.Location = New System.Drawing.Point(339, 35)
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
        Me.Label9.Location = New System.Drawing.Point(27, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 24)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Artist Name"
        '
        'TB_Name_Artist
        '
        Me.TB_Name_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Artist.Location = New System.Drawing.Point(27, 131)
        Me.TB_Name_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Artist.Name = "TB_Name_Artist"
        Me.TB_Name_Artist.Size = New System.Drawing.Size(282, 29)
        Me.TB_Name_Artist.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(27, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Artist ID"
        '
        'TB_Id_Artist
        '
        Me.TB_Id_Artist.Enabled = False
        Me.TB_Id_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Artist.Location = New System.Drawing.Point(27, 61)
        Me.TB_Id_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Artist.Name = "TB_Id_Artist"
        Me.TB_Id_Artist.Size = New System.Drawing.Size(282, 29)
        Me.TB_Id_Artist.TabIndex = 23
        '
        'TabSong
        '
        Me.TabSong.Controls.Add(Me.Label19)
        Me.TabSong.Controls.Add(Me.Label18)
        Me.TabSong.Controls.Add(Me.Label17)
        Me.TabSong.Controls.Add(Me.TB_Order_Song)
        Me.TabSong.Controls.Add(Me.TB_Duration_Song)
        Me.TabSong.Controls.Add(Me.lstSong)
        Me.TabSong.Controls.Add(Me.CB_Album_Song)
        Me.TabSong.Controls.Add(Me.Label14)
        Me.TabSong.Controls.Add(Me.Label15)
        Me.TabSong.Controls.Add(Me.TB_Name_Song)
        Me.TabSong.Controls.Add(Me.Label16)
        Me.TabSong.Controls.Add(Me.TB_Id_Song)
        Me.TabSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabSong.Location = New System.Drawing.Point(4, 34)
        Me.TabSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSong.Name = "TabSong"
        Me.TabSong.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSong.Size = New System.Drawing.Size(618, 391)
        Me.TabSong.TabIndex = 2
        Me.TabSong.Text = "Song"
        Me.TabSong.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(26, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 24)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Order"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(26, 312)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 24)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Order"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(26, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 24)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Duration"
        '
        'TB_Order_Song
        '
        Me.TB_Order_Song.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Order_Song.Location = New System.Drawing.Point(26, 340)
        Me.TB_Order_Song.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Order_Song.Name = "TB_Order_Song"
        Me.TB_Order_Song.Size = New System.Drawing.Size(282, 27)
        Me.TB_Order_Song.TabIndex = 48
        '
        'TB_Duration_Song
        '
        Me.TB_Duration_Song.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Duration_Song.Location = New System.Drawing.Point(26, 196)
        Me.TB_Duration_Song.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Duration_Song.Name = "TB_Duration_Song"
        Me.TB_Duration_Song.Size = New System.Drawing.Size(282, 29)
        Me.TB_Duration_Song.TabIndex = 47
        '
        'lstSong
        '
        Me.lstSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstSong.Location = New System.Drawing.Point(338, 28)
        Me.lstSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSong.MultiSelect = False
        Me.lstSong.Name = "lstSong"
        Me.lstSong.Size = New System.Drawing.Size(254, 341)
        Me.lstSong.TabIndex = 46
        Me.lstSong.UseCompatibleStateImageBehavior = False
        '
        'CB_Album_Song
        '
        Me.CB_Album_Song.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Album_Song.FormattingEnabled = True
        Me.CB_Album_Song.Location = New System.Drawing.Point(26, 267)
        Me.CB_Album_Song.Name = "CB_Album_Song"
        Me.CB_Album_Song.Size = New System.Drawing.Size(151, 32)
        Me.CB_Album_Song.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(26, 241)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 24)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Album"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(26, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 24)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Song Name"
        '
        'TB_Name_Song
        '
        Me.TB_Name_Song.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Song.Location = New System.Drawing.Point(26, 128)
        Me.TB_Name_Song.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Song.Name = "TB_Name_Song"
        Me.TB_Name_Song.Size = New System.Drawing.Size(282, 29)
        Me.TB_Name_Song.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(26, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 24)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Song ID"
        '
        'TB_Id_Song
        '
        Me.TB_Id_Song.Enabled = False
        Me.TB_Id_Song.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Song.Location = New System.Drawing.Point(26, 55)
        Me.TB_Id_Song.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Song.Name = "TB_Id_Song"
        Me.TB_Id_Song.Size = New System.Drawing.Size(282, 29)
        Me.TB_Id_Song.TabIndex = 40
        '
        'TabConcert
        '
        Me.TabConcert.Controls.Add(Me.CB_Site_Concert)
        Me.TabConcert.Controls.Add(Me.Label24)
        Me.TabConcert.Controls.Add(Me.CB_Artist_Concert)
        Me.TabConcert.Controls.Add(Me.Label23)
        Me.TabConcert.Controls.Add(Me.lstConcert)
        Me.TabConcert.Controls.Add(Me.Label22)
        Me.TabConcert.Controls.Add(Me.TB_Id_Concert)
        Me.TabConcert.Controls.Add(Me.Label21)
        Me.TabConcert.Controls.Add(Me.DTP_Date_Concert)
        Me.TabConcert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabConcert.Location = New System.Drawing.Point(4, 34)
        Me.TabConcert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabConcert.Name = "TabConcert"
        Me.TabConcert.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabConcert.Size = New System.Drawing.Size(618, 391)
        Me.TabConcert.TabIndex = 3
        Me.TabConcert.Text = "Concert"
        Me.TabConcert.UseVisualStyleBackColor = True
        '
        'CB_Site_Concert
        '
        Me.CB_Site_Concert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Site_Concert.FormattingEnabled = True
        Me.CB_Site_Concert.Location = New System.Drawing.Point(40, 215)
        Me.CB_Site_Concert.Name = "CB_Site_Concert"
        Me.CB_Site_Concert.Size = New System.Drawing.Size(151, 32)
        Me.CB_Site_Concert.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(40, 189)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 24)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Site"
        '
        'CB_Artist_Concert
        '
        Me.CB_Artist_Concert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Artist_Concert.FormattingEnabled = True
        Me.CB_Artist_Concert.Location = New System.Drawing.Point(40, 137)
        Me.CB_Artist_Concert.Name = "CB_Artist_Concert"
        Me.CB_Artist_Concert.Size = New System.Drawing.Size(185, 32)
        Me.CB_Artist_Concert.TabIndex = 42
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(40, 111)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 24)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Artist name"
        '
        'lstConcert
        '
        Me.lstConcert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstConcert.Location = New System.Drawing.Point(338, 29)
        Me.lstConcert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstConcert.MultiSelect = False
        Me.lstConcert.Name = "lstConcert"
        Me.lstConcert.Size = New System.Drawing.Size(251, 325)
        Me.lstConcert.TabIndex = 23
        Me.lstConcert.UseCompatibleStateImageBehavior = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(40, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 24)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Concert ID"
        '
        'TB_Id_Concert
        '
        Me.TB_Id_Concert.Enabled = False
        Me.TB_Id_Concert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Concert.Location = New System.Drawing.Point(40, 57)
        Me.TB_Id_Concert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Concert.Name = "TB_Id_Concert"
        Me.TB_Id_Concert.Size = New System.Drawing.Size(282, 29)
        Me.TB_Id_Concert.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(40, 264)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 24)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Concert Date"
        '
        'DTP_Date_Concert
        '
        Me.DTP_Date_Concert.CustomFormat = "yyyy/MM/dd"
        Me.DTP_Date_Concert.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Date_Concert.Location = New System.Drawing.Point(40, 292)
        Me.DTP_Date_Concert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_Date_Concert.Name = "DTP_Date_Concert"
        Me.DTP_Date_Concert.Size = New System.Drawing.Size(228, 29)
        Me.DTP_Date_Concert.TabIndex = 0
        Me.DTP_Date_Concert.Value = New Date(2023, 4, 26, 0, 0, 0, 0)
        '
        'TabCountry
        '
        Me.TabCountry.Controls.Add(Me.lstContries)
        Me.TabCountry.Controls.Add(Me.Label2)
        Me.TabCountry.Controls.Add(Me.TB_Name_Country)
        Me.TabCountry.Controls.Add(Me.Label1)
        Me.TabCountry.Controls.Add(Me.TB_Id_Country)
        Me.TabCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabCountry.Location = New System.Drawing.Point(4, 34)
        Me.TabCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabCountry.Name = "TabCountry"
        Me.TabCountry.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabCountry.Size = New System.Drawing.Size(618, 391)
        Me.TabCountry.TabIndex = 4
        Me.TabCountry.Text = "Country"
        Me.TabCountry.UseVisualStyleBackColor = True
        '
        'lstContries
        '
        Me.lstContries.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.Label2.Location = New System.Drawing.Point(27, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Country Name"
        '
        'TB_Name_Country
        '
        Me.TB_Name_Country.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Country.Location = New System.Drawing.Point(27, 129)
        Me.TB_Name_Country.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Country.Name = "TB_Name_Country"
        Me.TB_Name_Country.Size = New System.Drawing.Size(282, 29)
        Me.TB_Name_Country.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Country ID"
        '
        'TB_Id_Country
        '
        Me.TB_Id_Country.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Country.Location = New System.Drawing.Point(27, 61)
        Me.TB_Id_Country.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Country.Name = "TB_Id_Country"
        Me.TB_Id_Country.Size = New System.Drawing.Size(282, 29)
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
        Me.TabSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabSite.Location = New System.Drawing.Point(4, 34)
        Me.TabSite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSite.Name = "TabSite"
        Me.TabSite.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabSite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabSite.Size = New System.Drawing.Size(618, 391)
        Me.TabSite.TabIndex = 5
        Me.TabSite.Text = "Site"
        Me.TabSite.UseVisualStyleBackColor = True
        '
        'CB_Country_Site
        '
        Me.CB_Country_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Country_Site.FormattingEnabled = True
        Me.CB_Country_Site.Location = New System.Drawing.Point(32, 275)
        Me.CB_Country_Site.Name = "CB_Country_Site"
        Me.CB_Country_Site.Size = New System.Drawing.Size(151, 32)
        Me.CB_Country_Site.TabIndex = 37
        '
        'CB_Type_Site
        '
        Me.CB_Type_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Type_Site.FormattingEnabled = True
        Me.CB_Type_Site.Location = New System.Drawing.Point(32, 201)
        Me.CB_Type_Site.Name = "CB_Type_Site"
        Me.CB_Type_Site.Size = New System.Drawing.Size(151, 32)
        Me.CB_Type_Site.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(32, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(32, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Type"
        '
        'lstSites
        '
        Me.lstSites.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstSites.Location = New System.Drawing.Point(339, 27)
        Me.lstSites.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSites.MultiSelect = False
        Me.lstSites.Name = "lstSites"
        Me.lstSites.Size = New System.Drawing.Size(265, 339)
        Me.lstSites.TabIndex = 31
        Me.lstSites.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Site Name"
        '
        'TB_Name_Site
        '
        Me.TB_Name_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Name_Site.Location = New System.Drawing.Point(32, 127)
        Me.TB_Name_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Name_Site.Name = "TB_Name_Site"
        Me.TB_Name_Site.Size = New System.Drawing.Size(282, 29)
        Me.TB_Name_Site.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(32, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Site ID"
        '
        'TB_Id_Site
        '
        Me.TB_Id_Site.Enabled = False
        Me.TB_Id_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Id_Site.Location = New System.Drawing.Point(32, 53)
        Me.TB_Id_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_Id_Site.Name = "TB_Id_Site"
        Me.TB_Id_Site.Size = New System.Drawing.Size(282, 29)
        Me.TB_Id_Site.TabIndex = 23
        '
        'TabNavegation
        '
        Me.TabNavegation.Controls.Add(Me.Label29)
        Me.TabNavegation.Controls.Add(Me.CB_Site_Navegation)
        Me.TabNavegation.Controls.Add(Me.lstSetlist_Site)
        Me.TabNavegation.Controls.Add(Me.lstConcert_Site)
        Me.TabNavegation.Controls.Add(Me.Label28)
        Me.TabNavegation.Controls.Add(Me.Label27)
        Me.TabNavegation.Controls.Add(Me.CB_Country_Navegation)
        Me.TabNavegation.Controls.Add(Me.CB_Artist_Navegation)
        Me.TabNavegation.Controls.Add(Me.lstSetlist_Artist)
        Me.TabNavegation.Controls.Add(Me.lstConcert_Artist)
        Me.TabNavegation.Location = New System.Drawing.Point(4, 34)
        Me.TabNavegation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabNavegation.Name = "TabNavegation"
        Me.TabNavegation.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabNavegation.Size = New System.Drawing.Size(618, 391)
        Me.TabNavegation.TabIndex = 6
        Me.TabNavegation.Text = "Navegation"
        Me.TabNavegation.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label29.Location = New System.Drawing.Point(327, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(141, 24)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Site Navegation"
        '
        'CB_Site_Navegation
        '
        Me.CB_Site_Navegation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Site_Navegation.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CB_Site_Navegation.FormattingEnabled = True
        Me.CB_Site_Navegation.Location = New System.Drawing.Point(327, 61)
        Me.CB_Site_Navegation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Site_Navegation.Name = "CB_Site_Navegation"
        Me.CB_Site_Navegation.Size = New System.Drawing.Size(165, 32)
        Me.CB_Site_Navegation.TabIndex = 8
        Me.CB_Site_Navegation.Text = "Site"
        '
        'lstSetlist_Site
        '
        Me.lstSetlist_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstSetlist_Site.Location = New System.Drawing.Point(327, 247)
        Me.lstSetlist_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSetlist_Site.Name = "lstSetlist_Site"
        Me.lstSetlist_Site.Size = New System.Drawing.Size(267, 120)
        Me.lstSetlist_Site.TabIndex = 7
        Me.lstSetlist_Site.UseCompatibleStateImageBehavior = False
        '
        'lstConcert_Site
        '
        Me.lstConcert_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstConcert_Site.Location = New System.Drawing.Point(327, 111)
        Me.lstConcert_Site.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstConcert_Site.Name = "lstConcert_Site"
        Me.lstConcert_Site.Size = New System.Drawing.Size(267, 120)
        Me.lstConcert_Site.TabIndex = 6
        Me.lstConcert_Site.UseCompatibleStateImageBehavior = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label28.Location = New System.Drawing.Point(110, 39)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(0, 24)
        Me.Label28.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label27.Location = New System.Drawing.Point(22, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(150, 24)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Artist Navegation"
        '
        'CB_Country_Navegation
        '
        Me.CB_Country_Navegation.Enabled = False
        Me.CB_Country_Navegation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Country_Navegation.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CB_Country_Navegation.FormattingEnabled = True
        Me.CB_Country_Navegation.Location = New System.Drawing.Point(178, 61)
        Me.CB_Country_Navegation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Country_Navegation.Name = "CB_Country_Navegation"
        Me.CB_Country_Navegation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CB_Country_Navegation.Size = New System.Drawing.Size(110, 32)
        Me.CB_Country_Navegation.TabIndex = 3
        Me.CB_Country_Navegation.Text = "Country"
        '
        'CB_Artist_Navegation
        '
        Me.CB_Artist_Navegation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CB_Artist_Navegation.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CB_Artist_Navegation.FormattingEnabled = True
        Me.CB_Artist_Navegation.Location = New System.Drawing.Point(22, 61)
        Me.CB_Artist_Navegation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Artist_Navegation.Name = "CB_Artist_Navegation"
        Me.CB_Artist_Navegation.Size = New System.Drawing.Size(149, 32)
        Me.CB_Artist_Navegation.TabIndex = 2
        Me.CB_Artist_Navegation.Text = "Artist"
        '
        'lstSetlist_Artist
        '
        Me.lstSetlist_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstSetlist_Artist.Location = New System.Drawing.Point(22, 247)
        Me.lstSetlist_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSetlist_Artist.Name = "lstSetlist_Artist"
        Me.lstSetlist_Artist.Size = New System.Drawing.Size(267, 120)
        Me.lstSetlist_Artist.TabIndex = 1
        Me.lstSetlist_Artist.UseCompatibleStateImageBehavior = False
        '
        'lstConcert_Artist
        '
        Me.lstConcert_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstConcert_Artist.Location = New System.Drawing.Point(22, 111)
        Me.lstConcert_Artist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstConcert_Artist.Name = "lstConcert_Artist"
        Me.lstConcert_Artist.Size = New System.Drawing.Size(267, 120)
        Me.lstConcert_Artist.TabIndex = 0
        Me.lstConcert_Artist.UseCompatibleStateImageBehavior = False
        '
        'TabReport
        '
        Me.TabReport.Controls.Add(Me.TabReports)
        Me.TabReport.Location = New System.Drawing.Point(4, 34)
        Me.TabReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport.Size = New System.Drawing.Size(618, 391)
        Me.TabReport.TabIndex = 7
        Me.TabReport.Text = "Reports"
        Me.TabReport.UseVisualStyleBackColor = True
        '
        'TabReports
        '
        Me.TabReports.Controls.Add(Me.TabReport1)
        Me.TabReports.Controls.Add(Me.TabReport2)
        Me.TabReports.Controls.Add(Me.TabReport3)
        Me.TabReports.Controls.Add(Me.TabReport4)
        Me.TabReports.Controls.Add(Me.TabReport5)
        Me.TabReports.Controls.Add(Me.TabReport6)
        Me.TabReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabReports.Location = New System.Drawing.Point(14, 16)
        Me.TabReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReports.Name = "TabReports"
        Me.TabReports.Padding = New System.Drawing.Point(18, 3)
        Me.TabReports.SelectedIndex = 0
        Me.TabReports.Size = New System.Drawing.Size(597, 363)
        Me.TabReports.TabIndex = 0
        '
        'TabReport1
        '
        Me.TabReport1.Controls.Add(Me.lstReport1)
        Me.TabReport1.Controls.Add(Me.Label30)
        Me.TabReport1.Controls.Add(Me.Label31)
        Me.TabReport1.Controls.Add(Me.CB_Artist_Report1)
        Me.TabReport1.Location = New System.Drawing.Point(4, 29)
        Me.TabReport1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport1.Name = "TabReport1"
        Me.TabReport1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport1.Size = New System.Drawing.Size(589, 330)
        Me.TabReport1.TabIndex = 0
        Me.TabReport1.Text = "Report 1"
        Me.TabReport1.UseVisualStyleBackColor = True
        '
        'lstReport1
        '
        Me.lstReport1.Location = New System.Drawing.Point(274, 16)
        Me.lstReport1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport1.Name = "lstReport1"
        Me.lstReport1.Size = New System.Drawing.Size(298, 299)
        Me.lstReport1.TabIndex = 5
        Me.lstReport1.UseCompatibleStateImageBehavior = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label30.Location = New System.Drawing.Point(17, 100)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 20)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Artista"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(17, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(251, 84)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Ordered list of the most performed live songs by an artist throughout all his con" &
    "certs."
        '
        'CB_Artist_Report1
        '
        Me.CB_Artist_Report1.FormattingEnabled = True
        Me.CB_Artist_Report1.Location = New System.Drawing.Point(17, 125)
        Me.CB_Artist_Report1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Artist_Report1.Name = "CB_Artist_Report1"
        Me.CB_Artist_Report1.Size = New System.Drawing.Size(138, 28)
        Me.CB_Artist_Report1.TabIndex = 1
        '
        'TabReport2
        '
        Me.TabReport2.Controls.Add(Me.Label32)
        Me.TabReport2.Controls.Add(Me.Label33)
        Me.TabReport2.Controls.Add(Me.CB_Artist_Report2)
        Me.TabReport2.Controls.Add(Me.lstReport2)
        Me.TabReport2.Location = New System.Drawing.Point(4, 29)
        Me.TabReport2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport2.Name = "TabReport2"
        Me.TabReport2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport2.Size = New System.Drawing.Size(589, 330)
        Me.TabReport2.TabIndex = 1
        Me.TabReport2.Text = "Report 2"
        Me.TabReport2.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label32.Location = New System.Drawing.Point(16, 77)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(58, 20)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Artista"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(16, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(251, 84)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Ordered list of the most performed live albums by an artist."
        '
        'CB_Artist_Report2
        '
        Me.CB_Artist_Report2.FormattingEnabled = True
        Me.CB_Artist_Report2.Location = New System.Drawing.Point(16, 103)
        Me.CB_Artist_Report2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Artist_Report2.Name = "CB_Artist_Report2"
        Me.CB_Artist_Report2.Size = New System.Drawing.Size(138, 28)
        Me.CB_Artist_Report2.TabIndex = 6
        '
        'lstReport2
        '
        Me.lstReport2.Location = New System.Drawing.Point(296, 15)
        Me.lstReport2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport2.Name = "lstReport2"
        Me.lstReport2.Size = New System.Drawing.Size(275, 292)
        Me.lstReport2.TabIndex = 5
        Me.lstReport2.UseCompatibleStateImageBehavior = False
        '
        'TabReport3
        '
        Me.TabReport3.Controls.Add(Me.ButtonFind_Report3)
        Me.TabReport3.Controls.Add(Me.Label35)
        Me.TabReport3.Controls.Add(Me.lstReport3)
        Me.TabReport3.Location = New System.Drawing.Point(4, 29)
        Me.TabReport3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport3.Name = "TabReport3"
        Me.TabReport3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport3.Size = New System.Drawing.Size(589, 330)
        Me.TabReport3.TabIndex = 2
        Me.TabReport3.Text = "Report 3"
        Me.TabReport3.UseVisualStyleBackColor = True
        '
        'ButtonFind_Report3
        '
        Me.ButtonFind_Report3.Location = New System.Drawing.Point(16, 77)
        Me.ButtonFind_Report3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonFind_Report3.Name = "ButtonFind_Report3"
        Me.ButtonFind_Report3.Size = New System.Drawing.Size(86, 31)
        Me.ButtonFind_Report3.TabIndex = 12
        Me.ButtonFind_Report3.Text = "Find"
        Me.ButtonFind_Report3.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(16, 15)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(251, 84)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "List of artists who have performed a complete album live."
        '
        'lstReport3
        '
        Me.lstReport3.Location = New System.Drawing.Point(296, 15)
        Me.lstReport3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport3.Name = "lstReport3"
        Me.lstReport3.Size = New System.Drawing.Size(275, 292)
        Me.lstReport3.TabIndex = 9
        Me.lstReport3.UseCompatibleStateImageBehavior = False
        '
        'TabReport4
        '
        Me.TabReport4.Controls.Add(Me.ButtonFind_Report4)
        Me.TabReport4.Controls.Add(Me.Label34)
        Me.TabReport4.Controls.Add(Me.lstReport4)
        Me.TabReport4.Location = New System.Drawing.Point(4, 29)
        Me.TabReport4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport4.Name = "TabReport4"
        Me.TabReport4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport4.Size = New System.Drawing.Size(589, 330)
        Me.TabReport4.TabIndex = 3
        Me.TabReport4.Text = "Report 4"
        Me.TabReport4.UseVisualStyleBackColor = True
        '
        'ButtonFind_Report4
        '
        Me.ButtonFind_Report4.Location = New System.Drawing.Point(16, 103)
        Me.ButtonFind_Report4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonFind_Report4.Name = "ButtonFind_Report4"
        Me.ButtonFind_Report4.Size = New System.Drawing.Size(86, 31)
        Me.ButtonFind_Report4.TabIndex = 15
        Me.ButtonFind_Report4.Text = "Find"
        Me.ButtonFind_Report4.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(16, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(251, 84)
        Me.Label34.TabIndex = 14
        Me.Label34.Text = "List with complete information on songs that have been performed live the most ti" &
    "mes."
        '
        'lstReport4
        '
        Me.lstReport4.Location = New System.Drawing.Point(294, 15)
        Me.lstReport4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport4.Name = "lstReport4"
        Me.lstReport4.Size = New System.Drawing.Size(275, 292)
        Me.lstReport4.TabIndex = 13
        Me.lstReport4.UseCompatibleStateImageBehavior = False
        '
        'TabReport5
        '
        Me.TabReport5.Controls.Add(Me.Label38)
        Me.TabReport5.Controls.Add(Me.Label37)
        Me.TabReport5.Controls.Add(Me.DTP_Start_R5)
        Me.TabReport5.Controls.Add(Me.DTP_End_R5)
        Me.TabReport5.Controls.Add(Me.ButtonFind_Report5)
        Me.TabReport5.Controls.Add(Me.Label36)
        Me.TabReport5.Controls.Add(Me.lstReport5)
        Me.TabReport5.Location = New System.Drawing.Point(4, 29)
        Me.TabReport5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport5.Name = "TabReport5"
        Me.TabReport5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport5.Size = New System.Drawing.Size(589, 330)
        Me.TabReport5.TabIndex = 4
        Me.TabReport5.Text = "Report 5"
        Me.TabReport5.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label38.Location = New System.Drawing.Point(16, 169)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 20)
        Me.Label38.TabIndex = 22
        Me.Label38.Text = "End Date"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label37.Location = New System.Drawing.Point(16, 97)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(86, 20)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "Start Date"
        '
        'DTP_Start_R5
        '
        Me.DTP_Start_R5.CustomFormat = "yyyy/MM/dd"
        Me.DTP_Start_R5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP_Start_R5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Start_R5.Location = New System.Drawing.Point(16, 123)
        Me.DTP_Start_R5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_Start_R5.Name = "DTP_Start_R5"
        Me.DTP_Start_R5.Size = New System.Drawing.Size(228, 26)
        Me.DTP_Start_R5.TabIndex = 20
        Me.DTP_Start_R5.Value = New Date(2023, 4, 26, 0, 0, 0, 0)
        '
        'DTP_End_R5
        '
        Me.DTP_End_R5.CustomFormat = "yyyy/MM/dd"
        Me.DTP_End_R5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP_End_R5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_End_R5.Location = New System.Drawing.Point(16, 195)
        Me.DTP_End_R5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_End_R5.Name = "DTP_End_R5"
        Me.DTP_End_R5.Size = New System.Drawing.Size(228, 26)
        Me.DTP_End_R5.TabIndex = 19
        Me.DTP_End_R5.Value = New Date(2023, 4, 26, 0, 0, 0, 0)
        '
        'ButtonFind_Report5
        '
        Me.ButtonFind_Report5.Location = New System.Drawing.Point(16, 252)
        Me.ButtonFind_Report5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonFind_Report5.Name = "ButtonFind_Report5"
        Me.ButtonFind_Report5.Size = New System.Drawing.Size(86, 31)
        Me.ButtonFind_Report5.TabIndex = 18
        Me.ButtonFind_Report5.Text = "Find"
        Me.ButtonFind_Report5.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(16, 15)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(251, 84)
        Me.Label36.TabIndex = 17
        Me.Label36.Text = "Ordered list of artists who have given the most concerts between 2 specific dates" &
    "."
        '
        'lstReport5
        '
        Me.lstReport5.Location = New System.Drawing.Point(296, 15)
        Me.lstReport5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport5.Name = "lstReport5"
        Me.lstReport5.Size = New System.Drawing.Size(275, 292)
        Me.lstReport5.TabIndex = 16
        Me.lstReport5.UseCompatibleStateImageBehavior = False
        '
        'TabReport6
        '
        Me.TabReport6.Controls.Add(Me.Label39)
        Me.TabReport6.Controls.Add(Me.Label40)
        Me.TabReport6.Controls.Add(Me.DTP_Start_R6)
        Me.TabReport6.Controls.Add(Me.DTP_End_R6)
        Me.TabReport6.Controls.Add(Me.ButtonFind_Report6)
        Me.TabReport6.Controls.Add(Me.Label41)
        Me.TabReport6.Controls.Add(Me.lstReport6)
        Me.TabReport6.Location = New System.Drawing.Point(4, 29)
        Me.TabReport6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport6.Name = "TabReport6"
        Me.TabReport6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabReport6.Size = New System.Drawing.Size(589, 330)
        Me.TabReport6.TabIndex = 5
        Me.TabReport6.Text = "Report 6"
        Me.TabReport6.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label39.Location = New System.Drawing.Point(16, 169)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(79, 20)
        Me.Label39.TabIndex = 29
        Me.Label39.Text = "End Date"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label40.Location = New System.Drawing.Point(16, 97)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(86, 20)
        Me.Label40.TabIndex = 28
        Me.Label40.Text = "Start Date"
        '
        'DTP_Start_R6
        '
        Me.DTP_Start_R6.CustomFormat = "yyyy/MM/dd"
        Me.DTP_Start_R6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP_Start_R6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Start_R6.Location = New System.Drawing.Point(16, 123)
        Me.DTP_Start_R6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_Start_R6.Name = "DTP_Start_R6"
        Me.DTP_Start_R6.Size = New System.Drawing.Size(228, 26)
        Me.DTP_Start_R6.TabIndex = 27
        Me.DTP_Start_R6.Value = New Date(2023, 4, 26, 0, 0, 0, 0)
        '
        'DTP_End_R6
        '
        Me.DTP_End_R6.CustomFormat = "yyyy/MM/dd"
        Me.DTP_End_R6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP_End_R6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_End_R6.Location = New System.Drawing.Point(16, 195)
        Me.DTP_End_R6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_End_R6.Name = "DTP_End_R6"
        Me.DTP_End_R6.Size = New System.Drawing.Size(228, 26)
        Me.DTP_End_R6.TabIndex = 26
        Me.DTP_End_R6.Value = New Date(2023, 4, 26, 0, 0, 0, 0)
        '
        'ButtonFind_Report6
        '
        Me.ButtonFind_Report6.Location = New System.Drawing.Point(16, 252)
        Me.ButtonFind_Report6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonFind_Report6.Name = "ButtonFind_Report6"
        Me.ButtonFind_Report6.Size = New System.Drawing.Size(86, 31)
        Me.ButtonFind_Report6.TabIndex = 25
        Me.ButtonFind_Report6.Text = "Find"
        Me.ButtonFind_Report6.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(16, 15)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(251, 84)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Ordered list of countries in which there have been more concerts between 2 specif" &
    "ic dates."
        '
        'lstReport6
        '
        Me.lstReport6.Location = New System.Drawing.Point(296, 15)
        Me.lstReport6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReport6.Name = "lstReport6"
        Me.lstReport6.Size = New System.Drawing.Size(275, 292)
        Me.lstReport6.TabIndex = 23
        Me.lstReport6.UseCompatibleStateImageBehavior = False
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
        Me.ButtonClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonClearAll.Location = New System.Drawing.Point(41, 541)
        Me.ButtonClearAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(107, 47)
        Me.ButtonClearAll.TabIndex = 25
        Me.ButtonClearAll.Text = "Clear all"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonDelete.Location = New System.Drawing.Point(155, 541)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(107, 47)
        Me.ButtonDelete.TabIndex = 24
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAdd.Location = New System.Drawing.Point(384, 541)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(283, 47)
        Me.ButtonAdd.TabIndex = 22
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonModify.Location = New System.Drawing.Point(270, 541)
        Me.ButtonModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(107, 47)
        Me.ButtonModify.TabIndex = 23
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'lstConcertSongs
        '
        Me.lstConcertSongs.Enabled = False
        Me.lstConcertSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstConcertSongs.Location = New System.Drawing.Point(86, 644)
        Me.lstConcertSongs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstConcertSongs.Name = "lstConcertSongs"
        Me.lstConcertSongs.Size = New System.Drawing.Size(212, 267)
        Me.lstConcertSongs.TabIndex = 26
        Me.lstConcertSongs.UseCompatibleStateImageBehavior = False
        '
        'lstAllSongs
        '
        Me.lstAllSongs.Enabled = False
        Me.lstAllSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstAllSongs.Location = New System.Drawing.Point(432, 644)
        Me.lstAllSongs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstAllSongs.Name = "lstAllSongs"
        Me.lstAllSongs.Size = New System.Drawing.Size(230, 267)
        Me.lstAllSongs.TabIndex = 27
        Me.lstAllSongs.UseCompatibleStateImageBehavior = False
        '
        'AddSong
        '
        Me.AddSong.Enabled = False
        Me.AddSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddSong.Location = New System.Drawing.Point(321, 715)
        Me.AddSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddSong.Name = "AddSong"
        Me.AddSong.Size = New System.Drawing.Size(86, 31)
        Me.AddSong.TabIndex = 28
        Me.AddSong.Text = "Add"
        Me.AddSong.UseVisualStyleBackColor = True
        '
        'RemoveSong
        '
        Me.RemoveSong.Enabled = False
        Me.RemoveSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoveSong.Location = New System.Drawing.Point(321, 813)
        Me.RemoveSong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RemoveSong.Name = "RemoveSong"
        Me.RemoveSong.Size = New System.Drawing.Size(86, 31)
        Me.RemoveSong.TabIndex = 29
        Me.RemoveSong.Text = "Remove"
        Me.RemoveSong.UseVisualStyleBackColor = True
        '
        'OrderUp
        '
        Me.OrderUp.Enabled = False
        Me.OrderUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderUp.Location = New System.Drawing.Point(46, 644)
        Me.OrderUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderUp.Name = "OrderUp"
        Me.OrderUp.Size = New System.Drawing.Size(33, 56)
        Me.OrderUp.TabIndex = 30
        Me.OrderUp.Text = "↑"
        Me.OrderUp.UseVisualStyleBackColor = True
        '
        'OrderDown
        '
        Me.OrderDown.Enabled = False
        Me.OrderDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderDown.Location = New System.Drawing.Point(46, 705)
        Me.OrderDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderDown.Name = "OrderDown"
        Me.OrderDown.Size = New System.Drawing.Size(33, 56)
        Me.OrderDown.TabIndex = 31
        Me.OrderDown.Text = "↓"
        Me.OrderDown.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label25.Location = New System.Drawing.Point(86, 620)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 20)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Concert Songs"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label26.Location = New System.Drawing.Point(432, 620)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 20)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "All Songs"
        '
        'ModifySong
        '
        Me.ModifySong.Enabled = False
        Me.ModifySong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ModifySong.Location = New System.Drawing.Point(321, 765)
        Me.ModifySong.Name = "ModifySong"
        Me.ModifySong.Size = New System.Drawing.Size(86, 29)
        Me.ModifySong.TabIndex = 34
        Me.ModifySong.Text = "Modify Setlist"
        Me.ModifySong.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 947)
        Me.Controls.Add(Me.ModifySong)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.OrderDown)
        Me.Controls.Add(Me.OrderUp)
        Me.Controls.Add(Me.RemoveSong)
        Me.Controls.Add(Me.AddSong)
        Me.Controls.Add(Me.lstAllSongs)
        Me.Controls.Add(Me.lstConcertSongs)
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
        Me.TabSong.ResumeLayout(False)
        Me.TabSong.PerformLayout()
        Me.TabConcert.ResumeLayout(False)
        Me.TabConcert.PerformLayout()
        Me.TabCountry.ResumeLayout(False)
        Me.TabCountry.PerformLayout()
        Me.TabSite.ResumeLayout(False)
        Me.TabSite.PerformLayout()
        Me.TabNavegation.ResumeLayout(False)
        Me.TabNavegation.PerformLayout()
        Me.TabReport.ResumeLayout(False)
        Me.TabReports.ResumeLayout(False)
        Me.TabReport1.ResumeLayout(False)
        Me.TabReport1.PerformLayout()
        Me.TabReport2.ResumeLayout(False)
        Me.TabReport2.PerformLayout()
        Me.TabReport3.ResumeLayout(False)
        Me.TabReport4.ResumeLayout(False)
        Me.TabReport5.ResumeLayout(False)
        Me.TabReport5.PerformLayout()
        Me.TabReport6.ResumeLayout(False)
        Me.TabReport6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabAlbum As TabPage
    Friend WithEvents TabArtist As TabPage
    Friend WithEvents TabSong As TabPage
    Friend WithEvents TabConcert As TabPage
    Friend WithEvents TabCountry As TabPage
    Friend WithEvents TabSite As TabPage
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
    Friend WithEvents AddSong As Button
    Friend WithEvents RemoveSong As Button
    Friend WithEvents OrderUp As Button
    Friend WithEvents OrderDown As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ModifySong As Button
    Friend WithEvents TabNavegation As TabPage
    Friend WithEvents TabReport As TabPage
    Friend WithEvents Label29 As Label
    Friend WithEvents CB_Site_Navegation As ComboBox
    Friend WithEvents lstSetlist_Site As ListView
    Friend WithEvents lstConcert_Site As ListView
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CB_Country_Navegation As ComboBox
    Friend WithEvents CB_Artist_Navegation As ComboBox
    Friend WithEvents lstSetlist_Artist As ListView
    Friend WithEvents lstConcert_Artist As ListView
    Friend WithEvents TabReports As TabControl
    Friend WithEvents TabReport1 As TabPage
    Friend WithEvents TabReport2 As TabPage
    Friend WithEvents TabReport3 As TabPage
    Friend WithEvents TabReport4 As TabPage
    Friend WithEvents TabReport5 As TabPage
    Friend WithEvents TabReport6 As TabPage
    Friend WithEvents lstReport3 As ListView
    Friend WithEvents Label31 As Label
    Friend WithEvents CB_Artist_Report1 As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents CB_Artist_Report2 As ComboBox
    Friend WithEvents lstReport2 As ListView
    Friend WithEvents ButtonFind_Report3 As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents ButtonFind_Report4 As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents lstReport4 As ListView
    Friend WithEvents ButtonFind_Report5 As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents lstReport5 As ListView
    Friend WithEvents lstReport1 As ListView
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents DTP_Start_R5 As DateTimePicker
    Friend WithEvents DTP_End_R5 As DateTimePicker
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents DTP_Start_R6 As DateTimePicker
    Friend WithEvents DTP_End_R6 As DateTimePicker
    Friend WithEvents ButtonFind_Report6 As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents lstReport6 As ListView
End Class
