using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_project_part_one
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Voice greeting and logo instances
            new voice_greeting() { };
            new logo() { };

            //greeting_message instance and prompt for the user's name 
            greeting_message message = new greeting_message();
            message.ask_for_name();

            //user_interface instance
            new user_interface(message.get_name()) { };

        }//end of main method
    }//end of class
}//end of file
