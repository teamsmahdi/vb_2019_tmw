<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EX2S1
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
        Me.txtNbr2 = New System.Windows.Forms.TextBox()
        Me.bPlus = New System.Windows.Forms.Button()
        Me.bMoins = New System.Windows.Forms.Button()
        Me.bFois = New System.Windows.Forms.Button()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.txtNbr1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNbr2
        '
        Me.txtNbr2.Location = New System.Drawing.Point(367, 95)
        Me.txtNbr2.Name = "txtNbr2"
        Me.txtNbr2.Size = New System.Drawing.Size(174, 22)
        Me.txtNbr2.TabIndex = 0
        '
        'bPlus
        '
        Me.bPlus.Location = New System.Drawing.Point(272, 149)
        Me.bPlus.Name = "bPlus"
        Me.bPlus.Size = New System.Drawing.Size(29, 22)
        Me.bPlus.TabIndex = 2
        Me.bPlus.Text = "+"
        Me.bPlus.UseVisualStyleBackColor = True
        '
        'bMoins
        '
        Me.bMoins.Location = New System.Drawing.Point(305, 149)
        Me.bMoins.Name = "bMoins"
        Me.bMoins.Size = New System.Drawing.Size(29, 22)
        Me.bMoins.TabIndex = 3
        Me.bMoins.Text = "-"
        Me.bMoins.UseVisualStyleBackColor = True
        '
        'bFois
        '
        Me.bFois.Location = New System.Drawing.Point(338, 149)
        Me.bFois.Name = "bFois"
        Me.bFois.Size = New System.Drawing.Size(29, 22)
        Me.bFois.TabIndex = 4
        Me.bFois.Text = "*"
        Me.bFois.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Location = New System.Drawing.Point(318, 190)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(16, 17)
        Me.lblResultat.TabIndex = 5
        Me.lblResultat.Text = "="
        '
        'txtNbr1
        '
        Me.txtNbr1.Location = New System.Drawing.Point(146, 95)
        Me.txtNbr1.Name = "txtNbr1"
        Me.txtNbr1.Size = New System.Drawing.Size(174, 22)
        Me.txtNbr1.TabIndex = 6
        '
        'EX2S1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 391)
        Me.Controls.Add(Me.txtNbr1)
        Me.Controls.Add(Me.lblResultat)
        Me.Controls.Add(Me.bFois)
        Me.Controls.Add(Me.bMoins)
        Me.Controls.Add(Me.bPlus)
        Me.Controls.Add(Me.txtNbr2)
        Me.Name = "EX2S1"
        Me.Text = "2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNbr2 As System.Windows.Forms.TextBox
    Friend WithEvents bPlus As System.Windows.Forms.Button
    Friend WithEvents bMoins As System.Windows.Forms.Button
    Friend WithEvents bFois As System.Windows.Forms.Button
    Friend WithEvents lblResultat As System.Windows.Forms.Label
    Friend WithEvents txtNbr1 As System.Windows.Forms.TextBox
End Class
