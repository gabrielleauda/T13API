using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivrosRepository
    {
        private readonly ChapterContext _context;

        public LivrosRepository(ChapterContext context) 
        {
            _context = context;
        }

        public List<Livros> Listar() 
        {
            return _context.Livros.ToList();
        }
    }
}
