﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spotifake"
        'Dim alb As Album = New Album
        'Dim art As Artista = New Artista
        'Dim can As Cancion = New Cancion
        'Dim con As Concierto = New Concierto
        Dim pai As Pais = New Pais
        'Dim sit As Sitio = New Sitio
        Try
            pai.LeerTodosPaises(ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each p As Pais In pai.PaiDAO.Paises
            Me.lstPaises.Items.Add(p.IDPais)
        Next

        ' Añade columnas al listView
        lstPaises.View = View.Details
        lstPaises.Columns.Add("ID", 50)
        lstPaises.Columns.Add("Name", 100)

    End Sub

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim pai As Pais
        If Not Me.lstPaises.SelectedItems Is Nothing Then
            Try
                pai = New Pais(lstPaises.SelectedItems.ToString)
                pai.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.TB_Id.Text = pai.IDPais
            Me.TB_Name.Text = pai.NomPais
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.TB_Id.Text <> String.Empty And Me.TB_Name.Text <> String.Empty Then
            pai = New Pais(Me.TB_Id.Text)
            pai.NomPais = Me.TB_Name.Text
            Try
                If pai.InsertarPais() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'COGIDO AÑADIDO
                lstPaises.Items.Add(pai.IDPais & " " & pai.NomPais)
                MessageBox.Show(pai.NomPais.ToString & " Insertado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.TB_Id.Text <> String.Empty Then

            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.TB_Id.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pai = New Pais(Me.TB_Id.Text, Me.TB_Name.Text)
                Try
                    If pai.BorrarPais() <> 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    'COGIDO AÑADIDO
                    For Each item As ListViewItem In lstPaises.SelectedItems
                        lstPaises.Items.Remove(item)
                    Next

                    MessageBox.Show(pai.NomPais.ToString & " Eliminado correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End Try
                'CODIGO ERRONEO
                'Me.lstPersonas.Items.Remove(pers.IDPersona)
                'Me.bntEliminar.PerformClick()
            End If
        End If

    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Dim pai As Pais = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.TB_Id.Text <> String.Empty And Me.TB_Name.Text <> String.Empty Then
            pai = New Pais(Me.TB_Id.Text)
            pai.NomPais = Me.TB_Id.Text
            Try
                If pai.ActualizarPais() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show(pai.NomPais.ToString & " Actualizado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearAll.Click
        Me.TB_Id.Text = String.Empty
        Me.TB_Name.Text = String.Empty
    End Sub

    Private Sub lstPaises_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstPaises.SelectedIndexChanged

    End Sub
End Class
