<script setup lang="ts">
const emit = defineEmits(['evento']);
</script>

<template>
    <h2>MeuComponente</h2>
    <button type="button" @click="emit('evento', 'MeuComponete diz alô!')">Dispare Eventos</button>
</template>