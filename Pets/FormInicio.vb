Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
End Class