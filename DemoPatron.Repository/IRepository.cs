using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DemoPatron.Repository

{
    //T es una referencia y va a recibir tipos referencia
   public interface IRepository<T> where T: class
    {
        //int es un tipo valor (datos numericos o logicos), clases son tipo referencia, string es un tipo referencia (son cadenas de caracteres por eso se conocen como de referencia)
        //se crean los metodos para que persistan en el proyecto

        //Vamos a tener un metodo para poder obtener una lista 
        IEnumerable<T> GetAll(string query);

        
        T Create(T t);
        int Update(T T);
        int Delete(Expression<Func<T, bool>> predicate);

    }
}
