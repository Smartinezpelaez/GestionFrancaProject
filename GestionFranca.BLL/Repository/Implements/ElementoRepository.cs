using GestionFranca.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFranca.BLL.Repository.Implements
{
    public class ElementoRepository : GenericRepository<Elemento>, IElementoRepository
    {
        private readonly GestionFrancaContext context;

        public ElementoRepository(GestionFrancaContext context): base(context)
        {
            this.context = context;
        }

        public new async Task DeleteAsync(int id)
        {
            var elemento = await GetByIdAsync(id);

            if (elemento == null) throw new Exception("The entity is null.");
            //if (context.Autores.Any(x => x.Id == id)) throw new Exception("Foreign Key Accounts.");

            context.Elementos.Remove(elemento);
            await context.SaveChangesAsync();

        }
    }
}
