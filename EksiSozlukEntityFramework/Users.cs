using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukEntityFramework
{
    public class Users
    {
        public int ID { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public List<İcerik> İceriks { get; set; }

    }
}
