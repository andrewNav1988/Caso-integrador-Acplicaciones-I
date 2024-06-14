using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Calculador_Notas_Finales
{
    internal class conexionabd
    {
        public static SqlConnection Abrirconexion()
        {
            SqlConnection Conector=new SqlConnection("Data Source=StevenEscritorio\\SQLEXPRESS01;Initial Catalog=tecnologiaDesarrolloSoftware;Integrated Security=True");
            Conector.Open();
            return Conector;
        }





    }
}
