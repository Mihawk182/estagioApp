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

            //_PessoaRepository = new GenericRepository<NomeTabela, long>(DB, DBLocker);

            lock (DBLocker)
            {
                //DB.CreateTable<NomeTabela>();
            }
        }

        static object DBLocker = new object();
        readonly SQLiteConnection DB;

        //#region Pessoa
        //IGenericRepository<NomeTabela, long> _NomeTabelaRepository;
        //public IGenericRepository<NomeTabela, long> NomeTabelaRepository
        //{
        //    get
        //    {
        //        return _NomeTabelaRepository;
        //    }
        //}
        //#endregion

    }
}
