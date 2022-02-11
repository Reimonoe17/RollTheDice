'Jamison Burton
'RCET 0265
'Spring 2022
'https://github.com/Reimonoe17/RollTheDice
Module RollTheDice

    Sub Main()
        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim Roll(11) As Integer
        Dim Result(11) As Integer

        Console.WriteLine("Roll of the Dice")
        Console.WriteLine((StrDup(70, "-")))

        For i = 0 To 99
            firstRoll = RollDice()
            secondRoll = RollDice()
        Next

        Console.ReadLine()
    End Sub
    Function RollDice() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

End Module
