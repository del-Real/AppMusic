Public Class Form1

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
    End Sub
End Class
