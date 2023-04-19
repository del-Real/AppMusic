
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AppMusic.Sitio
Imports Mysqlx.Crud

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
        'Dim alb As Album = New Album
        Dim art As Artista = New Artista
        'Dim can As Cancion = New Cancion
        'Dim con As Concierto = New Concierto
        Dim pai As Pais = New Pais
        Dim sit As Sitio = New Sitio

        Try
            pai.LeerTodosPaises(ofdRuta.FileName)
            sit.LeerTodosSitios(ofdRuta.FileName)
            art.LeerTodosArtistas(ofdRuta.FileName)
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
            item.SubItems.Add("1")
            lstArtist.Items.Add(item)
        Next
        ' Añade columnas al listView de Artistas
        lstArtist.View = View.Details
        lstArtist.Columns.Add("ID", 50)
        lstArtist.Columns.Add("Name", 100)
        lstArtist.Columns.Add("IDPais", 50)

        For Each item As ListViewItem In lstContries.Items
            Dim p As Pais = New Pais(item.SubItems(0).Text, item.SubItems(1).Text)
            CB_Country_Artist.Items.Add(p)
        Next
        CB_Country_Site.SelectedIndex = -1
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
            'Aquí va el código para añadir un nuevo país
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
            'Aquí va el código para añadir un nuevo país
            Case "TabArtist"
            'Aquí va el código para añadir un nuevo sitio
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
            'Aquí va el código para añadir un nuevo país
            Case "TabArtist"
            'Aquí va el código para añadir un nuevo sitio
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
            'Aquí va el código para añadir un nuevo país
            Case "TabArtist"
            'Aquí va el código para añadir un nuevo sitio
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
    ' COUNTRY METHODS
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
                CB_Country_Site.Items.Add(item.SubItems(1).Text)
                MessageBox.Show(pai.NomPais.ToString & " Insertado correctamente")
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
                        CB_Country_Site.Items.Remove(item.SubItems(1).Text)
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
                CB_Country_Site.Items.Remove(nomPais)
                CB_Country_Site.Items.Add(pai.NomPais)
            End If
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
    ' SITE METHODS
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
            sit.Pais = New Pais(1, Me.CB_Country_Site.Text)
            sit.tipo = CB_Type_Site.Text
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
                MessageBox.Show("Pais con el ID " & sit.IDSitio & " actualizado correctamente a " & sit.NomSitio.ToString)
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
    ' ARTIST METHODS
    ' ===========================================

    ' -----------
    ' ARTIST ADD
    ' -----------

    Private Sub ArtistAdd()

        Dim art As Artista = Nothing
        If Me.TB_Id_Artist.Text <> String.Empty And Me.TB_Name_Artist.Text <> String.Empty Then
            art = New Artista(Me.TB_Id_Artist.Text)
            art.NomArtista = Me.TB_Name_Country.Text
            Try
                If art.InsertarArtista() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim item As New ListViewItem
                item.Text = art.IDArtista
                item.SubItems.Add(art.NomArtista)
                lstArtist.Items.Add(item)
                CB_Country_Artist.Items.Add(item.SubItems(1).Text)
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





    ' --------------
    ' ARTIST MODIFY
    ' --------------





    ' -----------------
    ' ARTIST CLEAR ALL
    ' -----------------




End Class
