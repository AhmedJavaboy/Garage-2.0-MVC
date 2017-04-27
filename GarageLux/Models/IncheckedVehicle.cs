using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageLux.Models
{
    public class IncheckedVehicle
    {
        public int ID { get; set; }

        [Display(Name = "Reg Nr")]
        public string RegNr { get; set; }
        public Vtype Vtype { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Wheel Wheel { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CheckInTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CheckOutTime { get; set; }
        public bool Status { get; set; }
    }
    public enum Vtype
    {
        Bandvagn, Bil, Buss, Båt, Cykel, Dragsjur, Fartyg, Flygplan, Fyrhjuling,
        Gruvtåg, Helikopter, Lastbild, Linbana, Luftballong, Luftskepp, Långtradare, Rymdskepp,
        Rälsbuss, Skoter, Skottkärra, Släde, Sparkstötting, Spårtaxi, Spårvagn, Terrängfordon,
        Tunnelbanetåg, Tåg, Ubåt
    }
   public enum Wheel
   {
        One,
        Two,
        Three,
       Four

    }
}