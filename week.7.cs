using System;



namespace FromAToB



{



    class Program



    {



        static void Main(string[] args)
        //Creating the string and the array for the program to read the user's input
        {
            //Reading string a
            string ab = Console.ReadLine();



            //Parsing
            string[] abArray = ab.Split(' ');



            //Integer A
            int a = Convert.ToInt32(abArray[0]);



            //Integer B
            int b = Convert.ToInt32(abArray[1]);



            //Initial count starting at 0
            int count = 0;
            //Calculations
            while (a > b)
            {



                if (a % 2 != 0)



                {
                    a += 1;
                    count += 1;
                }



                a /= 2;



                count += 1;
            }



            if (a < b)
            {

                count += b - a;
            }
            //Sending the final count to the console for the user to read
            Console.WriteLine(count);
        }
    }
}

