<template>
  <div class="header">
    <div class="wrapper">
      <header-app-bar></header-app-bar>
    </div>
    <div class="header-menu">
      <div class="wrapper" style="height: 100%">
        <header-menu></header-menu>
      </div>
    </div>
  </div>
</template>
<script>
import HeaderAppBar from "../../components/HeaderComponents/HeaderAppBar/HeaderAppBar.vue";
import HeaderMenu from "../../components/HeaderComponents/HeaderMenu/HeaderMenu.vue";
export default {
  components: { HeaderAppBar, HeaderMenu },
};
</script>
<style lang="scss" scoped>
$green-color-1: #498523;
$green-color-2: #5fae2e;
$red-brown-color: #b52759;
$gray-color: #757575;
$light-gray-color: #e5e5e5;
.header-menu {
  border-top: 1px solid $light-gray-color;
  border-bottom: 1px solid $light-gray-color;
  height: 50px;
}
</style>
