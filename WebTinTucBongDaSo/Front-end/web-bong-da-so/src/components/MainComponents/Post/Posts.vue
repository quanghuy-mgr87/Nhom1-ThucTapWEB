<template>
  <div class="wrapper">
    <post-header></post-header>
    <post-menu></post-menu>
    <!-- <post-sub-menu></post-sub-menu> -->
    <router-view></router-view>
  </div>
</template>
<script>
import PostHeader from "./Post-Header/PostHeader.vue";
import PostMenu from "./Post-Menu/PostMenu.vue";
// import PostSubMenu from "./Post-Menu/PostSubMenu.vue";
export default {
  components: {
    PostHeader,
    PostMenu,
    // PostSubMenu,
  },
};
</script>
