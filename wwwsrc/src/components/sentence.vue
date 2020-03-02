<template>
  <div class="sentence bg-info">
    <div v-for="sentence in sentences" :key="sentence.id">
      {{ sentence.text }}
    </div>
  </div>
</template>

<script>
export default {
  mounted() {
    this.$store.dispatch("getSentences");
  },
  name: "sentence",
  computed: {
    sentences() {
      return this.$store.state.sentences;
    }
  }
};
</script>

<style>
.sentence {
  height: 50vh;
}
</style>
