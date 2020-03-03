<template>
  <drop class="story bg-light drop" @drop="handleDrop">
    <p v-for="storySentence in storySentences" :key="storySentence.id">
      <span>{{ storySentence.text }}</span>
    </p>
  </drop>
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
      this.$store.state.storySentences.push(data);
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
