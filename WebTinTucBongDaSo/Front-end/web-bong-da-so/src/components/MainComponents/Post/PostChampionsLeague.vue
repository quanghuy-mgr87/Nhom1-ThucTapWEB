<template>
  <div class="container">
    <div class="post-main d-flex">
      <div class="left-col">
        <top-story></top-story>
        <list-news></list-news>
      </div>
      <div class="right-col">
        <box-tin-moi></box-tin-moi>
        <hot-news-video></hot-news-video>
        <hot-news-list></hot-news-list>
      </div>
    </div>
    <post-pagination></post-pagination>
  </div>
</template>
<script>
import TopStory from "./Post-List/TopStory.vue";
import ListNews from "./Post-List/ListNews.vue";
import BoxTinMoi from "./Post-HotNews/BoxTinMoi.vue";
import HotNewsVideo from "./Post-HotNews/HotNewsVideo.vue";
import HotNewsList from "./Post-HotNews/HotNewsList.vue";
import PostPagination from "./Post-Pagination/PostPagination.vue";
export default {
  components: {
    TopStory,
    ListNews,
    BoxTinMoi,
    HotNewsVideo,
    HotNewsList,
    PostPagination,
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../public/style.scss";
.post-main {
  padding: 30px 0px 20px 0px;
  border-bottom: 1px solid $light-gray-color;
  .left-col {
    width: 70%;
    padding-right: 30px;
    border-right: 1px solid $light-gray-color;
  }
  .right-col {
    width: 30%;
    padding-left: 30px;
  }
}
</style>
