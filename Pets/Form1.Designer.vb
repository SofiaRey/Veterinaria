<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPersona
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
        Me.lblPersonTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxCI = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.txtbxPhone = New System.Windows.Forms.TextBox()
        Me.txtbxAdd = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnAceptPersona = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPersonTitle
        '
        Me.lblPersonTitle.AutoSize = True
        Me.lblPersonTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonTitle.Location = New System.Drawing.Point(347, 28)
        Me.lblPersonTitle.Name = "lblPersonTitle"
        Me.lblPersonTitle.Size = New System.Drawing.Size(92, 25)
        Me.lblPersonTitle.TabIndex = 0
        Me.lblPersonTitle.Text = "Persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'txtbxCI
        '
        Me.txtbxCI.Location = New System.Drawing.Point(283, 93)
        Me.txtbxCI.Name = "txtbxCI"
        Me.txtbxCI.Size = New System.Drawing.Size(224, 20)
        Me.txtbxCI.TabIndex = 2
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(283, 141)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(224, 20)
        Me.txtbxName.TabIndex = 3
        '
        'txtbxPhone
        '
        Me.txtbxPhone.Location = New System.Drawing.Point(283, 192)
        Me.txtbxPhone.Name = "txtbxPhone"
        Me.txtbxPhone.Size = New System.Drawing.Size(224, 20)
        Me.txtbxPhone.TabIndex = 4
        '
        'txtbxAdd
        '
        Me.txtbxAdd.Location = New System.Drawing.Point(283, 239)
        Me.txtbxAdd.Name = "txtbxAdd"
        Me.txtbxAdd.Size = New System.Drawing.Size(224, 20)
        Me.txtbxAdd.TabIndex = 5
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(280, 77)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(17, 13)
        Me.lblCI.TabIndex = 6
        Me.lblCI.Text = "CI"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(280, 125)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Nombre"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(280, 176)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(49, 13)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Teléfono"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(280, 223)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(52, 13)
        Me.lblAdd.TabIndex = 9
        Me.lblAdd.Text = "Dirección"
        '
        'btnAceptPersona
        '
        Me.btnAceptPersona.Location = New System.Drawing.Point(352, 284)
        Me.btnAceptPersona.Name = "btnAceptPersona"
        Me.btnAceptPersona.Size = New System.Drawing.Size(86, 25)
        Me.btnAceptPersona.TabIndex = 10
        Me.btnAceptPersona.Text = "Aceptar"
        Me.btnAceptPersona.UseVisualStyleBackColor = True
        '
        'FormPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAceptPersona)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtbxAdd)
        Me.Controls.Add(Me.txtbxPhone)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.txtbxCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPersonTitle)
        Me.Name = "FormPersona"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPersonTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxCI As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents txtbxPhone As TextBox
    Friend WithEvents txtbxAdd As TextBox
    Friend WithEvents lblCI As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnAceptPersona As Button
End Class
