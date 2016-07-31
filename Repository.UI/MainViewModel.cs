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
            var repo = Repository.Core.RepositoryProvider.GetRepository();
            this._containers = repo.GetContainers().ToList();
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
