using System;
using System.Collections.Generic;
using System.Text;

namespace LearnScience
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
