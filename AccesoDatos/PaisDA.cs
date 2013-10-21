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
        public void Adicionar(Pais item)
        {
            DBDeportesDataContext dc = GetDC();
            dc.Pais.InsertOnSubmit(item);
            dc.SubmitChanges();
        }
        public void Eliminar(Pais item)
        {
            DBDeportesDataContext dc = GetDC();
            dc.Pais.Attach(item);
            dc.Pais.DeleteOnSubmit(item);
            dc.SubmitChanges();
        }
        public void Actualizar(Pais nuevoItem, Pais originalItem)
        {
            DBDeportesDataContext dc = GetDC();
            dc.Pais.Attach(nuevoItem, originalItem);
            dc.SubmitChanges();
        }
        #endregion
    }
}
