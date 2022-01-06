using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukEntityFramework
{
    public class İcerik
    {
        public int İcerikID { get; set; }

        public int KullaniciID { get; set; }

        public string Yorum { get; set; }
        public DateTime YorumTarihi { get; set; }

        public int KatID { get; set; }

        public Kategori Kategori { get; set; }

        public Users Users { get; set; }
    }
}
