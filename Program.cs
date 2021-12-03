/*
  This code reverses a message, counts the number of times 
  a particular character appears, then prints the results
  to the console window.
*/
string originalMessage = "Hello there, My name is Sairaj Tamboskar " +
    "I am an Electronics and Telecommunication Engineer, I work in Kilowott Agency as a software developer Trainee.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");