Public Class Pais
    Public Property IDPais As String
    Public Property NomPais As String
    Public ReadOnly Property PaiDAO As PaisDAO

    Public Sub New(id As String, nombre As String)
        Me.IDPais = id
        Me.NomPais = nombre
        Me.PaiDAO = New PaisDAO
    End Sub
    Public Sub LeerTodosPaises(ruta As String)
        Me.PaiDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerPais()
        Me.PaiDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaiDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaiDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaiDAO.Borrar(Me)
    End Function
End Class
