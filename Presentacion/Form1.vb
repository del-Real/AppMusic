Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AppMusic.Sitio
Imports Mysqlx.Crud

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
        Dim alb As Album = New Album
        Dim art As Artista = New Artista
        'Dim can As Cancion = New Cancion
        'Dim con As Concierto = New Concierto
        Dim pai As Pais = New Pais
        Dim sit As Sitio = New Sitio

        Try
            pai.LeerTodosPaises(ofdRuta.FileName)
            sit.LeerTodosSitios(ofdRuta.FileName)
            art.LeerTodosArtistas(ofdRuta.FileName)
            alb.LeerTodosAlbums(ofdRuta.FileName)
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
        lstContries.Columns.Add("ID", 50)
        lstContries.Columns.Add("Name", 100)

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
        lstSites.Columns.Add("Country", 120)
        lstSites.Columns.Add("Type", 100)

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
        lstArtist.Columns.Add("ID", 50)
        lstArtist.Columns.Add("Name", 100)
        lstArtist.Columns.Add("Country", 100)

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
        lstAlbumes.Columns.Add("Artist", 90)

        For Each item As ListViewItem In lstArtist.Items
            Dim a As Artista = New Artista(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Artist_Album.Items.Add(a)
        Next
        CB_Artist_Album.SelectedIndex = -1
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

    ' ==============
    ' PESTAÑA ALBUMES
    ' ==============

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
            'Aquí va el código para añadir un nuevo artista
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
            'Aquí va el código para añadir un nuevo artista
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
            'Aquí va el código para añadir un nuevo artista
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
            sit.Pais = CB_Country_Site.SelectedItem
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
            art = New Artista(Me.TB_Id_Artist.Text)
            art.NomArtista = Me.TB_Name_Artist.Text
            art.Pais = CB_Country_Artist.SelectedItem
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
            art.Pais = CB_Country_Artist.SelectedItem
            Dim item As ListViewItem = lstSites.FindItemWithText(art.IDArtista)
            Dim nomArtista As String = ""
            If item IsNot Nothing Then
                nomArtista = item.SubItems(1).Text
                item.SubItems(1).Text = art.NomArtista
                item.SubItems(2).Text = art.Pais.NomPais
                CB_Country_Site.Items.Remove(nomArtista)
                CB_Country_Site.Items.Add(art.NomArtista)
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
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Site.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                alb = New Album(Me.TB_ID_Album.Text, Me.TB_Name_Album.Text)
                Try
                    If alb.BorrarAlbum() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As ListViewItem = lstSites.FindItemWithText(alb.IDAlbum)
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


End Class
