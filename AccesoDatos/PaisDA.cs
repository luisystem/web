using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace AccesoDatos
{
    public class PaisDA:BaseDA,IDataAccess<Pais>
    {
        #region Miembros de IDataAccess<pais>
        public List<Pais> GetAll()
        {
            DBDeportesDataContext dc = GetDC();
            IQueryable<Pais> query = from pais in dc.Pais
                                     select pais;
            return ConsultaALista<Pais>(query);
        }
        #endregion
    }
}
