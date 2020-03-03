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
    stories: [],
    activeStory: {},
    storySentences: []
  },
  mutations: {
    setResource(state, payload) {
      state[payload.resource] = payload.data;
    }
  },
  actions: {}
});
