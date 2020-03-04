<template>
  <drop class="story bg-light drop" @drop="handleDrop">
    <h3 class="text-center">{{ activeStory.title }}</h3>
    <p>{{ concatSentence }}</p>
  </drop>
</template>

<script>
import { Drag, Drop } from "vue-drag-drop";

export default {
  data() {
    return {
      storyId: this.$store.state.activeStory.id
    };
  },
  mounted() {},
  name: "story",
  computed: {
    concatSentence() {
      return this.$store.state.concatSentence;
    },
    activeStory() {
      return this.$store.state.activeStory;
    }
  },
  methods: {
    handleDrop(data) {
      this.$store.state.storySentences.push(data);
      let storySentence = {
        storyId: this.storyId,
        sentenceId: data.id,
        sentenceOrder: 0
      };
      this.$store.dispatch("createStorySentence", storySentence);
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
