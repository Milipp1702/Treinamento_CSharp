using Microsoft.EntityFrameworkCore;

public class TarefaContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("TarefasBD");

    }

    public DbSet<Tarefa> Tarefas {get;set;} = null!;
}