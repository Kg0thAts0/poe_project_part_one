using System;
using System.IO;
using System.Media;
using NAudio;
using NAudio.Wave;

namespace poe_project_part_one
{
    public class voice_greeting
    {
        //constructor
        public voice_greeting()
        {
            // Get path
            string paths = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = paths.Replace("bin\\Debug\\", "");

            // Get the full path for input (MP3) and output (WAV)
            string old_path = Path.Combine(new_path, "voice_greeting.mp3");
            string find_wav = Path.Combine(new_path, "voice_greeting.wav");

            // Convert the MP3 to WAV
            conversion(old_path, find_wav);

            // Play the sound
            try
            {
                using (SoundPlayer play = new SoundPlayer(find_wav))
                {
                    play.PlaySync();  // Play synchronously
                    play.Stop();      // Stop playing (though it's redundant since PlaySync waits)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }//end of constructor

        // Convert MP3 to WAV
        private void conversion(string mp3FilePath, string wavFilePath)
        {
            try
            {
                if (File.Exists(mp3FilePath))
                {
                    // Create an Mp3FileReader to read the MP3 file
                    using (Mp3FileReader reader = new Mp3FileReader(mp3FilePath))
                    {
                        // Create a WaveFileWriter to write the WAV file
                        using (WaveFileWriter writer = new WaveFileWriter(wavFilePath, reader.WaveFormat))
                        {
                            // Copy data from MP3 to WAV
                            reader.CopyTo(writer);
                        }
                    }
                    Console.WriteLine("Conversion to WAV completed successfully.");
                }
                else
                {
                    Console.WriteLine("MP3 file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during conversion: " + ex.Message);
            }
        }//end of conversion

    }//end of class
}//end of file