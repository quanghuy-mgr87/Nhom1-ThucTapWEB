import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import vuetify from "./plugins/vuetify";
import BackToTop from 'vue-backtotop';
import CKEditor from '@ckeditor/ckeditor5-vue2';

Vue.use(BackToTop);
Vue.use(CKEditor);

Vue.config.productionTip = false;
export const eventBus = new Vue();

new Vue({
  router,
  store,
  vuetify,
  render: (h) => h(App),
}).$mount("#app");
