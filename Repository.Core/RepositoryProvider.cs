using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Repository.Core
{

    public static class RepositoryProvider
    {
        /// <summary>
        /// Generates a repository instance based on configuration
        /// </summary>
        /// <returns>Instance of Repository</returns>
        public static IRepository GetRepository()
        {
            var typeName = ConfigurationManager.AppSettings["RepositoryType"].ToString();
            var repoType = Type.GetType(typeName);
            var repository = Activator.CreateInstance(repoType);
            return repository as IRepository;
        }
    }
}
