using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data.Interfaz
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int Id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Insertar(T entity);
        void Actualizar(T entity);
        void Borrar(T entity);
    }
}
