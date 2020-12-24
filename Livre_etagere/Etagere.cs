using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace Livre_etagere
{
    class Etagere
    {
        private string num;
        
        public Etagere(string num)
        {
            this.Num = num;
        }

        public string Num { get => num; set => num = value; }
    }
}
