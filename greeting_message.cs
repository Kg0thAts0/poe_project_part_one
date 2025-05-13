using System;

namespace poe_project_part_one
{
    public class greeting_message
    {
        // Declare storage variable for name
        private string name = string.Empty;

        //constructor
        public greeting_message()
        {
            // Greet the user when the object is created
            display_greeting();

        }//end of constructor

        private void display_greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Chatbot: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello, welcome to the AI ChatBot assistant!");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.ResetColor();

        }//end of display_greeting method

        // Ask for the user's name
        public void ask_for_name()
        {
            //prompting the user for their name
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Chatbot: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please, what is your name?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("User: ");
            Console.ResetColor();

            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.ResetColor();

        }//end of ask_for_name

        // Get the user's name
        public string get_name()
        {
            return name;
        }//end of get_name

}//end of class
}//end of file
