Imports System.Collections.Concurrent
Imports System.Collections.ObjectModel
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
Imports Mysqlx.XDevAPI
Imports Org.BouncyCastle.Bcpg
Imports Org.BouncyCastle.Crypto.Agreement.Kdf
Imports Org.BouncyCastle.Crypto.Engines

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"

        'Country Controls

        lstCountries.Columns.Add("ID", 75)
        lstCountries.Columns.Add("Name", 150)

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

        'Report 1 (Song)

        lstReport1.View = View.Details
        lstReport1.Columns.Add("ID", 40)
        lstReport1.Columns.Add("Name", 80)
        lstReport1.Columns.Add("Duration", 40)
        lstReport1.Columns.Add("Album", 60)
        lstReport1.Columns.Add("Orden", 40)

        'Report 2 (Album)

        lstReport2.View = View.Details
        lstReport2.Columns.Add("ID", 40)
        lstReport2.Columns.Add("Name", 80)
        lstReport2.Columns.Add("Year", 60)
        lstReport2.Columns.Add("Artist", 80)

        'Report 3 (Artist)

        lstReport3.View = View.Details
        lstReport3.Columns.Add("ID", 40)
        lstReport3.Columns.Add("Name", 80)
        lstReport3.Columns.Add("Country", 90)

        'Report 4 (Song)

        lstReport4.View = View.Details
        lstReport4.Columns.Add("ID", 40)
        lstReport4.Columns.Add("Name", 80)
        lstReport4.Columns.Add("Duration", 40)
        lstReport4.Columns.Add("Album", 60)
        lstReport4.Columns.Add("Orden", 40)

        'Report 5 (Artist)

        lstReport5.View = View.Details
        lstReport5.Columns.Add("ID", 40)
        lstReport5.Columns.Add("Name", 80)
        lstReport5.Columns.Add("Country", 90)

        'Report 6 (Country)

        lstReport6.View = View.Details
        lstReport6.Columns.Add("ID", 75)
        lstReport6.Columns.Add("Name", 150)

        'Update tabs

        Update_Country()
        Update_Site()
        Update_Artist()
        Update_Album()
        Update_Song()
        Update_Concert()
        Update_Artist_Navegation()
        Update_Site_Navegation()
    End Sub

    ' =========================================================================================================
    ' PESTAÑAS
    ' =========================================================================================================

    ' ===========
    ' TAB CONTROL
    ' ===========

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        Dim tabPage As TabPage = TabControl.SelectedTab
        Dim subTabPage As TabPage = TabControl.SelectedTab
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
            Case "TabReport"
                Update_Report1()
                Update_Report2()
                Update_Report3()
                Update_Report4()
                Update_Report5()
                Update_Report6()
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

        ' Ciertos controles estarán deshabilitados en la pestañas Navegation y Report

        ButtonDelete.Enabled = True
        ButtonModify.Enabled = True
        ButtonAdd.Enabled = True

        If TabControl.SelectedTab.Name = "TabNavegation" Then
            ButtonDelete.Enabled = False
            ButtonModify.Enabled = False
            ButtonAdd.Enabled = False
        End If

        If TabControl.SelectedTab.Name = "TabReport" Then
            ButtonDelete.Enabled = False
            ButtonModify.Enabled = False
            ButtonAdd.Enabled = False
        End If


    End Sub

    ' ===============
    ' INFORME 1
    ' ===============

    Private Sub Update_Report1()
        lstReport1.Items.Clear()
        CB_Artist_Report1.Items.Clear()
        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Report1.Items.Add(a)
        Next
    End Sub

    Private Sub CB_Artist_Report1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Artist_Report1.SelectedIndexChanged
        Dim a As Artista = New Artista
        Dim c As Cancion = New Cancion
        a = CB_Artist_Report1.SelectedItem
        a.ArtDAO.CancionesInforme1.Clear()
        Try
            c.LeerTodasCanciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        a.Informe1()
        Dim cancionesActualizadas As New List(Of Cancion)
        For Each can As Cancion In a.ArtDAO.CancionesInforme1
            can.LeerCancion()
            Dim canActualizada As Cancion = Nothing
            For Each can1 As Cancion In c.CanDAO.Canciones
                If can1.IDCancion = can.IDCancion Then
                    canActualizada = New Cancion()
                    canActualizada.IDCancion = can1.IDCancion
                    canActualizada.NomCancion = can1.NomCancion
                    canActualizada.Duracion = can1.Duracion
                    canActualizada.Album = can1.Album
                    canActualizada.OrdenCancion = can1.OrdenCancion
                    cancionesActualizadas.Add(canActualizada)
                    Exit For
                End If
            Next
        Next

        For Each can As Cancion In cancionesActualizadas
            Dim item As New ListViewItem
            item.Text = can.IDCancion
            item.SubItems.Add(can.NomCancion)
            item.SubItems.Add(can.Duracion)
            can.Album.LeerAlbum()
            item.SubItems.Add(can.Album.IDAlbum)
            item.SubItems.Add(can.OrdenCancion)
            lstReport1.Items.Add(item)
        Next
    End Sub

    ' ===============
    ' INFORME 2
    ' ===============

    Private Sub Update_Report2()
        lstReport2.Items.Clear()
        CB_Artist_Report2.Items.Clear()

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Report2.Items.Add(a)
        Next
    End Sub

    Private Sub CB_Artist_Report2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Artist_Report2.SelectedIndexChanged

        lstReport2.Items.Clear()
        Dim a As Artista = CB_Artist_Report2.SelectedItem
        Dim al As Album = New Album
        a.ArtDAO.AlbumesInforme2.Clear()
        Try
            al.LeerTodosAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        a.Informe2()
        Dim albumActualizados As New List(Of Album)

        For Each alb As Album In a.ArtDAO.AlbumesInforme2
            alb.LeerAlbum()
            For Each alb1 As Album In al.AlbDAO.Albumes
                If alb1.IDAlbum = alb.IDAlbum Then
                    alb.NomAlbum = alb1.NomAlbum
                    alb.AnoAlbum = alb1.AnoAlbum
                    alb.Artista = alb1.Artista
                    albumActualizados.Add(alb)
                    Exit For
                End If
            Next
        Next

        For Each alb As Album In albumActualizados
            Dim item As New ListViewItem
            item.Text = alb.IDAlbum
            item.SubItems.Add(alb.NomAlbum)
            item.SubItems.Add(alb.AnoAlbum)
            alb.Artista.LeerArtista()
            item.SubItems.Add(alb.Artista.IDArtista)
            lstReport2.Items.Add(item)
        Next

    End Sub


    ' ===============
    ' INFORME 3
    ' ===============

    Private Sub Update_Report3()
        lstReport3.Items.Clear()
    End Sub


    Private Sub ButtonFind_Report3_Click(sender As Object, e As EventArgs) Handles ButtonFind_Report3.Click

        lstReport3.Items.Clear()
        Dim al As Album = New Album
        Dim a As Artista = New Artista
        Try
            a.LeerTodosArtistas()
            al.LeerTodosAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each artista As Artista In a.ArtDAO.Artistas
            a.Informe3()
        Next

        Dim artistasActualizados As New List(Of Artista)

        For Each art As Artista In a.ArtDAO.ArtistasInforme3
            art.LeerArtista()
            For Each art1 As Artista In a.ArtDAO.Artistas
                If art1.IDArtista = art.IDArtista Then
                    art.NomArtista = art1.NomArtista
                    art.Pais = art1.Pais
                    artistasActualizados.Add(art)
                    Exit For
                End If
            Next
        Next

        For Each art As Artista In artistasActualizados
            Dim item As New ListViewItem
            item.Text = a.IDArtista
            item.SubItems.Add(a.NomArtista)
            a.Pais.LeerPais()
            item.SubItems.Add(a.Pais.NomPais)
            lstReport3.Items.Add(item)
        Next

    End Sub


    ' ===============
    ' INFORME 4
    ' ===============

    Private Sub Update_Report4()
        lstReport4.Items.Clear()
    End Sub

    Private Sub ButtonFind_Report4_Click(sender As Object, e As EventArgs) Handles ButtonFind_Report4.Click
        lstReport4.Items.Clear()
        Dim c As Cancion = New Cancion
        Try
            c.LeerTodasCanciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        c.Informe4()
        Dim cancionesActualizadas As New List(Of Cancion)

        For Each can As Cancion In c.CanDAO.CancionesInforme4
            can.LeerCancion()
            For Each can1 As Cancion In c.CanDAO.Canciones
                If can1.IDCancion = can.IDCancion Then
                    can.NomCancion = can1.NomCancion
                    can.Duracion = can1.Duracion
                    can.Album = can1.Album
                    can.OrdenCancion = can1.OrdenCancion
                    cancionesActualizadas.Add(can)
                    Exit For
                End If
            Next
        Next

        For Each can As Cancion In cancionesActualizadas
            Dim item As New ListViewItem
            item.Text = can.IDCancion
            item.SubItems.Add(can.NomCancion)
            item.SubItems.Add(can.Duracion)
            can.Album.LeerAlbum()
            item.SubItems.Add(can.Album.IDAlbum)
            item.SubItems.Add(can.OrdenCancion)
            lstReport4.Items.Add(item)
        Next

    End Sub

    ' ===============
    ' INFORME 5
    ' ===============

    Private Sub Update_Report5()
        lstReport5.Items.Clear()
    End Sub


    Private Sub ButtonFind_Report5_Click(sender As Object, e As EventArgs) Handles ButtonFind_Report5.Click
        lstReport5.Items.Clear()
        Dim fechainicio As Date = DTP_Start_R5.Text
        Dim fechafinal As Date = DTP_End_R5.Text
        Dim a As Artista = New Artista
        Try
            a.LeerTodosArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        a.Informe5(fechainicio, fechafinal)
        Dim artistasActualizados As New List(Of Artista)

        For Each art As Artista In a.ArtDAO.ArtistasInforme5
            art.LeerArtista()
            For Each art1 As Artista In a.ArtDAO.Artistas
                If art1.IDArtista = art.IDArtista Then
                    art.NomArtista = art1.NomArtista
                    art.Pais = New Pais(art1.Pais.IDPais, art1.Pais.NomPais)
                    artistasActualizados.Add(art)
                    Exit For
                End If
            Next
        Next

        For Each art As Artista In artistasActualizados
            Dim item As New ListViewItem
            item.Text = art.IDArtista
            item.SubItems.Add(art.NomArtista)
            art.Pais.LeerPais()
            item.SubItems.Add(art.Pais.IDPais)
            lstReport5.Items.Add(item)
        Next

    End Sub

    ' ===============
    ' INFORME 6
    ' ===============

    Private Sub Update_Report6()
        lstReport6.Items.Clear()
    End Sub

    Private Sub ButtonFind_Report6_Click(sender As Object, e As EventArgs) Handles ButtonFind_Report6.Click
        lstReport6.Items.Clear()
        Dim fechainicio As Date = Me.DTP_Start_R6.Text
        Dim fechafinal As Date = Me.DTP_End_R6.Text
        Dim p As Pais = New Pais
        Try
            p.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        p.Informe6(fechainicio, fechafinal)
        For Each pa As Pais In p.PaiDAO.PaisesInforme6
            Dim item As New ListViewItem
            item.Text = pa.IDPais
            item.SubItems.Add(pa.NomPais)
            lstReport6.Items.Add(item)
        Next
    End Sub

    ' ===============
    ' PESTAÑA ARTISTA
    ' ===============

    Private Sub lstArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtist.SelectedIndexChanged
        Me.TB_Id_Artist.Text = String.Empty
        Dim art As Artista
        If Not Me.lstArtist.SelectedItems Is Nothing AndAlso Me.lstArtist.SelectedItems.Count > 0 Then
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

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Me.TB_Id_Country.Text = String.Empty
        Dim pai As Pais
        If Not Me.lstCountries.SelectedItems Is Nothing AndAlso Me.lstCountries.SelectedItems.Count > 0 Then
            Try
                pai = New Pais(lstCountries.SelectedItems(0).SubItems(0).Text, lstCountries.SelectedItems(0).SubItems(1).Text)
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
        If Not Me.lstSites.SelectedItems Is Nothing AndAlso Me.lstSites.SelectedItems.Count > 0 Then
            Try
                sit = New Sitio(lstSites.SelectedItems(0).SubItems(0).Text, lstSites.SelectedItems(0).SubItems(1).Text)
                sit.LeerSitio()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id_Site.Text = sit.IDSitio
            Me.TB_Name_Site.Text = sit.NomSitio
        End If
    End Sub

    ' ===============
    ' PESTAÑA ALBUMES
    ' ===============

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Me.TB_ID_Album.Text = String.Empty
        Dim alb As Album
        If Not Me.lstAlbumes.SelectedItems Is Nothing AndAlso Me.lstAlbumes.SelectedItems.Count > 0 Then
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
        If Not Me.lstSong.SelectedItems Is Nothing AndAlso Me.lstSong.SelectedItems.Count > 0 Then
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


    ' ===========================
    ' PESTAÑAS NAVEGACIÓN ARTISTA
    ' ===========================

    Private Sub CB_Artist_Navegation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Artist_Navegation.SelectedIndexChanged

        lstConcert_Artist.Items.Clear()


        Dim art As Artista = CB_Artist_Navegation.SelectedItem

        If art IsNot Nothing Then
            art.LeerArtista()

            Dim con As Concierto = New Concierto
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

        End If

        'Filtro Pais Enabled

        If CB_Artist_Navegation.SelectedItem IsNot Nothing Then
            CB_Country_Navegation.Enabled = True
        End If

    End Sub

    'FILTRO PAIS

    Private Sub CB_Country_Navegation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Country_Navegation.SelectedIndexChanged

        lstConcert_Artist.Items.Clear()

        Dim pai As Pais = CB_Country_Navegation.SelectedItem
        If pai IsNot Nothing Then
            pai.LeerPais()

            Dim sit As Sitio = New Sitio
            sit.Pais = pai

            Dim art As Artista = New Artista
            art = CB_Artist_Navegation.SelectedItem
            art.LeerArtista()

            Dim con As Concierto = New Concierto
            con.ConDAO.LeerPorArtistaFiltrado(art, sit)

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

        End If
    End Sub


    Private Sub lstConcert_Artist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConcert_Artist.SelectedIndexChanged

        lstSetlist_Artist.Items.Clear()

        Dim con As Concierto
        Dim can As Cancion = New Cancion

        If Me.lstConcert_Artist.SelectedItems.Count > 0 Then
            Try
                con = New Concierto(lstConcert_Artist.SelectedItems(0).SubItems(0).Text)
                con.LeerConcierto()
                con.LeerSetlist()
                Try
                    can.LeerTodasCanciones()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                If con.Canciones IsNot Nothing Then
                    For Each c As Cancion In con.Canciones
                        Dim item As New ListViewItem
                        item.Text = c.IDCancion
                        item.SubItems.Add(c.NomCancion)
                        item.SubItems.Add(c.Duracion)
                        c.Album.LeerAlbum()
                        item.SubItems.Add(c.Album.IDAlbum)
                        item.SubItems.Add(c.OrdenCancion)
                        lstSetlist_Artist.Items.Add(item)
                        lstSetlist_Artist.Refresh()
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub


    ' =========================
    ' PESTAÑAS NAVEGACIÓN SITIO
    ' =========================

    Private Sub CB_Site_Navegation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Site_Navegation.SelectedIndexChanged

        lstConcert_Site.Items.Clear()

        Dim sit As Sitio = CB_Site_Navegation.SelectedItem
        If sit IsNot Nothing Then
            sit.LeerSitio()

            Dim con As Concierto = New Concierto
            con.ConDAO.LeerPorSitio(sit)

            For Each c As Concierto In con.ConDAO.Conciertos
                Dim item As New ListViewItem
                item.Text = c.IDConcierto
                c.Artista.LeerArtista()
                item.SubItems.Add(c.Artista.NomArtista)
                c.Sitio.LeerSitio()
                item.SubItems.Add(c.Sitio.NomSitio)
                item.SubItems.Add(c.FechaConcierto)
                lstConcert_Site.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub lstConcert_Site_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConcert_Site.SelectedIndexChanged

        lstSetlist_Site.Items.Clear()

        Dim con As Concierto
        Dim can As Cancion = New Cancion

        If Me.lstConcert_Site.SelectedItems.Count > 0 Then
            Try
                con = New Concierto(lstConcert_Site.SelectedItems(0).SubItems(0).Text)
                con.LeerConcierto()
                con.LeerSetlist()
                Try
                    can.LeerTodasCanciones()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                If con.Canciones IsNot Nothing Then
                    For Each c As Cancion In con.Canciones
                        Dim item As New ListViewItem
                        item.Text = c.IDCancion
                        item.SubItems.Add(c.NomCancion)
                        item.SubItems.Add(c.Duracion)
                        c.Album.LeerAlbum()
                        item.SubItems.Add(c.Album.IDAlbum)
                        item.SubItems.Add(c.OrdenCancion)
                        lstSetlist_Site.Items.Add(item)
                        lstSetlist_Site.Refresh()
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub



    ' =========================================================================================================
    ' BOTONES FUNCIONES
    ' =========================================================================================================

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
            Case "TabNavegation"
                NavegationClearAll()
        End Select
    End Sub


    ' =========================================================================================================
    ' MÉTODOS
    ' =========================================================================================================

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
        lstCountries.Items.Clear()
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
            lstCountries.Items.Add(item)
        Next
        ' Añade columnas al listView de Países
        lstCountries.View = View.Details
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
        For Each item As ListViewItem In lstCountries.Items
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
        For Each item As ListViewItem In lstCountries.Items
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
        CB_Artist_Concert.SelectedIndex = -1
        CB_Site_Concert.SelectedIndex = -1
        lstConcertSongs.Items.Clear()
    End Sub

    ' ---------------------
    ' CONCERT UPDATE CONTROL
    ' ----------------------

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

            Dim songFound As Boolean = False
            For Each item As ListViewItem In lstConcertSongs.Items
                If item.SubItems(0).Text = c.IDCancion Then
                    songFound = True
                    Exit For
                End If
            Next

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

                    Exit Sub
                End If

            Catch ex As Exception

                Exit Sub
            End Try
        Next
        For Each item As ListViewItem In lstAllSongs.Items
            Dim can As Cancion = New Cancion
            can.IDCancion = item.SubItems(0).Text
            can.LeerCancion()
            Try
                If c.ActualizarSetlistRemove(can) <> 1 Then

                    Exit Sub
                End If

            Catch ex As Exception

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

        For Each item As ListViewItem In lstCountries.Items
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

    ' --------------------
    ' NAVEGATION CLEAR ALL
    ' --------------------

    Private Sub NavegationClearAll()

        lstConcert_Artist.Items.Clear()
        lstConcert_Site.Items.Clear()

        CB_Artist_Navegation.SelectedIndex = -1
        CB_Country_Navegation.SelectedIndex = -1
        CB_Site_Navegation.SelectedIndex = -1

    End Sub

End Class