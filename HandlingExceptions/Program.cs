namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"c:/lesson 17/WriteTex.txt");
                Console.WriteLine(content);
               
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly WriteTexte.txt ");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine(@"Make sure the directory c:/lesson 17 exists ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();

        }
    }
}