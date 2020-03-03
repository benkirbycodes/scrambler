<template>
  <drop class="story bg-light drop" @drop="handleDrop"></drop>
</template>

<script>
import { Drag, Drop } from "vue-drag-drop";

export default {
  mounted() {},
  name: "story",
  computed: {
    storySentences() {
      return this.$store.state.storySentences;
    }
  },
  methods: {
    handleDrop(data) {
      console.log(data);
    }
  },
  components: {
    Drag,
    Drop
  }
};
</script>

<style>
.story {
  height: 50vh;
  border: 1px solid black;
}
</style>
