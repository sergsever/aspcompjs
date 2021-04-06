import Vue from 'vue';
<template>
<v-stage ref="stage" :config="konva">
    <v-layer>
      <v-line :config="line"></v-line>
      <!--<v-circle :config="circle"></v-circle>-->
    </v-layer>
  </v-stage>
</template>

<script>
export default {
  name: 'App',
  data: function()
  {
    return {
      name: 'Sample',
      konva: {
        width: 200,
        height: 200
      },
      circle:{
        x: 100,
        y:100,
        radius: 70,
        fill: "black"
      },
      line:{
      x: 100,
  y: 50,
  points: [0, 0, 200, 200],
  stroke: 'red',
  tension: 1
      }

    }

  }

}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
