<script setup lang="ts">
import { ref } from 'vue'

const checkedTime = ref([]);
</script>

<template>
<br>
  <input type="checkbox" value="Inter" id="inter" v-model="checkedTime"/>
  <label for="inter">Inter</label>
  <input type="checkbox" value="Grêmio" id="gremio" v-model="checkedTime"/>
  <label for="gremio">Grêmio</label>
  <div>{{ checkedTime }}</div>
</template>