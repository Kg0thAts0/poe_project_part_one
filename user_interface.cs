using System;
using System.Collections;
using System.IO;

namespace poe_project_part_one
{
    public class user_interface
    {
        //global variable declaration and array
        private ArrayList answers = new ArrayList();
        private ArrayList ignores = new ArrayList();

        //constructor
        public user_interface(string name)
        {

            //calling both methods store_replies and store_ignore
            store_replies();
            store_ignore();

            // Greet the user
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Chatbot: Hello, {name}! Welcome to the Cybersecurity Chatbot.");
            Console.WriteLine("=================================================================");
            Console.WriteLine($"Chatbot: You can ask me anything about Cybersecurity!");

            //implenment a do while
            do
            {

                //prompting the user for question
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Chatbot: Please enter your question: ");
                Console.ResetColor();
                Console.Write($"{name}: ");
                string question = Console.ReadLine();
                Console.WriteLine("=================================================================");

                // Exit condition if user types 'exit'
                if (question.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Chatbot: Goodbye! Stay safe online.");
                    Console.ResetColor();
                    break;
                }//end of if statement

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
                    for (int counts = 0; counts < answers.Count; counts++)
                    {

                        if (answers[counts].ToString().Contains(filter[counting].ToString()))
                        {

                            found = true;
                            message += answers[counts] + "\n";

                        }//end of if 

                    }//end of reply for loop

                }//end of get answer for loop

                //if statement for display 
                if (found)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Chatbot:\n {message}");
                    Console.WriteLine("=================================================================");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=================================================================");
                    Console.WriteLine("Chatbot: Write something related to cyber security.");
                    Console.WriteLine("=================================================================");
                    Console.ResetColor();
                }//end of display

            } while(true);//end of do_while

        }//end of constructor

        //Create method for storing all replies
        private void store_replies()
        {
            //add values to arraylist
            //passwords
            answers.Add("Strong passwords help protect your accounts and personal data from unauthorized access and reduce the risk of being hacked.");
            answers.Add("A strong password typically contains a mix of uppercase and lowercase letters, numbers, and special characters, and is at least 12 characters long.\r\n");
            answers.Add("Change passwords periodically for sensitive accounts, but avoid frequent changes that weaken security.");

            //cybersecurity
            answers.Add("cybersecurity is the practice of protecting systems, networks, and data from digital attacks, unauthorized access, and damage.");
            answers.Add("cybersecurity prevents data breaches, fraud, and cyberattacks that can lead to financial and reputational damage.");
            answers.Add("common cyberattacks include ransomware, malware, man-in-the-middle (MitM), and denial-of-service (DoS) attacks.");

            //safe browsing
            answers.Add("safe browsing helps protect you from malware, online attacks, and data theft by ensuring that you avoid harmful websites and unsafe practices.");
            answers.Add("A secure website will have \"https://\" at the beginning of its URL and often display a padlock icon in the address bar, which means it's safe to browse.");

            //phishing
            answers.Add("phishing attempts can often be recognized by suspicious email addresses, urgent language, suspicious links, poor grammar, and requests for personal information.");
            answers.Add("phishing is when attackers trick you into revealing personal information by pretending to be legitimate entities.");
            answers.Add("phishing can be avoided by being cautious with unsolicited emails and links");

        }//end of store_replies

        //method to store ignores
        private void store_ignore()
        {
            //then add values to ignore arraylist
            ignores.Add("what"); ignores.Add("ohh");
            ignores.Add("is"); ignores.Add("yes");
            ignores.Add("are"); ignores.Add("most");
            ignores.Add("makes"); ignores.Add("scam");
            ignores.Add("tell"); ignores.Add("when");
            ignores.Add("me"); ignores.Add("attempts");
            ignores.Add("about"); ignores.Add("recognized");
            ignores.Add("how"); ignores.Add("and");
            ignores.Add("important"); ignores.Add("be");
            ignores.Add("can"); ignores.Add("to");
            ignores.Add("I"); ignores.Add("avoided");
            ignores.Add("identify"); ignores.Add("practice");
            ignores.Add("avoid"); ignores.Add("include");
            ignores.Add("it"); ignores.Add("attacks");
            ignores.Add("why"); ignores.Add("attack");
            ignores.Add("common"); ignores.Add("trick");
            ignores.Add("the"); ignores.Add("into");
            ignores.Add("types"); ignores.Add("which");
            ignores.Add("of"); ignores.Add("https");
            ignores.Add("strong"); ignores.Add("URL");
            ignores.Add("often"); ignores.Add("in");
            ignores.Add("should"); ignores.Add("hacked");
            ignores.Add("change"); ignores.Add("a");
            ignores.Add("my"); ignores.Add("at");
            ignores.Add("you"); ignores.Add("from");
            ignores.Add("your"); ignores.Add("hi");
            ignores.Add("malware"); ignores.Add("hello");
            ignores.Add("ransomware"); ignores.Add("security");
            ignores.Add("being"); ignores.Add("URL");

        }//end of store_ignore

    }//end of class
}//end of file