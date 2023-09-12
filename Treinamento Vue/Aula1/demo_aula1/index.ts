// Import stylesheets
import './style.css';
import { FotoDto } from './fotoDto';

// Write Typescript code!
async function cliqueDoBotao() {
  const urlBase = 'https://jsonplaceholder.typicode.com';
  const divDados = document.getElementById('divDados');
  const campoId = document.getElementById('campoId') as HTMLInputElement;
  const imgFoto = document.getElementById('imgFoto') as HTMLImageElement;
  const id = campoId.value;
  const resposta = await fetch(`${urlBase}/photos/${id}`);
  try {
    if (resposta.ok) {
      const dados = (await resposta.json()) as FotoDto;
      divDados.innerHTML = `<h2>${dados.title}</h2>`;
      imgFoto.src = dados.thumbnailUrl;
    } else {
      divDados.innerHTML = `<p>Falha na busca: ${resposta.status}</p>`;
    }
  } catch (error) {
    divDados.innerHTML = `<p>Falha na busca: ${(error as Error).message}</p>`;
  }
}

const botaoBuscar = document.getElementById('botaoBuscar');
botaoBuscar.onclick = cliqueDoBotao;
