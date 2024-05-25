' OOPS in VB.NET
Class Base
    ' Dy default all the members of a class are private
    Protected id As Integer
    Public str As String

    'Default Constructor
    Public Sub New()
        id = 1
        str = "Dhruv"
    End Sub

    'Parameterized Constructor
    Public Sub New(i As Integer)
        id = i
    End Sub

    Public Sub New(i As Integer, s As String)
        id = i
        str = s
    End Sub

    'Making a mathod overridable allows it to be overridden in derived class
    Public Overridable Sub Display()
        Console.WriteLine("ID: " & id & " Name: " & str)
    End Sub

    'Same as java there are no destructors in VB.NET due to automatic garbage collection
    'but we can override finalize method to perform cleanup operations
    Protected Overrides Sub Finalize()
        Console.WriteLine("Object Destroyed")
    End Sub

End Class

' To make a class abstract we use MustInherit keyword before class keyword
' NotInheritable keyword is used to make a class non-inheritable
' Implements keyword is used to implement an interface
MustInherit Class Base1
    Protected key As Integer

    Protected MustOverride Sub setKey(k As Integer)

    Protected Sub getKey()
        Console.WriteLine("Key: " & key)
    End Sub
End Class


' Inheritance
' Inherits keyword is used to inherit a class
' Same as java we can inherit only one class and can implement multiple interfaces
Class Child
    Inherits Base

    'To creare static members we use Shared keyword
    Public Shared count As Integer

    Dim data As Integer

    Public Sub New()
        'MyBase points to the base class
        MyBase.New()
        data = 10
        count += 1
    End Sub

    Public Sub New(id As Integer, str As String, d As Integer)
        MyBase.New(id, str)
        data = d
        count += 1
    End Sub

    'both functions and sub are same, both can be overloaded and overridden
    Public Overrides Sub Display()
        Console.WriteLine("ID: " & id & " Name: " & str & " Data: " & data)
    End Sub

End Class


Class Complex
    Private i As Integer
    Private j As Integer

    ' Operator Overloading
    Public Shared Operator +(c1 As Complex, c2 As Complex) As Complex
        Dim c As Complex = New Complex()
        c.i = c1.i + c2.i
        c.j = c1.j + c2.j
        Return c
    End Operator

End Class

Public Class Form1

    ' Function Overloading
    Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    Function add(x As Integer, y As Integer, z As Integer) As Integer
        Return x + y + z
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ch As Child = New Child(1, "12", 2)
        ch.Display()

        'Runtime Polymorphism
        Dim par As Base = New Child(1, "1222", 2)
        par.Display()

    End Sub
End Class



