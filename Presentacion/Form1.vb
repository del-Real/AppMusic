Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx.Crud

Public Class Form1
    Public ReadOnly Property Paises As Collection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
        'Dim alb As Album = New Album
        'Dim art As Artista = New Artista
        'Dim can As Cancion = New Cancion
        'Dim con As Concierto = New Concierto
        Dim pai As Pais = New Pais
        Dim sit As Sitio = New Sitio
        Try
            pai.LeerTodosPaises(ofdRuta.FileName)
            sit.LeerTodosSitios(ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'PAISES
        For Each p As Pais In pai.PaiDAO.Paises
            Dim item As New ListViewItem
            item.Text = p.IDPais ' Set the text of the first column to "pai.IDPais"
            item.SubItems.Add(p.NomPais) ' Add the value of "pai.NomPais" to the second column
            lstPaises.Items.Add(item)
        Next
        ' Añade columnas al listView
        lstPaises.View = View.Details
        lstPaises.Columns.Add("ID", 50)
        lstPaises.Columns.Add("Name", 100)

        'SITIOS
        For Each s As Sitio In sit.SitDAO.Sitios
            Dim item As New ListViewItem
            item.Text = s.IDSitio ' Set the text of the first column to "pai.IDPais"
            item.SubItems.Add(s.NomSitio) ' Add the value of "pai.NomPais" to the second column
            lstSitios.Items.Add(item)
        Next
        ' Añade columnas al listView
        lstSitios.View = View.Details
        lstSitios.Columns.Add("ID", 50)
        lstSitios.Columns.Add("Name", 100)

        'Añadir valores del anum al comboBox 
        CB_Type_Site.Items.Add(sit.TipoSitio.Estadio)
        CB_Type_Site.Items.Add(sit.TipoSitio.Festival)
        CB_Type_Site.Items.Add(sit.TipoSitio.Pabellon)
        CB_Type_Site.Items.Add(sit.TipoSitio.Sala)
        CB_Type_Site.SelectedIndex = 0
    End Sub

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim pai As Pais
        If Not Me.lstPaises.SelectedItems Is Nothing Then
            Try
                pai = New Pais(lstPaises.SelectedItems.ToString)
                pai.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.Id_Country.Text = pai.IDPais
            Me.TB_Name.Text = pai.NomPais
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs)
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.Id_Country.Text <> String.Empty And Me.TB_Name.Text <> String.Empty Then
            pai = New Pais(Me.Id_Country.Text)
            pai.NomPais = Me.TB_Name.Text
            Try
                If pai.InsertarPais() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'COGIDO AÑADIDO
                Dim item As New ListViewItem
                item.Text = pai.IDPais ' Set the text of the first column to "pai.IDPais"
                item.SubItems.Add(pai.NomPais) ' Add the value of "pai.NomPais" to the second column
                lstPaises.Items.Add(item)
                MessageBox.Show(pai.NomPais.ToString & " Insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs)
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.Id_Country.Text <> String.Empty Then

            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.Id_Country.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pai = New Pais(Me.Id_Country.Text, Me.TB_Name.Text)
                Try
                    If pai.BorrarPais() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    'COGIDO AÑADIDO
                    Dim item As ListViewItem = lstPaises.FindItemWithText(pai.IDPais) ' Buscamos el elemento con el texto "Elemento 2"
                    If item IsNot Nothing Then ' Comprobamos que se haya encontrado el elemento
                        lstPaises.Items.Remove(item)
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

    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs)
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.Id_Country.Text <> String.Empty And Me.TB_Name.Text <> String.Empty Then
            pai = New Pais(Me.Id_Country.Text)
            pai.NomPais = Me.TB_Name.Text
            Dim item As ListViewItem = lstPaises.FindItemWithText(pai.IDPais) ' Buscamos el elemento con el texto "Elemento 2"
            If item IsNot Nothing Then ' Comprobamos que se haya encontrado el elemento
                item.SubItems(1).Text = pai.NomPais ' Modificamos el texto del elemento encontrado
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

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs)
        Me.Id_Country.Text = String.Empty
        Me.TB_Name.Text = String.Empty
    End Sub

    Private Sub lstPaises_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstPaises.SelectedIndexChanged

    End Sub

    Private Sub TB_Name_TextChanged(sender As Object, e As EventArgs) Handles TB_Name.TextChanged

    End Sub

    Private Sub ButtonAdd_Click_1(sender As Object, e As EventArgs) Handles ButtonAdd.Click

    End Sub

    Private Sub ButtonClearAll_Click_1(sender As Object, e As EventArgs) Handles ButtonClearAll.Click

    End Sub

    Private Sub Id_Country_TextChanged(sender As Object, e As EventArgs) Handles Id_Country.TextChanged

    End Sub
End Class
