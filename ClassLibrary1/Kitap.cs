using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kitap
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime BasimTarihi { get; set; }
        public KitapTur KitapTuru { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime? OduncAlinmaTarihi { get; set; }
    }
}
