<script setup lang="ts">
import {ref} from 'vue';

const contagem = ref(0);

function incrementarContagem(){
  contagem.value++;
}

function tratadorDoClique(){
  incrementarContagem();
}
</script>

<template>
    <div>
      <button type="button" @click="tratadorDoClique">Clique Aqui</button>
      <span>foi clicado {{ contagem }} vezes</span>
    </div>
</template>