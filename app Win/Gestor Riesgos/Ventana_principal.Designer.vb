<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_principal
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
        LBActivos = New ListBox()
        LBAmenazas = New ListBox()
        LBSalvaguardas = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        Menu_archivo = New ToolStripMenuItem()
        Submenu_importar = New ToolStripMenuItem()
        Submenu_salir = New ToolStripMenuItem()
        ActivosToolStripMenuItem = New ToolStripMenuItem()
        Sumenu_activo_listado = New ToolStripMenuItem()
        Sumenu_activo_ver = New ToolStripMenuItem()
        Sumenu_activo_crear = New ToolStripMenuItem()
        Sumenu_activo_modificar = New ToolStripMenuItem()
        Sumenu_activo_eliminar = New ToolStripMenuItem()
        AmenazasToolStripMenuItem = New ToolStripMenuItem()
        Submenu_amenaza_listado = New ToolStripMenuItem()
        Submenu_amenaza_ver = New ToolStripMenuItem()
        Submenu_amenaza_crear = New ToolStripMenuItem()
        Submenu_amenaza_modificar = New ToolStripMenuItem()
        Submenu_amenaza_eliminar = New ToolStripMenuItem()
        SalvaguardasToolStripMenuItem = New ToolStripMenuItem()
        Submenu_salvaguarda_listado = New ToolStripMenuItem()
        Submenu_salvaguarda_ver = New ToolStripMenuItem()
        Submenu_salvaguarda_crear = New ToolStripMenuItem()
        Submenu_salvaguarda_modificar = New ToolStripMenuItem()
        Submenu_salvaguarda_eliminar = New ToolStripMenuItem()
        BBDDToolStripMenuItem = New ToolStripMenuItem()
        Submenu_bbdd_configuración = New ToolStripMenuItem()
        Submenu_bbdd_probar = New ToolStripMenuItem()
        UsuarioToolStripMenuItem = New ToolStripMenuItem()
        Submenu_usuario_login = New ToolStripMenuItem()
        Submenu_usuario_logout = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LBActivos
        ' 
        LBActivos.FormattingEnabled = True
        LBActivos.Location = New Point(9, 151)
        LBActivos.Name = "LBActivos"
        LBActivos.Size = New Size(250, 104)
        LBActivos.TabIndex = 0
        ' 
        ' LBAmenazas
        ' 
        LBAmenazas.FormattingEnabled = True
        LBAmenazas.Location = New Point(275, 151)
        LBAmenazas.Name = "LBAmenazas"
        LBAmenazas.Size = New Size(250, 104)
        LBAmenazas.TabIndex = 1
        ' 
        ' LBSalvaguardas
        ' 
        LBSalvaguardas.FormattingEnabled = True
        LBSalvaguardas.Location = New Point(537, 151)
        LBSalvaguardas.Name = "LBSalvaguardas"
        LBSalvaguardas.Size = New Size(250, 104)
        LBSalvaguardas.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 3
        Label1.Text = "Activos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(362, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 4
        Label2.Text = "Amenazas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(616, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 5
        Label3.Text = "Salvaguarda"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {Menu_archivo, ActivosToolStripMenuItem, AmenazasToolStripMenuItem, SalvaguardasToolStripMenuItem, BBDDToolStripMenuItem, UsuarioToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Menu_archivo
        ' 
        Menu_archivo.DropDownItems.AddRange(New ToolStripItem() {Submenu_importar, Submenu_salir})
        Menu_archivo.Name = "Menu_archivo"
        Menu_archivo.Size = New Size(73, 24)
        Menu_archivo.Text = "Archivo"
        ' 
        ' Submenu_importar
        ' 
        Submenu_importar.Name = "Submenu_importar"
        Submenu_importar.Size = New Size(150, 26)
        Submenu_importar.Text = "Importar"
        ' 
        ' Submenu_salir
        ' 
        Submenu_salir.Name = "Submenu_salir"
        Submenu_salir.Size = New Size(150, 26)
        Submenu_salir.Text = "Salir"
        ' 
        ' ActivosToolStripMenuItem
        ' 
        ActivosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Sumenu_activo_listado, Sumenu_activo_ver, Sumenu_activo_crear, Sumenu_activo_modificar, Sumenu_activo_eliminar})
        ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        ActivosToolStripMenuItem.Size = New Size(71, 24)
        ActivosToolStripMenuItem.Text = "Activos"
        ' 
        ' Sumenu_activo_listado
        ' 
        Sumenu_activo_listado.Name = "Sumenu_activo_listado"
        Sumenu_activo_listado.Size = New Size(156, 26)
        Sumenu_activo_listado.Text = "Listado"
        ' 
        ' Sumenu_activo_ver
        ' 
        Sumenu_activo_ver.Name = "Sumenu_activo_ver"
        Sumenu_activo_ver.Size = New Size(156, 26)
        Sumenu_activo_ver.Text = "Ver"
        ' 
        ' Sumenu_activo_crear
        ' 
        Sumenu_activo_crear.Name = "Sumenu_activo_crear"
        Sumenu_activo_crear.Size = New Size(156, 26)
        Sumenu_activo_crear.Text = "Crear"
        ' 
        ' Sumenu_activo_modificar
        ' 
        Sumenu_activo_modificar.Name = "Sumenu_activo_modificar"
        Sumenu_activo_modificar.Size = New Size(156, 26)
        Sumenu_activo_modificar.Text = "Modificar"
        ' 
        ' Sumenu_activo_eliminar
        ' 
        Sumenu_activo_eliminar.Name = "Sumenu_activo_eliminar"
        Sumenu_activo_eliminar.Size = New Size(156, 26)
        Sumenu_activo_eliminar.Text = "Eliminar"
        ' 
        ' AmenazasToolStripMenuItem
        ' 
        AmenazasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Submenu_amenaza_listado, Submenu_amenaza_ver, Submenu_amenaza_crear, Submenu_amenaza_modificar, Submenu_amenaza_eliminar})
        AmenazasToolStripMenuItem.Name = "AmenazasToolStripMenuItem"
        AmenazasToolStripMenuItem.Size = New Size(91, 24)
        AmenazasToolStripMenuItem.Text = "Amenazas"
        ' 
        ' Submenu_amenaza_listado
        ' 
        Submenu_amenaza_listado.Name = "Submenu_amenaza_listado"
        Submenu_amenaza_listado.Size = New Size(156, 26)
        Submenu_amenaza_listado.Text = "Listado"
        ' 
        ' Submenu_amenaza_ver
        ' 
        Submenu_amenaza_ver.Name = "Submenu_amenaza_ver"
        Submenu_amenaza_ver.Size = New Size(156, 26)
        Submenu_amenaza_ver.Text = "Ver"
        ' 
        ' Submenu_amenaza_crear
        ' 
        Submenu_amenaza_crear.Name = "Submenu_amenaza_crear"
        Submenu_amenaza_crear.Size = New Size(156, 26)
        Submenu_amenaza_crear.Text = "Crear"
        ' 
        ' Submenu_amenaza_modificar
        ' 
        Submenu_amenaza_modificar.Name = "Submenu_amenaza_modificar"
        Submenu_amenaza_modificar.Size = New Size(156, 26)
        Submenu_amenaza_modificar.Text = "Modificar"
        ' 
        ' Submenu_amenaza_eliminar
        ' 
        Submenu_amenaza_eliminar.Name = "Submenu_amenaza_eliminar"
        Submenu_amenaza_eliminar.Size = New Size(156, 26)
        Submenu_amenaza_eliminar.Text = "Eliminar"
        ' 
        ' SalvaguardasToolStripMenuItem
        ' 
        SalvaguardasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Submenu_salvaguarda_listado, Submenu_salvaguarda_ver, Submenu_salvaguarda_crear, Submenu_salvaguarda_modificar, Submenu_salvaguarda_eliminar})
        SalvaguardasToolStripMenuItem.Name = "SalvaguardasToolStripMenuItem"
        SalvaguardasToolStripMenuItem.Size = New Size(111, 24)
        SalvaguardasToolStripMenuItem.Text = "Salvaguardas"
        ' 
        ' Submenu_salvaguarda_listado
        ' 
        Submenu_salvaguarda_listado.Name = "Submenu_salvaguarda_listado"
        Submenu_salvaguarda_listado.Size = New Size(156, 26)
        Submenu_salvaguarda_listado.Text = "Listado"
        ' 
        ' Submenu_salvaguarda_ver
        ' 
        Submenu_salvaguarda_ver.Name = "Submenu_salvaguarda_ver"
        Submenu_salvaguarda_ver.Size = New Size(156, 26)
        Submenu_salvaguarda_ver.Text = "Ver"
        ' 
        ' Submenu_salvaguarda_crear
        ' 
        Submenu_salvaguarda_crear.Name = "Submenu_salvaguarda_crear"
        Submenu_salvaguarda_crear.Size = New Size(156, 26)
        Submenu_salvaguarda_crear.Text = "Crear"
        ' 
        ' Submenu_salvaguarda_modificar
        ' 
        Submenu_salvaguarda_modificar.Name = "Submenu_salvaguarda_modificar"
        Submenu_salvaguarda_modificar.Size = New Size(156, 26)
        Submenu_salvaguarda_modificar.Text = "Modificar"
        ' 
        ' Submenu_salvaguarda_eliminar
        ' 
        Submenu_salvaguarda_eliminar.Name = "Submenu_salvaguarda_eliminar"
        Submenu_salvaguarda_eliminar.Size = New Size(156, 26)
        Submenu_salvaguarda_eliminar.Text = "Eliminar"
        ' 
        ' BBDDToolStripMenuItem
        ' 
        BBDDToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Submenu_bbdd_configuración, Submenu_bbdd_probar})
        BBDDToolStripMenuItem.Name = "BBDDToolStripMenuItem"
        BBDDToolStripMenuItem.Size = New Size(63, 24)
        BBDDToolStripMenuItem.Text = "BBDD"
        ' 
        ' Submenu_bbdd_configuración
        ' 
        Submenu_bbdd_configuración.Name = "Submenu_bbdd_configuración"
        Submenu_bbdd_configuración.Size = New Size(224, 26)
        Submenu_bbdd_configuración.Text = "Configuración"
        ' 
        ' Submenu_bbdd_probar
        ' 
        Submenu_bbdd_probar.Name = "Submenu_bbdd_probar"
        Submenu_bbdd_probar.Size = New Size(224, 26)
        Submenu_bbdd_probar.Text = "Probar conexión"
        ' 
        ' UsuarioToolStripMenuItem
        ' 
        UsuarioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Submenu_usuario_login, Submenu_usuario_logout})
        UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        UsuarioToolStripMenuItem.Size = New Size(73, 24)
        UsuarioToolStripMenuItem.Text = "Usuario"
        ' 
        ' Submenu_usuario_login
        ' 
        Submenu_usuario_login.Name = "Submenu_usuario_login"
        Submenu_usuario_login.Size = New Size(224, 26)
        Submenu_usuario_login.Text = "Login"
        ' 
        ' Submenu_usuario_logout
        ' 
        Submenu_usuario_logout.Name = "Submenu_usuario_logout"
        Submenu_usuario_logout.Size = New Size(224, 26)
        Submenu_usuario_logout.Text = "Logout"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(65, 24)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' Ventana_principal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LBSalvaguardas)
        Controls.Add(LBAmenazas)
        Controls.Add(LBActivos)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Ventana_principal"
        Text = "Gestor riesgos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBActivos As ListBox
    Friend WithEvents LBAmenazas As ListBox
    Friend WithEvents LBSalvaguardas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu_archivo As ToolStripMenuItem
    Friend WithEvents Submenu_importar As ToolStripMenuItem
    Friend WithEvents Submenu_salir As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sumenu_activo_listado As ToolStripMenuItem
    Friend WithEvents Sumenu_activo_ver As ToolStripMenuItem
    Friend WithEvents Sumenu_activo_crear As ToolStripMenuItem
    Friend WithEvents Sumenu_activo_modificar As ToolStripMenuItem
    Friend WithEvents Sumenu_activo_eliminar As ToolStripMenuItem
    Friend WithEvents AmenazasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvaguardasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BBDDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Submenu_amenaza_listado As ToolStripMenuItem
    Friend WithEvents Submenu_amenaza_ver As ToolStripMenuItem
    Friend WithEvents Submenu_amenaza_crear As ToolStripMenuItem
    Friend WithEvents Submenu_amenaza_modificar As ToolStripMenuItem
    Friend WithEvents Submenu_amenaza_eliminar As ToolStripMenuItem
    Friend WithEvents Submenu_salvaguarda_listado As ToolStripMenuItem
    Friend WithEvents Submenu_salvaguarda_ver As ToolStripMenuItem
    Friend WithEvents Submenu_salvaguarda_crear As ToolStripMenuItem
    Friend WithEvents Submenu_salvaguarda_modificar As ToolStripMenuItem
    Friend WithEvents Submenu_salvaguarda_eliminar As ToolStripMenuItem
    Friend WithEvents Submenu_bbdd_configuración As ToolStripMenuItem
    Friend WithEvents Submenu_bbdd_probar As ToolStripMenuItem
    Friend WithEvents Submenu_usuario_login As ToolStripMenuItem
    Friend WithEvents Submenu_usuario_logout As ToolStripMenuItem

End Class
