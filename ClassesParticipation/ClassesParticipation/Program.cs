using System;

namespace ClassesParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor foreground;
            ConsoleColor background;

            foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            background = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            TextBox box1 = new TextBox();
            box1.BackColor = ConsoleColor.DarkGreen;
            box1.ForeColor = ConsoleColor.DarkYellow;
            box1.Padding = 32;
            box1.Text = "This is a text box.";
            box1.DisplayText();

            TextBox box2 = new TextBox();
            box2.BackColor = ConsoleColor.Cyan;
            box2.ForeColor = ConsoleColor.DarkRed;
            box2.Padding = 18;
            box2.Text = "This is another text box.";
            box2.DisplayText();

           


            Console.ReadKey();
        }
    }
}
