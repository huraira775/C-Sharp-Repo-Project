using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public enum PurposeOfDesktop { OfficialTasks, GamingAppDevelopment, ECommerceWebsiteDevelopment }
    public class Desktop : IEntityBase
    {
        
        public int Id { get; set; }
        public PurposeOfDesktop Purpose {  get; set; }
        public string Processor { get; set; }
        public string MotherBoard { get; set; }
        public string CasingName { get; set; }
        public int Ram { get; set; }
        public int Ssd { get; set; }
        public int PowerSupply { get; set; }
        public string Graphics { get; set; }
        public int NumberOfCoolingFan { get; set; }
        public string MontiorModel { get; set; }
        public string MouseModel { get; set; }
        public string KeyBoardModel { get; set; }
        public string SpeakerName { get; set; }
        public decimal TotalPrice { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\n CPU: {Processor}\n Mother Board: {MotherBoard}\n Purpose of the desktop:{Purpose}\n " +
                $"{CasingName}\n RAM: {Ram}GB\n SSD: {Ssd}GB\n Power Supply:{PowerSupply} W\n Graphics: {Graphics}\n Total Cooling Fan:{NumberOfCoolingFan} Fans\n Monitor Model: {MontiorModel}\n Keyboard Model: {KeyBoardModel}\n Mouse Model: {MouseModel}\n Speaker Name: {SpeakerName}\n Total Pricing: {TotalPrice} BDT";
        }
    }
}
