//inicializador de objetos
const pessoa = {
    nome: 'Milena',
    idade: 21
};

console.log(pessoa.nome);
console.log(pessoa.idade);
pessoa.idade = 22;
console.log(pessoa.idade);
console.log(typeof pessoa);

//construtor de objetos
type Carro = {modelo: string, fabricante:string, ano:number};
function Carro(this: Carro, modelo: string, fabricante:string, ano:number){
    this.modelo = modelo;
    this.fabricante = fabricante;
    this.ano = ano;
}
const carro = new (Carro as any)('Fusca','VW',1970);

const outraPessoa = {
    nome: 'Carla',
    idade: 54,
    saudar: () => 'Olá!'
    //ou 
    /*
    saudar: function(){
        return 'Olá!'
    }
    */
}

console.log(outraPessoa.nome);
console.log(outraPessoa.idade);
console.log(outraPessoa.saudar());

const maisUmaPessoa = {
    nome: 'Ian',
    idade: 23,
    saudar: function(){
        return `Olá! Meu nome é ${this.nome}`;
    }
}
console.log(maisUmaPessoa.saudar());

type Pessoa = {nome:string, idade:number};
function alo(umaPessoa:Pessoa){
    console.log(`Alô, ${umaPessoa.nome}! Você tem ${umaPessoa.idade} anos!`);
}

alo(pessoa);
alo(outraPessoa);
alo(maisUmaPessoa);

const temperatura = {
    celsius: 23,
    get fahrenheit(){
        return this.celsius * 1.8 + 32;
    }
}

console.log(temperatura.celsius);
console.log(temperatura.fahrenheit);

//cria um objeto igual ao especificado
const outraTemperatura = Object.create(temperatura);
console.log(outraTemperatura);