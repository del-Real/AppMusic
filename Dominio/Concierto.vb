Public Class Concierto
    Public Property IDConcierto As Integer
    Public Property Artista As Artista
    Public Property Sitio As Sitio
    Public Property FechaConcierto As Date
    Public Property Canciones As List(Of Cancion)
    Public ReadOnly Property ConDAO As ConciertoDAO

    Public Sub New(id As Integer, artista As Artista, sitio As Sitio, fecha As Date, canciones As List(Of Cancion))
        Me.IDConcierto = id
        Me.Artista = artista
        Me.Sitio = sitio
        Me.FechaConcierto = fecha
        Me.Canciones = canciones
        Me.ConDAO = New ConciertoDAO
    End Sub

    Public Sub New(id As Integer, nombre As String)
        Me.IDConcierto = id
        Me.ConDAO = New ConciertoDAO
        Me.Canciones = New List(Of Cancion)
    End Sub

    Public Sub New()
        Me.ConDAO = New ConciertoDAO
        Me.Canciones = New List(Of Cancion)
    End Sub

    Public Sub New(id As Integer)
        Me.IDConcierto = id
        Me.ConDAO = New ConciertoDAO
    End Sub

    Public Sub LeerTodosConciertos()
        Me.ConDAO.LeerTodas()
    End Sub

    Public Sub LeerConcierto()
        Me.ConDAO.Leer(Me)
    End Sub

    Public Function InsertarConcierto() As Integer
        Return Me.ConDAO.Insertar(Me)
    End Function

    Public Function ActualizarConcierto() As Integer
        Return Me.ConDAO.Actualizar(Me)
    End Function

    Public Function BorrarConcierto() As Integer
        Return Me.ConDAO.Borrar(Me)
    End Function

    Public Sub LeerSetlist()
        Me.ConDAO.LeerSetlist(Me)
    End Sub

    Public Function InsertarSetlist(c As Cancion) As Integer
        Return Me.ConDAO.InsertarSetlist(Me, c)
    End Function

    Public Function BorrarSetlist() As Integer
        Return Me.ConDAO.BorrarSetlist(Me)
    End Function

    Public Function ActualizarSetlistAdd(c As Cancion) As Integer
        Return Me.ConDAO.ActualizarSetlistAdd(Me, c)
    End Function

    Public Function ClearSetlist() As Integer
        Return Me.ConDAO.ClearSetlist(Me)
    End Function

End Class
