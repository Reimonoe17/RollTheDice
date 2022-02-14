'Jamison Burton
'RCET 0265
'Spring 2022
'https://github.com/Reimonoe17/RollTheDice
Module RollTheDice

    Sub Main()
        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim Result(12) As Integer

        'Writes out title
        Console.WriteLine(CStr("Roll of the Dice").PadLeft(45))
        Console.WriteLine((StrDup(90, "-")))

        'perform calcutations using Randomizer with dice values and adds to Result array
        For i = 0 To 999
            firstRoll = RollDice()
            secondRoll = RollDice()
            Result(firstRoll + secondRoll) += 1
        Next

        'displays array columns
        For i = 2 To UBound(Result)
            Console.Write(CStr(i).PadLeft(6) & " |")
        Next

        Console.WriteLine("")
        Console.WriteLine((StrDup(90, "-")))

        'displays array results
        For i = 2 To UBound(Result)
            Console.Write(CStr(Result(i)).PadLeft(6) & " |")
        Next

        Console.ReadLine()
    End Sub
    Function RollDice() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value 'Outputs a random value between 1 and 6
    End Function

End Module
