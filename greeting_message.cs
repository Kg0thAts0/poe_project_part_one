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
            DisplayGreeting();

        }//end of constructor

        private void DisplayGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine($"Chatbot: Hello, welcome to the AI ChatBot assistant!");
            Console.ResetColor();
        }

        // Ask for the user's name
        public void ask_for_name()
        {
            //prompting the user for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Chatbot: Please, what is your name?");
            Console.ResetColor();
            Console.Write($"User: ");
            name = Console.ReadLine();
        }//end of ask_for_name

        // Get the user's name
        public string get_name()
        {
            return name;
        }//end of get_name

}//end of class
}//end of file