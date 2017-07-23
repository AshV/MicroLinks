using System;
using MicroLinks.Firabase;
using System.IO;
using static System.Console;

namespace ConsoleCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            new Uri("https://github.com/AshV", UriKind.RelativeOrAbsolute);
            while (true)
            {
                WriteLine("Link To Short");
                var key = Console.ReadLine();
                WriteLine(Generator.Get.CreateMicroLink(key));
                WriteLine(Navigator.Get.Navigate("dkxmm"));
                ReadLine();
            }
        }
    }
}