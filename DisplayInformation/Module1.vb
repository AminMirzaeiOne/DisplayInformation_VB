Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Your Name: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Name As String = System.Console.ReadLine()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Your Age: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Age As Integer = System.Convert.ToInt32(Console.ReadLine())
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Your Height: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Height As Integer = Convert.ToInt32(Console.ReadLine())
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Green
        System.Console.WriteLine("Your Name Is: {0}", Name)
        System.Console.WriteLine("Your Age Is: {0}", Age)
        System.Console.WriteLine("Your Height Is: {0}", Height)
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()
    End Sub

End Module
