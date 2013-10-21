using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace AccesoDatos
{
    public class DeportistaDA : BaseDA, IDataAccess<deportista>
    {
         #region Miembros de IDataAccess<Deportista>
            public List<deportista> GetAll()
            {
                DBDeportesDataContext dc = GetDC();
                IQueryable<deportista> query = from deportista in dc.deportista
                                               select deportista;
                return ConsultaALista<deportista>(query);
            }
            public void Adicionar(deportista item)
            {
                DBDeportesDataContext dc = GetDC();
                dc.deportista.InsertOnSubmit(item);
                dc.SubmitChanges();
            }
            public void Eliminar(deportista item)
            {
                DBDeportesDataContext dc = GetDC();
                dc.deportista.Attach(item);
                dc.deportista.DeleteOnSubmit(item);
                dc.SubmitChanges();
            }
            public void Actualizar(deportista nuevoItem, deportista originalItem)
            {
                DBDeportesDataContext dc = GetDC();
                dc.deportista.Attach(nuevoItem, originalItem);
                dc.SubmitChanges();
            }
            #endregion

        }
    }

