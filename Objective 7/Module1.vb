Module Module1

    Sub Main()
        Dim choice As String
        Dim choosing As Boolean
        choosing = True
        Do While choosing = True
            Console.Write("Which Challenge: ")
            choice = Console.ReadLine()
            If choice = "" Then choosing = False
            If choice = "1" Then Challenge1()
            If choice = "2" Then Challenge2()
            If choice = "3" Then challenge3()
            If choice = "4" Then Challenge4()
            If choice = "5" Then Challenge5()
            If choice = "6" Then Challenge6()
            If choice = "7" Then challenge7()
        Loop
    End Sub

    Sub Challenge1()
        Dim input As Integer
        Dim choosing As Boolean
        choosing = True
        Console.WriteLine("1. Play Game ")
        Console.WriteLine("2. Instructions ")
        Console.WriteLine("3. Quit")
        Do While choosing = True
            Console.Write("Choose: ")
            input = Console.ReadLine()
            If input = 1 Or input = 2 Or input = 3 Then
                choosing = False
            Else
                Console.WriteLine("That is not a valid input ")
            End If
        Loop
        Console.WriteLine("Valid option chosen ")
        Console.ReadLine()
    End Sub

    Sub Challenge2()
        Dim current, target, year As Integer
        Console.Write("What is your current ballence: ")
        current = Console.ReadLine()
        Console.Write("What is your target ballence: ")
        target = Console.ReadLine()
        year = 0
        Do While current < target
            current = current * 1.04
            year = year + 1
            Console.WriteLine("Year " & year & ", £" & current)
        Loop
    End Sub

    Sub challenge3()
        Dim rN, guess As Integer
        Dim playing As Boolean
        Randomize()
        rN = Rnd() * 100
        playing = True
        Do While playing = True
            Console.Write("Guess: ")
            guess = Console.ReadLine()
            If guess = rN Then
                Console.WriteLine("That's the correct number!! ")
                playing = False
            ElseIf guess < rN Then
                Console.WriteLine("That's too low ")
            ElseIf guess > rN Then
                Console.WriteLine("That's too high ")
            End If
        Loop
    End Sub

    Sub Challenge4()
        Dim gamertag As String
        Dim choosing As Boolean
        Console.WriteLine("Gamertag must not be longer than 15 characters")
        choosing = True
        Do While choosing = True
            Console.Write("Gamertag: ")
            gamertag = Console.ReadLine()
            If gamertag.Length() > 15 Then Console.WriteLine("That is too long")
            If gamertag.Length() < 16 Then choosing = False
        Loop
        Console.Write("Valid tag entered ")
    End Sub

    Sub Challenge5()
        Dim userChoice As String
        Dim rN, compScore, userScore As Integer
        Dim playing As Boolean
        Randomize()
        playing = True
        compScore = 0
        userScore = 0
        Do While playing = True
            Console.Write("Rock, Paper, or Scissors: ")
            userChoice = UCase(Left(Console.ReadLine(), 1))
            rN = Rnd() * 3
            'rock = 0, paper = 1, scissors = 2
            If userChoice = "R" And rN = 2 Then
                Console.WriteLine("You win")
                userScore = userScore + 1
            ElseIf userChoice = "P" And rN = 0 Then
                Console.WriteLine("You win")
                userScore = userScore + 1
            ElseIf userChoice = "S" And rN = 2 Then
                Console.WriteLine("You win")
                userScore = userScore + 1
            ElseIf userChoice = "R" And rN = 1 Then
                Console.WriteLine("You loose")
                compScore = compScore + 1
            ElseIf userChoice = "P" And rN = 2 Then
                Console.WriteLine("You loose")
                compScore = compScore + 1
            ElseIf userChoice = "S" And rN = 0 Then
                Console.WriteLine("You loose")
                compScore = compScore + 1
            Else
                Console.WriteLine("It was a tie")
            End If
            If userScore = 10 Then
                Console.WriteLine("You win!!")
                playing = False
            ElseIf compScore = 10 Then
                Console.WriteLine("You loose :(")
                playing = False
            End If
            Console.WriteLine("Your score: " & userScore & "  Computer score: " & compScore)
        Loop
        Console.Read()
    End Sub

    Sub Challenge6()
        Dim number As String
        Dim addition, four As Integer
        Dim checking As Boolean
        Console.Write("Number: ")
        number = Console.ReadLine()
        checking = True
        four = 0
        Do While checking = True
            Dim unit(number.Length() - 1)
            Dim newNumber(number.Length() - 1)
            addition = 0
            For i = 0 To number.Length() - 1
                unit(i) = CInt(Mid(number, i + 1, 1))
                newNumber(i) = unit(i) * unit(i)
            Next
            For i = 0 To newNumber.Count() - 1
                addition = addition + newNumber(i)
            Next
            Console.WriteLine(addition)
            If addition = 1 Then
                checking = False
                Console.WriteLine("That is a happy number")
            ElseIf addition = 4 Then
                If four = 0 Then
                    four = 1
                Else
                    checking = False
                    Console.WriteLine("That is not a happpy number")
                End If
            End If
            number = CStr(addition)
        Loop
        Console.Read()
    End Sub

    Sub challenge7()
        Dim rank, xp, newxp, xpRequired As Integer
        Dim ranks(4) As String
        ranks(0) = "Private"
        ranks(1) = "Corporal"
        ranks(2) = "Seargent"
        ranks(3) = "Staff Seargent"
        ranks(4) = "Warrent Officer"
        rank = 1
        xp = 0
        xpRequired = 100
        Do While rank < 5
            Console.WriteLine("You are rank: " & ranks(rank - 1))
            Console.Write("XP gained: ")
            newxp = Console.ReadLine()
            xp = xp + newxp
            If xp > xpRequired - 1 Then
                xp = xp - xpRequired
                xpRequired = (xpRequired * 2) + 100
                rank = rank + 1
            End If
        Loop
        Console.Read()
    End Sub
End Module
