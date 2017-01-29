Public Class Form1
    Dim turns(10, 6) As Label
    Dim solution(6) As Integer
    Dim row As Integer
    Dim column As Integer
    Dim guess(6) As Integer
    Dim indicators(10, 6) As Label
    Dim won As Boolean = False
    Dim lost As Boolean = False
    Dim debugSet(6) As Label
    Dim uniqueCheck(6) As Boolean
    Dim uniqueStart(6) As Boolean
    Dim solutionSet(6) As Label

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        won = False
        lost = False
        row = 0
        column = 0

        Dim x As Integer = 0
        Dim y As Integer = 0

        Do While x < 10
            y = 0
            Do While y < 6
                turns(x, y).BackColor = Color.Gray
                indicators(x, y).BackColor = Color.Cyan
                y += 1
            Loop
            x += 1
        Loop

        Dim zTemp As Integer = 0
        Do While zTemp < 6
            turns(0, zTemp).BackColor = Color.Silver
            zTemp += 1
        Loop

        Dim tempChange As Integer = 0
        Do While tempChange < 6
            solutionSet(tempChange).BackColor = Color.Gray
            solutionSet(tempChange).ForeColor = Color.Black
            tempChange += 1
        Loop

        Randomize()
        solution(0) = Int((8 * Rnd()) + 1)
        solution(1) = Int((8 * Rnd()) + 1)
        solution(2) = Int((8 * Rnd()) + 1)
        solution(3) = Int((8 * Rnd()) + 1)
        solution(4) = Int((8 * Rnd()) + 1)
        solution(5) = Int((8 * Rnd()) + 1)

        Dim tempTracker As Integer = 0

        Do While tempTracker < 6
            If solution(tempTracker) = 1 Then
                debugSet(tempTracker).BackColor = Color.Red
            ElseIf solution(tempTracker) = 2 Then
                debugSet(tempTracker).BackColor = Color.Orange
            ElseIf solution(tempTracker) = 3 Then
                debugSet(tempTracker).BackColor = Color.Yellow
            ElseIf solution(tempTracker) = 4 Then
                debugSet(tempTracker).BackColor = Color.Green
            ElseIf solution(tempTracker) = 5 Then
                debugSet(tempTracker).BackColor = Color.Blue
            ElseIf solution(tempTracker) = 6 Then
                debugSet(tempTracker).BackColor = Color.Purple
            ElseIf solution(tempTracker) = 7 Then
                debugSet(tempTracker).BackColor = Color.White
            ElseIf solution(tempTracker) = 8 Then
                debugSet(tempTracker).BackColor = Color.Black
            End If

            uniqueCheck(tempTracker) = False
            uniqueStart(tempTracker) = False
            tempTracker += 1
            
        Loop

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lost = True

        turns(0, 0) = lbl00
        turns(0, 1) = lbl01
        turns(0, 2) = lbl02
        turns(0, 3) = lbl03
        turns(0, 4) = lbl04
        turns(0, 5) = lbl05

        turns(1, 0) = lbl10
        turns(1, 1) = lbl11
        turns(1, 2) = lbl12
        turns(1, 3) = lbl13
        turns(1, 4) = lbl14
        turns(1, 5) = lbl15

        turns(2, 0) = lbl20
        turns(2, 1) = lbl21
        turns(2, 2) = lbl22
        turns(2, 3) = lbl23
        turns(2, 4) = lbl24
        turns(2, 5) = lbl25

        turns(3, 0) = lbl30
        turns(3, 1) = lbl31
        turns(3, 2) = lbl32
        turns(3, 3) = lbl33
        turns(3, 4) = lbl34
        turns(3, 5) = lbl35

        turns(4, 0) = lbl40
        turns(4, 1) = lbl41
        turns(4, 2) = lbl42
        turns(4, 3) = lbl43
        turns(4, 4) = lbl44
        turns(4, 5) = lbl45

        turns(5, 0) = lbl50
        turns(5, 1) = lbl51
        turns(5, 2) = lbl52
        turns(5, 3) = lbl53
        turns(5, 4) = lbl54
        turns(5, 5) = lbl55

        turns(6, 0) = lbl60
        turns(6, 1) = lbl61
        turns(6, 2) = lbl62
        turns(6, 3) = lbl63
        turns(6, 4) = lbl64
        turns(6, 5) = lbl65

        turns(7, 0) = lbl70
        turns(7, 1) = lbl71
        turns(7, 2) = lbl72
        turns(7, 3) = lbl73
        turns(7, 4) = lbl74
        turns(7, 5) = lbl75

        turns(8, 0) = lbl80
        turns(8, 1) = lbl81
        turns(8, 2) = lbl82
        turns(8, 3) = lbl83
        turns(8, 4) = lbl84
        turns(8, 5) = lbl85

        turns(9, 0) = lbl90
        turns(9, 1) = lbl91
        turns(9, 2) = lbl92
        turns(9, 3) = lbl93
        turns(9, 4) = lbl94
        turns(9, 5) = lbl95


        indicators(0, 0) = lbli00
        indicators(0, 1) = lbli01
        indicators(0, 2) = lbli02
        indicators(0, 3) = lbli03
        indicators(0, 4) = lbli04
        indicators(0, 5) = lbli05

        indicators(1, 0) = lbli10
        indicators(1, 1) = lbli11
        indicators(1, 2) = lbli12
        indicators(1, 3) = lbli13
        indicators(1, 4) = lbli14
        indicators(1, 5) = lbli15

        indicators(2, 0) = lbli20
        indicators(2, 1) = lbli21
        indicators(2, 2) = lbli22
        indicators(2, 3) = lbli23
        indicators(2, 4) = lbli24
        indicators(2, 5) = lbli25

        indicators(3, 0) = lbli30
        indicators(3, 1) = lbli31
        indicators(3, 2) = lbli32
        indicators(3, 3) = lbli33
        indicators(3, 4) = lbli34
        indicators(3, 5) = lbli35

        indicators(4, 0) = lbli40
        indicators(4, 1) = lbli41
        indicators(4, 2) = lbli42
        indicators(4, 3) = lbli43
        indicators(4, 4) = lbli44
        indicators(4, 5) = lbli45

        indicators(5, 0) = lbli50
        indicators(5, 1) = lbli51
        indicators(5, 2) = lbli52
        indicators(5, 3) = lbli53
        indicators(5, 4) = lbli54
        indicators(5, 5) = lbli55

        indicators(6, 0) = lbli60
        indicators(6, 1) = lbli61
        indicators(6, 2) = lbli62
        indicators(6, 3) = lbli63
        indicators(6, 4) = lbli64
        indicators(6, 5) = lbli65

        indicators(7, 0) = lbli70
        indicators(7, 1) = lbli71
        indicators(7, 2) = lbli72
        indicators(7, 3) = lbli73
        indicators(7, 4) = lbli74
        indicators(7, 5) = lbli75

        indicators(8, 0) = lbli80
        indicators(8, 1) = lbli81
        indicators(8, 2) = lbli82
        indicators(8, 3) = lbli83
        indicators(8, 4) = lbli84
        indicators(8, 5) = lbli85

        indicators(9, 0) = lbli90
        indicators(9, 1) = lbli91
        indicators(9, 2) = lbli92
        indicators(9, 3) = lbli93
        indicators(9, 4) = lbli94
        indicators(9, 5) = lbli95


        debugSet(0) = lbld0
        debugSet(1) = lbld1
        debugSet(2) = lbld2
        debugSet(3) = lbld3
        debugSet(4) = lbld4
        debugSet(5) = lbld5

        solutionSet(0) = lblA0
        solutionSet(1) = lblA1
        solutionSet(2) = lblA2
        solutionSet(3) = lblA3
        solutionSet(4) = lblA4
        solutionSet(5) = lblA5

    End Sub

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click

        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 1
            turns(row, column).BackColor = Color.Red
            column += 1
        End If
    End Sub

    Private Sub btnOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrange.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 2
            turns(row, column).BackColor = Color.Orange
            column += 1
        End If
    End Sub

    Private Sub btnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 3
            turns(row, column).BackColor = Color.Yellow
            column += 1
        End If
    End Sub

    Private Sub btnGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreen.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 4
            turns(row, column).BackColor = Color.Green
            column += 1
        End If
    End Sub

    Private Sub btnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlue.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 5
            turns(row, column).BackColor = Color.Blue
            column += 1
        End If
    End Sub

    Private Sub btnPurple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurple.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 6
            turns(row, column).BackColor = Color.Purple
            column += 1
        End If
    End Sub

    Private Sub btnWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhite.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 7
            turns(row, column).BackColor = Color.White
            column += 1
        End If
    End Sub

    Private Sub btnBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlack.Click
        If won = True Or lost = True Then
            MessageBox.Show("Please start a new game.")
        ElseIf column < 6 Then
            guess(column) = 8
            turns(row, column).BackColor = Color.Black
            column += 1
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim x As Integer = 0

        If won = False And lost = False Then
            Do While x < 6
                turns(row, x).BackColor = Color.Silver
                guess(x) = 0
                x += 1
            Loop

            column = 0
        Else
            MessageBox.Show("Please start a new game.")
        End If
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim tempColumn As Integer = 0
        Dim tempCheckColumn As Integer = 0
        Dim rColorRSpot As Integer = 0
        Dim rColorWSpot As Integer = 0
        Dim tempTracker As Integer = 0
        Dim tempx As Integer = 0

        Do While tempx < 6
            uniqueCheck(tempx) = False
            uniqueStart(tempx) = False
            tempx += 1
        Loop

        If column < 6 Then
            MessageBox.Show("Please fill all of the nodes!")
        Else
            If won = True Or lost = True Then
                MessageBox.Show("Please start a new game.")
               
            Else
                If guess(0) = solution(0) And guess(1) = solution(1) And guess(2) = solution(2) And guess(3) = solution(3) And guess(4) = solution(4) And guess(5) = solution(5) Then
                    won = True
                    MessageBox.Show("You won!")
                    tempTracker = 0
                    Do While tempTracker < 6
                        If solution(tempTracker) = 1 Then
                            solutionSet(tempTracker).BackColor = Color.Red
                        ElseIf solution(tempTracker) = 2 Then
                            solutionSet(tempTracker).BackColor = Color.Orange
                        ElseIf solution(tempTracker) = 3 Then
                            solutionSet(tempTracker).BackColor = Color.Yellow
                        ElseIf solution(tempTracker) = 4 Then
                            solutionSet(tempTracker).BackColor = Color.Green
                        ElseIf solution(tempTracker) = 5 Then
                            solutionSet(tempTracker).BackColor = Color.Blue
                            solutionSet(tempTracker).ForeColor = Color.White
                        ElseIf solution(tempTracker) = 6 Then
                            solutionSet(tempTracker).BackColor = Color.Purple
                            solutionSet(tempTracker).ForeColor = Color.White
                        ElseIf solution(tempTracker) = 7 Then
                            solutionSet(tempTracker).BackColor = Color.White
                        ElseIf solution(tempTracker) = 8 Then
                            solutionSet(tempTracker).BackColor = Color.Black
                            solutionSet(tempTracker).ForeColor = Color.White
                        End If

                        tempTracker += 1
                    Loop
                Else
                    Do While tempCheckColumn < 6
                        If guess(tempCheckColumn) = solution(tempCheckColumn) Then
                            rColorRSpot += 1
                            uniqueCheck(tempCheckColumn) = True
                            uniqueStart(tempCheckColumn) = True
                        End If
                        tempCheckColumn += 1
                    Loop
                    tempCheckColumn = 0
                    Do While tempCheckColumn < 6
                        tempColumn = 0
                        Do While tempColumn < 6
                            If tempCheckColumn <> tempColumn And guess(tempCheckColumn) = solution(tempColumn) And uniqueCheck(tempColumn) = False And uniqueStart(tempCheckColumn) = False Then
                                rColorWSpot += 1
                                uniqueCheck(tempColumn) = True
                                uniqueStart(tempCheckColumn) = True
                            End If
                            tempColumn += 1
                        Loop
                        tempCheckColumn += 1
                    Loop

                    Dim tempIndicator As Integer = 0
                    Do While rColorRSpot > 0
                        indicators(row, tempIndicator).BackColor = Color.Black
                        rColorRSpot -= 1
                        tempIndicator += 1
                    Loop
                    Do While rColorWSpot > 0
                        indicators(row, tempIndicator).BackColor = Color.White
                        rColorWSpot -= 1
                        tempIndicator += 1
                    Loop

                    If row < 9 Then
                        row += 1
                        column = 0
                        Dim xTemp As Integer = 0
                        Do While xTemp < 6
                            turns(row, xTemp).BackColor = Color.Silver
                            xTemp += 1
                        Loop
                    Else
                        lost = True
                        MessageBox.Show("You lose!")
                        tempTracker = 0
                        Do While tempTracker < 6
                            If solution(tempTracker) = 1 Then
                                solutionSet(tempTracker).BackColor = Color.Red
                            ElseIf solution(tempTracker) = 2 Then
                                solutionSet(tempTracker).BackColor = Color.Orange
                            ElseIf solution(tempTracker) = 3 Then
                                solutionSet(tempTracker).BackColor = Color.Yellow
                            ElseIf solution(tempTracker) = 4 Then
                                solutionSet(tempTracker).BackColor = Color.Green
                            ElseIf solution(tempTracker) = 5 Then
                                solutionSet(tempTracker).BackColor = Color.Blue
                                solutionSet(tempTracker).ForeColor = Color.White
                            ElseIf solution(tempTracker) = 6 Then
                                solutionSet(tempTracker).BackColor = Color.Purple
                                solutionSet(tempTracker).ForeColor = Color.White
                            ElseIf solution(tempTracker) = 7 Then
                                solutionSet(tempTracker).BackColor = Color.White
                            ElseIf solution(tempTracker) = 8 Then
                                solutionSet(tempTracker).BackColor = Color.Black
                                solutionSet(tempTracker).ForeColor = Color.White
                            End If

                            tempTracker += 1
                        Loop
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ViewSolutionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSolutionToolStripMenuItem.Click
        If lbld0.Visible = False Then
            lbld0.Visible = True
            lbld1.Visible = True
            lbld2.Visible = True
            lbld3.Visible = True
            lbld4.Visible = True
            lbld5.Visible = True
        Else
            lbld0.Visible = False
            lbld1.Visible = False
            lbld2.Visible = False
            lbld3.Visible = False
            lbld4.Visible = False
            lbld5.Visible = False
        End If
    End Sub

    Private Sub btnNewGameE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGameE.Click
        won = False
        lost = False
        row = 0
        column = 0

        Dim x As Integer = 0
        Dim y As Integer = 0


        Do While x < 10
            y = 0
            Do While y < 6
                turns(x, y).BackColor = Color.Gray
                indicators(x, y).BackColor = Color.Cyan
                y += 1
            Loop
            x += 1
        Loop

        Dim zTemp As Integer = 0
        Do While zTemp < 6
            turns(0, zTemp).BackColor = Color.Silver
            zTemp += 1
        Loop

        Dim tempChange As Integer = 0
        Do While tempChange < 6
            solutionSet(tempChange).BackColor = Color.Gray
            solutionSet(tempChange).ForeColor = Color.Black
            tempChange += 1
        Loop

        Randomize()
        solution(0) = Int((8 * Rnd()) + 1)
        solution(1) = Int((8 * Rnd()) + 1)
        solution(2) = Int((8 * Rnd()) + 1)
        solution(3) = Int((8 * Rnd()) + 1)
        solution(4) = Int((8 * Rnd()) + 1)
        solution(5) = Int((8 * Rnd()) + 1)

        Do While solution(1) = solution(0)
            solution(1) = Int((8 * Rnd()) + 1)
        Loop
        Do While solution(2) = solution(1) Or solution(2) = solution(0)
            solution(2) = Int((8 * Rnd()) + 1)
        Loop
        Do While solution(3) = solution(1) Or solution(3) = solution(0) Or solution(3) = solution(2)
            solution(3) = Int((8 * Rnd()) + 1)
        Loop
        Do While solution(4) = solution(1) Or solution(4) = solution(0) Or solution(4) = solution(2) Or solution(4) = solution(3)
            solution(4) = Int((8 * Rnd()) + 1)
        Loop
        Do While solution(5) = solution(1) Or solution(5) = solution(0) Or solution(5) = solution(2) Or solution(5) = solution(3) Or solution(5) = solution(4)
            solution(5) = Int((8 * Rnd()) + 1)
        Loop

        Dim tempTracker As Integer = 0

        Do While tempTracker < 6
            If solution(tempTracker) = 1 Then
                debugSet(tempTracker).BackColor = Color.Red
            ElseIf solution(tempTracker) = 2 Then
                debugSet(tempTracker).BackColor = Color.Orange
            ElseIf solution(tempTracker) = 3 Then
                debugSet(tempTracker).BackColor = Color.Yellow
            ElseIf solution(tempTracker) = 4 Then
                debugSet(tempTracker).BackColor = Color.Green
            ElseIf solution(tempTracker) = 5 Then
                debugSet(tempTracker).BackColor = Color.Blue
            ElseIf solution(tempTracker) = 6 Then
                debugSet(tempTracker).BackColor = Color.Purple
            ElseIf solution(tempTracker) = 7 Then
                debugSet(tempTracker).BackColor = Color.White
            ElseIf solution(tempTracker) = 8 Then
                debugSet(tempTracker).BackColor = Color.Black
            End If

            uniqueCheck(tempTracker) = False
            uniqueStart(tempTracker) = False
            tempTracker += 1

        Loop
    End Sub

    Private Sub RulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulesToolStripMenuItem.Click
        MessageBox.Show("The object of Mastermind is to guess a series of six colors that are randomly generated by the game." & vbCrLf & vbCrLf & "This is accomplished by clicking the eight possible colors to fill the six guess nodes and pressing the Check button.  The game responds by filling the six cyan indicator nodes with either the color black or the color white." & vbCrLf & vbCrLf & "A black indicator node suggests that you have chosen a correct color and it is in the correct position." & vbCrLf & vbCrLf & "A white indicator node suggests that you have chosen a correct color, but that color is in the wrong position" & vbCrLf & vbCrLf & "You are given ten guesses so think and choose carefully.  If you make a mistake or are unsure of your current guess, the Delete button is there to clear your current line so your new guess can be entered.  But once the Check button is clicked, that guess is locked in and cannot be taken back." & vbCrLf & vbCrLf & "To begin, press either of the New Game options.  Enjoy Mastermind!", "Rules")
    End Sub

    Private Sub EasyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem.Click
        MessageBox.Show("Traditionally, Mastermind is played with the ability to have duplicate colors.  This means that it is possible to have two or more of each color in each solution." & vbCrLf & vbCrLf & "The option of Easy is intended to help those new to Mastermind.  The amount of colors, guesses and guess nodes are the same, but there can only be one of any color in each solution." & vbCrLf & vbCrLf & "Once you feel comfortable with the basics of Mastermind, press the normal New Game button to begin a game with duplicates.", "Easy")
    End Sub
End Class
