using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class LogLab
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        public int Evento { get; set; }

        public DateTime Instante { get; set; }

        [ForeignKey(typeof(Usuario))]
        public int IdUsuario { get; set; }

        [ForeignKey(typeof(Sala))]
        public int IdSala { get; set; }

        [ManyToOne]
        public Usuario Usuario { get; set; }

        [ManyToOne]
        public Sala Sala { get; set; }
    }
}
