using System;


    class Program
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            //url = Console.ReadLine(); //<------Untag this if u want ur own url
            Console.WriteLine(url);
            string protocol;
            string server;
            string resource;
            int afterProtocol = url.IndexOf("://");
            int afterServer = url.IndexOf("/",afterProtocol+3);
            protocol = url.Substring(0, afterProtocol);
            server = url.Substring(afterProtocol + 3, afterServer - afterProtocol - 3);
            resource = url.Substring(afterServer);
            Console.WriteLine("Protocol: {0}",protocol);
            Console.WriteLine("Server: {0}",server);
            Console.WriteLine("Resource: {0}",resource);

        }
    }

