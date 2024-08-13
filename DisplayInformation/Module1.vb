' This line declares a module named Module1
Module Module1

    ' This line defines the Main subroutine, which is the entry point of the program
    Sub Main()

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter their name using a colored message
        System.Console.Write("Pls Enter Your Name: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's name input and store it in the string variable 'Name'
        Dim Name As String = System.Console.ReadLine()

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter their age using a colored message
        System.Console.Write("Pls Enter Your Age: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's age input, convert it to an integer, and store it in the variable 'Age'
        Dim Age As Integer = System.Convert.ToInt32(Console.ReadLine())

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter their height using a colored message
        System.Console.Write("Pls Enter Your Height: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's height input, convert it to an integer, and store it in the variable 'Height'
        Dim Height As Integer = Convert.ToInt32(Console.ReadLine())

        ' Display a separator line with Magenta foreground color
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Set the foreground color to Green for user information output
        System.Console.ForegroundColor = ConsoleColor.Green

        ' Use formatted strings to display user information with placeholders for Name, Age, and Height
        System.Console.WriteLine("Your Name Is: {0}", Name)
        System.Console.WriteLine("Your Age Is: {0}", Age)
        System.Console.WriteLine("Your Height Is: {0}", Height)

        ' Display a separator line with Magenta foreground color
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Set the foreground color to Red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red

        ' Display programmer information
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console window until the user presses any key
        System.Console.ReadKey()

    End Sub

End Module
