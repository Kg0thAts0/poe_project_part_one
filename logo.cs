using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace poe_project_part_one
{
    public class logo
    {
        //constructor
        public logo()
        {
            // Get the base directory
            string location = AppDomain.CurrentDomain.BaseDirectory;

            // Replace the "bin\\Debug\\" 
            string new_pic_location = location.Replace("bin\\Debug\\", "");

            // combine new_pic_location with the image
            string image_path = Path.Combine(new_pic_location, "cyber_security_logo.jpeg");

            try
            {
                // Load the image from the file path
                using (Bitmap img = new Bitmap(image_path))
                {
                    // Resize the image to fit a smaller dimension
                    Bitmap resize_image = new Bitmap(img, new Size(160, 60));

                    // Store the ASCII art as a string
                    string asciiArt = string.Empty;

                    // Loop through each pixel of the resized image
                    for (int height = 0; height < resize_image.Height; height++)
                    {
                        // Building ASCII characters for the current row
                        string current_row = string.Empty;

                        for (int width = 0; width < resize_image.Width; width++)
                        {
                            // Get the color of the current pixel
                            Color pixel_color = resize_image.GetPixel(width, height);

                            // Convert the color to grayscale by averaging the RGB values
                            int gray = (pixel_color.R + pixel_color.G + pixel_color.B) / 3;

                            // Convert the grayscale value to an ASCII character (string)
                            string asciiChar = grayscale(gray).ToString();

                            // Add the ASCII character to the row string
                            current_row += asciiChar;
                        }

                        // Add the row to the overall ASCII art, with a new line at the end of each row
                        asciiArt += current_row + "\n";
                    }

                    // Return the generated ASCII art as a string
                    Console.WriteLine( asciiArt);
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine( $"Error: {ex.Message}");
            }
        }//end of constructor

        //method for getting the grayscale values
        private string grayscale(int gray)
        {
            // Returning different ASCII characters based on the grayscale value
            if (gray > 230) return " ";
            if (gray > 200) return ".";
            if (gray > 170) return "\"";
            if (gray > 140) return "+";
            if (gray > 110) return "*";
            if (gray > 80) return "#";
            if (gray > 50) return "%";
            if (gray > 20) return "&";
            return "@";
        }//end of grayscale method

    }//end of class
}//end of file