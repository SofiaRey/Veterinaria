<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuscarPersona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSearchPerson = New System.Windows.Forms.Button()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtbxCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSearchPersonTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lbltelephones = New System.Windows.Forms.Label()
        Me.txtbxNameToComplete = New System.Windows.Forms.TextBox()
        Me.txtbxAddressToComplete = New System.Windows.Forms.TextBox()
        Me.lvPhonesList = New System.Windows.Forms.ListView()
        Me.btnAddPhone = New System.Windows.Forms.Button()
        Me.txtbxPhone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSearchPerson
        '
        Me.btnSearchPerson.Location = New System.Drawing.Point(353, 193)
        Me.btnSearchPerson.Name = "btnSearchPerson"
        Me.btnSearchPerson.Size = New System.Drawing.Size(86, 25)
        Me.btnSearchPerson.TabIndex = 28
        Me.btnSearchPerson.Text = "Buscar"
        Me.btnSearchPerson.UseVisualStyleBackColor = True
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
        Me.lblName.Location = New System.Drawing.Point(79, 239)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 13)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "Nombre:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(79, 263)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(55, 13)
        Me.lblAddress.TabIndex = 30
        Me.lblAddress.Text = "Direccion:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(208, 367)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(79, 25)
        Me.btnModificar.TabIndex = 33
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lbltelephones
        '
        Me.lbltelephones.AutoSize = True
        Me.lbltelephones.Location = New System.Drawing.Point(79, 286)
        Me.lbltelephones.Name = "lbltelephones"
        Me.lbltelephones.Size = New System.Drawing.Size(57, 13)
        Me.lbltelephones.TabIndex = 34
        Me.lbltelephones.Text = "Telefonos:"
        '
        'txtbxNameToComplete
        '
        Me.txtbxNameToComplete.Location = New System.Drawing.Point(132, 236)
        Me.txtbxNameToComplete.Name = "txtbxNameToComplete"
        Me.txtbxNameToComplete.Size = New System.Drawing.Size(224, 20)
        Me.txtbxNameToComplete.TabIndex = 36
        '
        'txtbxAddressToComplete
        '
        Me.txtbxAddressToComplete.Location = New System.Drawing.Point(140, 260)
        Me.txtbxAddressToComplete.Name = "txtbxAddressToComplete"
        Me.txtbxAddressToComplete.Size = New System.Drawing.Size(224, 20)
        Me.txtbxAddressToComplete.TabIndex = 37
        '
        'lvPhonesList
        '
        Me.lvPhonesList.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvPhonesList.HideSelection = False
        Me.lvPhonesList.Location = New System.Drawing.Point(436, 281)
        Me.lvPhonesList.Name = "lvPhonesList"
        Me.lvPhonesList.Size = New System.Drawing.Size(163, 136)
        Me.lvPhonesList.TabIndex = 40
        Me.lvPhonesList.UseCompatibleStateImageBehavior = False
        Me.lvPhonesList.View = System.Windows.Forms.View.List
        '
        'btnAddPhone
        '
        Me.btnAddPhone.Location = New System.Drawing.Point(383, 281)
        Me.btnAddPhone.Name = "btnAddPhone"
        Me.btnAddPhone.Size = New System.Drawing.Size(34, 25)
        Me.btnAddPhone.TabIndex = 39
        Me.btnAddPhone.Text = "+"
        Me.btnAddPhone.UseVisualStyleBackColor = True
        '
        'txtbxPhone
        '
        Me.txtbxPhone.Location = New System.Drawing.Point(140, 286)
        Me.txtbxPhone.Name = "txtbxPhone"
        Me.txtbxPhone.Size = New System.Drawing.Size(224, 20)
        Me.txtbxPhone.TabIndex = 38
        '
        'FormBuscarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvPhonesList)
        Me.Controls.Add(Me.btnAddPhone)
        Me.Controls.Add(Me.txtbxPhone)
        Me.Controls.Add(Me.txtbxAddressToComplete)
        Me.Controls.Add(Me.txtbxNameToComplete)
        Me.Controls.Add(Me.lbltelephones)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSearchPerson)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtbxCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSearchPersonTitle)
        Me.Name = "FormBuscarPersona"
        Me.Text = "FormBuscarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchPerson As Button
    Friend WithEvents lblCI As Label
    Friend WithEvents txtbxCI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSearchPersonTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents lbltelephones As Label
    Friend WithEvents txtbxNameToComplete As TextBox
    Friend WithEvents txtbxAddressToComplete As TextBox
    Friend WithEvents lvPhonesList As ListView
    Friend WithEvents btnAddPhone As Button
    Friend WithEvents txtbxPhone As TextBox
End Class
