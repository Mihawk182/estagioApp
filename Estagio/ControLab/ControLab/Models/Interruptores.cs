using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class Interruptores
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        public long? IdSala { get; set; }

        public string Nome { get; set; }
    }
}
