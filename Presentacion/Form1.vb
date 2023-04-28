Imports System.Collections.Concurrent
Imports System.ComponentModel.DataAnnotations
Imports System.Configuration
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics
Imports System.Security.Policy
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AppMusic.Sitio
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Bcpg
Imports Org.BouncyCastle.Crypto.Agreement.Kdf
Imports Org.BouncyCastle.Crypto.Engines

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"

        'Country Controls

        lstContries.Columns.Add("ID", 75)
        lstContries.Columns.Add("Name", 150)

        'Site Controls

        lstSites.View = View.Details
        lstSites.Columns.Add("ID", 40)
        lstSites.Columns.Add("Name", 80)
        lstSites.Columns.Add("Country", 90)
        lstSites.Columns.Add("Type", 80)

        CB_Type_Site.Items.Add(TipoSitio.sala)
        CB_Type_Site.Items.Add(TipoSitio.pabellón)
        CB_Type_Site.Items.Add(TipoSitio.estadio)
        CB_Type_Site.Items.Add(TipoSitio.festival)
        CB_Type_Site.SelectedIndex = -1

        'Artist Controls

        lstArtist.View = View.Details
        lstArtist.Columns.Add("ID", 40)
        lstArtist.Columns.Add("Name", 80)
        lstArtist.Columns.Add("Country", 90)

        'Album Controls

        lstAlbumes.View = View.Details
        lstAlbumes.Columns.Add("ID", 40)
        lstAlbumes.Columns.Add("Name", 80)
        lstAlbumes.Columns.Add("Year", 60)
        lstAlbumes.Columns.Add("Artist", 80)

        'Song Controls

        lstSong.View = View.Details
        lstSong.Columns.Add("ID", 40)
        lstSong.Columns.Add("Name", 80)
        lstSong.Columns.Add("Duration", 40)
        lstSong.Columns.Add("Album", 60)
        lstSong.Columns.Add("Orden", 40)

        'Concert Controls

        lstConcert.View = View.Details
        lstConcert.Columns.Add("ID", 40)
        lstConcert.Columns.Add("Artista", 80)
        lstConcert.Columns.Add("Sitio", 60)
        lstConcert.Columns.Add("Fecha", 90)

        lstAllSongs.View = View.Details
        lstAllSongs.Columns.Add("ID", 40)
        lstAllSongs.Columns.Add("Name", 80)
        lstAllSongs.Columns.Add("Duration", 40)
        lstAllSongs.Columns.Add("Album", 60)
        lstAllSongs.Columns.Add("Orden", 40)

        lstConcertSongs.View = View.Details
        lstConcertSongs.Columns.Add("ID", 40)
        lstConcertSongs.Columns.Add("Name", 80)
        lstConcertSongs.Columns.Add("Duration", 40)
        lstConcertSongs.Columns.Add("Album", 60)
        lstConcertSongs.Columns.Add("Orden", 40)

        'Artist Navegation 

        lstConcert_Artist.View = View.Details
        lstConcert_Artist.Columns.Add("ID", 40)
        lstConcert_Artist.Columns.Add("Artista", 80)
        lstConcert_Artist.Columns.Add("Sitio", 60)
        lstConcert_Artist.Columns.Add("Fecha", 90)

        lstSetlist_Artist.View = View.Details
        lstSetlist_Artist.Columns.Add("ID", 40)
        lstSetlist_Artist.Columns.Add("Name", 80)
        lstSetlist_Artist.Columns.Add("Duration", 40)
        lstSetlist_Artist.Columns.Add("Album", 60)
        lstSetlist_Artist.Columns.Add("Orden", 40)

        'Site Navegation 

        lstConcert_Site.View = View.Details
        lstConcert_Site.Columns.Add("ID", 40)
        lstConcert_Site.Columns.Add("Artista", 80)
        lstConcert_Site.Columns.Add("Sitio", 60)
        lstConcert_Site.Columns.Add("Fecha", 90)

        lstSetlist_Site.View = View.Details
        lstSetlist_Site.Columns.Add("ID", 40)
        lstSetlist_Site.Columns.Add("Name", 80)
        lstSetlist_Site.Columns.Add("Duration", 40)
        lstSetlist_Site.Columns.Add("Album", 60)
        lstSetlist_Site.Columns.Add("Orden", 40)

        Update_Country()
        Update_Site()
        Update_Artist()
        Update_Album()
        Update_Song()
        Update_Concert()
        Update_Artist_Navegation()
        Update_Site_Navegation()
    End Sub

    ' =========================================================================================
    ' PESTAÑAS
    ' =========================================================================================

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        Dim tabPage As TabPage = TabControl.SelectedTab
        'Switch-case para comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
                Update_Album()
            Case "TabArtist"
                Update_Artist()
            Case "TabSong"
                Update_Song()
            Case "TabConcert"
                Update_Concert()
            Case "TabCountry"
                Update_Country()
            Case "TabSite"
                Update_Site()
            Case "TabNavegation"
                Update_Artist_Navegation()
                Update_Site_Navegation()
        End Select

        ' Las opciones del setlist estarán deshabilitadas a menos que se esté en la pestaña Concierto
        OrderUp.Enabled = False
        OrderDown.Enabled = False
        AddSong.Enabled = False
        RemoveSong.Enabled = False
        ModifySong.Enabled = False
        lstConcertSongs.Enabled = False
        lstAllSongs.Enabled = False

        If TabControl.SelectedTab.Name = "TabConcert" Then
            OrderUp.Enabled = True
            OrderDown.Enabled = True
            AddSong.Enabled = True
            RemoveSong.Enabled = True
            ModifySong.Enabled = True
            lstConcertSongs.Enabled = True
            lstAllSongs.Enabled = True
        End If

    End Sub

    ' ===============
    ' PESTAÑA ARTISTA
    ' ===============

    Private Sub lstArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtist.SelectedIndexChanged
        Me.TB_Id_Artist.Text = String.Empty
        Dim art As Artista
        If Not Me.lstArtist.SelectedItems Is Nothing Then
            Try
                art = New Artista(lstArtist.SelectedItems(0).SubItems(0).Text, lstArtist.SelectedItems(0).SubItems(1).Text)
                art.LeerArtista()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Artist.Text = art.IDArtista
            Me.TB_Name_Artist.Text = art.NomArtista
        End If
    End Sub

    ' ==============
    ' PESTAÑA PAÍSES
    ' ==============

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContries.SelectedIndexChanged
        Me.TB_Id_Country.Text = String.Empty
        Dim pai As Pais
        If Not Me.lstContries.SelectedItems Is Nothing Then
            Try
                pai = New Pais(lstContries.SelectedItems(0).SubItems(0).Text, lstContries.SelectedItems(0).SubItems(1).Text)
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
        Me.TB_Id_Site.Text = String.Empty
        Dim sit As Sitio
        If Not Me.lstSites.SelectedItems Is Nothing Then
            Try
                sit = New Sitio(lstSites.SelectedItems(0).SubItems(0).Text, lstSites.SelectedItems(0).SubItems(1).Text)
                sit.LeerSitio()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Site.Text = sit.IDSitio
            Me.TB_Name_Country.Text = sit.NomSitio
        End If
    End Sub

    ' ===============
    ' PESTAÑA ALBUMES
    ' ===============

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Me.TB_ID_Album.Text = String.Empty
        Dim alb As Album
        If Not Me.lstAlbumes.SelectedItems Is Nothing Then
            Try
                alb = New Album(lstAlbumes.SelectedItems(0).SubItems(0).Text, lstAlbumes.SelectedItems(0).SubItems(1).Text)
                alb.LeerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_ID_Album.Text = alb.IDAlbum
            Me.TB_Name_Album.Text = alb.NomAlbum
        End If
    End Sub

    ' =================
    ' PESTAÑA CANCIONES
    ' =================

    Private Sub lstSong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSong.SelectedIndexChanged
        Me.TB_Id_Song.Text = String.Empty
        Dim can As Cancion
        If Not Me.lstSong.SelectedItems Is Nothing Then
            Try
                can = New Cancion(lstSong.SelectedItems(0).SubItems(0).Text, lstSong.SelectedItems(0).SubItems(1).Text, lstSong.SelectedItems(0).SubItems(2).Text, lstSong.SelectedItems(0).SubItems(4).Text)
                can.LeerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Song.Text = can.IDCancion
            Me.TB_Name_Song.Text = can.NomCancion
            Me.TB_Duration_Song.Text = can.Duracion
            Me.TB_Order_Song.Text = can.OrdenCancion
        End If
    End Sub

    ' ==================
    ' PESTAÑA CONCIERTOS
    ' ==================

    Private Sub lstConcert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConcert.SelectedIndexChanged
        Me.TB_Id_Concert.Text = String.Empty
        lstConcertSongs.Items.Clear()
        lstAllSongs.Items.Clear()
        Dim con As Concierto
        Dim can As Cancion = New Cancion

        If Me.lstConcert.SelectedItems.Count > 0 Then
            Try
                con = New Concierto(lstConcert.SelectedItems(0).SubItems(0).Text)
                con.LeerConcierto()
                con.LeerSetlist()
                Try
                    can.LeerTodasCanciones()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                For Each c As Cancion In can.CanDAO.Canciones
                    Dim item As New ListViewItem
                    item.Text = c.IDCancion
                    item.SubItems.Add(c.NomCancion)
                    item.SubItems.Add(c.Duracion)
                    c.Album.LeerAlbum()
                    item.SubItems.Add(c.Album.IDAlbum)
                    item.SubItems.Add(c.OrdenCancion)
                    lstAllSongs.Items.Add(item)
                Next
                If con.Canciones IsNot Nothing Then
                    For Each c As Cancion In con.Canciones
                        Dim item As New ListViewItem
                        item.Text = c.IDCancion
                        item.SubItems.Add(c.NomCancion)
                        item.SubItems.Add(c.Duracion)
                        c.Album.LeerAlbum()
                        item.SubItems.Add(c.Album.IDAlbum)
                        item.SubItems.Add(c.OrdenCancion)
                        lstConcertSongs.Items.Add(item)
                        Dim matchingItem As ListViewItem = lstAllSongs.FindItemWithText(c.IDCancion, False, 0, True)
                        If matchingItem IsNot Nothing Then
                            lstAllSongs.Items.Remove(matchingItem)
                        End If
                        lstAllSongs.Refresh()
                        lstConcertSongs.Refresh()
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Concert.Text = con.IDConcierto
            Me.DTP_Date_Concert.Text = con.FechaConcierto
        End If
    End Sub


    ' ==================
    ' PESTAÑA NAVEGACIÓN
    ' ==================

    Private Sub CB_Artist_Navegation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Artist_Navegation.SelectedIndexChanged

        lstConcert_Artist.Items.Clear()
        Dim art As Artista = CB_Artist_Navegation.SelectedItem
        art.LeerArtista()
        Dim con As Concierto = New Concierto
        Dim conDAO As ConciertoDAO = New ConciertoDAO
        con.ConDAO.LeerPorArtista(art)

        For Each c As Concierto In con.ConDAO.Conciertos
            Dim item As New ListViewItem
            item.Text = c.IDConcierto
            c.Artista.LeerArtista()
            item.SubItems.Add(c.Artista.NomArtista)
            c.Sitio.LeerSitio()
            item.SubItems.Add(c.Sitio.NomSitio)
            item.SubItems.Add(c.FechaConcierto)
            lstConcert_Artist.Items.Add(item)
        Next

        'COUNTRY Filter

        'If CB_Country_Navegation.SelectedItem IsNot Nothing Then
        '    lstConcert_Artist.Items.Clear()


        '    art.LeerArtista()

        '    Dim pai As Pais = CB_Country_Navegation.SelectedItem
        '    pai.LeerPais()

        '    Dim sit As Sitio = New Sitio
        '    sit.Pais = pai


        '    con.LeerTodosConciertos()


        '    conDAO.LeerPorArtistaFiltrado(art, sit)

        '    For Each c As Concierto In con.ConDAO.Conciertos
        '        Dim item As New ListViewItem
        '        item.Text = c.IDConcierto
        '        c.Artista.LeerArtista()
        '        item.SubItems.Add(c.Artista.NomArtista)
        '        c.Sitio.LeerSitio()
        '        item.SubItems.Add(c.Sitio.NomSitio)
        '        item.SubItems.Add(c.FechaConcierto)
        '        lstConcert_Artist.Items.Add(item)
        '    Next
        'End If



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
                ConcertAdd()
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
                ConcertDelete()
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
                SongModify()
            Case "TabConcert"
                ConcertModify()
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
                ConcertClearAll()
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
        If Me.TB_Id_Country.Text <> String.Empty And Me.TB_Name_Country.Text <> String.Empty And Me.TB_Id_Country.Text.Length = 3 Then
            pai = New Pais(Me.TB_Id_Country.Text, Me.TB_Name_Country.Text)
            Try
                If pai.InsertarPais() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Country()
                MessageBox.Show("Pais con el ID " & pai.IDPais & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("El ID del país debe tener exactamente 3 letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' --------------
    ' COUNTRY DELETE
    ' --------------

    Private Sub CountryDelete()

        Dim pai As Pais = Nothing
        If Me.TB_Id_Country.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Country.Text, ". Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pai = New Pais(Me.TB_Id_Country.Text, Me.TB_Name_Country.Text)
                Try
                    If pai.BorrarPais() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Update_Country()
                    MessageBox.Show("Pais con el ID " & pai.IDPais & " eliminado correctamente")
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
            pai = New Pais(TB_Id_Country.Text)
            pai.NomPais = Me.TB_Name_Country.Text
            Try
                If pai.ActualizarPais() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Country()
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

    ' --------------------
    ' COUNTRY UPDATE CONTROL
    ' --------------------

    Private Sub Update_Country()
        lstContries.Items.Clear()
        Dim pai As Pais = New Pais
        Try
            pai.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each p As Pais In pai.PaiDAO.Paises
            Dim item As New ListViewItem
            item.Text = p.IDPais
            item.SubItems.Add(p.NomPais)
            lstContries.Items.Add(item)
        Next
        ' Añade columnas al listView de Países
        lstContries.View = View.Details
    End Sub

    ' ===========================================
    ' MÉTODOS SITIO
    ' ===========================================

    ' -----------
    ' SITE ADD
    ' -----------

    Private Sub SiteAdd()

        Dim sit As Sitio = New Sitio
        If Me.TB_Name_Site.Text <> String.Empty Then
            sit.NomSitio = Me.TB_Name_Site.Text
            sit.tipo = CB_Type_Site.SelectedItem.ToString
            sit.Pais = CB_Country_Site.SelectedItem
            Try
                If sit.InsertarSitio() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Site()
                MessageBox.Show("Sitio con el ID " & sit.IDSitio & " insertado correctamente")
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
                    Update_Site()
                    MessageBox.Show("Sitio con el ID " & sit.IDSitio & " eliminado correctamente")
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

        Dim sit As Sitio = New Sitio
        If Me.TB_Id_Site.Text <> String.Empty And Me.TB_Name_Site.Text <> String.Empty And Me.CB_Country_Site.Text <> String.Empty And Me.CB_Type_Site.Text <> String.Empty Then
            sit = New Sitio(Me.TB_Id_Site.Text)
            sit.NomSitio = Me.TB_Name_Site.Text
            sit.Pais = CB_Country_Site.SelectedItem
            sit.tipo = CB_Type_Site.SelectedItem.ToString
            Try
                If sit.ActualizarSitio() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Site()
                MessageBox.Show("Sitio con el ID " & sit.IDSitio & " actualizado correctamente al nombre " & sit.NomSitio.ToString & ", pais " & sit.Pais.NomPais & " y tipo " & sit.tipo)
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

    ' ---------------------
    ' SITE UPDATE CONTROL
    ' ---------------------

    Private Sub Update_Site()
        lstSites.Items.Clear()
        CB_Country_Site.Items.Clear()
        Dim sit As Sitio = New Sitio
        Try
            sit.LeerTodosSitios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each s As Sitio In sit.SitDAO.Sitios
            Dim item As New ListViewItem
            item.Text = s.IDSitio
            item.SubItems.Add(s.NomSitio)
            s.Pais.LeerPais()
            item.SubItems.Add(s.Pais.NomPais)
            item.SubItems.Add(s.tipo)
            lstSites.Items.Add(item)
        Next
        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Site.Items.Add(p)
        Next
        CB_Country_Site.SelectedIndex = -1
    End Sub

    ' ===========================================
    ' MÉTODOS ARTISTA
    ' ===========================================

    ' -----------
    ' ARTISTA ADD
    ' -----------

    Private Sub ArtistAdd()
        Dim art As Artista = New Artista
        If Me.TB_Name_Artist.Text <> String.Empty Then
            art.NomArtista = Me.TB_Name_Artist.Text
            art.Pais = CB_Country_Artist.SelectedItem
            Try
                If art.InsertarArtista() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Artist()
                MessageBox.Show("Artista con el ID " & art.IDArtista & " insertado correctamente")
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
                    Update_Artist()
                    MessageBox.Show("Artista con el ID " & art.IDArtista & " eliminado correctamente")
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

        Dim art As Artista = New Artista
        If Me.TB_Id_Artist.Text <> String.Empty And Me.TB_Name_Artist.Text <> String.Empty And Me.CB_Country_Artist.Text <> String.Empty Then
            art = New Artista(Me.TB_Id_Artist.Text)
            art.NomArtista = Me.TB_Name_Artist.Text
            art.Pais = CB_Country_Artist.SelectedItem
            Try
                If art.ActualizarArtista() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Artist()
                MessageBox.Show("Artista con el ID " & art.IDArtista & " actualizado correctamente al nombre " & art.NomArtista.ToString & " y pais " & art.Pais.NomPais)
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

    ' ---------------------
    ' ARTIST UPDATE CONTROL
    ' ---------------------

    Private Sub Update_Artist()
        lstArtist.Items.Clear()
        CB_Country_Artist.Items.Clear()
        Dim art As Artista = New Artista
        Try
            art.LeerTodosArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each a As Artista In art.ArtDAO.Artistas
            Dim item As New ListViewItem
            item.Text = a.IDArtista
            item.SubItems.Add(a.NomArtista)
            a.Pais.LeerPais()
            item.SubItems.Add(a.Pais.NomPais)
            lstArtist.Items.Add(item)
        Next
        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Artist.Items.Add(p)
        Next
    End Sub

    ' ===========================================
    ' MÉTODOS ALBUM
    ' ===========================================

    ' -----------
    ' ALBUM ADD
    ' -----------

    Private Sub AlbumAdd()

        Dim alb As Album = New Album
        If Me.TB_Name_Album.Text <> String.Empty And Me.CB_Artist_Album.Text <> String.Empty And Me.DTP_Year_Album.Text <> String.Empty Then
            alb.NomAlbum = TB_Name_Album.Text
            alb.AnoAlbum = DTP_Year_Album.Value.Year
            alb.Artista = CB_Artist_Album.SelectedItem
            Try
                If alb.InsertarAlbum() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Album()
                MessageBox.Show("Album con ID " & alb.IDAlbum & " insertado correctamente")
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
                    Update_Album()
                    MessageBox.Show("Album con ID " & alb.IDAlbum & " eliminado correctamente")
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
        If Me.TB_ID_Album.Text <> String.Empty And Me.TB_Name_Album.Text <> String.Empty And Me.CB_Artist_Album.Text <> String.Empty Then
            alb = New Album(CInt(Me.TB_ID_Album.Text), Me.TB_Name_Album.Text)
            alb.Artista = CB_Artist_Album.SelectedItem
            alb.AnoAlbum = DTP_Year_Album.Value.Year
            Try
                If alb.ActualizarAlbum() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Album()
                MessageBox.Show("Album con el ID " & alb.IDAlbum & " actualizado correctamente al nombre " & alb.NomAlbum.ToString & ", artista " & alb.Artista.NomArtista & " y año " & alb.AnoAlbum)
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

    ' --------------------
    ' ALBUM UPDATE CONTROL
    ' --------------------

    Private Sub Update_Album()
        lstAlbumes.Items.Clear()
        CB_Artist_Album.Items.Clear()
        Dim alb As Album = New Album
        Try
            alb.LeerTodosAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each a As Album In alb.AlbDAO.Albumes
            Dim item As New ListViewItem
            item.Text = a.IDAlbum
            item.SubItems.Add(a.NomAlbum)
            item.SubItems.Add(a.AnoAlbum)
            a.Artista.LeerArtista()
            item.SubItems.Add(a.Artista.IDArtista)
            lstAlbumes.Items.Add(item)
        Next

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Album.Items.Add(a)
        Next
        CB_Artist_Album.SelectedIndex = -1
    End Sub

    ' ===========================================
    ' MÉTODOS CANCIÓN
    ' ===========================================

    ' -----------
    ' SONG ADD
    ' -----------

    Private Sub SongAdd()

        Dim can As Cancion = New Cancion
        If Me.TB_Name_Song.Text <> String.Empty And Me.CB_Album_Song.Text <> String.Empty And Me.TB_Duration_Song.Text <> String.Empty And Me.TB_Order_Song.Text <> String.Empty Then
            can.NomCancion = TB_Name_Song.Text
            can.Duracion = CInt(TB_Duration_Song.Text)
            can.Album = CB_Album_Song.SelectedItem
            can.OrdenCancion = CInt(TB_Order_Song.Text)
            Try
                If can.InsertarCancion() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Song()
                MessageBox.Show("Canción con el ID " & can.IDCancion & " insertada correctamente")
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
                    Update_Song()
                    MessageBox.Show("Canción con el ID " & can.IDCancion & " eliminada correctamente")
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

    Private Sub SongModify()

        Dim can As Cancion = Nothing
        If Me.TB_Id_Song.Text <> String.Empty And Me.TB_Name_Song.Text <> String.Empty And Me.CB_Album_Song.Text <> String.Empty And Me.TB_Order_Song.Text <> String.Empty And Me.TB_Duration_Song.Text <> String.Empty Then
            can = New Cancion(CInt(Me.TB_Id_Song.Text), Me.TB_Name_Song.Text)
            can.Album = CB_Album_Song.SelectedItem
            can.Duracion = CInt(TB_Duration_Song.Text)
            can.OrdenCancion = CInt(TB_Order_Song.Text)
            Try
                If can.ActualizarCancion() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Update_Song()
                MessageBox.Show("Cancion con el ID " & can.IDCancion & " actualizado correctamente al nombre " & can.NomCancion & ", album " & can.Album.NomAlbum & ", duración " & can.Duracion & " y orden " & can.OrdenCancion)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub

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

    ' --------------------
    ' SONG UPDATE CONTROL
    ' --------------------

    Private Sub Update_Song()
        CB_Album_Song.Items.Clear()
        lstSong.Items.Clear()
        Dim can As Cancion = New Cancion
        Try
            can.LeerTodasCanciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each c As Cancion In can.CanDAO.Canciones
            Dim item As New ListViewItem
            item.Text = c.IDCancion
            item.SubItems.Add(c.NomCancion)
            item.SubItems.Add(c.Duracion)
            c.Album.LeerAlbum()
            item.SubItems.Add(c.Album.IDAlbum)
            item.SubItems.Add(c.OrdenCancion)
            lstSong.Items.Add(item)
        Next

        For Each item As ListViewItem In lstAlbumes.Items
            Dim a As Album = New Album(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Album_Song.Items.Add(a)
        Next
        CB_Album_Song.SelectedIndex = -1
    End Sub

    ' ===========================================
    ' MÉTODOS CONCIERTO
    ' ===========================================

    ' -----------
    ' CONCERT ADD
    ' -----------

    Private Sub ConcertAdd()

        Dim con As Concierto = New Concierto
        If Me.CB_Artist_Concert.Text <> String.Empty And Me.CB_Site_Concert.Text <> String.Empty And Me.DTP_Date_Concert.Text <> String.Empty Then
            con.Artista = CB_Artist_Concert.SelectedItem
            con.Sitio = CB_Site_Concert.SelectedItem
            con.FechaConcierto = DTP_Date_Concert.Value.Date
            Try
                If con.InsertarConcierto() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                For Each item As ListViewItem In lstConcertSongs.Items
                    Dim can = New Cancion(item.SubItems(0).Text, item.SubItems(1).Text, item.SubItems(2).Text, item.SubItems(4).Text)
                    can.Album = New Album(item.SubItems(3).Text)
                    can.Album.LeerAlbum()
                    con.LeerConcierto()
                    If con IsNot Nothing Then
                        con.Canciones.Add(can)
                        con.InsertarSetlist(can)
                    End If
                Next
                Update_Concert()
                MessageBox.Show("Concierto con el ID " & con.IDConcierto.ToString & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try


        End If

    End Sub

    ' --------------
    ' CONCERT DELETE
    ' --------------

    Private Sub ConcertDelete()

        Dim con As Concierto = Nothing
        If Me.TB_Id_Concert.Text <> String.Empty Then
            If MessageBox.Show("Estas seguro de que quieres eliminar el concierto con el ID " & Me.TB_Id_Concert.Text, "?. Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con = New Concierto(Me.TB_Id_Concert.Text)
                con.LeerConcierto()
                con.LeerSetlist()
                For Each c As Cancion In con.Canciones
                    con.BorrarSetlist()
                Next
                Try
                    If con.BorrarConcierto() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Update_Concert()
                    con.BorrarSetlist()
                    lstConcertSongs.Clear()
                    MessageBox.Show("Concierto con el ID " & con.IDConcierto & " eliminado correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If

    End Sub

    ' --------------
    ' CONCERT MODIFY
    ' --------------

    Private Sub ConcertModify()

        Dim con As Concierto = Nothing
        If Me.TB_Id_Concert.Text <> String.Empty And Me.CB_Artist_Concert.Text <> String.Empty And Me.CB_Site_Concert.Text <> String.Empty And Me.DTP_Date_Concert.Text <> String.Empty Then
            con = New Concierto(CInt(Me.TB_Id_Concert.Text))
            con.Artista = CB_Artist_Concert.SelectedItem
            con.Sitio = CB_Site_Concert.SelectedItem
            con.FechaConcierto = DTP_Date_Concert.Value.Date
            Try
                If con.ActualizarConcierto() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Update_Concert()
                For Each item As ListViewItem In lstConcertSongs.Items

                Next
                MessageBox.Show("Concierto con el ID " & con.IDConcierto & " actualizado correctamente al artista " & con.Artista.NomArtista & ", sitio " & con.Sitio.NomSitio & " y fecha " & con.FechaConcierto)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub

    ' -----------------
    ' CONCERT CLEAR ALL
    ' -----------------

    Private Sub ConcertClearAll()
        Me.TB_Id_Concert.Text = String.Empty
        Me.DTP_Date_Concert.Text = String.Empty
        CB_Artist_Concert.SelectedIndex = 0
        CB_Site_Concert.SelectedIndex = 0
        lstConcertSongs.Items.Clear()
    End Sub

    ' --------------------
    ' CONCERT UPDATE CONTROL
    ' --------------------

    Private Sub Update_Concert()
        lstConcert.Items.Clear()
        CB_Artist_Concert.Items.Clear()
        CB_Site_Concert.Items.Clear()
        Dim con As Concierto = New Concierto
        Try
            con.LeerTodosConciertos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each c As Concierto In con.ConDAO.Conciertos
            Dim item As New ListViewItem
            item.Text = c.IDConcierto
            c.Artista.LeerArtista()
            item.SubItems.Add(c.Artista.NomArtista)
            c.Sitio.LeerSitio()
            item.SubItems.Add(c.Sitio.NomSitio)
            item.SubItems.Add(c.FechaConcierto)
            lstConcert.Items.Add(item)
        Next

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Concert.Items.Add(a)
        Next
        CB_Artist_Concert.SelectedIndex = -1
        For Each item As ListViewItem In lstSites.Items
            Dim s As Sitio = New Sitio(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Site_Concert.Items.Add(s)
        Next
        CB_Site_Concert.SelectedIndex = -1

        ' -------------------------
        ' Update AllSongs listview
        ' -------------------------

        lstAllSongs.Items.Clear()
        Dim can As Cancion = New Cancion
        Try
            can.LeerTodasCanciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each c As Cancion In can.CanDAO.Canciones

            ' Check if the song is already in lstConcertSongs
            Dim songFound As Boolean = False
            For Each item As ListViewItem In lstConcertSongs.Items
                If item.SubItems(0).Text = c.IDCancion Then
                    songFound = True
                    Exit For
                End If
            Next

            ' If the song is not already in lstConcertSongs, add it to lstAllSongs
            If Not songFound Then
                Dim item As New ListViewItem
                item.Text = c.IDCancion
                item.SubItems.Add(c.NomCancion)
                item.SubItems.Add(c.Duracion)
                c.Album.LeerAlbum()
                item.SubItems.Add(c.Album.IDAlbum)
                item.SubItems.Add(c.OrdenCancion)
                lstAllSongs.Items.Add(item)
            End If
        Next
    End Sub

    ' ===========================================
    ' MÉTODOS SETLIST
    ' ===========================================

    Private Sub ModifySetlist_Click(sender As Object, e As EventArgs) Handles ModifySong.Click
        Dim c As Concierto = New Concierto
        c.IDConcierto = CInt(TB_Id_Concert.Text)
        c.LeerConcierto()
        c.LeerSetlist()
        For Each item As ListViewItem In lstConcertSongs.Items
            Dim can As Cancion = New Cancion
            can.IDCancion = item.SubItems(0).Text
            can.LeerCancion()
            Try
                If c.ActualizarSetlistAdd(can) <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Setlist con el ID " & can.IDCancion & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Next
        For Each item As ListViewItem In lstAllSongs.Items
            Dim can As Cancion = New Cancion
            can.IDCancion = item.SubItems(0).Text
            can.LeerCancion()
            Try
                If c.ActualizarSetlistRemove(can) <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Setlist con el ID " & can.IDCancion & " insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Next
    End Sub

    ' ==============================
    ' BOTÓN AÑADIR CANCIÓN (SETLIST)
    ' ==============================

    Private Sub AddSong_Click(sender As Object, e As EventArgs) Handles AddSong.Click
        If lstAllSongs.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In lstAllSongs.SelectedItems
                Dim selectedItem As ListViewItem = lstAllSongs.SelectedItems(0)
                lstAllSongs.Items.Remove(selectedItem)
                lstConcertSongs.Items.Add(selectedItem)
                Dim c As Cancion = New Cancion(selectedItem.SubItems(0).Text, selectedItem.SubItems(1).Text, selectedItem.SubItems(2).Text, selectedItem.SubItems(4).Text)
            Next
        Else
            ' Si no se ha seleccionado ningún elemento, mostrar un mensaje de error
            MessageBox.Show("Debe seleccionar un elemento primero.")
        End If
    End Sub

    ' ================================
    ' BOTÓN ELIMINAR CANCIÓN (SETLIST)
    ' ================================

    Private Sub RemoveSong_Click(sender As Object, e As EventArgs) Handles RemoveSong.Click

        If lstConcertSongs.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In lstConcertSongs.SelectedItems
                Dim selectedItem As ListViewItem = lstConcertSongs.SelectedItems(0)
                lstConcertSongs.Items.Remove(selectedItem)
                lstAllSongs.Items.Add(selectedItem)
                Dim c As Cancion = New Cancion(selectedItem.SubItems(0).Text, selectedItem.SubItems(1).Text, selectedItem.SubItems(2).Text, selectedItem.SubItems(4).Text)
            Next
        Else
            ' Si no se ha seleccionado ningún elemento, mostrar un mensaje de error
            MessageBox.Show("Debe seleccionar un elemento primero.")
        End If

    End Sub

    ' ===========================================
    ' MÉTODOS NAVEGACIÓN
    ' ===========================================

    ' -------------------------
    ' Update Artist Navegation
    ' -------------------------

    Private Sub Update_Artist_Navegation()
        lstConcert_Artist.Items.Clear()
        CB_Artist_Navegation.Items.Clear()
        CB_Country_Navegation.Items.Clear()

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Navegation.Items.Add(a)
        Next

        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Navegation.Items.Add(p)
        Next

    End Sub

    ' ----------------------
    ' Update Site Navegation
    ' ----------------------

    Private Sub Update_Site_Navegation()
        lstConcert_Site.Items.Clear()
        CB_Site_Navegation.Items.Clear()

        For Each item As ListViewItem In lstSites.Items
            Dim s As Sitio = New Sitio(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Site_Navegation.Items.Add(s)
        Next

    End Sub


End Class