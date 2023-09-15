<script setup lang="ts">
</script>

<template>
    <button type="button" class="botaoColorido">
        <slot>Botão</slot>
    </button>
</template>

<style scoped>
    .botaoColorido{
        color: white;
        background: linear-gradient(315deg, pink 25%, rgb(181, 38, 213));
        border: solid rgb(181, 38, 213);
        padding: 5px 10px;
        margin: 5px;
        border-radius: 8px;
        cursor: pointer;
    }
</style>