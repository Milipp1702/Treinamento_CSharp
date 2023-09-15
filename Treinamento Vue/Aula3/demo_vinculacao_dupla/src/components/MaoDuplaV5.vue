<script setup lang="ts">
import { ref } from 'vue'

const selected = ref([]);
</script>

<template>
<br>
  <select v-model="selected" multiple>
    <option disabled value="">Selecione uma opção</option>
    <option>A</option>
    <option>B</option>
    <option>C</option>
  </select>
  <span>{{ selected }}</span>
</template>

<!-- ou -->
<!--
<script setup lang="ts">
import { ref } from 'vue'

const selected = ref('');
</script>

<template>
<br>
  <select v-model="selected">
    <option disabled value="">Selecione uma opção</option>
    <option>A</option>
    <option>B</option>
    <option>C</option>
  </select>
  <span>{{ selected }}</span>
</template>
-->