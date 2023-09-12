interface Colorido{
    cor: string;
}

interface Circulo{
    raio: number;
}

interface CirculoColorido extends Colorido, Circulo {}

class CirculoColorido implements CirculoColorido{
    constructor(public raio: number, public cor: string) {}
    area(){
        return Math.PI * this.raio**2;
    }
}

const obj = {
    nome: 'Caneta',
    cor: 'Azul'
}

function imprimir(coisa: Colorido){
    console.log(coisa.cor);
}

imprimir(obj);
const c = new CirculoColorido(0,'Vermelho');