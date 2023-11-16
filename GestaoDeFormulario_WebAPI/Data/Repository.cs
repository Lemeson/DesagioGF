using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class Repository : IRepository //herda de IRepository e aqui os métodos definidos em IRepository tomam "vida"
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }//até aqui é obgratorio

        public async Task<Lead[]> GetAllLeadsAsync() //false é apenas um valor padrão para inicialização
        {
            IQueryable<Lead> query = _context.Leads;

            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }
        public async Task<Lead> GetLeadsAsyncById(int leadId)
        {
            IQueryable<Lead> query = _context.Alunos;

            query = query.AsNoTracking()
                         .OrderBy(lead => lead.id)
                         .Where(lead => lead.id == leadId);

            return await query.FirstOrDefaultAsync();
        }
    

    }
}
