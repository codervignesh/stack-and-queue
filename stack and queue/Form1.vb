Public Class Form1
    Dim mystack As New Stack
    Dim queue(6) As String
    Dim iFront As Integer
    Dim iRear As Integer = -1
    Dim iNumberInQueue As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub psh_Click(sender As Object, e As EventArgs) Handles psh.Click
        If stk.Checked Then
            psh.Text = "Push"
            pop.Text = "Pop"
            If psh_box.Text = "" Then
            Else
                mystack.Push(Me.psh_box.Text)
                Me.psh_box.Text = ""
                Me.psh_box.Select()
            End If
        ElseIf que.Checked Then
            psh.Text = "Enqueue"
            pop.Text = "Dequeue"
            If iNumberInQueue = 7 Then
                MsgBox("queue is full")
            Else
                If psh_box.Text = "" Then
                Else
                    If iRear = 6 Then
                        iRear = 0
                    Else
                        iRear = iRear + 1
                    End If
                    queue(iRear) = Me.psh_box.Text
                    Me.Controls("txtStack" & iRear).ForeColor = Color.Black
                    Me.Controls("txtStack" & iRear).Text = Me.psh_box.Text
                    Me.psh_box.Text = ""
                    iNumberInQueue = iNumberInQueue + 1
                End If
            End If
        End If
    End Sub

    Private Sub pop_Click(sender As Object, e As EventArgs) Handles pop.Click
        If stk.Checked Then
            psh.Text = "Push"
            pop.Text = "Pop"
            Me.pop_box.Text = mystack.Pop()
        ElseIf que.Checked Then
            psh.Text = "Enqueue"
            pop.Text = "Dequeue"
            If iNumberInQueue = 0 Then
                MsgBox("queue is empty")
            Else
                Me.pop_box.Text = queue(iFront)
                Me.Controls("txtStack" & iFront).ForeColor = Color.LightGray
                iNumberInQueue = iNumberInQueue - 1
                If iFront = 6 Then
                    iFront = 0
                Else
                    iFront = iFront + 1
                End If
            End If
        End If
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        Dim i As Integer
        Dim Arr() As Integer = {0, 1, 2, 3, 4, 5, 6}
        If stk.Checked Then
            psh.Text = "Push"
            pop.Text = "Pop"
        ElseIf que.Checked Then
            psh.Text = "Enqueue"
            pop.Text = "Dequeue"
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
        mystack.iTop = -1
        iFront = 0
        iRear = -1
        iNumberInQueue = 0
        For Each i In Arr
            Me.Controls("txtStack" & i).ForeColor = Color.Black
        Next
    End Sub


End Class

Class Stack
    Dim aData(6) As String
    Const iMaxsize As Integer = 6
    Public iTop As Integer = -1

    Public Sub Push(DataItem As String)
        If iTop = iMaxsize Then
            MsgBox("Stack overflow")
        Else
            iTop = iTop + 1
            aData(iTop) = DataItem

            Form1.Controls("txtStack" & iTop).Text = DataItem
            Form1.Controls("txtStack" & iTop).ForeColor = Color.Black
        End If
    End Sub

    Function Pop() As String
        Dim returnValue As String

        If iTop = -1 Then
            returnValue = "Stack is empty"
        Else
            returnValue = aData(iTop)

            Form1.Controls("txtStack" & iTop).ForeColor = Color.LightGray
            iTop = iTop - 1
        End If

        Return returnValue
    End Function
End Class
