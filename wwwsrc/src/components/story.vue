<template>
  <drop class="story bg-light drop" @drop="handleDrop">
    <p>{{ concatSentence }}</p>
  </drop>
</template>

<script>
import { Drag, Drop } from "vue-drag-drop";

export default {
  mounted() {},
  name: "story",
  computed: {
    concatSentence() {
      return this.$store.state.concatSentence;
      console.log(this.$store.state.concatSentence);
    }
  },
  methods: {
    handleDrop(data) {
      this.$store.state.storySentences.push(data);
      this.$store.dispatch("concatStorySentences");
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
