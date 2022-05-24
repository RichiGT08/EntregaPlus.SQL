using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EntregaPlus.Dependencies;
using ProyectoSqlLite.Droid;
using SQLite;
using Xamarin.Forms;


[assembly: Dependency(typeof(SqLiteClient))]
namespace ProyectoSqlLite.Droid
{
    public class SqLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "EntregaPlus.db3";
            String rutadocumentos = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            String path = Path.Combine(rutadocumentos, bbddfile);
            SQLite.SQLiteConnection cn = new SQLite.SQLiteConnection(path);
            return cn;
        }

        public SQLiteConnection GetLiteConnection()
        {
            throw new NotImplementedException();
        }
    }
}