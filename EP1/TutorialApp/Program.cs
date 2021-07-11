using System;
using System.Threading;

namespace TutorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // String's and integer's in a nutshell c# tutorial S1 EP1
            string url = "google.com";
            int version = 1;
            Console.WriteLine($"Current Version: {version} Latest download link {url}");
            Thread.Sleep(2000);
            version = 2;
            url = "youtube.com";
            Console.WriteLine($"Current Version: {version} Latest download link {url}");
        }
    }
}
