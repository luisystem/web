using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public interface IDataAccess<T>
    {
        List<T> GetAll();
        void Adicionar(T item);
        void Eliminar(T item);
        void Actualizar(T nuevoItem, T originalItem);
    }
}
