using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Aluno[]> GetAllLeadsAsync(bool includeProfessor);
        //Task<Aluno[]> GetLeadsAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina);
        Task<Aluno> GetLeadsAsyncById(int alunoId, bool includeProfessor);

    }
}
