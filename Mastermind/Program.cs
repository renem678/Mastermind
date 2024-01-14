using System;

class Program
{
    static void Main()
    {
        // Generate a random 4-digit answer
        int[] answer = GenerateRandomAnswer();

        // Display welcome message
        Console.WriteLine("Welcome to Mastermind!");
        Console.WriteLine("Try to guess the 4-digit number. (4 digits between 1 and 6): ");

        int attemptsLeft = 10;

        // Main game loop
        while (attemptsLeft > 0)
        {
            // Get user input
            Console.Write($"Attempts left: {attemptsLeft}. Enter your guess: ");
            string input = Console.ReadLine();

            // Validate user input
            if (!ValidateInput(input))
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit number.");
                continue;
            }

            // Convert input to an array of integers
            int[] guess = ConvertInputToArray(input);

            // Check the user's guess
            CheckGuess(answer, guess);

            // Check if the guess is correct
            if (IsCorrect(answer, guess))
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break;
            }

            attemptsLeft--;
        }

        // Display a message if the player runs out of attempts
        if (attemptsLeft == 0)
        {
            Console.WriteLine($"Sorry, you've run out of attempts. The correct number was: {string.Join("", answer)}");
        }
    }

    // Generate a random 4-digit answer
    static int[] GenerateRandomAnswer()
    {
        Random random = new Random();
        int[] answer = new int[4];

        // Generate each digit randomly between 1 and 6
        for (int i = 0; i < 4; i++)
        {
            answer[i] = random.Next(1, 7);
        }

        return answer;
    }

    // Validate user input
    static bool ValidateInput(string input)
    {
        // Check if the input is exactly 4 characters and can be parsed as an integer
        return input.Length == 4 && int.TryParse(input, out _);
    }

    // Convert user input to an array of integers
    static int[] ConvertInputToArray(string input)
    {
        return Array.ConvertAll(input.ToCharArray(), c => (int)Char.GetNumericValue(c));
    }

    // Check the user's guess and provide feedback
    static void CheckGuess(int[] answer, int[] guess)
    {
        // Iterate through each digit in the guess
        for (int i = 0; i < 4; i++)
        {
            // Check if the digit is in the correct position
            if (guess[i] == answer[i])
            {
                Console.Write("+");
            }
            // Check if the digit is correct but in the wrong position
            else if (Array.IndexOf(answer, guess[i]) != -1)
            {
                Console.Write("-");
            }
        }

        // Move to the next line for better formatting
        Console.WriteLine();
    }

    // Check if the guess is correct
    static bool IsCorrect(int[] answer, int[] guess)
    {
        // Check if each digit in the guess matches the corresponding digit in the answer
        return answer[0] == guess[0] && answer[1] == guess[1] && answer[2] == guess[2] && answer[3] == guess[3];
    }
}
