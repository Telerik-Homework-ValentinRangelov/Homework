using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public static class File
    {
        public static string GetFileExtension(string fileName)
        {

            int indexOfLastDot = fileName.LastIndexOf(".");
            try
            {

                if (indexOfLastDot == -1)
                {
                    throw new Exception("Extension not found!");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Exception accured ! - 'Extension not found!'");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;

        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
