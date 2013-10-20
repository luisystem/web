using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace AccesoDatos
{
    public class BaseDA
    {
        protected DBDeportesDataContext GetDC()
        {
            DBDeportesDataContext DC = new DBDeportesDataContext();
            DC.DeferredLoadingEnabled = false;
            return DC;
        }
        protected List<T> ConsultaALista<T>(IQueryable<T> query)
        {
            List<T> lista = new List<T>();
            foreach(T item in query)
            {
                lista.Add(item);
            }
            return lista;
        }    
    }
}
