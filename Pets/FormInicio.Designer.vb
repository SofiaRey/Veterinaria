<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AltaPersoanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaMascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarMascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.ImageLocation = "C:\Users\sofur\Desktop\WallpaperPets.jpg"
        Me.PictureBox2.Location = New System.Drawing.Point(115, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(573, 295)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPersoanaToolStripMenuItem, Me.AltaMascotaToolStripMenuItem, Me.BuscarPersonaToolStripMenuItem, Me.ListarPersonasToolStripMenuItem, Me.ListarMascotasToolStripMenuItem, Me.BuscarMascotaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaPersoanaToolStripMenuItem
        '
        Me.AltaPersoanaToolStripMenuItem.Name = "AltaPersoanaToolStripMenuItem"
        Me.AltaPersoanaToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AltaPersoanaToolStripMenuItem.Text = "Alta Persona"
        '
        'AltaMascotaToolStripMenuItem
        '
        Me.AltaMascotaToolStripMenuItem.Name = "AltaMascotaToolStripMenuItem"
        Me.AltaMascotaToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AltaMascotaToolStripMenuItem.Text = "Alta Mascota"
        '
        'BuscarPersonaToolStripMenuItem
        '
        Me.BuscarPersonaToolStripMenuItem.Name = "BuscarPersonaToolStripMenuItem"
        Me.BuscarPersonaToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.BuscarPersonaToolStripMenuItem.Text = "Buscar Persona"
        '
        'ListarPersonasToolStripMenuItem
        '
        Me.ListarPersonasToolStripMenuItem.Name = "ListarPersonasToolStripMenuItem"
        Me.ListarPersonasToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ListarPersonasToolStripMenuItem.Text = "Listar Personas"
        '
        'ListarMascotasToolStripMenuItem
        '
        Me.ListarMascotasToolStripMenuItem.Name = "ListarMascotasToolStripMenuItem"
        Me.ListarMascotasToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ListarMascotasToolStripMenuItem.Text = "Listar Mascotas"
        '
        'BuscarMascotaToolStripMenuItem
        '
        Me.BuscarMascotaToolStripMenuItem.Name = "BuscarMascotaToolStripMenuItem"
        Me.BuscarMascotaToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.BuscarMascotaToolStripMenuItem.Text = "Buscar Mascota"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaPersoanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaMascotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarPersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarMascotaToolStripMenuItem As ToolStripMenuItem
End Class
