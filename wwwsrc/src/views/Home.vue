<template>
  <div class="home container-fluid">
    <div class="row">
      <div class="col-6 p-5">
        <button
          v-if="activeStory.title"
          @click="scramble"
          class="btn btn-outline-dark"
        >
          Scramble!
        </button>
        <button
          data-toggle="modal"
          data-target="#one"
          v-else
          class="btn btn-outline-dark text-center"
        >
          Start a New Story
        </button>
      </div>

      <div class="col-6 p-5"><h1>ScRaMbLeR</h1></div>
      <div class="col-12">
        <story v-if="activeStory.title" />
      </div>
      <div class="col-12">
        <sentence v-if="activeStory.title" />
      </div>
    </div>
    <modal id="one" />
  </div>
</template>

<script>
import story from "@/components/story.vue";
import sentence from "@/components/sentence.vue";
import modal from "@/components/modal.vue";

export default {
  name: "home",
  computed: {
    activeStory() {
      return this.$store.state.activeStory;
    }
  },
  methods: {
    scramble() {
      this.$store.dispatch("randomizeSentences");
    }
  },
  components: {
    story,
    sentence,
    modal
  }
};
</script>

<style></style>
