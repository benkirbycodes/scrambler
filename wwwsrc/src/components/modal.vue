<template>
  <div class="modal" tabindex="-1" :id="id" role="dialog">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h3 class="modal-title">
            <slot name="title"></slot>
          </h3>
          <button type="button" class="close btn btn-outline-dark" data-dismiss="modal">
            <span>&times;</span>
          </button>
        </div>
        <div class="modal-body">
          <slot name="body"></slot>
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
