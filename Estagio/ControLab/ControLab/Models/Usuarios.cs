using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int Privilegios { get; set; } 
    }
}
