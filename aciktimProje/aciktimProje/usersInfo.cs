using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aciktimProje
{
    internal class usersInfo
    {
        public class KullaniciBilgileri
        {
            public string KullaniciMail { get; set; }
            public int ToplamFiyat { get; set; }

            private static KullaniciBilgileri _instance;

            public static KullaniciBilgileri Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new KullaniciBilgileri();
                    }
                    return _instance;
                }
            }
        }


    }
}
