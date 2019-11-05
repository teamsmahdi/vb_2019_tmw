Public Class EX2S1

    Private ancienButton As New Button
    Private ancienLocation As New Point
    Private Sub bPlus_Click(sender As Object, e As EventArgs) Handles bPlus.Click
        Dim p As Point
        'distance horizontale entre deux TextBox
        Dim decalage As Double = (txtNbr2.Location.X - txtNbr1.Location.X - txtNbr1.Width) / 2
        Console.WriteLine(decalage)
        p.X = txtNbr1.Location.X + txtNbr1.Width + decalage / 2
        'positon Verticale du bouton
        p.Y = txtNbr1.Location.Y
        'First Clic=>empty Location
        If (IsNothing(ancienLocation)) Then
            ancienLocation = bPlus.Location
            ancienButton = bPlus
        Else
            'retour ancien bouton
            ancienButton.Location = ancienLocation
            ancienButton = bPlus
            ancienLocation = bPlus.Location

        End If
        bPlus.Location = p
        lblResultat.Text = "=" & CDbl(txtNbr1.Text) + CDbl(txtNbr2.Text)

    End Sub

 
  
    Private Sub bMoins_Click(sender As Object, e As EventArgs) Handles bMoins.Click

        Dim p As Point
        'distance horizontale entre deux TextBox
        Dim decalage As Double = (txtNbr2.Location.X - txtNbr1.Location.X - txtNbr1.Width) / 2
        Console.WriteLine(decalage)
        p.X = txtNbr1.Location.X + txtNbr1.Width + decalage / 2
        'positon Verticale du bouton
        p.Y = txtNbr1.Location.Y
        'First Clic=>empty Location
        If (IsNothing(ancienLocation)) Then
            ancienLocation = bMoins.Location
            ancienButton = bMoins
        Else
            'retour ancien bouton
            ancienButton.Location = ancienLocation
            ancienButton = bMoins
            ancienLocation = bMoins.Location
        End If
        bMoins.Location = p
        lblResultat.Text = "=" & CDbl(txtNbr1.Text) - CDbl(txtNbr2.Text)
    End Sub



    Private Sub bFois_Click(sender As Object, e As EventArgs) Handles bFois.Click
        Dim p As Point
        'distance horizontale entre deux TextBox
        Dim decalage As Double = (txtNbr2.Location.X - txtNbr1.Location.X - txtNbr1.Width) / 2
        Console.WriteLine(decalage)
        p.X = txtNbr1.Location.X + txtNbr1.Width + decalage / 2
        'positon Verticale du bouton
        p.Y = txtNbr1.Location.Y
        'First Clic=>empty Location
        If (IsNothing(ancienLocation)) Then
            ancienLocation = bFois.Location
            ancienButton = bFois
        Else
            'retour ancien bouton
            ancienButton.Location = ancienLocation
            ancienButton = bFois
            ancienLocation = bFois.Location
        End If
        bFois.Location = p
        lblResultat.Text = "=" & CDbl(txtNbr1.Text) * CDbl(txtNbr2.Text)
    End Sub

 

    'sans cliquer le bouton plus, calculer le resultalt     
    Private Sub txtNbr_TextChanged(sender As Object, e As EventArgs) Handles txtNbr1.TextChanged, txtNbr2.TextChanged
        If IsNumeric(txtNbr1.Text) And IsNumeric(txtNbr2.Text) Then
            If CDbl(txtNbr1.Text) > CDbl(txtNbr2.Text) Then
                lblResultat.Text = "=" & CDbl(txtNbr1.Text) + CDbl(txtNbr2.Text)
            Else
                lblResultat.Text = "?"
            End If
        End If

    End Sub
End Class