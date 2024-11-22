using Blazored.LocalStorage.StorageOptions;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using tare9.Data;



public class UserService
{
    private readonly ApplicationDbContext _context;
    
    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CheckIfUserExists(string usuario, string correo)
    {
        return await _context.Users.AnyAsync(u => u.Usuario == usuario || u.Correo == correo);
    }

    public async Task RegisterUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
    }

    public async Task<User?> Login(string usuario, string clave)
    {
        return await _context.Users
        .FirstOrDefaultAsync(u => u.Usuario == usuario && u.Clave == clave);
    }

    public async Task DeleteAllVivenciasByUser(int userId)
{
    // Obtén todas las vivencias del usuario
    var vivencias = await _context.Vivencias.Where(v => v.UsuarioId == userId).ToListAsync();

    if (vivencias.Any())
    {
        _context.Vivencias.RemoveRange(vivencias);
        await _context.SaveChangesAsync();
    }
}

   
}

