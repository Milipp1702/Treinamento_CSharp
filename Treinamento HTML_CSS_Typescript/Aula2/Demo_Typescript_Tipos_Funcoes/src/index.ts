let saudacao : string = "Olá, mundo!";
console.log(saudacao);

function saudar(nome : string){
    console.log('Alô, '+nome+'!');
}

function criarSaudacao(nome : string){
    return `Alô, ${nome}`;
}
saudar('Milena');
console.log(criarSaudacao('Milena'));

function potencia(base: number, expoente: number = 0){
    let resultado = 1;
    for(let cont = 0; cont < expoente; cont++){
        resultado = resultado * base;
    }
    return resultado;
}

console.log(potencia(2,3));
console.log(potencia(2));

const saudarAnonima = function(nome : string){
    return `Alô , ${nome}!`;
}

console.log(saudarAnonima);
console.log(saudarAnonima('Milena'));

const saudarArrow = (nome : string) => `Alô, ${nome}!`;

console.log(saudarArrow('Milena'));

//execução imediata de funções
(function (x : number, y : number){
    console.log(x+y);
})(1,2);

//closure
function multiplicar(fator : number) : (n: number) => number{
    return numero => numero * fator;
}

const dobrar = multiplicar(2);
console.log(dobrar(5));