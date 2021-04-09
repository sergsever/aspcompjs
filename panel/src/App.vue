import Vue from 'vue';
<template>
<v-stage ref="stage" :config="konva">
    <v-layer>
      <v-line :config="noteline(1)"></v-line>
      <v-line :config="noteline(2)"></v-line>
      <v-line :config="noteline(3)"></v-line>
      <v-line :config="noteline(4)"></v-line>
      <v-line :config="noteline(5)"></v-line>
      <v-circle :config="note(shownote)"></v-circle>
    </v-layer>
  </v-stage>
</template>

<script>
	const Note = {
		Do: 1,
		Re: 2,
		Mi: 3,
		Fa: 4,
		Sol: 5,
		La: 6,
		Si: 7
	};

	const hight = 30;
export default {
		name: 'App',
	data: function()
	{
		return {
			shownote: Note.Si,
		name: 'Sample',
		konva: {
				width: 200,
				height: 200
			},
			circle: {
			x: 100,
			y: 100,
			radius: 70,
			fill: "black"
			},
			line: {
			x: 100,
			y: 50,
			points: [0, 50, 200, 50],
			stroke: 'red',
			tension: 1
			}

	};

		},

    methods:
  {
    noteline(num)
    {
      return {
        x: 0,
        y:0,
        points: [0, hight * num, 200, hight * num],
  stroke: 'red',
  tension: 1

      };
		},
		note(note) {

			var ypos = (hight * 5) - (hight * note);
			switch (note) {
				case Note.Do:
					ypos += hight * 2;
					break;
				case Note.Re:
					ypos += hight * 2.5;
					break;
				case Note.Mi:
					ypos += hight * 3;
					break;
				case Note.Fa:
					ypos += hight * 3.5;
					break;
				case Note.Sol:
					ypos += hight * 4;
					break;
				case Note.La:
					ypos += hight * 4.5;
					break;
				case Note.Si:
					ypos += hight * 5;
					break;
				default:
					ypos += hight * 4;

			}
		var xpos = 60;
		return {
			x: xpos,
			y: ypos,
			radius: 10,
			fill: "black"

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
