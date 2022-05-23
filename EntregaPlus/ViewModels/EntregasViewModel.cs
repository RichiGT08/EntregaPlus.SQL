using EntregaPlus.Base;
using EntregaPlus.Models;
using EntregaPlus.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EntregaPlus.ViewModels
{
   public class EntregasViewModel: ViewModelBase
    {
        public EntregasViewModel()
        {
            RepositoryEntregas repo = new RepositoryEntregas();
            List<Entrega> lista = repo.GetEntregas();
            this.Entregas = new ObservableCollection<Entrega> (lista);
        }
        private ObservableCollection<Entrega> _Entregas;
        public ObservableCollection<Entrega> Entregas
        {
            get { return this._Entregas;  }
            set
            {
                this._Entregas = value;
                OnPropertyChanged("Entregas");
            }
        }
    }
}
