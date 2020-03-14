<template>
  <div class="home bg-dark container-fluid">
    <div class="row">
      <div class="col-6 p-5">
        <button v-if="activeStory.title" @click="scramble" class="btn btn-outline-light">Scramble!</button>
        <button
          data-toggle="modal"
          data-target="#one"
          v-else
          class="btn btn-outline-light text-center"
        >Start a New Story</button>
        <button
          data-toggle="modal"
          data-target="#two"
          class="btn btn-outline-light text-center"
        >Load A Story</button>
      </div>

      <div class="col-6 p-5">
        <h1 class="text-white">ScRaMbLeR</h1>
      </div>
      <div class="col-12">
        <story v-if="activeStory.title" />
      </div>
      <div class="col-12">
        <sentence v-if="activeStory.title" />
      </div>
    </div>
    <modal id="one">
      <div slot="title">What Is The Title Of Your New Story?</div>
      <form @submit.prevent="createStory" slot="body">
        <input v-model="newStory.title" type="text" />
        <button class="btn btn-outline-light">Make it!</button>
      </form>
    </modal>
    <modal id="two">
      <div slot="title">Choose A Previous Story</div>
      <div @click="setActiveStory(story.id)" slot="body" v-for="story in stories" :key="story.id">
        <a>{{story.title}}</a>
      </div>
    </modal>
  </div>
</template>

<script>
import story from "@/components/story.vue";
import sentence from "@/components/sentence.vue";
import modal from "@/components/modal.vue";

export default {
  mounted() {
    this.$store.dispatch("getStories");
  },
  data() {
    return {
      newStory: {
        title: ""
      }
    };
  },
  name: "home",
  computed: {
    activeStory() {
      return this.$store.state.activeStory;
    },
    stories() {
      return this.$store.state.stories;
    }
  },
  methods: {
    scramble() {
      this.$store.dispatch("randomizeSentences");
    },
    createStory() {
      let story = { ...this.newStory };
      this.$store.dispatch("createStory", story);
      this.newStory = {
        title: ""
      };
      $("#one").modal("hide");
    },
    setActiveStory(id) {
      this.$store.dispatch("getStoryById", id);
      this.$store.dispatch("getSentencesByStoryId", id);
    }
  },
  components: {
    story,
    sentence,
    modal
  }
};
</script>

<style>
.home {
  height: 100%;
  width: 100%;
}
</style>
