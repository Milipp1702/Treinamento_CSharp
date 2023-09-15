<script setup lang="ts">
import { ref, computed } from 'vue'

const autor = ref({id:1,nome:'Milena P',livros:[]});
const mensagem = computed(() => {return autor.value.livros.length > 0 ? 'Possui livros' : 'Sem livros'});
</script>

<template>
<br>
<br>
  <h1>{{ autor.nome }}</h1>
  <h2>Livros:</h2>
  <span>{{ mensagem }}</span>
</template>