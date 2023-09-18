<script setup lang="ts">
const emit = defineEmits<{evento:[valor:string]}>();
</script>

<template>
    <h2>MeuComponente</h2>
    <button type="button" @click="emit('evento', 'MeuComponete diz alo!')">Dispare Eventos</button>
</template>