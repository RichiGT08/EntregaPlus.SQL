using EntregaPlus.Base;
using EntregaPlus.Models;
using EntregaPlus.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EntregaPlus.ViewModels
{
   public class EntregaModel: ViewModelBase
    {
        RepositoryEntregas repo;

        public EntregaModel()
        {
            this.repo = new RepositoryEntregas();
            this.entrega = new Entrega();
        }

        public Command InsertarEntrega
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarEntrega (this.entrega.Codigo, entrega.Direccion, entrega.destinatario, entrega.ubicacion, entrega.Estado, entrega.Observacion);
                    
                });
            }
        }

        public Command ModificarEntrega
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarEntrega(this.entrega.Codigo, entrega.Direccion, entrega.destinatario, entrega.ubicacion, entrega.Estado, entrega.Observacion);
                });
            }
        }

        public Command EliminarEntrega
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarEntrega(this.entrega.Codigo);
                });
            }
        }

        private Entrega _entrega;
        public Entrega entrega
        {
            get { return this._entrega; }
            set
            {
                this._entrega = value;
                OnPropertyChanged("Entrega");
            }
        }
    }
}