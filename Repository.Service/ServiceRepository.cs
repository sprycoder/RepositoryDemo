using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Core;

namespace Repository.Service
{
    using Repository.Model;

    public class ServiceRepository : IRepository
    {
        public IEnumerable<InjectionContainer> GetContainers()
        {
            return new List<InjectionContainer>
                               {
                                   new InjectionContainer
                                       {
                                           Name = "Unity",
                                           Author = "Microsoft",
                                           Description = "The Unity InjectionContainer (Unity) is a lightweight, extensible dependency injection container with optional support for instance and type interception."
                                       },
                                    new InjectionContainer
                                       {
                                           Name = "AutoFac",
                                           Author = "MIT",
                                           Description = "Autofac is an IoC container for Microsoft .NET. It manages the dependencies between classes so that applications stay easy to change as they grow in size and complexity. This is achieved by treating regular .NET classes as components."
                                       }
                               };

        }
    }
}
