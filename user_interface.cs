using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace poe_project_part_one
{
    public class user_interface
    {
        //global variable declaration and array
        // Replaced ArrayList with List<string> for better performance and type safety
        private List<string> answers = new List<string>();
        private List<string> ignores = new List<string>();
        private List<string> memory_store = new List<string>();
        private Random random = new Random();  

        private string memoryPath;

        // Define delegate for matching answers
        private delegate bool MatchDelegate(string input, string keyword);

        //constructor
        public user_interface(string name)
        {
            // Setup file path for memory recall
            string full_path = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = full_path.Replace("bin\\Debug\\", "");
            memoryPath = Path.Combine(new_path, "memory.txt");

            // Load previous memory
            memory_store = memory_load(memoryPath);


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

                // Save question to memory
                memory_store.Add($"{name}, {question}");
                File.WriteAllLines(memoryPath, memory_store);

                // Split the input into individual words
                string[] store_word = question.Split(' ');

                // Filter out common or unimportant words using a lambda expression
                List<string> filter = store_word.Where(word => !ignores.Contains(word)).ToList();

                // Boolean to check if any answers were matched
                bool found = false;

                // Store all matching answers
                List<string> matchedAnswers = new List<string>();

                // Use a delegate with a lambda expression to define the matching logic
                MatchDelegate matcher = (input, keyword) => input.ToLower().Contains(keyword.ToLower());

                // Iterate through each filtered keyword
                foreach (string keyword in filter)
                {
                    // For each keyword, apply the matcher delegate to all answers
                    answers.ForEach(answer =>
                    {
                        // If a match is found and not already added, store it
                        if (matcher(answer, keyword) && !matchedAnswers.Contains(answer))
                        {
                            matchedAnswers.Add(answer);
                            found = true;
                        }
                    });
                }

                // String to hold the message to be displayed
                string message = "";

                // If matches were found
                if (found)
                {
                    // Determine how many responses to show (max 2)
                    int numberToPick = Math.Min(2, matchedAnswers.Count);

                    // Randomly pick and remove entries to avoid duplicates
                    for (int i = 0; i < numberToPick; i++)
                    {
                        // Pick a random index
                        int index = random.Next(matchedAnswers.Count);

                        // Append the randomly picked answer to the message with bullet point formatting
                        message += "- " + matchedAnswers[index] + "\n";

                        // Remove the picked answer to prevent duplicates
                        matchedAnswers.RemoveAt(index);
                    }
                }

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

        //create method to return all memory recall
        private List<string> memory_load(string path)
        {

            //checking if the txt file exists
            if (File.Exists(path))
            {

                //return all the history
                return new List<string>(File.ReadAllLines(path));

            }
            else
            {

                //create the file
                File.CreateText(path);
                return new List<string>();

            }//end of if statement

        }//end of method memory_load

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