function min(x: number, y: number): number {
    if (x < y) {
      return x;
    } else {
      return y;
    }
}
const menorNumber = min(1, 10);
console.log(`O numero menor é: ${menorNumber}`);

function toMaiusculaPrimeira(palavra : string = ''): string {
    return palavra.charAt(0).toUpperCase() + palavra.substring(1,palavra.length);
}

console.log(toMaiusculaPrimeira('milena'));
console.log(toMaiusculaPrimeira());