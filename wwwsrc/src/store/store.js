import Vue from "vue";
// @ts-ignore
import Vuex from "vuex";
// @ts-ignore
import router from "../router";
import { api } from "./api";
import sentencesModule from "./sentencesModule";
import storiesModule from "./storiesModule";
import storySentencesModule from "./storySentencesModule";

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    sentencesModule,
    storiesModule,
    storySentencesModule
  },
  state: {
    sentences: [],
    activeStory: {},
    storySentences: [],
    concatSentence: ""
  },
  mutations: {
    setResource(state, payload) {
      state[payload.resource] = payload.data;
    }
  },
  actions: {
    concatStorySentences({ commit, dispatch }) {
      let concat = "";
      for (let i = 0; i < this.state.storySentences.length; i++) {
        concat += this.state.storySentences[i].text;
        console.log(this.state.storySentences[i].text);
      }
      console.log(concat);
      commit("setResource", { resource: "concatSentence", data: concat });
    }
  }
});
