using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using RepositoryFactoryAndMethodPattern.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RepositoryFactoryAndMethodPattern.Models.Desktop;

namespace RepositoryFactoryAndMethodPattern.Tests
{
    public class DITest1
    {
        private readonly  IRepositoryFactory factory; 
        public DITest1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public void RunDesktop()
        {
            IGenericRepository<Desktop>repo =this.factory.GetRepo<Desktop>();                 
            repo.Insert(new Desktop { Id = 01, Purpose = PurposeOfDesktop.OfficialTasks,              
                CasingName = "Xtreme 929 Mid Tower ATX Casing", 
                Processor= "Intel 10th Gen Core i3 10100F Processor", MotherBoard= "Gigabyte H410M S2H 10th Gen Micro ATX Motherboard", 
                Ram = 8, Ssd= 128,PowerSupply= 450, Graphics= "MSI GeForce GT 730 4GB DDR3 Graphics Card", 
                NumberOfCoolingFan= 4, MontiorModel= "Viewsonic VA1903H 18.5 inch LED Monitor", MouseModel= "Xtrike Me GM-124 USB Wired Optical Mouse",
                KeyBoardModel = "Havit KB376 USB Multimedia Keyboard", SpeakerName= "Havit SK518 2.0 USB Speaker", TotalPrice= 55500.00M
            });
            repo.InsertRange(new Desktop[]
            {
                
                 new Desktop {Id = 02, Purpose=PurposeOfDesktop.ECommerceWebsiteDevelopment, CasingName= "Value-Top V300 Mini Tower Micro-ATX Gaming Casing",
                    Processor= "Intel 12th Gen Core i7-12700 Alder Lake Processor", MotherBoard= "GIGABYTE B760M H DDR4 mATX Motherboard",
                    Ram = 16, Ssd= 512,PowerSupply= 550, Graphics= "ASUS ProArt GeForce RTX 4060 OC Edition 8GB GDDR6 Graphics Card",
                    NumberOfCoolingFan= 4, MontiorModel= "Viewsonic VA1903H 18.5 inch LED Monitor", MouseModel= "Xtrike Me GM-124 USB Wired Optical Mouse",
                    KeyBoardModel = "Ajazz AK820 75% Gasket-mounted Sea Salt Switch Wired Mechanical Keyboard", SpeakerName= "Havit SK518 2.0 USB Speaker", TotalPrice= 155000.00M}, 
                
                new Desktop { Id = 03, Purpose=PurposeOfDesktop.GamingAppDevelopment, CasingName= "Antec NX410 V2 Mid Tower ARGB Gaming Case White",
                    Processor= "Intel Core i9 14900K 14th Gen Raptor Lake Processor", MotherBoard= "GIGABYTE B760M H DDR4 mATX Motherboard",
                    Ram = 64, Ssd= 2048,PowerSupply= 650, Graphics= "ASUS ROG Strix GeForce RTX 4060 OC Edition 8GB GDDR6 Graphics Card",
                    NumberOfCoolingFan= 8, MontiorModel= "ASUS TUF Gaming VG30VQL1A 29.5 inch 2K 200Hz HDR Ultrawide Curved Monitor", MouseModel= "Razer Cobra Pro RGB Wireless Gaming Mouse (Global)",
                    KeyBoardModel = "Logitech G813 LIGHTSYNC RGB Mechanical Gaming Keyboard", SpeakerName= "Logitech Surround Sound Z623 2:1 Speaker", TotalPrice= 750000.00M}
            });


            
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Inserting Computers' Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine(b.GetDetails()));
            Console.WriteLine("-------------------");
            Console.WriteLine();
            //Update
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Updating Computers' Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            var desktop = repo.Get(2);
            desktop.TotalPrice = 1750M;
            repo.Update(desktop); 
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine(b.GetDetails()));
            Console.WriteLine("-------------------");
            Console.WriteLine();
            //Delete 
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Deleting Computers' Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            repo.Delete(1);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine(b.GetDetails()));
            Console.WriteLine("-------------------");
            Console.WriteLine("===============================================");
            Console.WriteLine();
            IGenericRepository<UPS> repo1 = this.factory.GetRepo<UPS>();
            repo1.Insert(new UPS { Id = 1, UpsModel = "Digital X 650VA Offline UPS", LoadCapacity = 480, OutputVoltage = "220V ~ 240V", BackupTime = "5-10 Minutes", Price = 3050.50M });
            repo1.InsertRange(new UPS[]
            {
                new UPS () { Id = 2, UpsModel= "KSTAR 1500VA Offline UPS", LoadCapacity=900, OutputVoltage= "230V", BackupTime="7-20 Minutes", Price = 8880.00M},
                new UPS () { Id = 3,UpsModel= "KSTAR 1500VA Offline UPS", LoadCapacity=900, OutputVoltage= "230V", BackupTime="7-20 Minutes", Price = 8880.00M}
            });


            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Inserting UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            repo1.Get()
                .ToList()
                .ForEach(u => Console.WriteLine(u.GetDetails()));
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Updating UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            var ups = repo1.Get(1);
            ups.UpsModel = "APOLLO 1120F 1200VA Offline UPS";
            ups.LoadCapacity = 750;
            ups.BackupTime = "10-30 Minutes";

            ups.Price = 6400;
            repo1.Update(ups);
            repo1.Get()
                .ToList()
                .ForEach(u => Console.WriteLine(u.GetDetails()));
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Deleting UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            repo1.Delete(2);
            repo1.Get()
                .ToList()
                .ForEach(u => Console.WriteLine(u.GetDetails()));
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
