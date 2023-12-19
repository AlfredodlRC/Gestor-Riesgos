<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_datos_basicos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ImageList1 = New ImageList(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tbCodigo = New TextBox()
        tbNombre = New TextBox()
        tb_fecha_creacion = New TextBox()
        tbDescripcion = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tipo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 1
        Label2.Text = "Código:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nombre:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 3
        Label4.Text = "Fecha creación:"
        ' 
        ' tbCodigo
        ' 
        tbCodigo.Location = New Point(147, 58)
        tbCodigo.Name = "tbCodigo"
        tbCodigo.Size = New Size(125, 27)
        tbCodigo.TabIndex = 4
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(147, 107)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(125, 27)
        tbNombre.TabIndex = 5
        ' 
        ' tb_fecha_creacion
        ' 
        tb_fecha_creacion.Location = New Point(147, 156)
        tb_fecha_creacion.Name = "tb_fecha_creacion"
        tb_fecha_creacion.Size = New Size(125, 27)
        tb_fecha_creacion.TabIndex = 6
        ' 
        ' tbDescripcion
        ' 
        tbDescripcion.Location = New Point(325, 37)
        tbDescripcion.Multiline = True
        tbDescripcion.Name = "tbDescripcion"
        tbDescripcion.Size = New Size(500, 200)
        tbDescripcion.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(530, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 8
        Label5.Text = "Descripción"
        ' 
        ' Panel_datos_basicos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ControlLight
        Controls.Add(Label5)
        Controls.Add(tbDescripcion)
        Controls.Add(tb_fecha_creacion)
        Controls.Add(tbNombre)
        Controls.Add(tbCodigo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Panel_datos_basicos"
        Size = New Size(850, 250)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tb_fecha_creacion As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label5 As Label

End Class
