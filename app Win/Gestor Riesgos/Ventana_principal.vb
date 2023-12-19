Imports System.Reflection.Emit

Public Class Ventana_principal


    Dim lista_denominacion_activos As List(Of String)
    Dim lista_denominacion_amenazas As List(Of String)
    Dim lista_denominacion_salvaguardas As List(Of String)

    Dim ventana As Ventana_ver_activo

    Public Sub carga_ventana() Handles MyBase.Load
        lista_denominacion_activos = New List(Of String)
        lista_denominacion_amenazas = New List(Of String)
        lista_denominacion_salvaguardas = New List(Of String)
        ventana = New Ventana_ver_activo()
        ventana.Show()

    End Sub

    Private Sub LBActivos_SelectedValueChanged(sender As Object, e As EventArgs) Handles LBActivos.SelectedValueChanged

    End Sub

    Private Sub LBAmenazas_SelectedValueChanged(sender As Object, e As EventArgs) Handles LBAmenazas.SelectedValueChanged

    End Sub

    Private Sub LBSalvaguardas_SelectedValueChanged(sender As Object, e As EventArgs) Handles LBSalvaguardas.SelectedValueChanged

    End Sub

    Private Sub Submenu_importar_Click(sender As Object, e As EventArgs) Handles Submenu_importar.Click

    End Sub

    Private Sub Submenu_salir_Click(sender As Object, e As EventArgs) Handles Submenu_salir.Click

    End Sub

    Private Sub Submenu_usuario_login_Click(sender As Object, e As EventArgs) Handles Submenu_usuario_login.Click

    End Sub

    Private Sub Submenu_usuario_logout_Click(sender As Object, e As EventArgs) Handles Submenu_usuario_logout.Click

    End Sub

    Private Sub Submenu_bbdd_configuración_Click(sender As Object, e As EventArgs) Handles Submenu_bbdd_configuración.Click

    End Sub

    Private Sub Submenu_bbdd_probar_Click(sender As Object, e As EventArgs) Handles Submenu_bbdd_probar.Click

    End Sub

    Private Sub Sumenu_activo_listado_Click(sender As Object, e As EventArgs) Handles Sumenu_activo_listado.Click

    End Sub

    Private Sub Sumenu_activo_ver_Click(sender As Object, e As EventArgs) Handles Sumenu_activo_ver.Click

    End Sub

    Private Sub Sumenu_activo_crear_Click(sender As Object, e As EventArgs) Handles Sumenu_activo_crear.Click

    End Sub

    Private Sub Sumenu_activo_modificar_Click(sender As Object, e As EventArgs) Handles Sumenu_activo_modificar.Click

    End Sub

    Private Sub Sumenu_activo_eliminar_Click(sender As Object, e As EventArgs) Handles Sumenu_activo_eliminar.Click

    End Sub

    Private Sub Submenu_amenaza_listado_Click(sender As Object, e As EventArgs) Handles Submenu_amenaza_listado.Click

    End Sub

    Private Sub Submenu_amenaza_ver_Click(sender As Object, e As EventArgs) Handles Submenu_amenaza_ver.Click

    End Sub

    Private Sub Submenu_amenaza_crear_Click(sender As Object, e As EventArgs) Handles Submenu_amenaza_crear.Click

    End Sub

    Private Sub Submenu_amenaza_modificar_Click(sender As Object, e As EventArgs) Handles Submenu_amenaza_modificar.Click

    End Sub

    Private Sub Submenu_amenaza_eliminar_Click(sender As Object, e As EventArgs) Handles Submenu_amenaza_eliminar.Click

    End Sub

    Private Sub Submenu_salvaguarda_listado_Click(sender As Object, e As EventArgs) Handles Submenu_salvaguarda_listado.Click

    End Sub

    Private Sub Submenu_salvaguarda_ver_Click(sender As Object, e As EventArgs) Handles Submenu_salvaguarda_ver.Click

    End Sub

    Private Sub Submenu_salvaguarda_crear_Click(sender As Object, e As EventArgs) Handles Submenu_salvaguarda_crear.Click

    End Sub

    Private Sub Submenu_salvaguarda_modificar_Click(sender As Object, e As EventArgs) Handles Submenu_salvaguarda_modificar.Click

    End Sub

    Private Sub Submenu_salvaguarda_eliminar_Click(sender As Object, e As EventArgs) Handles Submenu_salvaguarda_eliminar.Click

    End Sub
End Class
