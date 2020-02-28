import { api } from "./api";

export default {
  actions: {
    async getSentences({ commit, dispatch }) {
      try {
        let res = await api.get("sentences");
        commit("setResource", { resource: "sentences", data: res.data });
      } catch (error) {
        console.error(error);
      }
    },
    async getSentenceById({ commit, dispatch }, id) {
      try {
        let res = await api.get("sentences/" + id);
        //NOTE Whats the commit/dispatch here?
      } catch (error) {}
    }
  }
};
