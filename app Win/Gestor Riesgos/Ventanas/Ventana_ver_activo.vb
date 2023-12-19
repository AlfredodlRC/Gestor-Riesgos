Public Class Ventana_ver_activo

    Dim panel_datos_basicos As Panel_datos_basicos
    Dim panel_datos_complementarios As Panel_tab_activos


    Private Sub Ventana_ver_activo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panel_datos_basicos = New Panel_datos_basicos()
        panel_datos_basicos.Location = New Point(0, 0)
        Me.Controls.Add(panel_datos_basicos)

        panel_datos_complementarios = New Panel_tab_activos()
        panel_datos_complementarios.Location = New Point(0, 250)
        Me.Controls.Add(panel_datos_complementarios)
    End Sub
End Class