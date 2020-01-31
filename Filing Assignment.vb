Module Module1
    Dim mName As String
    Dim more As Char
    Dim IDNum As Integer

    Sub Main()

        Dim taskNo As Integer

        taskNo = 0
        Do
            Console.Clear()
            Console.WriteLine("0: To Quit")
            Console.WriteLine("1: Task 1.1")
            Console.WriteLine("2: Task 1.2")
            Console.WriteLine("3: Task 1.3")
            Console.WriteLine("4: Task 1.4")
            Console.WriteLine("5: Task 1.5")
            Console.WriteLine()

            Console.Write("Enter task number: ") : taskNo = Console.ReadLine

            If taskNo = 1 Then Call Task1()
            If taskNo = 2 Then Call Task2()
            If taskNo = 3 Then Call Task3()
            If taskNo = 4 Then Call Task4()
            If taskNo = 5 Then Call Task5()

        Loop Until taskNo = 0

    End Sub

    Sub Task1()

        Console.Clear()

        mName = ""
        IDNum = 0
        more = "N"

        FileOpen(1, "ABC.txt", OpenMode.Output)

        Do
            Console.Write("Enter member name: ") : mName = Console.ReadLine
            Console.Write("Enter member ID number: ") : IDNum = Console.ReadLine

            WriteLine(1, mName)
            WriteLine(1, IDNum)

            Console.Write("Do you want to enter another record? (Y/N)") : more = Console.ReadLine

        Loop Until UCase(more) = "N"
        FileClose(1)

    End Sub

    Sub Task2()
        Console.Clear()
        FileOpen(1, "ABC.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, mName)
            Input(1, IDNum)

            Console.WriteLine(mName)
            Console.WriteLine(IDNum)

        End While
        FileClose(1)
        Console.ReadKey()

    End Sub

    Sub Task3()
        Console.Clear()

        Dim isFound As Boolean = False
        Dim sName As String = ""

        Console.Write("Enter member name to search: ") : sName = Console.ReadLine

        FileOpen(1, "ABC.txt", OpenMode.Input)

        While Not EOF(1) And isFound = False
            Input(1, mName)
            Input(1, IDNum)

            If UCase(mName) = UCase(sName) Then
                isFound = True
                Console.WriteLine(IDNum)
            End If
        End While

        If isFound = False Then Console.WriteLine("Member not found.")

        FileClose(1)

        Console.ReadKey()

    End Sub

    Sub Task4()
        Console.Clear()

        more = "N"
        FileOpen(1, "ABC.txt", OpenMode.Append)
        Do
            Console.Write("Enter member name: ") : mName = Console.ReadLine
            Console.Write("Enter member ID number: ") : IDNum = Console.ReadLine

            WriteLine(1, mName)
            WriteLine(1, IDNum)

            Console.Write("Do you want to enter another record? (Y/N)") : more = Console.ReadLine

        Loop Until UCase(more) = "N"

        FileClose(1)

    End Sub

    Sub Task5()
        Console.Clear()
        Dim TNum As Long
        Dim mDate As String


        FileOpen(1, "ABC.txt", OpenMode.Input)
        FileOpen(2, "ABC1.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, mName)
            Input(1, IDNum)

            Console.WriteLine(mName)
            Console.WriteLine(IDNum)
            Console.Write("Enter telephone number: ") : TNum = Console.ReadLine
            Console.Write("Enter membership start date: ") : mDate = Console.ReadLine

            WriteLine(2, mName)
            WriteLine(2, IDNum)
            WriteLine(2, TNum)
            WriteLine(2, mDate)

        End While

        FileClose(1)
        FileClose(2)


    End Sub
End Module
