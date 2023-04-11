# AppMusic


Cómo organizar la interfaz
-------------------------

- Cuadros texto para input -> ID, Nombre

- Botones -> Añadir, Actualizar, Eliminar, Limpiar y CONECTAR

- Cuadro texto -> DB idPersonas (ListBox o ListView configurando por columnas (ColumnHeader), 
crear objeto ListViewItem y asignar valor concreto de cada una de las columnas)

- ComboBox -> Desplegable para seleccionar artista de un país concreto

- Date TimePicker -> para seleccionar la fecha ya formateada

- Tab Control -> (Pestañas para Países, albumes...)

- NumericUpDown -> contador 

```
Public Overrides FUnction Totring() As String
	Return IDPersona & ""& Nombre
End Function
```

Debe de ser usable: no abusar de los TextBox, que se muestre información completa
Al hcer doble click en la barra de la ventana del formulario crea un método que gestiona
la carga del formulario (por si elegimos la opción de crear varios formularios)


Instalación conector (AgenteDB)
-------------------------------

Desde MySQL Installer -> instalar Connector 8.0/NET
Botón derecho sobre carpeta Dependencies -> Browse/Examinar -> Archivos de programa (x86) -> MySQL -> Connector NET 8.0 ->
-> Assemblies -> net7.0 -> MySql.Data.dll


