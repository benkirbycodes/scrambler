import { api } from "./api";

export default {
  actions: {
    async getStories({ commit, dispatch }) {
      try {
        let res = await api.get("stories");
        commit("setResource", { resource: "stories", data: res.data });
      } catch (error) {
        console.error(error);
      }
    },
    async getStoryById({ commit, dispatch }, id) {
      try {
        let res = await api.get("stories/" + id);
        commit("setResource", { resource: "activeStory", data: res.data });
      } catch (error) {
        console.error(error);
      }
    },
    async createStory({ commit, dispatch }, story) {
      try {
        let res = await api.post("stories");
        dispatch("getStories");
      } catch (error) {
        console.error(error);
      }
    },
    async editStory({ commit, dispatch }, { storyId, update }) {
      try {
        let res = await api.put("stories/" + storyId, update);
        dispatch("getStories");
      } catch (error) {
        console.error(error);
      }
    },
    async deleteStory({ commit, dispatch }, id) {
      try {
        let res = await api.delete("stories/" + id);
        dispatch("getStories");
      } catch (error) {
        console.error(error);
      }
    }
  }
};
