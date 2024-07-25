namespace ST10079970_PROG7312_ICE_Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Convict convict = new Convict(12345, 5, 101, "Swiper", "No Swiping", "Theft");

            Console.WriteLine("Convict ID: " + convict[0]);
            Console.WriteLine("Sentence: " + convict[1]);
            Console.WriteLine("Cell Number: " + convict[2]);
            convict[2] = 102;
            Console.WriteLine("Name: " + convict[3]);
            Console.WriteLine("Surname: " + convict[4]);
            Console.WriteLine("Crime: " + convict[5]);

            Console.WriteLine("\nUpdated Convict Information:");
            Console.WriteLine("Convict ID: " + convict["convictid"]);
            Console.WriteLine("Sentence: " + convict["sentence"]);
            Console.WriteLine("Cell Number: " + convict["cellnumber"]);
            Console.WriteLine("Name: " + convict["name"]);
            Console.WriteLine("Surname: " + convict["surname"]);
            Console.WriteLine("Crime: " + convict["crime"]);
        }
    }
}