using System;
using Microsoft.Owin.Hosting;

class Program
{
    static void Main()
    {
        string baseAddress = "http://localhost:50000" +
            "/";

        using (WebApp.Start<Startup>(url: baseAddress))
        {
            Console.WriteLine($"Server running at {baseAddress}");
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
