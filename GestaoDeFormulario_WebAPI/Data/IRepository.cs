using GestaoDeFormulario_WebAPI.Models;

namespace GestaoDeFormulario_WebAPI.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Lead[]> GetAllLeadsAsync();
        //Task<Aluno[]> GetLeadsAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina);
        Task<Lead> GetLeadsAsyncById(int leadId);

    }
}
