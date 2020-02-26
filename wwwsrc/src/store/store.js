import Vue from "vue";
// @ts-ignore
import Vuex from "vuex";
// @ts-ignore
import router from "../router";
import { api } from "./api";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    sentences: [],
    stories: [],
    activeStory: {}
  },
  mutations: {
    setResource(state, payload) {
      state[payload.resource] = payload.data;
    }
  },
  actions: {
    setBearer({}, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    }
  }
});
