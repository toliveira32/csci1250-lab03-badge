/*
* Name: Tiago Miguel Lourenço Vedes de Oliveira
* Course: CSCI 1250, Section 001
* Assignment: Lab 3, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
*/

//Part 1: Write later
System.Console.Write("Hello, What is your full name? ");

string fullName = Console.ReadLine();
fullName = fullName.Trim();

Random rng = new Random();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

System.Console.WriteLine($"Name on Badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {firstName.Substring(0, 1) + lastName}");
System.Console.WriteLine($"Initials: {firstName.Substring(0, 1).ToUpper()}.{lastName.Substring(0, 1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");


/*Part 2: Generating a randomized number for a Student ID and a Locker: 
* studentID should be six digits from 100000 through 999999 and locker number should be from 1-500
*/

System.Console.WriteLine($"Student ID: {rng.Next(100000, 1000000)}");
System.Console.WriteLine($"Locker: {rng.Next(501)}");

//Part 3: Write later

System.Console.WriteLine($"Distance: ");
System.Console.WriteLine($"Walk time: ");
