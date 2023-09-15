<script setup lang="ts">
import { ref } from 'vue'

const checked = ref(true)
</script>

<template>
  <input type="checkbox" v-model="checked" id="caixa"/>
  <label for="caixa">{{checked}}</label>
</template>