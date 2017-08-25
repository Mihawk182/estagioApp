using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class Sala
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public int Qtd_Ar { get; set; }

        public int Qtd_Interruptores { get; set; }

        [OneToMany]
        public List<LogLab> Logs { get; set; }
        public List<DataSala> Datas { get; set; }
        public List<ArCondicionado> Ares { get; set; }
        public List<Interruptor> Interruptores { get; set; }
    }
}