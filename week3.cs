using System;
namespace KattisBela
{
    public class Bela
    {
        public static void Main(string[] args)
        {
            //Reading the first line and settng each value as a variable for further use
            string line = Console.ReadLine();
            //How we are determining the hand/suit based on the "space" of the varchar
            int space = line.IndexOf(' ');
            //Parsing the line for the second varchar the number of hands (each hand is comprised of 4 cards)
            int hand = int.Parse(line.Substring(0, space)) * 4;
            //Determing the dominant hand
            char suit = line[space + 1];
            //Points start at 0
            int points = 0;
            for (int x = 0; x < hand; x++)
            {
                string s = Console.ReadLine();
                switch (s[0])
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    //Because the value for J is dependent on dominant vs nondominant- use an if else statement to determine point value
                    case 'J':
                        if (s[1] == suit)
                            points += 20;
                        else
                            points += 2;
                        break;
                    case 'T':
                        points += 10;
                        break;
                    //Because the value for J is dependent on dominant vs nondominant- use an if else statement to determine point value
                    case '9':
                        if (s[1] == suit)
                            points += 14;
                        else
                            points += 0;
                        break;
                    //Card 8 and 7 could also be the "default"
                    case '8':
                        points += 0;
                        break;
                    case '7':
                        points += 0;
                        break;
                }
            }
            //Write total points for the user to see
            Console.WriteLine(points);
        }
    }
}


