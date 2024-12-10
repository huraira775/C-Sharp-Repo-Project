using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern
{
    internal class Program
    {
        static void Main()
        {
            RepositoryFactoryImpl factory = new RepositoryFactoryImpl();
            Console.WriteLine(); 
            Console.WriteLine("                                            DITest-01                          ");           
            Console.WriteLine("                                      Computers description:                         ");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine();
            DITest1 di1 = new DITest1(factory);
            di1.RunDesktop();           
            Console.WriteLine();

            Console.WriteLine("                                           DITest-02                                         ");
            Console.WriteLine("                                          Computer Details:                                        ");
            Console.WriteLine("===============================================================================================");
           
            DiTest2 di2 = new DiTest2(factory.GetRepo<Desktop>());
            di2.RunComputers();
            Console.WriteLine("                                           DITest-03                                         ");
            Console.WriteLine("                                          UPS Details:                                        ");
            Console.WriteLine("===============================================================================================");
            
            DITest3 di3 = new DITest3(factory.GetRepo<UPS>());
            di3.RunUPS();

            Console.ReadLine();
        }
    }
}

