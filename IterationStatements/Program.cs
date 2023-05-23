namespace IterationStatements
{
    public class Program
    {
        static void Check(string[] args)
        {
            Accept();
        }

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Sum()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Between()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        } 


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Accept()
        {
            int num1 = 10;
            int num2 = 11;

            double.Parse(Console.WriteLine($"Are {num1} && {num2} ==?"));
            string response = Console.ReadLine();
        }
     
      
        //Write a method to check whether a given number is even or odd
        public static void Check()
        {
            var i = 4;

            while (i % 2 = 0) 
            {
                Console.WriteLine("True");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void Positive()
        {
            int positive = > 0;
            int negative = < 0;
            var num = response;
            Console.WriteLine("Write a random number!");
            var response = double Try.Parse.(Console.ReadLine()) ;

            if (num == positive)
            {
                Console.WriteLine("Positive");
            }
            else 
            {
                (Console.WriteLine("Negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void Vote()
        { 
            do 
            {
                Console.WriteLine("This portal is to determine if your of age to vote! /nHow old are you?");
                var answer = double.TryParse.(Console.ReadLine());
            }while (answer < 21) ;
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge

        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void User()
        {
            Console.WriteLine("Please write a random number!");
            int response = double.TryParse(Console.ReadLine());

            if (response < -10 && response > 10) 
            {
                Console.WriteLine("You are in range!");
            }
            else
            {
                Console.WriteLine("You are out of range!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Table()
        {
        // I'm LOST on this one! I need to move on and come back to this!
        }


        //Call the methods to test them in the Main method below
    




    }

}

      

