using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class Interruptor
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey(typeof(Sala))]
        public int IdSala { get; set; }

        [ManyToOne]
        public Sala Sala{ get; set; }
    }
}
