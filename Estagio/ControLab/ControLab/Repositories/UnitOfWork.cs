using ControLab.Models;
using ControLab.Repositories.Interfaces;
using SQLite.Net;

namespace ControLab.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(SQLiteConnection sqlite)
        {
            DB = sqlite;

            _UsuarioRepository = new GenericRepository<Usuario, long>(DB, DBLocker);
            _DataSalaRepository = new GenericRepository<DataSala, long>(DB, DBLocker);
            _InterruptorRepository = new GenericRepository<Interruptor, long>(DB, DBLocker);
            _LogLabRepository = new GenericRepository<LogLab, long>(DB, DBLocker);
            _SalaRepository = new GenericRepository<Sala, long>(DB, DBLocker);
            _ArCondicionadoRepository = new GenericRepository<ArCondicionado, long>(DB, DBLocker);

            lock (DBLocker)
            {
                DB.CreateTable<Usuario>();
                DB.CreateTable<DataSala>();
                DB.CreateTable<Interruptor>();
                DB.CreateTable<LogLab>();
                DB.CreateTable<Sala>();
                DB.CreateTable<ArCondicionado>();
            }
        }

        static object DBLocker = new object();
        readonly SQLiteConnection DB;

        #region Usuario
        IGenericRepository<Usuario, long> _UsuarioRepository;
        public IGenericRepository<Usuario, long> UsuarioRepository
        {
            get
            {
                return _UsuarioRepository;
            }
        }
        #endregion

        #region DataSala
        IGenericRepository<DataSala, long> _DataSalaRepository;
        public IGenericRepository<DataSala, long> DataSalaRepository
        {
            get
            {
                return _DataSalaRepository;
            }
        }
        #endregion

        #region Interruptor
        IGenericRepository<Interruptor, long> _InterruptorRepository;
        public IGenericRepository<Interruptor, long> InterruptorRepository
        {
            get
            {
                return _InterruptorRepository;
            }
        }
        #endregion

        #region LogLab
        IGenericRepository<LogLab, long> _LogLabRepository;
        public IGenericRepository<LogLab, long> LogLabRepository
        {
            get
            {
                return _LogLabRepository;
            }
        }
        #endregion

        #region Sala
        IGenericRepository<Sala, long> _SalaRepository;
        public IGenericRepository<Sala, long> SalaRepository
        {
            get
            {
                return _SalaRepository;
            }
        }
        #endregion

        #region ArCondicionado
        IGenericRepository<ArCondicionado, long> _ArCondicionadoRepository;
        public IGenericRepository<ArCondicionado, long> ArCondicionadoRepository
        {
            get
            {
                return _ArCondicionadoRepository;
            }
        }
        #endregion

    }
}
