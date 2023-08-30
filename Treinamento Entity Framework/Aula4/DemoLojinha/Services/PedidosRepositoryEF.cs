namespace DemoLojinha.Services;

using DemoLojinha.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

public class PedidosRepositoryEF : IPedidosRepository
{
    private readonly LojinhaContext _context;

    public PedidosRepositoryEF(LojinhaContext context)
    {
        _context = context;
    }

    public async Task<Pedido?> ConsultarPorIdAsync(int id)
    {
        var pedido = await _context.Pedidos
                    .Where(p => p.Id == id)
                    .Include(p => p.Cliente)
                    .Include(p=> p.Produtos)
                    .FirstOrDefaultAsync();
        return pedido;
    }

    public async Task<Pedido> AdicionarAsync(Pedido pedido)
    {
        await _context.Pedidos.AddAsync(pedido);
        await _context.SaveChangesAsync();
        return pedido;
    }
}