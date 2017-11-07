using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace ASF.Data
{
    public class AbstractDAC<TEntity> where TEntity : class
    {

        protected LeatherContext Context { get; set; }

        public AbstractDAC(LeatherContext context)
        {
            Context = context;
        }
        
        /// <summary>
        /// Find entity using numerci id
        /// </summary>
        /// <typeparam name="T">Entity to find</typeparam>
        /// <param name="id"></param>
        /// <returns>The entity</returns>
        public T FindById<T> (long id)
        {

            using (var dbo = Context)
            {
                var prop = dbo.GetType().GetProperty(typeof(T).Name);

                var getter = prop.GetGetMethod();

                var dbset = getter.Invoke(dbo,null);



                var findMethod = dbset.GetType().GetMethod("Find");
                var result = findMethod.Invoke(dbset,new object[] { new object[] { id } });

                return (T) result;
              
            }
        }

        public List<TEntity> SelectAll()
        {
            return SelectAll(500);
        }

        public List<TEntity> SelectAll(int max)
        {
            return Context.Set<TEntity>().Take(max).ToList();   
        }
    }
}