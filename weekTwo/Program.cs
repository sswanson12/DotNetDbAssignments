namespace weekTwo;
class Program
{
    static void Main(string[] args)
    {
        string file = "files/grades.txt";
        //read file
        StreamReader sr = new StreamReader(file);

        sr.ReadLine();

        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();

            var column = line.Split(',');
            Console.WriteLine("Name: {0}, Class: {1}, Grade: {2}", column[0], column[1], column[2]);

        }
        sr.Close();
        
        //write file
        StreamWriter sw = new StreamWriter(file, true);
        // Console.WriteLine("Enter your name");
        // var name = Console.ReadLine();

        var entryRow = "Bob, German, B";
        
        sw.WriteLine(entryRow);
        
        sw.Close();
    }
}