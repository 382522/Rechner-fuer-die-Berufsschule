Public Class Form1
    Dim Eingabe1 As Double
    Dim Eingabe2 As Double
    Dim Ausgabe As Double


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Eingabe1 = CDbl(TextBox1.Text)
        Eingabe2 = CDbl(TextBox2.Text)
        Ausgabe = Eingabe1 + Eingabe2
        TextBox3.Text = CSng(Ausgabe)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Eingabe1 = CDbl(TextBox1.Text)
        Eingabe2 = CDbl(TextBox2.Text)
        Ausgabe = Eingabe1 - Eingabe2
        TextBox3.Text = CSng(Ausgabe)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Eingabe1 = CDbl(TextBox1.Text)
        Eingabe2 = CDbl(TextBox2.Text)
        Ausgabe = Eingabe1 * Eingabe2
        TextBox3.Text = CSng(Ausgabe)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Eingabe1 = CDbl(TextBox1.Text)
        Eingabe2 = CDbl(TextBox2.Text)
        Ausgabe = Eingabe1 / Eingabe2
        TextBox3.Text = CSng(Ausgabe)
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
