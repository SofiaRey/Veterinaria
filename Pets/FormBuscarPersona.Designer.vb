<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarPersona
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
        Me.btnAceptTelephone = New System.Windows.Forms.Button()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtbxCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSearchPersonTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblNameToComplete = New System.Windows.Forms.Label()
        Me.lblAddressToComplete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptTelephone
        '
        Me.btnAceptTelephone.Location = New System.Drawing.Point(353, 193)
        Me.btnAceptTelephone.Name = "btnAceptTelephone"
        Me.btnAceptTelephone.Size = New System.Drawing.Size(86, 25)
        Me.btnAceptTelephone.TabIndex = 28
        Me.btnAceptTelephone.Text = "Buscar"
        Me.btnAceptTelephone.UseVisualStyleBackColor = True
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(287, 120)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(17, 13)
        Me.lblCI.TabIndex = 26
        Me.lblCI.Text = "CI"
        '
        'txtbxCI
        '
        Me.txtbxCI.Location = New System.Drawing.Point(290, 136)
        Me.txtbxCI.Name = "txtbxCI"
        Me.txtbxCI.Size = New System.Drawing.Size(224, 20)
        Me.txtbxCI.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 23
        '
        'lblSearchPersonTitle
        '
        Me.lblSearchPersonTitle.AutoSize = True
        Me.lblSearchPersonTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchPersonTitle.Location = New System.Drawing.Point(329, 63)
        Me.lblSearchPersonTitle.Name = "lblSearchPersonTitle"
        Me.lblSearchPersonTitle.Size = New System.Drawing.Size(165, 25)
        Me.lblSearchPersonTitle.TabIndex = 22
        Me.lblSearchPersonTitle.Text = "Buscar Persona"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(79, 259)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 13)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "Nombre:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(79, 296)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(55, 13)
        Me.lblAddress.TabIndex = 30
        Me.lblAddress.Text = "Direccion:"
        '
        'lblNameToComplete
        '
        Me.lblNameToComplete.AutoSize = True
        Me.lblNameToComplete.Location = New System.Drawing.Point(132, 259)
        Me.lblNameToComplete.Name = "lblNameToComplete"
        Me.lblNameToComplete.Size = New System.Drawing.Size(16, 13)
        Me.lblNameToComplete.TabIndex = 31
        Me.lblNameToComplete.Text = "..."
        '
        'lblAddressToComplete
        '
        Me.lblAddressToComplete.AutoSize = True
        Me.lblAddressToComplete.Location = New System.Drawing.Point(140, 296)
        Me.lblAddressToComplete.Name = "lblAddressToComplete"
        Me.lblAddressToComplete.Size = New System.Drawing.Size(16, 13)
        Me.lblAddressToComplete.TabIndex = 32
        Me.lblAddressToComplete.Text = "..."
        '
        'FormBuscarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAddressToComplete)
        Me.Controls.Add(Me.lblNameToComplete)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAceptTelephone)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtbxCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSearchPersonTitle)
        Me.Name = "FormBuscarPersona"
        Me.Text = "FormBuscarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptTelephone As Button
    Friend WithEvents lblCI As Label
    Friend WithEvents txtbxCI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSearchPersonTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNameToComplete As Label
    Friend WithEvents lblAddressToComplete As Label
End Class
