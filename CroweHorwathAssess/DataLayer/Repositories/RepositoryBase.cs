using CroweHorwathAssess.DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHorwathAssess.DataLayer.Repositories
{
    /// <summary>
    /// Skeleton repository base
    /// </summary>
    /// <typeparam name="model"></typeparam>
    /// <typeparam name="efItem"></typeparam>
    internal abstract class RepositoryBase<model, efItem>
        where model : class
        where efItem : class
    {
        /// <summary>
        /// Implementation of the model class mapping to Entity Framework
        /// </summary>
        /// <param name="efitem"></param>
        /// <returns></returns>
        internal abstract model FromEF(efItem efitem);
        /// <summary>
        /// Implementation of the Entity Framework mapping to model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        internal abstract efItem ToEF(model model);
        internal virtual List<model> FromEF(IEnumerable<efItem> efItems)
        {
            List<model> result = new List<model>();
            foreach (efItem item in efItems)
            {
                result.Add(this.FromEF(item));
            }
            return result;
        }
        
      
    }
}