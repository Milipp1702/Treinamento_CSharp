Console.WriteLine("Iniciando conexão com o BD");
using(var context = new TarefaContext())
{
    /*Console.WriteLine("Inserindo Dados:");
    context.Tarefas.Add(new Tarefa{
        Nome = "Estudar .NET",
        Descricao = "Ler o material do Learn Microsoft",
        Completa = false
    });
    context.Tarefas.Add(new Tarefa{
        Nome = "Lavar a Louça",
        Completa = true
    });
    context.SaveChanges();*/

    Console.WriteLine("Consultando dados:");
    var todasTarefas = context.Tarefas.ToList();
    todasTarefas.ForEach(t => 
        Console.WriteLine($"Id = {t.Id}\nNome = {t.Nome}\nDescrição = {t.Descricao}\nCompleta = {t.Completa}"));
}
