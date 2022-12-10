using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjekatOsoba
{
    class Povezivanje
    {
        public static SqlConnection Konekcija()
        {
            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-TB5074K\\SQLEXPRESS;Initial Catalog=ednevnik2022;Integrated Security=true");
            return veza;
        }
    }
}
