<template>
  <div class="home container-fluid">
    <div class="row">
      <div class="col-12 p-5">
        <button @click="scramble" class="btn btn-outline-dark">
          Scramble!
        </button>
      </div>
      <div class="col-12">
        <story />
      </div>
      <div class="col-12">
        <sentence />
      </div>
    </div>
  </div>
</template>

<script>
import story from "@/components/story.vue";
import sentence from "@/components/sentence.vue";
export default {
  name: "home",
  computed: {},
  methods: {
    scramble() {
      this.$store.dispatch("randomizeSentences");
    }
  },
  components: {
    story,
    sentence
  }
};
</script>

<style></style>
