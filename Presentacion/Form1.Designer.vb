<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ButtonClearAll = New Button()
        ButtonDelete = New Button()
        ButtonModify = New Button()
        ButtonAdd = New Button()
        Label2 = New Label()
        TB_Name = New TextBox()
        Label1 = New Label()
        TB_Id = New TextBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Label3 = New Label()
        ButtonSelect = New Button()
        ButtonConnect = New Button()
        Label4 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Location = New Point(230, 35)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(344, 358)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ButtonClearAll)
        TabPage1.Controls.Add(ButtonDelete)
        TabPage1.Controls.Add(ButtonModify)
        TabPage1.Controls.Add(ButtonAdd)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(TB_Name)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(TB_Id)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(336, 330)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Album"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' ButtonClearAll
        ' 
        ButtonClearAll.Location = New Point(47, 242)
        ButtonClearAll.Name = "ButtonClearAll"
        ButtonClearAll.Size = New Size(237, 23)
        ButtonClearAll.TabIndex = 7
        ButtonClearAll.Text = "Limpiar campos"
        ButtonClearAll.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(209, 202)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(75, 23)
        ButtonDelete.TabIndex = 6
        ButtonDelete.Text = "Eliminar"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonModify
        ' 
        ButtonModify.Location = New Point(128, 202)
        ButtonModify.Name = "ButtonModify"
        ButtonModify.Size = New Size(75, 23)
        ButtonModify.TabIndex = 5
        ButtonModify.Text = "Modificar"
        ButtonModify.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Location = New Point(47, 202)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(75, 23)
        ButtonAdd.TabIndex = 4
        ButtonAdd.Text = "Añadir"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' TB_Name
        ' 
        TB_Name.Location = New Point(47, 139)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(237, 23)
        TB_Name.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        ' 
        ' TB_Id
        ' 
        TB_Id.Location = New Point(47, 73)
        TB_Id.Name = "TB_Id"
        TB_Id.Size = New Size(237, 23)
        TB_Id.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(336, 330)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Artista"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(336, 330)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Canción"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(336, 330)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Concierto"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(336, 330)
        TabPage5.TabIndex = 4
        TabPage5.Text = "País"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.RightToLeft = RightToLeft.No
        TabPage6.Size = New Size(336, 330)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Sitio"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(26, 59)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(178, 334)
        ListBox1.TabIndex = 1
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(234, 408)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 94)
        ListBox2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(26, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 21)
        Label3.TabIndex = 3
        Label3.Text = "🎵 App Music"
        ' 
        ' ButtonSelect
        ' 
        ButtonSelect.Location = New Point(26, 439)
        ButtonSelect.Name = "ButtonSelect"
        ButtonSelect.Size = New Size(178, 23)
        ButtonSelect.TabIndex = 4
        ButtonSelect.Text = "Seleccionar"
        ButtonSelect.UseVisualStyleBackColor = True
        ' 
        ' ButtonConnect
        ' 
        ButtonConnect.Location = New Point(26, 479)
        ButtonConnect.Name = "ButtonConnect"
        ButtonConnect.Size = New Size(178, 23)
        ButtonConnect.TabIndex = 5
        ButtonConnect.Text = "Conectar"
        ButtonConnect.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 408)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 6
        Label4.Text = "Base de Datos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(602, 539)
        Controls.Add(Label4)
        Controls.Add(ButtonConnect)
        Controls.Add(ButtonSelect)
        Controls.Add(Label3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Id As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label4 As Label
End Class
