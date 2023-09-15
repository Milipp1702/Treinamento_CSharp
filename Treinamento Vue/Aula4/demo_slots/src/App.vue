<script setup lang="ts">
import BotaoColorido from './components/BotaoColorido.vue';
import LayoutBasico from './components/LayoutBasico.vue';
</script>

<template>
  <LayoutBasico>
    <template #header>

    </template>
    <template #default>
      <button type="button">Botão</button>
      <BotaoColorido>Clique Aqui💕</BotaoColorido>
      <BotaoColorido>
        <span style="color:black">Curtir</span> ❤️
      </BotaoColorido>
    </template>
    <template #footer>
      <span>Desenvolvido por eu mesmo</span>
    </template> 
  </LayoutBasico>
</template>

<style scoped>
</style>
