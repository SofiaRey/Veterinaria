<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarMascota
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
        Me.lblSearchPetTitle = New System.Windows.Forms.Label()
        Me.btnSearchPet = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtbxID = New System.Windows.Forms.TextBox()
        Me.txtbxNombre = New System.Windows.Forms.TextBox()
        Me.txtbxAnoNac = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAnoNac = New System.Windows.Forms.Label()
        Me.btnDeletePet = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblOwnerCi = New System.Windows.Forms.Label()
        Me.lblDataCedula = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSearchPetTitle
        '
        Me.lblSearchPetTitle.AutoSize = True
        Me.lblSearchPetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchPetTitle.Location = New System.Drawing.Point(327, 64)
        Me.lblSearchPetTitle.Name = "lblSearchPetTitle"
        Me.lblSearchPetTitle.Size = New System.Drawing.Size(167, 25)
        Me.lblSearchPetTitle.TabIndex = 23
        Me.lblSearchPetTitle.Text = "Buscar Mascota"
        '
        'btnSearchPet
        '
        Me.btnSearchPet.Location = New System.Drawing.Point(361, 191)
        Me.btnSearchPet.Name = "btnSearchPet"
        Me.btnSearchPet.Size = New System.Drawing.Size(86, 25)
        Me.btnSearchPet.TabIndex = 31
        Me.btnSearchPet.Text = "Buscar"
        Me.btnSearchPet.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(285, 120)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 30
        Me.lblId.Text = "ID"
        '
        'txtbxID
        '
        Me.txtbxID.Location = New System.Drawing.Point(288, 136)
        Me.txtbxID.Name = "txtbxID"
        Me.txtbxID.Size = New System.Drawing.Size(224, 20)
        Me.txtbxID.TabIndex = 29
        '
        'txtbxNombre
        '
        Me.txtbxNombre.Location = New System.Drawing.Point(151, 268)
        Me.txtbxNombre.Name = "txtbxNombre"
        Me.txtbxNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtbxNombre.TabIndex = 32
        '
        'txtbxAnoNac
        '
        Me.txtbxAnoNac.Location = New System.Drawing.Point(151, 314)
        Me.txtbxAnoNac.Name = "txtbxAnoNac"
        Me.txtbxAnoNac.Size = New System.Drawing.Size(152, 20)
        Me.txtbxAnoNac.TabIndex = 33
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(101, 275)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 35
        Me.lblNombre.Text = "Nombre"
        '
        'lblAnoNac
        '
        Me.lblAnoNac.AutoSize = True
        Me.lblAnoNac.Location = New System.Drawing.Point(48, 321)
        Me.lblAnoNac.Name = "lblAnoNac"
        Me.lblAnoNac.Size = New System.Drawing.Size(97, 13)
        Me.lblAnoNac.TabIndex = 36
        Me.lblAnoNac.Text = "Año de Nacimiento"
        '
        'btnDeletePet
        '
        Me.btnDeletePet.Location = New System.Drawing.Point(709, 413)
        Me.btnDeletePet.Name = "btnDeletePet"
        Me.btnDeletePet.Size = New System.Drawing.Size(79, 25)
        Me.btnDeletePet.TabIndex = 43
        Me.btnDeletePet.Text = "ELIMINAR"
        Me.btnDeletePet.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(188, 357)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(79, 25)
        Me.btnModificar.TabIndex = 42
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblOwnerCi
        '
        Me.lblOwnerCi.AutoSize = True
        Me.lblOwnerCi.Location = New System.Drawing.Point(329, 275)
        Me.lblOwnerCi.Name = "lblOwnerCi"
        Me.lblOwnerCi.Size = New System.Drawing.Size(93, 13)
        Me.lblOwnerCi.TabIndex = 44
        Me.lblOwnerCi.Text = "Cédula del dueño:"
        '
        'lblDataCedula
        '
        Me.lblDataCedula.AutoSize = True
        Me.lblDataCedula.Location = New System.Drawing.Point(437, 275)
        Me.lblDataCedula.Name = "lblDataCedula"
        Me.lblDataCedula.Size = New System.Drawing.Size(10, 13)
        Me.lblDataCedula.TabIndex = 46
        Me.lblDataCedula.Text = "-"
        '
        'FormBuscarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDataCedula)
        Me.Controls.Add(Me.lblOwnerCi)
        Me.Controls.Add(Me.btnDeletePet)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblAnoNac)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtbxAnoNac)
        Me.Controls.Add(Me.txtbxNombre)
        Me.Controls.Add(Me.btnSearchPet)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtbxID)
        Me.Controls.Add(Me.lblSearchPetTitle)
        Me.Name = "FormBuscarMascota"
        Me.Text = "FormBuscarMascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchPetTitle As Label
    Friend WithEvents btnSearchPet As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtbxID As TextBox
    Friend WithEvents txtbxNombre As TextBox
    Friend WithEvents txtbxAnoNac As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAnoNac As Label
    Friend WithEvents btnDeletePet As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblOwnerCi As Label
    Friend WithEvents lblDataCedula As Label
End Class
