
Imports AppMusic.Form1
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSetlist.View = View.Details
        lstSetlist.Columns.Add("ID", 40)
        lstSetlist.Columns.Add("Name", 80)
        lstSetlist.Columns.Add("Duration", 40)
        lstSetlist.Columns.Add("Album", 60)
        lstSetlist.Columns.Add("Orden", 40)

        lstSong2.View = View.Details
        lstSong2.Columns.Add("ID", 40)
        lstSong2.Columns.Add("Name", 80)
        lstSong2.Columns.Add("Duration", 40)
        lstSong2.Columns.Add("Album", 60)
        lstSong2.Columns.Add("Orden", 40)

        Update_Song()
    End Sub


    Private Sub ButtonAddSong_Click(sender As Object, e As EventArgs) Handles ButtonAddSong.Click





    End Sub







    Private Sub Update_Song()

        lstSong2.Items.Clear()
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
            item.SubItems.Add(c.Album.NomAlbum)
            item.SubItems.Add(c.OrdenCancion)
            lstSong2.Items.Add(item)
        Next
    End Sub



End Class