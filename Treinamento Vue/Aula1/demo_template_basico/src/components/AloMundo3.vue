<script setup lang="ts">
    function tratadorDoClick(evento: MouseEvent){
        alert('Alô, Mundo!');
    }
    function tratadorDoClick2(evento: MouseEvent){
        const botaoClicado = evento.currentTarget as HTMLButtonElement;
        alert(`Alô, ${botaoClicado.name}!`);
    }
</script>

<template>
    <button type="button" @click="tratadorDoClick">Diga Alô</button>
    <button name="botaoOi" type="button" @click="tratadorDoClick2">Diga Oi</button>
</template>