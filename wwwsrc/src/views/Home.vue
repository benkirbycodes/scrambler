<template>
  <div class="home container-fluid">
    <div class="row">
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
  methods: {},
  components: {
    story,
    sentence
  }
};
</script>

<style></style>
