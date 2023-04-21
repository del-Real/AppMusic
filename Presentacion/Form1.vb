Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AppMusic.Sitio
Imports Mysqlx.Crud

Public Class Form1
    Private lstArtists As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
        Dim pai As Pais = New Pais
        Dim sit As Sitio = New Sitio
        Dim art As Artista = New Artista
        Dim alb As Album = New Album
        Dim can As Cancion = New Cancion
        'Dim con As Concierto = New Concierto

        Try
            pai.LeerTodosPaises(ofdRuta.FileName)
            sit.LeerTodosSitios(ofdRuta.FileName)
            art.LeerTodosArtistas(ofdRuta.FileName)
            alb.LeerTodosAlbums(ofdRuta.FileName)
            can.LeerTodasCanciones(ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ' ------
        ' PAISES
        ' ------

        For Each p As Pais In pai.PaiDAO.Paises
            Dim item As New ListViewItem
            item.Text = p.IDPais
            item.SubItems.Add(p.NomPais)
            lstContries.Items.Add(item)
        Next
        ' Añade columnas al listView de Países
        lstContries.View = View.Details
        lstContries.Columns.Add("ID", 40)
        lstContries.Columns.Add("Name", 60)

        ' ------
        ' SITIOS
        ' ------

        For Each s As Sitio In sit.SitDAO.Sitios
            Dim item As New ListViewItem
            item.Text = s.IDSitio
            item.SubItems.Add(s.NomSitio)
            s.Pais.LeerPais()
            item.SubItems.Add(s.Pais.NomPais)
            item.SubItems.Add(s.tipo)
            lstSites.Items.Add(item)
        Next
        ' Añade columnas al listView de Sitios
        lstSites.View = View.Details
        lstSites.Columns.Add("ID", 40)
        lstSites.Columns.Add("Name", 80)
        lstSites.Columns.Add("Country", 90)
        lstSites.Columns.Add("Type", 80)

        ' Añade valores del enum al comboBox
        CB_Type_Site.Items.Add(TipoSitio.sala)
        CB_Type_Site.Items.Add(TipoSitio.pabellón)
        CB_Type_Site.Items.Add(TipoSitio.estadio)
        CB_Type_Site.Items.Add(TipoSitio.festival)
        CB_Type_Site.SelectedIndex = -1


        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Site.Items.Add(p)
        Next
        CB_Country_Site.SelectedIndex = -1

        ' --------
        ' ARTISTAS
        ' --------

        For Each a As Artista In art.ArtDAO.Artistas
            Dim item As New ListViewItem
            item.Text = a.IDArtista
            item.SubItems.Add(a.NomArtista)
            a.Pais.LeerPais()
            item.SubItems.Add(a.Pais.NomPais)
            lstArtist.Items.Add(item)
        Next
        ' Añade columnas al listView de Artistas
        lstArtist.View = View.Details
        lstArtist.Columns.Add("ID", 40)
        lstArtist.Columns.Add("Name", 80)
        lstArtist.Columns.Add("Country", 90)

        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Artist.Items.Add(p)
        Next
        CB_Country_Artist.SelectedIndex = -1

        ' --------
        ' ALBUMES
        ' --------

        For Each a As Album In alb.AlbDAO.Albumes
            Dim item As New ListViewItem
            item.Text = a.IDAlbum
            item.SubItems.Add(a.NomAlbum)
            item.SubItems.Add(a.AnoAlbum)
            a.Artista.LeerArtista()
            item.SubItems.Add(a.Artista.NomArtista)
            lstAlbumes.Items.Add(item)
        Next
        ' Añade columnas al listView de Albumes
        lstAlbumes.View = View.Details
        lstAlbumes.Columns.Add("ID", 40)
        lstAlbumes.Columns.Add("Name", 80)
        lstAlbumes.Columns.Add("Year", 60)
        lstAlbumes.Columns.Add("Artist", 80)

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Album.Items.Add(a)
        Next
        CB_Artist_Album.SelectedIndex = -1

        ' ---------
        ' CANCIONES
        ' ---------

        For Each c As Cancion In can.CanDAO.Canciones
            Dim item As New ListViewItem
            item.Text = c.IDCancion
            item.SubItems.Add(c.NomCancion)
            item.SubItems.Add(c.Duracion)
            c.Album.LeerAlbum()
            item.SubItems.Add(c.Album.NomAlbum)
            item.SubItems.Add(c.OrdenCancion)
            lstSong.Items.Add(item)
        Next
        ' Añade columnas al listView de Canciones
        lstSong.View = View.Details
        lstSong.Columns.Add("ID", 40)
        lstSong.Columns.Add("Name", 80)
        lstSong.Columns.Add("Duration", 60)
        lstSong.Columns.Add("Album", 90)
        lstSong.Columns.Add("Orden", 60)

        For Each item As ListViewItem In lstAlbumes.Items
            Dim a As Album = New Album(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Album_Song.Items.Add(a)
        Next
        CB_Album_Song.SelectedIndex = -1


    End Sub

    ' =========================================================================================
    ' PESTAÑAS
    ' =========================================================================================

    ' ===============
    ' PESTAÑA ARTISTA
    ' ===============

    Private Sub lstArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtist.SelectedIndexChanged
        Dim art As Artista
        If Not Me.lstArtist.SelectedItems Is Nothing Then
            Try
                art = New Artista(lstArtist.SelectedItems.ToString)
                art.LeerArtista()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Artist.Text = art.IDArtista
            Me.TB_Name_Artist.Text = art.NomArtista
            Me.CB_Country_Artist.Text = art.Pais.NomPais
        End If
    End Sub

    ' ==============
    ' PESTAÑA PAÍSES
    ' ==============

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContries.SelectedIndexChanged
        Dim pai As Pais
        If Not Me.lstContries.SelectedItems Is Nothing Then
            Try
                pai = New Pais(lstContries.SelectedItems.ToString)
                pai.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Country.Text = pai.IDPais
            Me.TB_Name_Country.Text = pai.NomPais
        End If
    End Sub

    ' ==============
    ' PESTAÑA SITIOS
    ' ==============

    Private Sub lstSites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSites.SelectedIndexChanged
        Dim sit As Sitio
        If Not Me.lstSites.SelectedItems Is Nothing Then
            Try
                sit = New Sitio(lstSites.SelectedItems.ToString)
                sit.LeerSitio()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Country.Text = sit.IDSitio
            Me.TB_Name_Country.Text = sit.NomSitio
            Me.CB_Type_Site.Text = sit.tipo
            Me.CB_Country_Site.Text = sit.Pais.NomPais
        End If
    End Sub

    ' ===============
    ' PESTAÑA ALBUMES
    ' ===============

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Dim alb As Album
        If Not Me.lstAlbumes.SelectedItems Is Nothing Then
            Try
                alb = New Album(lstAlbumes.SelectedItems.ToString)
                alb.LeerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_ID_Album.Text = alb.IDAlbum
            Me.TB_Name_Album.Text = alb.NomAlbum
            Me.CB_Artist_Album.Text = alb.Artista.NomArtista
            Me.DTP_Year_Album.Text = alb.AnoAlbum
        End If
    End Sub

    ' =================
    ' PESTAÑA CANCIONES
    ' =================

    Private Sub lstSong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSong.SelectedIndexChanged
        Dim can As Cancion
        If Not Me.lstSong.SelectedItems Is Nothing Then
            Try
                can = New Cancion(lstSong.SelectedItems.ToString)
                can.LeerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Song.Text = can.IDCancion
            Me.TB_Name_Song.Text = can.NomCancion
            Me.TB_Duration_Song.Text = can.Duracion
            Me.CB_Album_Song.Text = can.Album.NomAlbum
            Me.TB_Order_Song.Text = can.OrdenCancion
        End If
    End Sub

    ' =========================================================================================
    ' BOTONES FUNCIONES
    ' =========================================================================================

    ' ============
    ' BOTÓN AÑADIR
    ' ============

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Switch-case para comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
                AlbumAdd()
            Case "TabArtist"
                ArtistAdd()
            Case "TabSong"
                SongAdd()
            Case "TabConcert"
            'Aquí va el código para añadir una nueva canción
            Case "TabCountry"
                CountryAdd()
            Case "TabSite"
                SiteAdd()
        End Select

    End Sub

    ' ==============
    ' BOTÓN ELIMINAR
    ' ==============

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Switch-case para comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
                AlbumDelete()
            Case "TabArtist"
                ArtistDelete()
            Case "TabSong"
                SongDelete()
            Case "TabConcert"
            'Aquí va el código para añadir una nueva canción
            Case "TabCountry"
                CountryDelete()
            Case "TabSite"
                SiteDelete()
        End Select

    End Sub

    ' ===============
    ' BOTÓN MODIFICAR
    ' ===============

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Switch-case para comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
                AlbumModify()
            Case "TabArtist"
                ArtistModify()
            Case "TabSong"
            'Aquí va el código para añadir un nuevo artista
            Case "TabConcert"
            'Aquí va el código para añadir una nueva canción
            Case "TabCountry"
                CountryModify()
            Case "TabSite"
                SiteModify()
        End Select

    End Sub

    ' =============
    ' BOTÓN LIMPIAR
    ' =============

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearAll.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Switch-case para comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
                AlbumClearAll()
            Case "TabArtist"
                ArtistClearAll()
            Case "TabSong"
                SongClearAll()
            Case "TabConcert"
            'Aquí va el código para añadir una nueva canción
            Case "TabCountry"
                CountryClearAll()
            Case "TabSite"
                SiteClearAll()
        End Select
    End Sub

    ' =========================================================================================
    ' MÉTODOS
    ' =========================================================================================

    ' ===========================================
    ' MÉTODOS PAIS
    ' ===========================================

    ' -----------
    ' COUNTRY ADD
    ' -----------

    Private Sub CountryAdd()

        Dim pai As Pais = Nothing
        If Me.TB_Id_Country.Text <> String.Empty And Me.TB_Name_Country.Text <> String.Empty Then
            pai = New Pais(Me.TB_Id_Country.Text)
            pai.NomPais = Me.TB_Name_Country.Text
            Try
                If pai.InsertarPais() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = pai.IDPais
                item.SubItems.Add(pai.NomPais)
                lstContries.Items.Add(item)
                CB_Country_Site.Items.Add(pai)
                CB_Country_Artist.Items.Add(pai)
                MessageBox.Show(pai.NomPais.ToString & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub


    ' --------------
    ' COUNTRY DELETE
    ' --------------

    Private Sub CountryDelete()

        Dim pai As Pais = Nothing
        If Me.TB_Id_Country.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Country.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pai = New Pais(Me.TB_Id_Country.Text, Me.TB_Name_Country.Text)
                Try
                    If pai.BorrarPais() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstContries.FindItemWithText(pai.IDPais)
                    If item IsNot Nothing Then
                        lstContries.Items.Remove(item)
                        For Each a As Object In CB_Country_Artist.Items
                            If a.Pais.IDPais = pai.IDPais Then
                                CB_Country_Artist.Items.Remove(item)
                            End If
                        Next

                        For Each s As Object In CB_Country_Site.Items
                            If s.Pais.IDPais = pai.IDPais Then
                                CB_Country_Site.Items.Remove(item)
                            End If
                        Next
                    End If
                    MessageBox.Show(pai.NomPais.ToString & " eliminado correctamente")
                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
            End If
        End If

    End Sub



    ' --------------
    ' COUNTRY MODIFY
    ' --------------

    Private Sub CountryModify()

        Dim pai As Pais = Nothing
        If Me.TB_Id_Country.Text <> String.Empty And Me.TB_Name_Country.Text <> String.Empty Then
            pai = New Pais(Me.TB_Id_Country.Text)
            pai.NomPais = Me.TB_Name_Country.Text
            Dim item As ListViewItem = lstContries.FindItemWithText(pai.IDPais)
            Dim nomPais As String = ""
            If item IsNot Nothing Then
                nomPais = item.SubItems(1).Text
                item.SubItems(1).Text = pai.NomPais
                CB_Country_Site.Items.Add(item)
                CB_Country_Artist.Items.Add(item)
            End If
            'ACTUALIZA INFORMACION DE LOS COMBOBOX DE PAISES DE LAS DEMAS VENTANAS
            For Each el1 As Pais In CB_Country_Site.Items
                Dim pais As Pais = CType(el1, Pais)
                If pais.IDPais = pai.IDPais Then
                    pais.NomPais = pai.NomPais
                    For Each el2 As Pais In CB_Country_Artist.Items
                        If el2.IDPais = pai.IDPais Then
                            el2.NomPais = pai.NomPais
                            Exit For
                        End If
                    Next
                    Exit For
                End If
            Next
            Try
                If pai.ActualizarPais() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Pais con el ID " & pai.IDPais & " actualizado correctamente a " & pai.NomPais.ToString)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub



    ' -----------------
    ' COUNTRY CLEAR ALL
    ' -----------------

    Private Sub CountryClearAll()
        Me.TB_Id_Country.Text = String.Empty
        Me.TB_Name_Country.Text = String.Empty
    End Sub



    ' ===========================================
    ' MÉTODOS SITIO
    ' ===========================================

    ' -----------
    ' SITE ADD
    ' -----------

    Private Sub SiteAdd()

        Dim sit As Sitio = Nothing
        If Me.TB_Id_Site.Text <> String.Empty And Me.TB_Name_Site.Text <> String.Empty Then
            sit = New Sitio(Me.TB_Id_Site.Text)
            sit.NomSitio = Me.TB_Name_Site.Text
            sit.tipo = CB_Type_Site.SelectedItem.ToString
            sit.Pais = CB_Country_Site.SelectedItem
            Try
                If sit.InsertarSitio() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = sit.IDSitio
                item.SubItems.Add(sit.NomSitio)
                item.SubItems.Add(sit.Pais.NomPais)
                item.SubItems.Add(sit.tipo.ToString)
                lstSites.Items.Add(item)
                MessageBox.Show(sit.NomSitio.ToString & " Insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub


    ' --------------
    ' SITE DELETE
    ' --------------

    Private Sub SiteDelete()

        Dim sit As Sitio = Nothing
        If Me.TB_Id_Site.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Site.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sit = New Sitio(Me.TB_Id_Site.Text, Me.TB_Name_Site.Text)
                Try
                    If sit.BorrarSitio() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstSites.FindItemWithText(sit.IDSitio)
                    If item IsNot Nothing Then
                        lstSites.Items.Remove(item)
                    End If
                    MessageBox.Show(sit.NomSitio.ToString & " eliminado correctamente")
                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
            End If
        End If

    End Sub



    ' --------------
    ' SITE MODIFY
    ' --------------

    Private Sub SiteModify()

        Dim sit As Sitio = Nothing
        If Me.TB_Id_Site.Text <> String.Empty And Me.TB_Name_Site.Text <> String.Empty And Me.CB_Country_Site.Text <> String.Empty And Me.CB_Type_Site.Text <> String.Empty Then
            sit = New Sitio(Me.TB_Id_Site.Text)
            sit.NomSitio = Me.TB_Name_Site.Text
            sit.Pais = New Pais(CType(CB_Country_Site.SelectedItem, Pais).IDPais, CType(CB_Country_Site.SelectedItem, Pais).NomPais)
            sit.tipo = CB_Type_Site.SelectedItem.ToString
            Dim item As ListViewItem = lstSites.FindItemWithText(sit.IDSitio)
            Dim nomSitio As String = ""
            If item IsNot Nothing Then
                nomSitio = item.SubItems(1).Text
                item.SubItems(1).Text = sit.NomSitio
                item.SubItems(2).Text = sit.Pais.NomPais
                item.SubItems(3).Text = sit.tipo
                CB_Country_Site.Items.Remove(nomSitio)
                CB_Country_Site.Items.Add(sit.NomSitio)
            End If
            Try
                If sit.ActualizarSitio() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Sitio con el ID " & sit.IDSitio & " actualizado correctamente al nombre " & sit.NomSitio.ToString & ", a pais " & sit.Pais.NomPais & " y a tipo " & sit.tipo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub



    ' -----------------
    ' SITE CLEAR ALL
    ' -----------------

    Private Sub SiteClearAll()
        Me.TB_Id_Site.Text = String.Empty
        Me.TB_Name_Site.Text = String.Empty
        CB_Country_Site.SelectedIndex = -1
        CB_Type_Site.SelectedIndex = -1
    End Sub


    ' ===========================================
    ' MÉTODOS ARTISTA
    ' ===========================================



    ' -----------
    ' ARTISTA ADD
    ' -----------

    Private Sub ArtistAdd()
        Dim art As Artista = Nothing
        If Me.TB_Id_Artist.Text <> String.Empty And Me.TB_Name_Artist.Text <> String.Empty Then
            If TypeOf CB_Country_Artist.SelectedItem Is Pais Then
                art = New Artista(Me.TB_Id_Artist.Text, Me.TB_Name_Artist.Text, CType(CB_Country_Artist.SelectedItem, Pais))
            Else
                MessageBox.Show("Selecciona un país valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                If art.InsertarArtista() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = art.IDArtista
                item.SubItems.Add(art.NomArtista)
                item.SubItems.Add(art.Pais.NomPais)
                lstArtist.Items.Add(item)
                MessageBox.Show(art.NomArtista.ToString & " Insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub


    ' --------------
    ' ARTIST DELETE
    ' --------------

    Private Sub ArtistDelete()

        Dim art As Artista = Nothing
        If Me.TB_Id_Artist.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Artist.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                art = New Artista(Me.TB_Id_Artist.Text, Me.TB_Name_Artist.Text)
                Try
                    If art.BorrarArtista() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstArtist.FindItemWithText(art.IDArtista)
                    If item IsNot Nothing Then
                        lstArtist.Items.Remove(item)
                    End If
                    MessageBox.Show(art.NomArtista.ToString & " eliminado correctamente")
                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
            End If
        End If

    End Sub



    ' --------------
    ' ARTIST MODIFY
    ' --------------


    Private Sub ArtistModify()

        Dim art As Artista = Nothing
        If Me.TB_Id_Artist.Text <> String.Empty And Me.TB_Name_Artist.Text <> String.Empty And Me.CB_Country_Artist.Text <> String.Empty Then
            art = New Artista(Me.TB_Id_Artist.Text)
            art.NomArtista = Me.TB_Name_Artist.Text
            If TypeOf CB_Country_Artist.SelectedItem Is Pais Then
                art.Pais = CType(CB_Country_Artist.SelectedItem, Pais)
            Else
                MessageBox.Show("Selecciona un país valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim item As ListViewItem = lstArtists.FindItemWithText(art.IDArtista)
            Dim nomArtista As String = ""
            If item IsNot Nothing Then
                nomArtista = item.SubItems(1).Text
                item.SubItems(1).Text = art.NomArtista
                item.SubItems(2).Text = art.Pais.NomPais
                CB_Country_Artist.Items.Remove(nomArtista)
                CB_Country_Artist.Items.Add(art.NomArtista)
            End If
            Try
                If art.ActualizarArtista() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Artista con el ID " & art.IDArtista & " actualizado correctamente a " & art.NomArtista.ToString)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub




    ' -----------------
    ' ARTIST CLEAR ALL
    ' -----------------

    Private Sub ArtistClearAll()
        Me.TB_Id_Artist.Text = String.Empty
        Me.TB_Name_Artist.Text = String.Empty
        CB_Country_Artist.SelectedIndex = -1
    End Sub



    ' ===========================================
    ' MÉTODOS ALBUM
    ' ===========================================

    ' -----------
    ' ALBUM ADD
    ' -----------

    Private Sub AlbumAdd()

        Dim alb As Album = Nothing
        If Me.TB_ID_Album.Text <> String.Empty And Me.TB_Name_Album.Text <> String.Empty And Me.CB_Artist_Album.Text <> String.Empty And Me.DTP_Year_Album.Text <> String.Empty Then
            alb = New Album(Me.TB_ID_Album.Text)
            alb.NomAlbum = TB_Name_Album.Text
            alb.AnoAlbum = DTP_Year_Album.Value.Year
            alb.Artista = CB_Artist_Album.SelectedItem
            Try
                If alb.InsertarAlbum() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = alb.IDAlbum
                item.SubItems.Add(alb.NomAlbum)
                item.SubItems.Add(alb.Artista.NomArtista)
                item.SubItems.Add(alb.AnoAlbum)
                lstAlbumes.Items.Add(item)
                MessageBox.Show(alb.NomAlbum.ToString & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub


    ' --------------
    ' ALBUM DELETE
    ' --------------

    Private Sub AlbumDelete()

        Dim alb As Album = Nothing
        If Me.TB_ID_Album.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_ID_Album.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                alb = New Album(Me.TB_ID_Album.Text, Me.TB_Name_Album.Text)
                Try
                    If alb.BorrarAlbum() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstAlbumes.FindItemWithText(alb.IDAlbum)
                    If item IsNot Nothing Then
                        lstAlbumes.Items.Remove(item)
                    End If
                    MessageBox.Show(alb.NomAlbum.ToString & " eliminado correctamente")
                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
            End If
        End If

    End Sub



    ' --------------
    ' ALBUM MODIFY
    ' --------------

    Private Sub AlbumModify()

        Dim alb As Album = Nothing
        If Me.TB_ID_Album.Text <> String.Empty And Me.TB_Name_Album.Text <> String.Empty And Me.CB_Artist_Album.Text <> String.Empty And Me.DTP_Year_Album.Text <> String.Empty Then
            alb = New Album(Me.TB_Id_Site.Text, Me.TB_Name_Album.Text)
            alb.Artista = CB_Artist_Album.SelectedItem
            alb.AnoAlbum = DTP_Year_Album.Value.Year
            Dim item As ListViewItem = lstAlbumes.FindItemWithText(alb.IDAlbum)
            Dim nomAlbum As String = ""
            If item IsNot Nothing Then
                nomAlbum = item.SubItems(1).Text
                item.SubItems(1).Text = alb.NomAlbum
                item.SubItems(2).Text = alb.Artista.NomArtista
                item.SubItems(3).Text = alb.AnoAlbum
            End If
            Try
                If alb.ActualizarAlbum() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Album con el ID " & alb.IDAlbum & " actualizado correctamente al nombre " & alb.NomAlbum.ToString & ", a artista " & alb.Artista.NomArtista & " y a año " & alb.AnoAlbum)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub



    ' -----------------
    ' ALBUM CLEAR ALL
    ' -----------------

    Private Sub AlbumClearAll()
        Me.TB_ID_Album.Text = String.Empty
        Me.TB_Name_Album.Text = String.Empty
        CB_Artist_Album.SelectedIndex = -1
    End Sub


    ' ===========================================
    ' MÉTODOS CANCIÓN
    ' ===========================================

    ' -----------
    ' SONG ADD
    ' -----------

    Private Sub SongAdd()

        Dim can As Cancion = Nothing
        If Me.TB_Id_Song.Text <> String.Empty And Me.TB_Name_Song.Text <> String.Empty And Me.CB_Album_Song.Text <> String.Empty And Me.TB_Duration_Song.Text <> String.Empty And Me.TB_Order_Song.Text <> String.Empty Then
            can = New Cancion(Me.TB_Id_Song.Text)
            can.NomCancion = TB_Name_Song.Text
            can.Duracion = TB_Duration_Song.Text
            can.Album = CB_Album_Song.SelectedItem
            can.OrdenCancion = TB_Order_Song.Text
            Try
                If can.InsertarCancion() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = can.IDCancion
                item.SubItems.Add(can.NomCancion)
                item.SubItems.Add(can.Duracion)
                item.SubItems.Add(can.Album.NomAlbum)
                item.SubItems.Add(can.OrdenCancion)
                lstAlbumes.Items.Add(item)
                MessageBox.Show(can.NomCancion.ToString & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub

    ' --------------
    ' SONG DELETE
    ' --------------

    Private Sub SongDelete()

        Dim can As Cancion = Nothing
        If Me.TB_Id_Song.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Song.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                can = New Cancion(Me.TB_Id_Song.Text, Me.TB_Name_Song.Text)
                Try
                    If can.BorrarCancion() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstSong.FindItemWithText(can.IDCancion)
                    If item IsNot Nothing Then
                        lstSong.Items.Remove(item)
                    End If
                    MessageBox.Show(can.NomCancion.ToString & " eliminado correctamente")
                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
            End If
        End If

    End Sub

    ' -----------------
    ' SONG MODIFY
    ' -----------------




    ' -----------------
    ' SONG CLEAR ALL
    ' -----------------

    Private Sub SongClearAll()
        Me.TB_Id_Song.Text = String.Empty
        Me.TB_Name_Song.Text = String.Empty
        Me.TB_Duration_Song.Text = String.Empty
        CB_Album_Song.SelectedIndex = -1
        Me.TB_Order_Song.Text = String.Empty
    End Sub


End Class
