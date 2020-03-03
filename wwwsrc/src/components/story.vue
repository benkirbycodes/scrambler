<template>
  <div class="story bg-light">
    <div v-for="storySentence in storySentences" :key="storySentence.Id">
      <p>{{ storySentence.Text }}</p>
    </div>
  </div>
</template>

<script>
export default {
  mounted() {
    this.$store.dispatch("getStoryById", 1);
    this.$store.dispatch("getSentencesByStoryId", 1);
  },
  name: "story",
  computed: {
    storySentences() {
      return this.$store.state.storySentences;
    }
  }
};
</script>

<style>
.story {
  height: 50vh;
}
</style>
