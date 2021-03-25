using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
        }
    }
}
