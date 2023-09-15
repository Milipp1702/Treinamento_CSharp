<script setup lang="ts">
  import AloMundo from './components/AloMundo.vue';
  import AloMundo2 from './components/AloMundo2.vue';
  import AloMundo3 from './components/AloMundo3.vue';
  import AloMundo4 from './components/AloMundo4.vue';
  import {Pessoa} from './Pessoa';
  import {ref} from 'vue';

  const vips= ref ([
  new Pessoa (1,'Milena', 21),
  new Pessoa (2,'Carla', 54),
  new Pessoa (3,'Ian', 23),

]);
</script>

<template>
  <AloMundo nome="Milena" />
  <AloMundo />
  <AloMundo2 nome="Milena" />
  <AloMundo3 nome="Ian" :repeticao="5" />
  <AloMundo3 nome="Carla" />
  <AloMundo4 :pessoas="vips"/>
</template>

<style scoped>
</style>
