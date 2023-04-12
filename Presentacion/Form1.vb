Public Class Form1
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        Me.ofdRuta.InitialDirectory = Application.StartupPath
        If (Me.ofdRuta.ShowDialog() = DialogResult.OK) Then
            Me.FilePathTextBox.Text = Me.ofdRuta.FileName
            Me.ButtonConnect.Enabled = True
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Dim alb As Album = New Album
        Dim art As Artista = New Artista
        Dim can As Cancion = New Cancion
        Dim con As Concierto = New Concierto
        Dim pai As Pais = New Pais
        Dim sit As Sitio = New Sitio
        Try
            alb.LeerTodosAlbums(ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each a As Album In alb.AlbDAO.Albumes
            Me.lstAlbumes.Items.Add(a.IDAlbum)
        Next
        Me.ButtonDelete.Enabled = True
        Me.ButtonModify.Enabled = True
        Me.ButtonAdd.Enabled = True
        Me.ButtonClearAll.Enabled = True
        Me.ButtonSelect.Enabled = False
    End Sub

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Dim alb As Album
        If Not Me.lstAlbumes.SelectedItems Is Nothing Then
            Try
                alb = New Album(lstAlbumes.SelectedItem.ToString)
                alb.LeerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id.Text = alb.IDAlbum
            Me.TB_Name.Text = alb.NomAlbum
        End If
    End Sub
End Class
