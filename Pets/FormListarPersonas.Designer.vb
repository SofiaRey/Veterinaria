<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarPersonas
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
        Me.lbPersonas = New System.Windows.Forms.ListBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbPersonas
        '
        Me.lbPersonas.FormattingEnabled = True
        Me.lbPersonas.Location = New System.Drawing.Point(12, 5)
        Me.lbPersonas.Name = "lbPersonas"
        Me.lbPersonas.Size = New System.Drawing.Size(646, 433)
        Me.lbPersonas.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(664, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(124, 31)
        Me.btnListar.TabIndex = 3
        Me.btnListar.Text = "Listar Personas"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'FormListarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.lbPersonas)
        Me.Name = "FormListarPersonas"
        Me.Text = "FormListarPersonas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbPersonas As ListBox
    Friend WithEvents btnListar As Button
End Class
