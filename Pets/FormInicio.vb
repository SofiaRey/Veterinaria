﻿Public Class FormInicio
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub AltaPersoanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPersoanaToolStripMenuItem.Click
        FormPersona.Show()
    End Sub

    Private Sub AltaMascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaMascotaToolStripMenuItem.Click
        FormPet.Show()
    End Sub

    Private Sub BuscarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPersonaToolStripMenuItem.Click
        FormBuscarPersona.Show()
    End Sub

    Private Sub ListarPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPersonasToolStripMenuItem.Click
        FormListarPersonas.Show()
    End Sub

    Private Sub ListarMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMascotasToolStripMenuItem.Click
        FormListarMascotas.Show()
    End Sub

    Private Sub BuscarMascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarMascotaToolStripMenuItem.Click
        FormBuscarMascota.Show()
    End Sub
End Class