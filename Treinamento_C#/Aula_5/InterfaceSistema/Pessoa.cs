public class Pessoa:IEquatable<Pessoa>{
    private string nome;
    private int idade;

    public Pessoa(string _nome, int _idade){
        this.nome = _nome;
        this.idade = _idade;
    }

    public string Nome{get{return nome;}}
    public int Idade{get{return idade;}}

    public override string? ToString(){
        return $"Nome: {this.nome};idade: {this.idade}\n";
    }

    public bool Equals(Pessoa? other){
        if(other is null)
        {
            return false;
        }
        else{
            if(this.nome.Equals(other.nome) && this.idade.Equals(other.idade)){
                return true;
            }
            else
                return false;
        }
    }
}