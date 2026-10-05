/*
* Name: Tiago Miguel Lourenço Vedes de Oliveira
* Course: CSCI 1250, Section 001
* Assignment: Lab 3, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
*/

//Part 1: Requesting the user for their full name: formulate their full name into a username that matches instructions for a badge

using System.Security.Cryptography;

System.Console.Write("Hello, What is your full name? ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();

Random rng = new Random();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string userName = firstName.Substring(0, 1).ToLower() + lastName.ToLower();

System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {firstName.Substring(0, 1).ToUpper()}.{lastName.Substring(0, 1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");


/*Part 2: Generating a randomized number for a Student ID and a Locker: 
* studentID should be six digits from 100000 through 999999 and locker number should be from 1-500
*/
int randomStudentId = rng.Next(100000, 1000000);
int randomLockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"Student ID: {randomStudentId}");
System.Console.WriteLine($"Locker: {randomLockerNumber}");

//Part 3: Asking the user for data to be able to do calculatons on distance in feet, and walk time in minutes and seconds layout, from dorm to first class at campus
// saving this data to be able to use on badge later

System.Console.Write("Dorm x: ");
double dormX = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Dorm y: ");
double dormY = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Class x: ");
double classX = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Class y: ");
double classY = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Walking speed in feet per second: ");
double studentWalkingSpeed = Convert.ToDouble(Console.ReadLine());

double valueOfX = classX - dormX;
double valueOfY = classY - dormY;
double squareOfX = Math.Pow(valueOfX, 2);
double squareOfY = Math.Pow(valueOfY, 2);
double sumOfValues = squareOfX + squareOfY;
double distance = Math.Round(Math.Sqrt(sumOfValues), 1);
int walkingTimeFullSeconds = Convert.ToInt32(distance / studentWalkingSpeed);
int walkingTimeMinutes = walkingTimeFullSeconds / 60;
int walkingTimeSeconds = walkingTimeFullSeconds % 60;

System.Console.WriteLine($"Distance: {distance} feet");
System.Console.WriteLine($"Walk time: {walkingTimeMinutes} minutes {walkingTimeSeconds} seconds");

//Part 4: Printing the finished Badge to the user, following the proper formating requirements

int checkDigit = randomStudentId % 9;
string labelBars = "==================================";
//System.Console.WriteLine(labelBars.Length);
string etsuStudentBadge = "\tETSU STUDENT BADGE";
System.Console.WriteLine($"{labelBars}\n{etsuStudentBadge}\n{labelBars}");
System.Console.WriteLine("Name".PadRight(10) + fullName.ToUpper());
System.Console.WriteLine("USERNAME".PadRight(10) + userName);
System.Console.WriteLine("ID".PadRight(10) + randomStudentId + "-" + checkDigit);
System.Console.WriteLine("LOCKER".PadRight(10) + randomLockerNumber);
System.Console.WriteLine("WALK".PadRight(10) + walkingTimeMinutes + " " + "min" + " " + walkingTimeSeconds + " " + "sec");
System.Console.WriteLine($"{labelBars}");
