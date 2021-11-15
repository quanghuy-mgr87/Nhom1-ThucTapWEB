<template>
  <div class="wrapper">
    <footer-header></footer-header>
    <div>
      <footer-menu></footer-menu>
      <footer-copyright></footer-copyright>
      <footer-info></footer-info>
    </div>
  </div>
</template>
<script>
import FooterHeader from "../../components/FooterComponents/FooterHeader.vue";
import FooterMenu from "../../components/FooterComponents/FooterMenu.vue";
import FooterInfo from "../../components/FooterComponents/FooterInfo.vue";
import FooterCopyright from "../../components/FooterComponents/FooterCopyright.vue";
export default {
  components: {
    FooterHeader,
    FooterMenu,
    FooterInfo,
    FooterCopyright,
  },
};
</script>
<style lang="scss" scoped></style>
