namespace ArrayTester1
{
    public class ArrayTester
    {
        // Method to find divisors
        public List<double> ArrayTester1(double startnumber, int counter )
        {
            List<double> multiplelist = new List<double>();

            // Loop through numbers from 1 to number-1
            for (int i = 1; i < counter; i++)
            {
                multiplelist.Add(startnumber*i); //add number to list
            }

            return multiplelist;
        }
    }

    internal class Program
    {
        private static void Main()
        {
            // Create an instance of ArrayTester to call the non-static method
            ArrayTester arrayTester = new ArrayTester();
            
            List<double> result =  arrayTester.ArrayTester1(3, 5);

            Console.WriteLine("The result is:");
            foreach (var multi in result) //var for multi
            {   
                Console.WriteLine(multi);
            }   
            
        }
    }
}