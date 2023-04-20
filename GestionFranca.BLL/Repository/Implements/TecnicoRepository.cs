using GestionFranca.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFranca.BLL.Repository.Implements
{
    public class TecnicoRepository : GenericRepository<Tecnico>, ITecnicoRepository
    {
        private readonly GestionFrancaContext context;

        public TecnicoRepository(GestionFrancaContext context): base(context)
        {
            this.context = context;
        }

        public new async Task DeleteAsync(int id)
        {
            var autor = await GetByIdAsync(id);

            if (autor == null) throw new Exception("The entity is null.");
            //if (context.Autores.Any(x => x.Id == id)) throw new Exception("Foreign Key Accounts.");

            context.Tecnicos.Remove(autor);
            await context.SaveChangesAsync();

        }
    }
}
