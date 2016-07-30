using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Repository.Model;

using RepositoryDemo.Annotations;

namespace RepositoryDemo
{

    public class MainViewModel : INotifyPropertyChanged
    {
        List<InjectionContainer> _containers = new List<InjectionContainer>();

        public MainViewModel()
        {
            var repo = Repository.RepositoryProvider.GetRepository();
            this._containers = repo.GetContainers().ToList();
            //new List<InjectionContainer>
            //                   {
            //                       new InjectionContainer
            //                           {
            //                               Name = "Unity",
            //                               Author = "Microsoft",
            //                               Description = "The Unity InjectionContainer (Unity) is a lightweight, extensible dependency injection container with optional support for instance and type interception."
            //                           },
            //                        new InjectionContainer
            //                           {
            //                               Name = "AutoFac",
            //                               Author = "MIT",
            //                               Description = "Autofac is an IoC container for Microsoft .NET. It manages the dependencies between classes so that applications stay easy to change as they grow in size and complexity. This is achieved by treating regular .NET classes as components."
            //                           }
            //                   };
        }

        public List<InjectionContainer> InjectionContainers
        {
            get { return this._containers; }
            set
            {
                this._containers = value;
            }
        }

        #region NotifyPropertyChanged region
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
