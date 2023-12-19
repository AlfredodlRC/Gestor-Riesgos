<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_tab_activos
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
        Panel_tabulador = New TabControl()
        pagina_valoracion = New TabPage()
        paginas_criterios = New TabPage()
        pagina_activos_superiores = New TabPage()
        pagina_activos_inferiores = New TabPage()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Panel_tabulador.SuspendLayout()
        pagina_valoracion.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_tabulador
        ' 
        Panel_tabulador.Controls.Add(pagina_valoracion)
        Panel_tabulador.Controls.Add(paginas_criterios)
        Panel_tabulador.Controls.Add(pagina_activos_superiores)
        Panel_tabulador.Controls.Add(pagina_activos_inferiores)
        Panel_tabulador.Location = New Point(0, 0)
        Panel_tabulador.Name = "Panel_tabulador"
        Panel_tabulador.SelectedIndex = 0
        Panel_tabulador.Size = New Size(850, 300)
        Panel_tabulador.TabIndex = 0
        ' 
        ' pagina_valoracion
        ' 
        pagina_valoracion.Controls.Add(ComboBox1)
        pagina_valoracion.Controls.Add(Label2)
        pagina_valoracion.Controls.Add(Label1)
        pagina_valoracion.Controls.Add(NumericUpDown1)
        pagina_valoracion.Location = New Point(4, 29)
        pagina_valoracion.Name = "pagina_valoracion"
        pagina_valoracion.Padding = New Padding(3)
        pagina_valoracion.Size = New Size(842, 267)
        pagina_valoracion.TabIndex = 0
        pagina_valoracion.Text = "Valoración"
        pagina_valoracion.UseVisualStyleBackColor = True
        ' 
        ' paginas_criterios
        ' 
        paginas_criterios.Location = New Point(4, 29)
        paginas_criterios.Name = "paginas_criterios"
        paginas_criterios.Padding = New Padding(3)
        paginas_criterios.Size = New Size(842, 267)
        paginas_criterios.TabIndex = 1
        paginas_criterios.Text = "Criterios"
        paginas_criterios.UseVisualStyleBackColor = True
        ' 
        ' pagina_activos_superiores
        ' 
        pagina_activos_superiores.Location = New Point(4, 29)
        pagina_activos_superiores.Name = "pagina_activos_superiores"
        pagina_activos_superiores.Padding = New Padding(3)
        pagina_activos_superiores.Size = New Size(842, 267)
        pagina_activos_superiores.TabIndex = 2
        pagina_activos_superiores.Text = "Activos superiores"
        pagina_activos_superiores.UseVisualStyleBackColor = True
        ' 
        ' pagina_activos_inferiores
        ' 
        pagina_activos_inferiores.Location = New Point(4, 29)
        pagina_activos_inferiores.Name = "pagina_activos_inferiores"
        pagina_activos_inferiores.Padding = New Padding(3)
        pagina_activos_inferiores.Size = New Size(842, 267)
        pagina_activos_inferiores.TabIndex = 3
        pagina_activos_inferiores.Text = "Activos inferiores"
        pagina_activos_inferiores.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(167, 50)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 20)
        Label1.TabIndex = 1
        Label1.Text = "Valor económico:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 2
        Label2.Text = "Valoración:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(166, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' Panel_tab_activos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_tabulador)
        Name = "Panel_tab_activos"
        Size = New Size(850, 300)
        Panel_tabulador.ResumeLayout(False)
        pagina_valoracion.ResumeLayout(False)
        pagina_valoracion.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_tabulador As TabControl
    Friend WithEvents pagina_valoracion As TabPage
    Friend WithEvents paginas_criterios As TabPage
    Friend WithEvents pagina_activos_superiores As TabPage
    Friend WithEvents pagina_activos_inferiores As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown

End Class
