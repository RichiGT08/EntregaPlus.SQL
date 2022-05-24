using EntregaPlus.Models;
using EntregaPlus.Repository;
using EntregaPlus.ViewModels;
using EntregaPlus.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntregaPlus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        RepositoryEntregas repo;
        public Registro()
        {
            InitializeComponent();
            this.repo = new RepositoryEntregas();
            this.repo.CrearBDD();
            this.btneliminar.Clicked += Btneliminar_Clicked;
            this.btnmodificar.Clicked += Btnmodificar_Clicked;
            this.btnmostrar.Clicked += Btnmostrar_Clicked;
            this.btnnuevo.Clicked += Btnnuevo_Clicked;
        }

        private async void Btnnuevo_Clicked(object sender, EventArgs e)
        {
            InsertarEntrega view = new InsertarEntrega();
            await Navigation.PushModalAsync(view);

        }

        private async void Btnmostrar_Clicked(object sender, EventArgs e)
        {
            EntregasView view = new EntregasView();
            await Navigation.PushModalAsync(view);

        }

        private async void Btnmodificar_Clicked(object sender, EventArgs e)
        {
            ModificarEntrega view = new ModificarEntrega();
            EntregaModel viewmodel = new EntregaModel();

            //buscar el número de departamento que hay en la caja
            int num = int.Parse(this.cajacodigo.Text);
            //asociarlo con viewmodel
            Entrega entreg = this.repo.BuscarEntrega(num);
            viewmodel.entrega = entreg;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

        private async void Btneliminar_Clicked(object sender, EventArgs e)
        {
            EliminarEntrega view = new EliminarEntrega();
            EntregaModel viewmodel = new EntregaModel();
            int num = int.Parse(this.cajacodigo.Text);
            Entrega entreg = this.repo.BuscarEntrega(num);
            viewmodel.entrega = entreg;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }
    }
}