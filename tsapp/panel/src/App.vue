import Vue from 'vue';
<template>
<v-stage ref="stage" :config="konva">
    <v-layer>
      <v-line :config="noteline(1)"></v-line>
      <v-line :config="noteline(2)"></v-line>
      <v-line :config="noteline(3)"></v-line>
      <v-line :config="noteline(4)"></v-line>
      <v-line :config="noteline(5)"></v-line>

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
  points: [0, 50, 200, 50],
  stroke: 'red',
  tension: 1
      }

    }

  },

  methods:
  {
    noteline(num)
    {
      const hight = 30;
      return {
        x: 0,
        y:0,
        points: [0, hight * num, 200, hight * num],
  stroke: 'red',
  tension: 1

      };
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
