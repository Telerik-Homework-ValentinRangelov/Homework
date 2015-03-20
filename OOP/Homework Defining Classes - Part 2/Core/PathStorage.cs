using System.IO;
namespace Core
{
    public static class PathStorage
    {


        private static StreamWriter writeFile;
        private static StreamReader readFile;
        public static void Save(Path point)
        {
            using (writeFile= new StreamWriter(@"text.txt"))
            {
                writeFile.WriteLine(point);
            }
        }
        
        
        public static void Load()
        {
            using (readFile = new StreamReader(@"text.txt"))
            {
                string text = readFile.ReadToEnd();
                System.Console.WriteLine(text);
            }
        }
       
    }
}
