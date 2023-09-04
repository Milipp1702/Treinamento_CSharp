'use strict';

const botao = document.querySelector('.btn');
botao.addEventListener(
    'click',
    () => {
        //pega a classe do body
        document.body.classList.toggle('light-theme');
        document.body.classList.toggle('dark-theme');
        const nomeClasse = document.body.className;
        botao.textContent = nomeClasse == 'light-theme' ? 'Dark' : 'Light';
    }
);