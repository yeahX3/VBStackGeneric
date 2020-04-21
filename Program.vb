Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        '---TESTING DLNODES-----------------------------------------------------------------
        Dim aNode As New DLNode(Of Integer)

        aNode.setElement(5)

        Console.WriteLine("number saved is " & aNode.getElement())

        Dim bNode As New DLNode(Of Integer)
        bNode.setElement(10)

        aNode.setNext(bNode)

        Console.WriteLine("the next number is: " & aNode.getNext().getElement)

        '--TESTING STACK----------------------------------------------------------------------
        Dim myStack As New stackN(Of Integer)

        Console.WriteLine("Entering numbers 10, 20, 30")
        myStack.Push(10)
        myStack.Push(20)
        myStack.Push(30)

        Console.WriteLine("Reading stack")
        Try
            While myStack.counter > 0
                Console.Write(myStack.Pop() & ", ")
            End While
        Catch ex As Exception
            Console.WriteLine("Stack is empty")
        End Try


    End Sub

    Dim myStack As New Stack



End Module
