using System;
using System.Collections;
using System.IO;

namespace poe_project_part_one
{
    public class user_interface
    {
        //global variable declaration and array

        private ArrayList reply = new ArrayList();
        private ArrayList ignores = new ArrayList();

        //constructor
        public user_interface(string name)
        {

            //calling both methods store_replies and store_ignore
            store_replies();
            store_ignore();

            //implenment a do while
            do
            {

            //prompting the user for question
            Console.WriteLine("Please enter your question: ");
            string question = Console.ReadLine();

            //use split function
            string[] store_word = question.Split(' ');

            //temp arratlist
            ArrayList filter = new ArrayList();

            //for loop to display and add to temp array
            for (int count = 0; count < store_word.Length; count++)
            {

                //check to final store
                if (!ignores.Contains(store_word[count]))
                {
                    //store final
                    filter.Add(store_word[count]);

                }//end of if statement

            }//end of for loop

            //boolean for correct found answer
            Boolean found = false;
            string message = "";

            //then display the answer
            for (int counting = 0; counting < filter.Count; counting++)
            {

                //nested for loop
                for (int counts = 0; counts < reply.Count; counts++)
                {

                    if (reply[counts].ToString().Contains(filter[counting].ToString()))
                    {

                        found = true;
                        message += reply[counts] + "\n";

                    }//end of if 

                }//end of reply for loop

            }//end of get answer for loop

            //if for display 
            if (found)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Write something related to cyber security");
            }//end of display

            }while(true);

        }//end of constructor

        //Create method for storing all replies
        private void store_replies()
        {
            //add values to arraylist
            //passwords
            reply.Add("Strong passwords help protect your accounts and personal data from unauthorized access and reduce the risk of being hacked.");
            reply.Add("A strong password typically contains a mix of uppercase and lowercase letters, numbers, and special characters, and is at least 12 characters long.\r\n");
            reply.Add("Change passwords periodically for sensitive accounts, but avoid frequent changes that weaken security.");

            //cybersecurity
            reply.Add("cybersecurity is the practice of protecting systems, networks, and data from digital attacks, unauthorized access, and damage.");
            reply.Add("cybersecurity prevents data breaches, fraud, and cyberattacks that can lead to financial and reputational damage.");
            reply.Add("common cyberattacks include phishing, ransomware, malware, man-in-the-middle (MitM), and denial-of-service (DoS) attacks.");

            //safe browsing
            reply.Add("safe browsing helps protect you from malware, phishing attacks, and data theft by ensuring that you avoid harmful websites and unsafe practices.");
            reply.Add("A secure website will have \"https://\" at the beginning of its URL and often display a padlock icon in the address bar, which means it's safe to browse.");

            //phishing
            reply.Add("ohh yes the most common scam is phishing");
            reply.Add("phishing is when attackers trick you into revealing personal information by pretending to be legitimate entities.");
            reply.Add("phishing can be avoided by being cautious with unsolicited emails and links");

        }//end of store_replies

        //method to store ignores
        private void store_ignore()
        {
            //then add values to ignore arraylist
            ignores.Add("what");
            ignores.Add("is");
            ignores.Add("are");
            ignores.Add("makes");
            ignores.Add("tell");
            ignores.Add("me");
            ignores.Add("about");
            ignores.Add("how");
            ignores.Add("important");
            ignores.Add("can");
            ignores.Add("I");
            ignores.Add("identify");
            ignores.Add("avoid");
            ignores.Add("it");
            ignores.Add("why");
            ignores.Add("common");
            ignores.Add("the");
            ignores.Add("types");
            ignores.Add("of");
            ignores.Add("strong");
            ignores.Add("often");
            ignores.Add("should");
            ignores.Add("change");
            ignores.Add("my");

        }//end of store_ignore

    }//end of class
}//end of file