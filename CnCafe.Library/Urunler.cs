using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnCafe.Library
{
    public class Urunler
    {
        public Guid ID { get; set; }
        public string  Urun{ get; set; }
        public double Fiyat{ get; set; }
        public int Adet{ get; set; }
        public double Toplam{ get; set; }
        public bool YiyecekMi{ get; set; }
        public override string ToString()
        {
            return Urun;
        }
    }
}
