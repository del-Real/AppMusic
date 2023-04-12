Public Class Album
    Public Property IDAlbum As Integer
    Public Property NomAlbum As String
    Public Property AnoAlbum As Integer
    Public Property Artista As Artista
    Public ReadOnly Property AlbDAO As AlbumDAO

    Public Sub New(id As Integer, nombre As String, ano As Integer, artista As Artista)
        Me.IDAlbum = id
        Me.NomAlbum = nombre
        Me.AnoAlbum = ano
        Me.Artista = artista
        Me.AlbDAO = New AlbumDAO
    End Sub

    Public Sub New()
        Me.AlbDAO = New AlbumDAO
    End Sub

    Public Sub New(id As Integer)
        Me.IDAlbum = id
        Me.AlbDAO = New AlbumDAO
    End Sub
    Public Sub LeerTodosAlbums(ruta As String)
        Me.AlbDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerAlbum()
        Me.AlbDAO.Leer(Me)
    End Sub

    Public Function InsertarAlbum() As Integer
        Return Me.AlbDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlbum() As Integer
        Return Me.AlbDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlbum() As Integer
        Return Me.AlbDAO.Borrar(Me)
    End Function

End Class

