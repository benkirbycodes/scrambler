<template>
  <div class="sentence rounded">
    <drag
      class="drag"
      v-for="sentence in sentences"
      :key="sentence.id"
      :transfer-data="sentence"
    >{{ sentence.text }}</drag>
  </div>
</template>

<script>
import { Drag, Drop } from "vue-drag-drop";

export default {
  mounted() {
    this.$store.dispatch("getSentences");
  },
  name: "sentence",
  computed: {
    sentences() {
      return this.$store.state.sentences;
    }
  },
  methods: {},
  components: {
    Drag,
    Drop
  }
};
</script>

<style>
.sentence {
  height: 50vh;
  border: 1px solid black;
}
</style>
