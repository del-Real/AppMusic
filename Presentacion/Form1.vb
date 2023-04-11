Public Class Form1
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        Dim openFileDialog As New OpenFileDialog()

        'Set the initial directory of the OpenFileDialog
        openFileDialog.InitialDirectory = "C:\"

        'Filter files to display only .txt files
        openFileDialog.Filter = "Text Files (*.mwb)|*.mwb"

        'Display the OpenFileDialog and get the result
        Dim result As DialogResult = openFileDialog.ShowDialog()

        'If the user clicked the OK button, set the selected file path to a textbox
        If result = DialogResult.OK Then
            FilePathTextBox.Text = openFileDialog.FileName
            Me.ButtonConnect.Enabled = True
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click

        Me.ButtonDelete.Enabled = True
        Me.ButtonModify.Enabled = True
        Me.ButtonAdd.Enabled = True
        Me.ButtonClearAll.Enabled = True
        Me.ButtonSelect.Enabled = False
    End Sub

End Class
