<script setup lang="ts">
</script>
<template>
    <header>
        <slot name="header"></slot>
    </header>
    <main>
        <slot></slot>
    </main>
    <footer>
        <slot name="footer"></slot>
    </footer>
</template>

<style scoped>
    footer{
        border-top: 3px solid #ccc;
        color: grey;
        font-size: 0.8em;
    }
</style>