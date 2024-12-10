using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Tests
{
    public class DITest3
    {
        private readonly IGenericRepository<UPS> repo; 
        public DITest3(IGenericRepository<UPS> repo) 
        {
            this.repo = repo;
        }
        
        public void RunUPS ()
        {
            this.repo.Insert (new UPS { Id = 1, UpsModel= "Digital X 650VA Offline UPS", LoadCapacity=480, OutputVoltage= "220V ~ 240V", BackupTime="5-10 Minutes", Price = 3050.50M});
            this.repo.InsertRange(new UPS[]
            { 
                new UPS () { Id = 2, UpsModel= "KSTAR 1500VA Offline UPS", LoadCapacity=900, OutputVoltage= "230V", BackupTime="7-20 Minutes", Price = 8880.00M},
                new UPS () { Id = 3,UpsModel= "KSTAR 1500VA Offline UPS", LoadCapacity=900, OutputVoltage= "230V", BackupTime="7-20 Minutes", Price = 8880.00M}
            });


            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Inserting UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            this.repo.Get()
                .ToList()
                .ForEach(u => Console.WriteLine($"ID: {u.Id}\n UPS Model:{u.UpsModel}\n Load Capacity: {u.LoadCapacity}W\n Output Voltage: {u.OutputVoltage}\n Backup time: {u.BackupTime}\n Price:{u.Price} BDT"));
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Updating UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            var ups = repo.Get(1);
            ups.UpsModel = "APOLLO 1120F 1200VA Offline UPS";
            ups.LoadCapacity = 750;
            ups.BackupTime = "10-30 Minutes";

            ups.Price = 6400; 
            this.repo.Update(ups);
            this.repo.Get()
                .ToList () 
                .ForEach(u => Console.WriteLine($"ID: {u.Id}\n UPS Model:{u.UpsModel}\n Load Capacity: {u.LoadCapacity}W\n Output Voltage: {u.OutputVoltage}\n Backup time: {u.BackupTime}\n Price:{u.Price} BDT"));
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Deleting UPS Info~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            this.repo.Delete(2); 
            this.repo.Get()
                .ToList()
                .ForEach(u => Console.WriteLine($"ID: {u.Id}\n UPS Model:{u.UpsModel}\n Load Capacity: {u.LoadCapacity}W\n Output Voltage: {u.OutputVoltage}\n Backup time: {u.BackupTime}\n Price:{u.Price} BDT"));
            Console.WriteLine();
            Console.WriteLine("=====================================================================");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}

