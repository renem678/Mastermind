# Mastermind
This C# console application is a simplified version of the classic game Mastermind. The goal is to guess a randomly generated four-digit number, where each digit is between 1 and 6. The game provides feedback in the form of plus (+) and minus (-) signs to indicate correct digits in the correct or wrong positions.

# Rules
The answer is a four-digit number.
Each digit in the answer is between 1 and 6.
After each guess, the game provides feedback:
A plus (+) sign for every correct digit in the correct position.
A minus (-) sign for every correct digit in the wrong position.
No sign for incorrect digits.
Print all plus signs first, then all minus signs.
The player has ten attempts to guess the correct number.

# How to Play
Run the console application.
Enter a four-digit combination when prompted.
Receive feedback in the form of plus and minus signs.
Repeat steps 2-3 until the correct number is guessed or the player exhausts their ten attempts.

# Example
If the correct answer is 3462:
If the player's guess is 3146, the feedback will be ++-- (one correct digit in the correct position, one correct digit in the wrong position).
If the player's guess is 6243, the feedback will be --++ (two correct digits in the wrong positions).

# Game Over
The player has ten attempts to guess the correct number. If unsuccessful, a message will be displayed indicating that they have lost.
