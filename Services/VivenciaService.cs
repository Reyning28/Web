using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace tare9.Data
{
    public class VivenciaService
    {
        private readonly ApplicationDbContext _context;

        public VivenciaService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obtener vivencias por usuario
        public async Task<List<Vivencia>> GetVivenciasByUser(int userId)
        {
            return await _context.Vivencias
                .Where(v => v.UsuarioId == userId)
                .ToListAsync();
        }

        // Validar clave del usuario
        public async Task<bool> ValidateUserPassword(int userId, string clave)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return false;

            return user.Clave == clave; 
        }

        // Eliminar todas las vivencias del usuario
        public async Task DeleteAllVivenciasByUser(int userId)
        {
            var vivencias = _context.Vivencias
                .Where(v => v.UsuarioId == userId);

            _context.Vivencias.RemoveRange(vivencias);
            await _context.SaveChangesAsync();
        }

        // Guardar una nueva vivencia
        public async Task SaveVivencia(Vivencia vivencia)
        {
            if (vivencia.Id == 0)
            {
                _context.Vivencias.Add(vivencia);
            }
            else
            {
                _context.Vivencias.Update(vivencia);
            }

            await _context.SaveChangesAsync();
        }
    }
}
