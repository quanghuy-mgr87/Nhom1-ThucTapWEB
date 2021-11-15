<template>
  <v-app>
    <header-page></header-page>
    <v-main>
      <main-page></main-page>
    </v-main>
    <footer>
      <footer-page></footer-page>
      <back-to-top bottom="20px" right="20px">
        <div class="backToTop"><i class="fa fa-arrow-up" aria-hidden="true"></i></div>
      </back-to-top>
    </footer>
  </v-app>
</template>

<script>
import BackToTop from "vue-backtotop";
import HeaderPage from "./views/Header/HeaderPage.vue";
import MainPage from "./views/Main/MainPage.vue";
import FooterPage from "./views/Footer/FooterPage.vue";
import "../public/style.scss";
import "../public/reset.css";
export default {
  name: "App",

  components: { HeaderPage, MainPage, FooterPage, BackToTop },

  data: () => ({
    //
  }),
};
</script>
