using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaPlus.Dependencies
{
   public interface IDataBase
    {
        SQLite.SQLiteConnection GetLiteConnection();
        SQLiteConnection GetConnection();
    }
}
