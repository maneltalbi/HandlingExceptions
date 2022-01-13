namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"c:/lesson 17/WriteText.txt");
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}