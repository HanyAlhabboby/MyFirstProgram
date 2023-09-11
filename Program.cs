namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hany Alhabboby - .NET23
            //Created a variabel that has a number that is lower than 10, so i chose 5
            int Num = 5;

            //If the number is higher than 10
            if (Num > 10)
            {
                Console.WriteLine("Talet är stort!");
            }

            //If the number is lower than 10
            else if (Num < 10)
            {
                Console.WriteLine("Oj. Lågt tal");
            }
           
            //asking the user name
            Console.WriteLine("Vad heter du?");
            
            // saving the user name
            String Name = Console.ReadLine();

            //Saying hi to the name that the user fill in
            Console.WriteLine("Hej " + Name);

            //crated While loop that will count until 4 (lower than 5)
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }







        }
    }
}