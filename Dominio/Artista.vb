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

    Public Sub New(id As Integer, pais As Pais)
        Me.IDArtista = id
        Me.Pais = pais
        Me.ArtDAO = New ArtistaDAO
    End Sub


    Public Sub New()
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub New(id As Integer)
        Me.IDArtista = id
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub LeerTodosArtistas()
        Me.ArtDAO.LeerTodos()
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

    Public Sub Informe1()
        Me.ArtDAO.Informe1(Me)
    End Sub

    Public Sub Informe2()
        Me.ArtDAO.Informe2(Me)
    End Sub

    Public Sub Informe3()
        Me.ArtDAO.Informe3()
    End Sub

    Public Sub Informe5(startDate As Date, endDate As Date)
        Me.ArtDAO.Informe5(startDate, endDate)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.IDArtista & " " & Me.NomArtista
    End Function

End Class
