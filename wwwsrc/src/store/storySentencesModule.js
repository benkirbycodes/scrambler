import { api } from "./api";

export default {
  actions: {
    async getSentencesByStoryId({ commit, dispatch }, id) {
      try {
        let res = await api.get("storysentences/" + id + "/sentences");
        commit("setResource", { resource: "storySentences", data: res.data });
        console.log(res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async createStorySentence({ commit, dispatch }, storySentence) {
      try {
        let res = await api.post("storysentences", storySentence);
        dispatch("getSentencesByStoryId", storySentence.storyId);
      } catch (error) {
        console.error(error);
      }
    },
    async editStorySentence({ commit, dispatch }, { update, id }) {
      try {
        let res = await api.put("storysentences/" + id, update);
        dispatch("getSentencesByStoryId", update.storyId);
      } catch (error) {
        console.error(error);
      }
    },
    async deleteStorySentence({ commit, dispatch }, { storyId, sentenceId }) {
      try {
        let res = await api.delete(
          "storysentences/" + storyId + "/sentences/" + sentenceId
        );
        dispatch("getSentencesByStoryId", storyId);
      } catch (error) {
        console.error(error);
      }
    }
  }
};
