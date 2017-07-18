using ControLab.Models;
namespace ControLab.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Usuarios, long> UsuariosRepository { get; }
        IGenericRepository<DataSala, long> DataSalaRepository { get; }
        IGenericRepository<Interruptores, long> InterruptoresRepository { get; }
        IGenericRepository<LogLab, long> LogLabRepository { get; }
        IGenericRepository<Sala, long> SalaRepository { get; }
        IGenericRepository<ArCondicionado, long> ArCondicionadoRepository { get; }
    }
}
