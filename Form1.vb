Public Class Form1

    Public WordData As New List(Of Dictionary(Of String, List(Of String)))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sLetter As String
        Dim AlphaBet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
        "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

        WordData.Add(New Dictionary(Of String, List(Of String)))
        WordData.Add(New Dictionary(Of String, List(Of String)))
        WordData.Add(New Dictionary(Of String, List(Of String)))
        WordData.Add(New Dictionary(Of String, List(Of String)))
        WordData.Add(New Dictionary(Of String, List(Of String)))

        For Each sLetter In AlphaBet
            WordData(0).Add(sLetter, New List(Of String))
            WordData(1).Add(sLetter, New List(Of String))
            WordData(2).Add(sLetter, New List(Of String))
            WordData(3).Add(sLetter, New List(Of String))
            WordData(4).Add(sLetter, New List(Of String))
        Next

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim aWords() As String
        Dim alWords As New List(Of String)
        Dim sWord As String
        Dim acLetters() As Char
        Dim asLetters(4) As String

        aWords = System.IO.File.ReadAllText("c:\words_alpha_5.txt").Replace(vbCr, "").Split(vbLf)

        For Each sWord In aWords
            If sWord.Length = 5 Then

                alWords.Add(sWord)

                sWord = sWord.ToUpper
                acLetters = sWord.ToCharArray

                For i As Integer = 0 To 4

                    asLetters(i) = acLetters(i).ToString.ToUpper

                    If Not WordData(i)(asLetters(i)).Contains(sWord) Then
                        WordData(i)(asLetters(i)).Add(sWord)
                    End If

                Next

            End If
        Next

        Dim SS As String = ""
        For Each sWord In alWords
            SS &= sWord & vbCrLf
        Next
        System.IO.File.WriteAllText("\words_alpha_5.txt", SS)



        '+++
        For r As Integer = 0 To TLP1.RowCount - 1
            For c As Integer = 0 To TLP1.ColumnCount - 1
                TLP1.Controls.Add(New WB, c, r)
            Next
        Next

        TLP1.AutoSize = True
        TLP1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        '---

    End Sub

End Class
