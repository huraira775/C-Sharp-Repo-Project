using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class UPS:IEntityBase
    {
        public int Id { get; set; }
        public string UpsModel { get; set; }
        public int LoadCapacity { get; set; }
        public string OutputVoltage { get; set; }
        public string BackupTime { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, UPS Model: {UpsModel}, Load capacity: {LoadCapacity}, Output Voltage: {OutputVoltage}, Total Backup time:{BackupTime}, Price: {Price}"; 
        }

    }
}
