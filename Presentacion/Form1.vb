Public Class Form1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim pers As Persona = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty Then
            pers = New Persona(Me.txtID.Text)
            pers.Nombre = Me.txtNombre.Text
            Try
                If pers.InsertarPersona() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'COGIDO AÑADIDO
                lstPersonas.Items.Add(pers.IDPersona)
                MessageBox.Show(pers.Nombre.ToString & " Insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If
    End Sub
End Class
