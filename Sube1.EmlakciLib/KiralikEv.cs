using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan):base(odasayisi,katno,alan,semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;           
        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        //}
        public override void EvBilgisi()
        {
            Console.WriteLine($"Semt: {Semt}\n Oda Sayısı: {Odasayisi}\n Kat: {Katno}\n Alan: {Alan} m²\n Kira: {Kira} TL\n Depozito: {Depozito} TL");
        }
        public override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}

//internal: Yalnızca aynı namespace içindeki classlar tarafından erişilebilir.
