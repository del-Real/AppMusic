Imports Mysqlx.XDevAPI.Common

Public Class Pais
    Public Property IDPais As String
    Public Property NomPais As String
    Public ReadOnly Property PaiDAO As PaisDAO

    Public Sub New(id As String, nombre As String)
        Me.IDPais = id.ToUpper().Substring(0, 3)
        Me.NomPais = nombre
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub New()
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.IDPais = id.ToUpper().Substring(0, 3)
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub LeerTodosPaises(ruta As String)
        Me.PaiDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerPais()
        Me.PaiDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaiDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaiDAO.Actualizar(Me)
        Dim result As Integer = Me.PaiDAO.Actualizar(Me)
        If result > 0 Then
            ' Actualizar la referencia a IDPais en la tabla artistas y sitio
            AgenteBD.ObtenerAgente.Modificar("UPDATE artistas SET Nacionalidad='" & Me.IDPais & "' WHERE Nacionalidad='" & NomPais & "';")
            AgenteBD.ObtenerAgente.Modificar("UPDATE sitio SET Pais='" & Me.IDPais & "' WHERE Pais='" & IDPais & "';")
        End If
        Return result
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaiDAO.Borrar(Me)
    End Function

    Public Overrides Function toString() As String
        Return Me.IDPais & " " & Me.NomPais
    End Function
End Class
