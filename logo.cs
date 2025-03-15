using System;
using System.IO;

namespace poe_project_part_one
{
    public class logo
    {
        //constructor
        public logo()
        {

            string imagePath = "cyber_security_logo.png";  // Change this to your image file
            int newWidth = 100; // Adjust width
            string asciiChars = "@%#*+=-:. "; // Characters for brightness levels

            try
            {
                using (Bitmap image = new Bitmap(imagePath))
                {
                    // Calculate new height to maintain aspect ratio
                    int newHeight = (int)(image.Height / (double)image.Width * newWidth * 0.55);
                    Bitmap resizedImage = new Bitmap(image, new Size(newWidth, newHeight));

                    // Convert to ASCII
                    string asciiArt = ConvertToASCII(resizedImage, asciiChars);

                    // Print to console
                    Console.WriteLine(asciiArt);

                    // Save to file
                    File.WriteAllText("ascii_logo.txt", asciiArt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }//end of constructor

        //creating method for
        private string ConvertToASCII(Bitmap image, string asciiChars)
        {
            string asciiArt = "";
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Convert to grayscale
                    int charIndex = gray * (asciiChars.Length - 1) / 255; // Map to ASCII
                    asciiArt += asciiChars[charIndex];
                }
                asciiArt += "\n";
            }
            return asciiArt;
        }

}//end of class
}//end of file