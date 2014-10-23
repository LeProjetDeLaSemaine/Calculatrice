Public Class Form1
    Dim nb1, nb2, resultat As Double
    Dim i As Short

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        i = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        i = 2
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        i = 3
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        i = 4
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        i = 5
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        i = 6
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        i = 7
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
33:         nb1 = TextBox1.Text
        Catch ex As Exception
            Beep()
        End Try
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
35:         nb2 = TextBox2.Text
        Catch ex As Exception
            Beep()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = ""
        Try
            Select Case i
                Case 1
                    resultat = nb1 + nb2
                Case 2
                    resultat = nb1 - nb2
                Case 3
                    resultat = nb1 * nb2
                Case 4
                    resultat = nb1 / nb2
                Case 5
                    resultat = nb1 \ nb2
                    TextBox4.Text = nb1 Mod nb2
                Case 6
                    resultat = nb1 ^ nb2
                Case 7
                    resultat = nb1 & nb2
            End Select
            TextBox3.Text = resultat
        Catch ex As Exception
            Beep()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            TextBox1.Text = resultat
            nb1 = resultat
        Catch ex As Exception
            Beep()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            TextBox2.Text = resultat
            nb2 = resultat
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RéinitialiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RéinitialiserToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        MsgBox("Calculatrice, programmée par Ernest Foussard, dernière mise à jour: 27/05/2013 à 17:08")
    End Sub
End Class
