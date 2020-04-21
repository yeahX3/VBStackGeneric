Public Class stackN(Of T)
    Public first As DLNode(Of T)
    Public last As DLNode(Of T)
    Public counter As Integer = 0

    Public Function Push(el As T)
        Dim temp As New DLNode(Of T)
        temp.setElement(el)

        If (counter = 0) Then
            temp.setNext(last)
            temp.setPrev(first)

            last = New DLNode(Of T)
            last.setPrev(temp)

            first = New DLNode(Of T)
            first.setNext(temp)

        Else
            temp.setNext(last)
            temp.setPrev(last.getPrev())

            last.getPrev().setNext(temp)
            last.setPrev(temp)

        End If

        counter += 1

    End Function


    Public Function Pop() As T
        If (counter = 0) Then
            Throw New Exception
        Else
            Dim outputValue As T = last.getPrev().getElement()

            Dim Pointer As DLNode(Of T) = last.getPrev().getPrev()

            'last.getPrev().getPrev().setNext(last)
            Try
                Pointer.setNext(last)
                last.setPrev(Pointer)
            Catch ex As Exception
                Pointer = Nothing

            End Try


            counter -= 1

            Return outputValue
        End If
    End Function

    Public Function Top() As T
        Dim outputValue As T
        outputValue = last.getPrev().getElement()

        Return outputValue
    End Function

    Public Function size() As Integer
        Return counter
    End Function


End Class
