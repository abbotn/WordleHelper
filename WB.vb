Partial Public Class WB
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB.TextChanged

        Dim WordList As New List(Of String)
        Dim YellowList As New List(Of String)
        Dim HaveYellow As Boolean

        Dim WB As WB
        Dim s As String

        For r As Integer = 0 To Form1.TLP1.RowCount - 1
            For c As Integer = 0 To Form1.TLP1.ColumnCount - 1
                WB = Form1.TLP1.GetControlFromPosition(c, r)

                If WB.TB.Text <> "" AndAlso WB.TB.BackColor = Color.LightGreen Then

                    If WordList.Count = 0 Then
                        For Each s In Form1.WordData(c)(WB.TB.Text).ToArray
                            If Not WordList.Contains(s) Then
                                WordList.Add(s)
                            End If
                        Next
                    Else
                        For Each s In WordList.ToArray
                            If Not Form1.WordData(c)(WB.TB.Text).Contains(s) Then
                                WordList.Remove(s)
                            End If
                        Next
                    End If
                End If
            Next
        Next


        For r As Integer = 0 To Form1.TLP1.RowCount - 1
            For c As Integer = 0 To Form1.TLP1.ColumnCount - 1
                WB = Form1.TLP1.GetControlFromPosition(c, r)

                If WB.TB.Text <> "" AndAlso WB.TB.BackColor = Color.Yellow Then

                    If YellowList.Count = 0 Then
                        For c1 As Integer = 0 To Form1.TLP1.ColumnCount - 1
                            If c1 <> c Then
                                For Each s In Form1.WordData(c1)(WB.TB.Text).ToArray
                                    If Not YellowList.Contains(s) Then
                                        YellowList.Add(s)
                                    End If
                                Next
                            End If
                        Next
                    Else

                        For Each s In YellowList.ToArray

                            For c1 As Integer = 0 To Form1.TLP1.ColumnCount - 1
                                If c1 <> c Then

                                    If Form1.WordData(c1)(WB.TB.Text).Contains(s) Then
                                        HaveYellow = True
                                        Exit For
                                    End If
                                End If
                            Next

                            If Not HaveYellow Then
                                YellowList.Remove(s)
                            End If
                            HaveYellow = False

                        Next
                    End If

                End If
            Next
        Next

        If YellowList.Count > 0 Then
            If WordList.Count = 0 Then
                WordList = YellowList
            Else
                For Each s In WordList.ToArray
                    If Not YellowList.Contains(s) Then
                        WordList.Remove(s)
                    End If
                Next
            End If
        End If



        For r As Integer = 0 To Form1.TLP1.RowCount - 1
            For c As Integer = 0 To Form1.TLP1.ColumnCount - 1
                WB = Form1.TLP1.GetControlFromPosition(c, r)

                If WB.TB.Text <> "" AndAlso WB.TB.BackColor = Color.LightGray Then

                    For c1 As Integer = 0 To Form1.TLP1.ColumnCount - 1
                        For Each s In Form1.WordData(c1)(WB.TB.Text).ToArray
                            If WordList.Contains(s) Then
                                WordList.Remove(s)
                            End If
                        Next
                    Next
                End If
            Next
        Next





        Form1.ListView1.Items.Clear()
        For Each s In WordList
            Form1.ListView1.Items.Add(s)
        Next

    End Sub

    Private Sub TB_Click(sender As Object, e As EventArgs) Handles TB.Click

        Dim TB As TextBox = sender

        If TB.Text <> "" Then
            If TB.BackColor = Color.LightGray Then
                TB.BackColor = Color.LightGreen
            ElseIf TB.BackColor = Color.LightGreen Then
                TB.BackColor = Color.Yellow
            ElseIf TB.BackColor = Color.Yellow Then
                TB.BackColor = Color.LightGray
            End If

            TextBox1_TextChanged(Nothing, Nothing)

        Else
            TB.BackColor = Color.LightGray
        End If

    End Sub

End Class
