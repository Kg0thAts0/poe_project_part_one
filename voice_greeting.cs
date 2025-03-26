using System;
using System.IO;
using System.Media;

namespace poe_project_part_one
{
    public class voice_greeting
    {
        //constructor
        public voice_greeting()
        {
            // Get path
            string paths = AppDomain.CurrentDomain.BaseDirectory;

            //replacing the bin\\Debug\\
            string new_path = paths.Replace("bin\\Debug\\", "");

            // Combine the path
            string full_path = Path.Combine(new_path, "greetings.wav");

            // Play the sound
            try
            {
                // Check if the file exists before attempting to play it
                if (File.Exists(full_path))
                {

                    //making use of using function
                    using (SoundPlayer play = new SoundPlayer(full_path))
                    {
                        play.PlaySync();
                    }//end of using function
                }
                else
                {
                    Console.WriteLine("Greeting file not found at: " + full_path);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }//end of try_catch

        }//end of constructor

    }//end of class
}//end of file