<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPet
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
        Me.btnAceptPet = New System.Windows.Forms.Button()
        Me.lblCIOwner = New System.Windows.Forms.Label()
        Me.lblYearBirth = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtbxCIOwner = New System.Windows.Forms.TextBox()
        Me.txtbxYearBirth = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.lblPetTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptPet
        '
        Me.btnAceptPet.Location = New System.Drawing.Point(361, 257)
        Me.btnAceptPet.Name = "btnAceptPet"
        Me.btnAceptPet.Size = New System.Drawing.Size(86, 25)
        Me.btnAceptPet.TabIndex = 21
        Me.btnAceptPet.Text = "Aceptar"
        Me.btnAceptPet.UseVisualStyleBackColor = True
        '
        'lblCIOwner
        '
        Me.lblCIOwner.AutoSize = True
        Me.lblCIOwner.Location = New System.Drawing.Point(287, 191)
        Me.lblCIOwner.Name = "lblCIOwner"
        Me.lblCIOwner.Size = New System.Drawing.Size(50, 13)
        Me.lblCIOwner.TabIndex = 20
        Me.lblCIOwner.Text = "CI dueño"
        '
        'lblYearBirth
        '
        Me.lblYearBirth.AutoSize = True
        Me.lblYearBirth.Location = New System.Drawing.Point(287, 144)
        Me.lblYearBirth.Name = "lblYearBirth"
        Me.lblYearBirth.Size = New System.Drawing.Size(95, 13)
        Me.lblYearBirth.TabIndex = 19
        Me.lblYearBirth.Text = "Año de nacimiento"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(287, 93)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 13)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Nombre"
        '
        'txtbxCIOwner
        '
        Me.txtbxCIOwner.Location = New System.Drawing.Point(290, 207)
        Me.txtbxCIOwner.Name = "txtbxCIOwner"
        Me.txtbxCIOwner.Size = New System.Drawing.Size(224, 20)
        Me.txtbxCIOwner.TabIndex = 16
        '
        'txtbxYearBirth
        '
        Me.txtbxYearBirth.Location = New System.Drawing.Point(290, 160)
        Me.txtbxYearBirth.Name = "txtbxYearBirth"
        Me.txtbxYearBirth.Size = New System.Drawing.Size(224, 20)
        Me.txtbxYearBirth.TabIndex = 15
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(290, 109)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(224, 20)
        Me.txtbxName.TabIndex = 14
        '
        'lblPetTitle
        '
        Me.lblPetTitle.AutoSize = True
        Me.lblPetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetTitle.Location = New System.Drawing.Point(356, 38)
        Me.lblPetTitle.Name = "lblPetTitle"
        Me.lblPetTitle.Size = New System.Drawing.Size(94, 25)
        Me.lblPetTitle.TabIndex = 11
        Me.lblPetTitle.Text = "Mascota"
        '
        'FormPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAceptPet)
        Me.Controls.Add(Me.lblCIOwner)
        Me.Controls.Add(Me.lblYearBirth)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtbxCIOwner)
        Me.Controls.Add(Me.txtbxYearBirth)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.lblPetTitle)
        Me.Name = "FormPet"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptPet As Button
    Friend WithEvents lblCIOwner As Label
    Friend WithEvents lblYearBirth As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtbxCIOwner As TextBox
    Friend WithEvents txtbxYearBirth As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents lblPetTitle As Label
End Class
