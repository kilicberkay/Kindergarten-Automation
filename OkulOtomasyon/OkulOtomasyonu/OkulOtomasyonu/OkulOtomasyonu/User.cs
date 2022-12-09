using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu
{
    public class User
    {
        public int UserID { get; set; }
        public string TCKN { get; set; }
        public int isTeacher { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public DateTime Date { get; set; }
    }
}
