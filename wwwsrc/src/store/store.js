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
    concatSentence: "",
    stories: []
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
      }
      commit("setResource", { resource: "concatSentence", data: concat });
    },
    //Fisher-Yates shuffle
    randomizeSentences({ commit, dispatch }) {
      let array = this.state.storySentences;
      for (let i = array.length - 1; i > 0; i--) {
        let j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
      }
      commit("setResource", { resource: "storySentences", data: array });
      dispatch("concatStorySentences");
    }
  }
});
