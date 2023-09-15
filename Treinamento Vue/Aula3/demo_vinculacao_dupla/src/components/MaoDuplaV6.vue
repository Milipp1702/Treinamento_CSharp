<script setup lang="ts">
import { ref } from 'vue'

const ligado = ref(true);
</script>

<template>
<br>
<br>
  <button type="button" @click="ligado = !ligado">Clique</button>
  <span>{{ ligado }}</span>
  <template v-if="ligado">
    <h1>Ligado!</h1>
    <p>Alô, Mundo!</p>
  </template>
</template>

<!-- ou
<template>
<br>
<br>
  <button type="button" @click="ligado = !ligado">Clique</button>
  <span>{{ ligado }}</span>
  <h1 v-if="ligado">Ligado!</h1>
  <h1 v-else>Desligado!</h1>
</template>
-->