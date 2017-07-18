using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ControLab.Models
{
    public partial class DataSala
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public long? IdSala { get; set; }
        public DateTime Instante { get; set; }
        public int MediaUmid { get; set; }
        public int MediaTemp { get; set; }
        public int MediaLumi { get; set; }
    }
}
