using EntregaPlus.Dependencies;
using SQLite;
using EntregaPlus.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace EntregaPlus.Repository
{
  public  class RepositoryEntregas
    {
        private SQLiteConnection cn;
        public RepositoryEntregas()
        {
            this.cn = DependencyService.Get<IDataBase>().GetConnection();

        }

        //---------METODOS:

        public void CrearBDD()
        {
            this.cn.DropTable<Entrega>();
            this.cn.CreateTable<Entrega>();
        }
        public List<Entrega> GetEntregas()
        {
            var consulta = from datos in cn.Table<Entrega>()
                           select datos;
            return consulta.ToList();

        }

       

        public Entrega BuscarEntrega(int num)
        {
            var consulta = from datos in cn.Table<Entrega>()
                           where datos.codigo == num
                           select datos;
            return consulta.FirstOrDefault();

        }
        public void InsertarEntrega (int codigo, string direccion, string destinatario, string ubicacion, string estado, string observacion)
        {
            Entrega entreg = new Entrega();
            entreg.direccion = direccion;
            entreg.destinatario = destinatario;
            entreg.ubicacion = ubicacion;
            entreg.estado = estado;
            entreg.observacion = observacion;
            this.cn.Insert(entreg);
        }

        public void ModificarEntrega (int codigo, string direccion, string destinatario, string ubicacion, string estado, string observacion)
        {
            Entrega entreg = this.BuscarEntrega(codigo);
            entreg.direccion = direccion;
            entreg.destinatario = destinatario;
            entreg.ubicacion = ubicacion;
            entreg.estado = estado;
            entreg.observacion = observacion;
            this.cn.Update(entreg);
        }
        public void EliminarEntrega (int codigo)
        {
            Entrega entreg = this.BuscarEntrega(codigo);
            this.cn.Delete<Entrega>(codigo);
        }
    }
}
