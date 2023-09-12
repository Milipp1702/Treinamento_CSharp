// importar módulos
import {area, circunferencia as cir} from './circulos_funcoes';
import Circ from './circulo_objeto';
import * as fs from 'node:fs';
// usando as funções
console.log(area(3.75));
console.log(cir(4));

//usando classe importada
const c1 = new Circ(10.5);
console.log(c1.area());
console.log(c1.circunferencia());

/*const json = JSON.stringify(c1);
try {
    fs.writeFileSync('dados.json', json);
} catch (error) {
    console.error('Falha de escrita no arquivo');
    console.error((error as Error).message);
}*/

//Leitura do arquivo de texto
try {
    const json = fs.readFileSync('dados.json', {encoding:'utf-8'});
    const circulo:Circ = JSON.parse(json);
    console.log(circulo.circunferencia());
} catch (error) {
    console.log('Falha na leitura do arquivo');
    console.error((error as Error).message);
}
