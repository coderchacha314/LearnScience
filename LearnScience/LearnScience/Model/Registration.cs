using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnScience.Model
{
    public class Registration
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string name { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }




    }
}
