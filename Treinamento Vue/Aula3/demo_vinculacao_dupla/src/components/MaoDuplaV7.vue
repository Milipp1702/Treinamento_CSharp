<!-- mostrando na lista só itens com a cond = true-->
<script setup lang="ts">
import { ref } from 'vue'

const itens = ref([{valor:'texto',cond:true},{valor:'outro',cond:false}]);
</script>

<template>
<br>
<br>
  <ul>
    <template v-for="item in itens">
        <li v-if="item.cond">{{ item.valor }}</li>
    </template>
  </ul>
</template>

<!-- como pegar um for com array de objetos
<script setup lang="ts">
import { ref } from 'vue'

const itens = ref([{valor:1},{valor:2},{valor:3}]);
</script>

<template>
<br>
<br>
  <ul>
    <li v-for="item in itens">{{ item.valor }}</li>
  </ul>
</template>-->

<!-- ou pra pegar array de objetos com o index
    <script setup lang="ts">
    import { ref } from 'vue'

    const itens = ref([{valor:'um'},{valor:'dois'},{valor:'tres'}]);
    </script>

    <template>
    <br>
    <br>
        <ul>
            <li v-for="(item,index) in itens">{{ index }} - {{ item.valor }}</li>
        </ul>
    </template>
-->

<!-- ou só pra pegar array normal
    <script setup lang="ts">
    import { ref } from 'vue'

    const itens = ref([1,2,3]);
    </script>

    <template>
    <br>
    <br>
        <ul>
            <li v-for="item in itens">{{ item }}</li>
        </ul>
    </template>
-->