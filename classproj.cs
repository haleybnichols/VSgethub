using System;

namespace DatingStrangers
{
    class Program
    {
        static void Main(string[] args)
        {
            int userID;
            string bioLine;
            string career;
            string city;
            string country; 
            int age;

            string userName = Console.ReadLine();

            if (userName == "Samantha Rudford")
            {
                userID = 12345;
                bioLine = "Not looking for anything serious- leaving tampa in 3 months";
                city = "tampa";
                country = "USA";
                age = 24;
                career = "Professional Chef";
                string[] SRHobbies = { "Running", "Wine Tasting", "Traveling" };

                //Write to the Console Samantha's profile
                Console.WriteLine(userID.ToString());
                Console.WriteLine(bioLine);
                Console.WriteLine(city);
                Console.WriteLine(country);
                Console.WriteLine(age.ToString());
                Console.WriteLine(career);
                Console.WriteLine("Hobbies Include");
                Console.WriteLine(SRHobbies[0]);
                Console.WriteLine(SRHobbies[1]);
                Console.WriteLine(SRHobbies[2]);
            }
            else if (userName == "Khan Rohina")
            {
                userID = 23619;
                bioLine = "Date me and I will hook you up with amazing KFC discounts";
                city = "Gilgit";
                country = "Pakistan";
                age = 18;
                career = "KFC cashier";
                string[] KRHobbies = { "KFC", "Skateboarding", "Plants" };

                //Write to the Console Khan's profile
                Console.WriteLine(userID.ToString());
                Console.WriteLine(bioLine);
                Console.WriteLine(city);
                Console.WriteLine(country);
                Console.WriteLine(age.ToString());
                Console.WriteLine(career);
                Console.WriteLine("Hobbies Include");
                Console.WriteLine(KRHobbies[0]);
                Console.WriteLine(KRHobbies[1]);
                Console.WriteLine(KRHobbies[2]);
            }


            else if (userName == "Brad McDonald")
            {
                userID = 23456;
                bioLine = "6’2, rock climbing is my life";
                city = "Miami";
                country = "USA";
                age = 21;
                career = "Professional rock climber";
                string[] BMHobbies = { "The outdoors", "Gym Rat", "Marvel movies" };

                //Write to the Console Brad's profile
                Console.WriteLine(userID.ToString());
                Console.WriteLine(bioLine);
                Console.WriteLine(city);
                Console.WriteLine(country);
                Console.WriteLine(age.ToString());
                Console.WriteLine(career);
                Console.WriteLine("Hobbies Include");
                Console.WriteLine(BMHobbies[0]);
                Console.WriteLine(BMHobbies[1]);
                Console.WriteLine(BMHobbies[2]);
            }


            else if (userName == "Shawna Smith")
            {
                userID = 32821;
                bioLine = "ready to mingle and connect";
                city = "Orlando";
                country = "USA";
                age = 24;
                career = "Accountant ";
                string[] SSHobbies = { "Math", "Love visiting beer breweries", "Part time cosmetologist" };

                //Write to the Console Shawna's profile
                Console.WriteLine(userID.ToString());
                Console.WriteLine(bioLine);
                Console.WriteLine(city);
                Console.WriteLine(country);
                Console.WriteLine(age.ToString());
                Console.WriteLine(career);
                Console.WriteLine("Hobbies Include");
                Console.WriteLine(SSHobbies[0]);
                Console.WriteLine(SSHobbies[1]);
                Console.WriteLine(SSHobbies[2]);
            }


            else if (userName == "Mikayla Carter")
            {
                userID = 45343;
                bioLine = "Love long walks on the beach and going out for dinner and drinks!";
                city = "Brooklyn";
                country = "USA";
                age = 22;
                career = "Tattoo Artist";
                string[] MCHobbies = { "Happy Hour", "Fostering pets- mostly dogs", "I love to bake!" };

                //Write to the Console Mikayla's profile
                Console.WriteLine(userID.ToString());
                Console.WriteLine(bioLine);
                Console.WriteLine(city);
                Console.WriteLine(country);
                Console.WriteLine(age.ToString());
                Console.WriteLine(career);
                Console.WriteLine("Hobbies Include");
                Console.WriteLine(MCHobbies[0]);
                Console.WriteLine(MCHobbies[1]);
                Console.WriteLine(MCHobbies[2]);
            }
            else
            {
                Console.WriteLine("User not found, please check your spelling or invite your crush to join Dating Strangers!");
            }
        }
    }
}


