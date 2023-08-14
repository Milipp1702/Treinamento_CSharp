public class Pilha : IPilha, IUmaCoisa, IOutraCoisa
{
    private List<object> minhaListaDeObj;
    private int nElementos;

    void IUmaCoisa.metodo(){
        Console.WriteLine("Um método da interface UmaCoisa!");
    }

    void IOutraCoisa.metodo(){
        Console.WriteLine("Um método da interface OutraCoisa!");
    }

    public Pilha()
    {
        minhaListaDeObj = new List<object>();
        nElementos = 0;
    }

    public void Empilha(object o)
    {
        minhaListaDeObj.Add(o);
        nElementos++;
    }
    public object? Desempilha()
    {
        if(nElementos > 0)
        {
            object aux = minhaListaDeObj[nElementos-1];
            minhaListaDeObj.RemoveAt(nElementos-1);
            nElementos--;
            return aux;
        }
        else
            return null;
    }
    public object? Topo
    {
        get{
            if(nElementos > 0){
                return minhaListaDeObj[nElementos-1];
            }
            else{
                return null;
            }
        }
    }

    public int QtdElementos
    {
        get
        {
            return minhaListaDeObj.Count;
        }
    }
}