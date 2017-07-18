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

            _UsuariosRepository = new GenericRepository<Usuarios, long>(DB, DBLocker);
            _DataSalaRepository = new GenericRepository<DataSala, long>(DB, DBLocker);
            _InterruptoresRepository = new GenericRepository<Interruptores, long>(DB, DBLocker);
            _LogLabRepository = new GenericRepository<LogLab, long>(DB, DBLocker);
            _SalaRepository = new GenericRepository<Sala, long>(DB, DBLocker);
            _ArCondicionadoRepository = new GenericRepository<ArCondicionado, long>(DB, DBLocker);

            lock (DBLocker)
            {
                DB.CreateTable<Usuarios>();
                DB.CreateTable<DataSala>();
                DB.CreateTable<Interruptores>();
                DB.CreateTable<LogLab>();
                DB.CreateTable<Sala>();
                DB.CreateTable<ArCondicionado>();
            }
        }

        static object DBLocker = new object();
        readonly SQLiteConnection DB;

        #region Usuarios
        IGenericRepository<Usuarios, long> _UsuariosRepository;
        public IGenericRepository<Usuarios, long> UsuariosRepository
        {
            get
            {
                return _UsuariosRepository;
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

        #region Interruptores
        IGenericRepository<Interruptores, long> _InterruptoresRepository;
        public IGenericRepository<Interruptores, long> InterruptoresRepository
        {
            get
            {
                return _InterruptoresRepository;
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
