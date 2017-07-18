using ControLab.Models;
namespace ControLab.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Usuario, long> UsuarioRepository { get; }
        IGenericRepository<DataSala, long> DataSalaRepository { get; }
        IGenericRepository<Interruptor, long> InterruptorRepository { get; }
        IGenericRepository<LogLab, long> LogLabRepository { get; }
        IGenericRepository<Sala, long> SalaRepository { get; }
        IGenericRepository<ArCondicionado, long> ArCondicionadoRepository { get; }
    }
}
