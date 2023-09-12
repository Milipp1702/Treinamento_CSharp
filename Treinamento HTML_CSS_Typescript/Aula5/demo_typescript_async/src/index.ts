import fetch from 'node-fetch';

async function main(){
    const urlbase = 'https://jsonplaceholder.typicode.com';
    try {
        const resposta = await fetch(`${urlbase}/posts`);
        if(resposta.ok){
            const dados = await resposta.json();
            console.log(dados);
        }else{
            console.log(resposta.status);
            console.log(resposta.statusText);
        }
    } catch (error) {
        console.log('Falha na requisição do HTTP');
        console.log(error);
    }
}

main();