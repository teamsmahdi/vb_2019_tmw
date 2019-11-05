<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EX1S1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Taper votre nom:"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(201, 46)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(200, 22)
        Me.tbNom.TabIndex = 1
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(201, 74)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(200, 22)
        Me.tbPrenom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Taper votre prénom:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Afficher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(286, 115)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(75, 23)
        Me.btnEffacer.TabIndex = 5
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'EX1S1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 253)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EX1S1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNom As System.Windows.Forms.TextBox
    Friend WithEvents tbPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEffacer As System.Windows.Forms.Button

End Class
