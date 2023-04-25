Public Class Pais
    Public Property IDPais As String
    Public Property NomPais As String
    Public ReadOnly Property PaiDAO As PaisDAO

    Public Sub New(id As String, nombre As String)
        Me.IDPais = id
        Me.NomPais = nombre
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub New()
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.IDPais = id
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaiDAO.LeerTodos()
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

    Public Overrides Function toString() As String
        Return Me.IDPais & " " & Me.NomPais
    End Function
End Class