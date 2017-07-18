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

        public long? IdUsuario { get; set; }

        public long? IdSala { get; set; }

        public int Evento { get; set; }

        public DateTime Instante { get; set; }
    }
}
