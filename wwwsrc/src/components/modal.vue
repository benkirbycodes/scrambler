<template>
  <div class="modal" tabindex="-1" :id="id" role="dialog">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h3 class="modal-title">What is the title of your new Story?</h3>
          <button
            type="button"
            class="close btn btn-outline-dark"
            data-dismiss="modal"
          >
            <span>&times;</span>
          </button>
        </div>
        <div class="modal-body">
          <form @submit.prevent="createStory">
            <input v-model="newStory.title" type="text" />
            <button class="btn btn-outline-dark">
              Make it!
            </button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "modal",
  data() {
    return {
      newStory: {
        title: ""
      }
    };
  },
  props: ["id"],
  methods: {
    createStory() {
      let story = { ...this.newStory };
      this.$store.dispatch("createStory", story);
      this.newStory = {
        title: ""
      };
      $("#one").modal("hide");
    }
  }
};
</script>

<style></style>
