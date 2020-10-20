/*
The following example uses the Clear method to clear
the console before it executes a loop, prompts the user to select
a foreground and background color and to enter a string to display.
If the user chooses not to exit the program, the console's original
foreground and background colors are restored and the Clear
method is called again before re-executing the loop.
 */
using System;

public class ByMrcFaruk
{
    public static void Main()
    {
        Console.Title = "Clear Method";
        ConsoleColor dftForeColor = Console.ForegroundColor;
        ConsoleColor dftBackColor = Console.BackgroundColor;
        bool continueFlag = true;
        Console.Clear();
        do
        {
            ConsoleColor newForeColor = ConsoleColor.White;
            ConsoleColor newBackColor = ConsoleColor.White;
            Char foreColorSelection = GetKeyPress("Select Text Color(B For Blue, R For Red, Y for Yellow): ",
            new Char[] { 'B', 'R', 'Y' });

            switch(foreColorSelection)
            {
                case 'B':
                case 'b':
                    newForeColor = ConsoleColor.DarkBlue;
                    break;
                case 'R':
                case 'r':
                    newForeColor = ConsoleColor.DarkRed;
                    break;

                case 'Y':
                case 'y':
                    newForeColor = ConsoleColor.DarkYellow;
                   break;
             
            }          
            char backcolorselection = GetKeyPress("Select Background(W For White, G for Green, M For Magenta):",
            new Char[] { 'W', 'G', 'M' });
            switch (backcolorselection)
            {
                case 'W':
                case 'w':
                    newBackColor = ConsoleColor.White;
                    break;

                case 'G':
                case 'g':
                    newBackColor = ConsoleColor.Green;
                    break;

                case 'M':
                case 'm':
                    newBackColor = ConsoleColor.Magenta;
                    break;


            }
            Console.WriteLine();
            Console.Write("Enter a message : ");
            String textToDisplay = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = newForeColor;
            Console.BackgroundColor = newBackColor;
            Console.WriteLine(textToDisplay);
            Console.WriteLine();
            if (Char.ToUpper(GetKeyPress("Display another message (Y/N): ", new Char[] { 'Y', 'N' })) == 'N')
                continueFlag = false;
            Console.ForegroundColor = dftForeColor;
            Console.BackgroundColor = dftBackColor;
            Console.Clear();
        } while (continueFlag);
    }
    private static Char GetKeyPress(String msg, Char[] validChars)
    {
        ConsoleKeyInfo keyPressed;
        bool valid = false;
        Console.WriteLine();
        do
        {
            Console.Write(msg);
            keyPressed = Console.ReadKey();
            Console.WriteLine();
            if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                valid = true;
        } while (!valid);
        return keyPressed.KeyChar;
    }
}
        