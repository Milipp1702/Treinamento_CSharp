class Circulo{
    x: number;
    y: number;
    raio: number;

    constructor(x: number, y: number, raio: number) {
        this.x = x;
        this.y = y;
        this.raio = raio;
    }

    get area(){
        return Math.PI * Math.pow(this.raio,2);
    }

    get comprimentoCirc(){
        return 2 * Math.PI * this.raio;
    }
}

const c = new Circulo(1,2,3);
console.log(c.area.toFixed(2));
console.log(c.comprimentoCirc.toFixed(2));
