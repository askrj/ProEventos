using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IGenericsPersist
    {
         void Add<T>(T entity) where T: class;
         void UpDate<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         void DeleteRange<T>(T entity) where T: class;
         Task<bool> SaveChangesAsync();
    }
}