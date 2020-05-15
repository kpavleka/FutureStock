using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace FutureStock
{

     public class Konekcija
     {
        public NpgsqlConnection conn;
        
        public void OtvoriVezu()
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=ABC123123; Database=postgres;");
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }

        public void ZatvoriVezu()
        {
            conn.Close();
        }
       
          

     }
}
