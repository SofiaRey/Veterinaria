<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTelefono
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtbxTel = New System.Windows.Forms.TextBox()
        Me.txtbxCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTelephoneTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptTelephone
        '
        Me.btnAceptTelephone.Location = New System.Drawing.Point(359, 248)
        Me.btnAceptTelephone.Name = "btnAceptTelephone"
        Me.btnAceptTelephone.Size = New System.Drawing.Size(86, 25)
        Me.btnAceptTelephone.TabIndex = 21
        Me.btnAceptTelephone.Text = "Aceptar"
        Me.btnAceptTelephone.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(287, 182)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 13)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Telefono"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(287, 134)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(17, 13)
        Me.lblCI.TabIndex = 17
        Me.lblCI.Text = "CI"
        '
        'txtbxTel
        '
        Me.txtbxTel.Location = New System.Drawing.Point(290, 198)
        Me.txtbxTel.Name = "txtbxTel"
        Me.txtbxTel.Size = New System.Drawing.Size(224, 20)
        Me.txtbxTel.TabIndex = 14
        '
        'txtbxCI
        '
        Me.txtbxCI.Location = New System.Drawing.Point(290, 150)
        Me.txtbxCI.Name = "txtbxCI"
        Me.txtbxCI.Size = New System.Drawing.Size(224, 20)
        Me.txtbxCI.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 12
        '
        'lblTelephoneTitle
        '
        Me.lblTelephoneTitle.AutoSize = True
        Me.lblTelephoneTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneTitle.Location = New System.Drawing.Point(354, 85)
        Me.lblTelephoneTitle.Name = "lblTelephoneTitle"
        Me.lblTelephoneTitle.Size = New System.Drawing.Size(96, 25)
        Me.lblTelephoneTitle.TabIndex = 11
        Me.lblTelephoneTitle.Text = "Telefono"
        '
        'FormTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAceptTelephone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtbxTel)
        Me.Controls.Add(Me.txtbxCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTelephoneTitle)
        Me.Name = "FormTelefono"
        Me.Text = "Telefono"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptTelephone As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents txtbxTel As TextBox
    Friend WithEvents txtbxCI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTelephoneTitle As Label
End Class
