
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




        'PAISES
        For Each p As Pais In pai.PaiDAO.Paises
            Dim item As New ListViewItem
            item.Text = p.IDPais ' Set the text of the first column to "pai.IDPais"
            item.SubItems.Add(p.NomPais) ' Add the value of "pai.NomPais" to the second column
            lstContries.Items.Add(item)
        Next
        ' Añade columnas al listView
        lstContries.View = View.Details
        lstContries.Columns.Add("ID", 50)
        lstContries.Columns.Add("Name", 100)




        'SITIOS
        For Each s As Sitio In sit.SitDAO.Sitios
            Dim item As New ListViewItem
            item.Text = s.IDSitio ' Set the text of the first column to "pai.IDPais"
            item.SubItems.Add(s.NomSitio) ' Add the value of "pai.NomPais" to the second column
            lstSites.Items.Add(item)
        Next
        ' Añade columnas al listView
        lstSites.View = View.Details
        lstSites.Columns.Add("ID", 40)
        lstSites.Columns.Add("Name", 80)
        lstSites.Columns.Add("CountryID", 40)
        lstSites.Columns.Add("Type", 150)
        'Añadir valores del enum al comboBox 
        CB_Type_Site.Items.Add(TipoSitio.Festival)
        CB_Type_Site.Items.Add(TipoSitio.Hall)
        CB_Type_Site.Items.Add(TipoSitio.Pavilion)
        CB_Type_Site.Items.Add(TipoSitio.Stadium)
        CB_Type_Site.SelectedIndex = -1

        For Each item As ListViewItem In lstContries.Items
            CB_Country_Site.Items.Add(item.SubItems(1).Text)
        Next
        CB_Country_Site.SelectedIndex = -1




        'ARTISTAS
        For Each a As Artista In art.ArtDAO.Artistas
            Dim item As New ListViewItem
            item.Text = a.IDArtista ' Set the text of the first column to "pai.IDPais"
            item.SubItems.Add(a.NomArtista) ' Add the value of "pai.NomPais" to the second column
            item.SubItems.Add("1")
            lstArtist.Items.Add(item)
        Next
        ' Añade columnas al listView
        lstArtist.View = View.Details
        lstArtist.Columns.Add("ID", 50)
        lstArtist.Columns.Add("Name", 100)
        lstArtist.Columns.Add("IDPais", 50)

        For Each item As ListViewItem In lstContries.Items
            CB_Country_Artist.Items.Add(item.SubItems(1).Text)
        Next
        CB_Country_Site.SelectedIndex = -1
    End Sub

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

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Comprobar qué pestaña está activa y realizar la acción correspondiente
        Select Case tabPage.Name
            Case "TabAlbum"
            'Aquí va el código para añadir un nuevo país
            Case "TabArtist"
                Dim art As Artista = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Artist.Text <> String.Empty And Me.TB_Name_Artist.Text <> String.Empty Then
                    art = New Artista(Me.TB_Id_Artist.Text)
                    art.NomArtista = Me.TB_Name_Country.Text
                    Try
                        If art.InsertarArtista() <> 1 Then
                            MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        'COGIDO AÑADIDO
                        Dim item As New ListViewItem
                        item.Text = art.IDArtista ' Set the text of the first column to "pai.IDPais"
                        item.SubItems.Add(art.NomArtista) ' Add the value of "pai.NomPais" to the second column
                        lstArtist.Items.Add(item)
                        CB_Country_Artist.Items.Add(item.SubItems(1).Text)
                        MessageBox.Show(art.NomArtista.ToString & " Insertado correctamente")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Case "TabSong"
            'Aquí va el código para añadir un nuevo artista
            Case "TabConcert"
            'Aquí va el código para añadir una nueva canción
            Case "TabCountry"
                Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Country.Text <> String.Empty And Me.TB_Name_Country.Text <> String.Empty Then
                    pai = New Pais(Me.TB_Id_Country.Text)
                    pai.NomPais = Me.TB_Name_Country.Text
                    Try
                        If pai.InsertarPais() <> 1 Then
                            MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        'COGIDO AÑADIDO
                        Dim item As New ListViewItem
                        item.Text = pai.IDPais ' Set the text of the first column to "pai.IDPais"
                        item.SubItems.Add(pai.NomPais) ' Add the value of "pai.NomPais" to the second column
                        lstContries.Items.Add(item)
                        CB_Country_Site.Items.Add(item.SubItems(1).Text)
                        MessageBox.Show(pai.NomPais.ToString & " Insertado correctamente")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Case "TabSite"
                Dim sit As Sitio = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Site.Text <> String.Empty And Me.TB_Name_Site.Text <> String.Empty Then
                    sit = New Sitio(Me.TB_Id_Site.Text)
                    sit.NomSitio = Me.TB_Name_Site.Text
                    sit.tipo = DirectCast([Enum].Parse(GetType(TipoSitio), CB_Type_Site.SelectedItem.ToString()), TipoSitio)
                    sit.Pais = New Pais(1, CB_Country_Site.Text)
                    sit.Pais = CB_Country_Site.SelectedItem
                    Try
                        If sit.InsertarSitio() <> 1 Then
                            MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        'COGIDO AÑADIDO
                        Dim item As New ListViewItem
                        item.Text = sit.IDSitio
                        item.SubItems.Add(sit.NomSitio)
                        item.SubItems.Add("1")
                        item.SubItems.Add(sit.tipo.ToString)
                        lstSites.Items.Add(item)
                        MessageBox.Show(sit.NomSitio.ToString & " Insertado correctamente")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
        End Select

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Comprobar qué pestaña está activa y realizar la acción correspondiente
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
                Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Country.Text <> String.Empty Then
                    If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Country.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        pai = New Pais(Me.TB_Id_Country.Text, Me.TB_Name_Country.Text)
                        Try
                            If pai.BorrarPais() <> 1 Then
                                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            'COGIDO AÑADIDO
                            Dim item As ListViewItem = lstContries.FindItemWithText(pai.IDPais) ' Buscamos el elemento con el texto "Elemento 2"
                            If item IsNot Nothing Then ' Comprobamos que se haya encontrado el elemento
                                lstContries.Items.Remove(item)
                                CB_Country_Site.Items.Remove(item.SubItems(1).Text)
                            End If
                            MessageBox.Show(pai.NomPais.ToString & " eliminado correctamente")
                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub

                        End Try
                        'CODIGO ERRONEO
                        'Me.lstPersonas.Items.Remove(pers.IDPersona)
                        'Me.bntEliminar.PerformClick()
                    End If
                End If
            Case "TabSite"
                Dim sit As Sitio = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Site.Text <> String.Empty Then
                    If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id_Site.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        sit = New Sitio(Me.TB_Id_Site.Text, Me.TB_Name_Site.Text)
                        Try
                            If sit.BorrarSitio() <> 1 Then
                                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            'COGIDO AÑADIDO
                            Dim item As ListViewItem = lstSites.FindItemWithText(sit.IDSitio) ' Buscamos el elemento con el texto "Elemento 2"
                            If item IsNot Nothing Then ' Comprobamos que se haya encontrado el elemento
                                lstSites.Items.Remove(item)
                            End If
                            MessageBox.Show(sit.NomSitio.ToString & " eliminado correctamente")
                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub

                        End Try
                        'CODIGO ERRONEO
                        'Me.lstPersonas.Items.Remove(pers.IDPersona)
                        'Me.bntEliminar.PerformClick()
                    End If
                End If
        End Select

    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Comprobar qué pestaña está activa y realizar la acción correspondiente
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
                Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Country.Text <> String.Empty And Me.TB_Name_Country.Text <> String.Empty Then
                    pai = New Pais(Me.TB_Id_Country.Text)
                    pai.NomPais = Me.TB_Name_Country.Text
                    Dim item As ListViewItem = lstContries.FindItemWithText(pai.IDPais) ' Buscamos el elemento con el texto "Elemento 2"
                    Dim nomPais As String = ""
                    If item IsNot Nothing Then
                        ' Si se encontró el elemento con el ID de país buscado, obtener el nombre del país de la columna 1
                        nomPais = item.SubItems(1).Text

                        item.SubItems(1).Text = pai.NomPais ' Modificamos el texto del elemento encontrado
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
            Case "TabSite"
                Dim sit As Sitio = Nothing 'INICIALIZADA VARIABLE POR WARNING
                If Me.TB_Id_Site.Text <> String.Empty And Me.TB_Name_Site.Text <> String.Empty And Me.CB_Country_Site.Text <> String.Empty And Me.CB_Type_Site.Text <> String.Empty Then
                    sit = New Sitio(Me.TB_Id_Site.Text)
                    sit.NomSitio = Me.TB_Name_Site.Text
                    sit.Pais = New Pais(1, Me.CB_Country_Site.Text)
                    sit.tipo = CB_Type_Site.Text
                    Dim item As ListViewItem = lstSites.FindItemWithText(sit.IDSitio) ' Buscamos el elemento con el texto "Elemento 2"
                    Dim nomSitio As String = ""
                    If item IsNot Nothing Then
                        ' Si se encontró el elemento con el ID de país buscado, obtener el nombre del país de la columna 1
                        nomSitio = item.SubItems(1).Text
                        item.SubItems(1).Text = sit.NomSitio ' Modificamos el texto del elemento encontrado
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
        End Select

    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearAll.Click
        Dim tabPage As TabPage = TabControl.SelectedTab

        'Comprobar qué pestaña está activa y realizar la acción correspondiente
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
                Me.TB_Id_Country.Text = String.Empty
                Me.TB_Name_Country.Text = String.Empty
            Case "TabSite"
                Me.TB_Id_Site.Text = String.Empty
                Me.TB_Name_Site.Text = String.Empty
                CB_Country_Site.SelectedIndex = -1
                CB_Type_Site.SelectedIndex = -1
        End Select
    End Sub
End Class