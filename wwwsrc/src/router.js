import Vue from "vue";
import Router from "vue-router";
// @ts-ignore
import Home from "./views/Home.vue";
// @ts-ignore

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "home",
      component: Home
    }
  ]
});
