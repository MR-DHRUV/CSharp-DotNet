Public Class Form1

    ' Funtion -> can return a value
    ' Sub -> can't return a value, called as procedure

    Function fib(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        End If

        Return fib(n - 1) + fib(n - 2)
    End Function

    Const maxVal As Integer = 5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        Dim myArr() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

        'For loop
        For i As Integer = 1 To maxVal Step 1
            str = str + CStr(i)
            ' after completion of each iteration, next will update the variable counter
        Next
        TextBox1.Text() = str
        Console.WriteLine("done")

        'For each
        For Each i In myArr
            Console.WriteLine(i)
        Next

        'While 
        Dim x As Integer = 1
        While x < 10
            Console.WriteLine(x)
            x += 1
        End While

        'Do While
        Dim y As Integer = 1
        Do
            Console.WriteLine(y)
            y += 1
        Loop While y < 10

        ' if else
        If y = 10 Then
            Console.WriteLine("y is 10")
        ElseIf x = 10 Then
            Console.WriteLine("x is 10")
        Else
            Console.WriteLine("x and y are not 10")
        End If

        Console.WriteLine(fib(maxVal))

        'Switch case
        Select Case x
            Case 10
                Console.WriteLine("x is 1")
            Case 2
                Console.WriteLine("x is 2")
            Case 3
                Console.WriteLine("x is 3")
            Case Else
                Console.WriteLine("x is not 1, 2 or 3")
        End Select


    End Sub
End Class
