Public Class EX1S1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Rappel
        'vbLf ou vbCr ou vbCrLf est interprété de la même manière
        'VbLf = Chr(10) ( Line Feed) : Saut de ligne
        'vbCr = Chr(13) (Carriage Return) : Retour charriot
        'vbCrLf = Chr(13) & Chr(10)
        MessageBox.Show("Bienvenue! " _
                        & vbLf & tbNom.Text & tbPrenom.Text, "TP Vb.Net", MessageBoxButtons.OK)
    End Sub

    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        tbNom.Clear()
        tbPrenom.Clear()

    End Sub
End Class
