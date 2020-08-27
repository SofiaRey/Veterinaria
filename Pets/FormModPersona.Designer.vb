<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModPersona
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
        Me.lvPhonesList = New System.Windows.Forms.ListView()
        Me.btnAddPhone = New System.Windows.Forms.Button()
        Me.btnAceptPersona = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtbxAdd = New System.Windows.Forms.TextBox()
        Me.txtbxPhone = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.txtbxCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPersonTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvPhonesList
        '
        Me.lvPhonesList.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvPhonesList.HideSelection = False
        Me.lvPhonesList.Location = New System.Drawing.Point(557, 240)
        Me.lvPhonesList.Name = "lvPhonesList"
        Me.lvPhonesList.Size = New System.Drawing.Size(163, 136)
        Me.lvPhonesList.TabIndex = 25
        Me.lvPhonesList.UseCompatibleStateImageBehavior = False
        Me.lvPhonesList.View = System.Windows.Forms.View.List
        '
        'btnAddPhone
        '
        Me.btnAddPhone.Location = New System.Drawing.Point(504, 240)
        Me.btnAddPhone.Name = "btnAddPhone"
        Me.btnAddPhone.Size = New System.Drawing.Size(34, 25)
        Me.btnAddPhone.TabIndex = 24
        Me.btnAddPhone.Text = "+"
        Me.btnAddPhone.UseVisualStyleBackColor = True
        '
        'btnAceptPersona
        '
        Me.btnAceptPersona.Location = New System.Drawing.Point(330, 291)
        Me.btnAceptPersona.Name = "btnAceptPersona"
        Me.btnAceptPersona.Size = New System.Drawing.Size(86, 25)
        Me.btnAceptPersona.TabIndex = 23
        Me.btnAceptPersona.Text = "Aceptar"
        Me.btnAceptPersona.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(258, 180)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(52, 13)
        Me.lblAdd.TabIndex = 22
        Me.lblAdd.Text = "Dirección"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(258, 229)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(49, 13)
        Me.lblPhone.TabIndex = 21
        Me.lblPhone.Text = "Teléfono"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(258, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 13)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Nombre"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(258, 86)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(17, 13)
        Me.lblCI.TabIndex = 19
        Me.lblCI.Text = "CI"
        '
        'txtbxAdd
        '
        Me.txtbxAdd.Location = New System.Drawing.Point(261, 196)
        Me.txtbxAdd.Name = "txtbxAdd"
        Me.txtbxAdd.Size = New System.Drawing.Size(224, 20)
        Me.txtbxAdd.TabIndex = 18
        '
        'txtbxPhone
        '
        Me.txtbxPhone.Location = New System.Drawing.Point(261, 245)
        Me.txtbxPhone.Name = "txtbxPhone"
        Me.txtbxPhone.Size = New System.Drawing.Size(224, 20)
        Me.txtbxPhone.TabIndex = 17
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(261, 150)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(224, 20)
        Me.txtbxName.TabIndex = 16
        '
        'txtbxCI
        '
        Me.txtbxCI.Location = New System.Drawing.Point(261, 102)
        Me.txtbxCI.Name = "txtbxCI"
        Me.txtbxCI.Size = New System.Drawing.Size(224, 20)
        Me.txtbxCI.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 14
        '
        'lblPersonTitle
        '
        Me.lblPersonTitle.AutoSize = True
        Me.lblPersonTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonTitle.Location = New System.Drawing.Point(325, 37)
        Me.lblPersonTitle.Name = "lblPersonTitle"
        Me.lblPersonTitle.Size = New System.Drawing.Size(186, 25)
        Me.lblPersonTitle.TabIndex = 13
        Me.lblPersonTitle.Text = "Modificar Persona"
        '
        'FormModPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvPhonesList)
        Me.Controls.Add(Me.btnAddPhone)
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
        Me.Name = "FormModPersona"
        Me.Text = "FormModPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvPhonesList As ListView
    Friend WithEvents btnAddPhone As Button
    Friend WithEvents btnAceptPersona As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents txtbxAdd As TextBox
    Friend WithEvents txtbxPhone As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents txtbxCI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPersonTitle As Label
End Class
