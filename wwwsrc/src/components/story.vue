<template>
  <div class="story bg-dark">
    <div v-for="storySentnce in storySentnces" :key="storySentnce.Id">
      <p>{{ storySentence.Text }}</p>
    </div>
  </div>
</template>

<script>
export default {
  mounted() {
    this.$store.dispatch("getStoryById");
  },
  name: "story",
  computed: {
    storySentnces() {
      return this.$store.state.storySentnces;
    }
  }
};
</script>

<style>
.story {
  height: 50vh;
}
</style>
