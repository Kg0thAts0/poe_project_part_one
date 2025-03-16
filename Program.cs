using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_project_part_one
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Voice greeting and logo
            new voice_greeting() { };
            //new logo() { };

            //greeting message and prompt for the name 
            greeting_message message = new greeting_message();
            message.ask_for_name();

            new user_interface(message.get_name()) { };

        }
    }
}
