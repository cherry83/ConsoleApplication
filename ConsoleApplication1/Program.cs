using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            String Hello = "Hello";
            String World = "World";
            Object HelloWorldObject = Hello + " " + World;
            String HelloWorld = HelloWorldObject.ToString();
            Console.WriteLine(HelloWorld);
        }
    }
}