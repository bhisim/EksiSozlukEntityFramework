using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukEntityFramework
{
    public class Kategori
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<İcerik> İcerikler { get; set; }
    }
}
