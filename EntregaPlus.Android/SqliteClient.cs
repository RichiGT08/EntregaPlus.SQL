using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using EntregaPlus.Dependencies;
using EntregaPlus.Droid;
using Xamarin.Forms;

[assembly: Dependency (typeof(SqliteClient))]
namespace EntregaPlus.Droid
{
    public class SqliteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        { 
            throw new NotImplementedException();
        }

        public SQLiteConnection GetLiteConnection()
        {
            throw new NotImplementedException();
        }
    }
}