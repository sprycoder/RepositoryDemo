using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo
{
    /// <summary>
    /// This class contains information about a Dependency Injection container
    /// </summary>
    public class Container
    {
        /// <summary>
        /// Gets or sets name of the container
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets company name of container
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets description of container
        /// </summary>
        public string Description { get; set; }

    }
}
