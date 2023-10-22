Public Class ll
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim input As String
        Dim result As String
        Dim len As Integer
        Dim a, b As Integer


        input = TextBox1.Text
        len = input.Length
        a = len - 1
        For b = 0 To a

            result = result & input.Chars(a)
            a = a - 1
            txt4.Text = result

        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input As String
        Dim result As String
        Dim len As Integer
        Dim a, b As Integer


        input = TextBox2.Text
        len = input.Length
        a = len - 1
        For b = 0 To a

            result = result & input.Chars(a)
            a = a - 1
            txt1.Text = result

        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input As String
        Dim result As String
        Dim len As Integer
        Dim a, b As Integer


        input = TextBox3.Text
        len = input.Length
        a = len - 1
        For b = 0 To a

            result = result & input.Chars(a)
            a = a - 1
            txt5.Text = result

        Next

    End Sub
End Class
