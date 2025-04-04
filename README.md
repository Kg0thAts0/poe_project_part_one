# POE Project Part One - Cybersecurity Chatbot

## Project Overview

POE Project Part One - is a simple console-based AI chatbot assistant that helps users learn about **Cybersecurity**.
The chatbot provides responses to basic cybersecurity-related questions, displays an ASCII art logo, and plays a greeting sound when the application starts.
It interacts with the user through the console and responds intelligently to relevant questions by filtering out common filler words.

## Features

- Voice Greeting: Plays an introductory `greetings.wav` file.
- Logo Display: Converts a `.jpeg` image (`cyber_security_logo.jpeg`) into ASCII art and prints it in the console.
- Greeting Message: Asks the user for their name and welcomes them.
- Cybersecurity Knowledge Bot: Provides intelligent responses to cybersecurity questions.
- Keyword Matching: Uses basic keyword filtering to match relevant answers.
- Exit Option: Type `exit` at any time to end the chat session.

## Technologies Used

- C# (.NET Core / .NET Framework)
- System.Media.SoundPlayer for playing .wav files.
- System.Drawing for image processing and ASCII art generation.
- Console UI for basic user interaction.

## Add Required Files

Ensure the following files are present in the project root directory (NOT inside bin/Debug/):
- greetings.wav
- cyber_security_logo.jpeg

## How It Works

- The Program class initializes the greeting sound and logo.
- The greeting_message class handles initial console messages and name input.
- The user_interface class:
- Filters user input by removing common/filler words.
- Matches relevant keywords with pre-stored cybersecurity answers.
- Displays responses or prompts for better input.

## Example Questions to Ask

- What is cybersecurity?
- Tell me about phishing
- Why are strong passwords important?
- How can I browse safely?

## How to Exit

- Type 'exit' anytime during the chat to terminate the session.

## Notes

- For best results, ask questions that include keywords like phishing, passwords, browsing, or cybersecurity.
