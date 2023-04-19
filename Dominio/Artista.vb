Public Class Artista
    Public Property IDArtista As Integer
    Public Property NomArtista As String
    Public Property Pais As Pais
    Public ReadOnly Property ArtDAO As ArtistaDAO

    Public Sub New(id As Integer, nombre As String, pais As Pais)
        Me.IDArtista = id
        Me.NomArtista = nombre
        Me.Pais = pais
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub New(id As Integer, nombre As String)
        Me.IDArtista = id
        Me.NomArtista = nombre
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub New()
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub New(id As Integer)
        Me.IDArtista = id
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub LeerTodosArtistas(ruta As String)
        Me.ArtDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerArtista()
        Me.ArtDAO.Leer(Me)
    End Sub

    Public Function InsertarArtista() As Integer
        Return Me.ArtDAO.Insertar(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtDAO.Actualizar(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtDAO.Borrar(Me)
    End Function

End Class
