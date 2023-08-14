public class Data
{
    private int dia, mes, ano;
    private static string informacao = "Um objeto que armazena um dado";

    public Data(Data d) : this(d.dia, d.mes, d.ano)
    {
    }

    public Data(): this(1,1,1){}

    public Data(int _dia, int _mes): this(_dia,_mes,2023){}

    public Data(int _dia, int _mes, int _ano)
    {
        dia = _dia;
        mes = _mes;
        ano =_ano;
    }

    public Data(int _dia, int _mes, string _ano)
    {
        ano = Int32.Parse(_ano);
        mes = _mes;
        dia =_dia;
    }
    
    public static void imprimeAlgo(){
        Console.WriteLine(informacao);
    }

    public void print(){
        Console.WriteLine("dia: "+dia+"\nmês: "+mes+"\nano: "+ano);
    }

    public static Data operator+(Data dataA, Data dataB)
    {
        //forma ternária
        int d = (dataA.dia>dataB.dia) ? d = dataA.dia : d = dataB.dia;
        
        int m;
        if(dataA.mes>dataB.mes){
            m = dataA.mes;
        }
        else{
            m = dataB.mes;
        }
        int a;
        if(dataA.ano>dataB.ano){
            a = dataA.ano;
        }
        else{
            a = dataB.ano;
        }
        return new(d,m,a);
    }

    public static Data operator+(Data dt, int valor)
    {
        return new Data(dt.dia+valor,dt.mes,dt.ano);
    }
}