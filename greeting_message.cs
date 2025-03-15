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
            ask_for_name();
            personal_greeting();

        }//end of constructor

        private void DisplayGreeting()
        {
            Console.WriteLine("Hello, welcome to the AI ChatBot assistant!");
        }

        // Ask for the user's name
        public void ask_for_name()
        {
            //prompting the user for their name
            Console.WriteLine("Please, what is your name?");
            name = Console.ReadLine();
        }//end of ask_for_name

        // Get the user's name
        public string get_name()
        {
            return name;
        }//end of get_name

        // Method to greet the user personally
        private void personal_greeting()
        {
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Nice to meet you, {name}! How may I be of assistance to you today?");
            }
            else
            {
                Console.WriteLine("I didn't catch your name. Could you please tell me your name?");
            }//end of if statement

        }//end of personal_greeting method

}//end of class
}//end of file