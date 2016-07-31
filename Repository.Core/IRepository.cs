using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Core
{

    public interface IRepository
    {
        /// <summary>
        /// Fetches collection of InjectionContainer
        /// </summary>
        /// <returns>IEnumerable InjectionContainer</returns>
        IEnumerable<InjectionContainer> GetContainers();
    }
}
