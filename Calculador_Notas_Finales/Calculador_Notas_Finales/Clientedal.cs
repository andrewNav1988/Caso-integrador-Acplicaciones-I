using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Calculador_Notas_Finales
{
    internal class Clientedal
    {
        public static int CrearEstudiante(string pNombreEstudiante, string pTipoDocumento, string pNoDocumento, string pNotacorte1, string pNotaCorte2, string pNotaCorte3, string pNotaDefinitiva)
        {   
            int resultado = 0;
            SqlConnection Conector = conexionabd.Abrirconexion();
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into tecnologiaDesarrollooftware(NombreEstudiante,TipoDocumento,NoDocumento,NotaCorte1,NotaCorte2,NotaCorte3,NotaDefinitiva) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", pNombreEstudiante, pTipoDocumento, pNoDocumento, pNotacorte1, pNotaCorte2, pNotaCorte3, pNotaDefinitiva), Conector);
                resultado= comando.ExecuteNonQuery();
               
            }return resultado;
        }
    }
}
