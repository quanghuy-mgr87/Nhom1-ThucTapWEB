<template>
  <div class="posts">
    <div class="posts title-hotnews">Serie A</div>
    <div class="new-post">
      <div class="new-post__image hot-news">
        <img :src="serieAPosts[0].image" alt="" />
      </div>
      <div class="new-post__title hot-news">
        <a :href="serieAPosts[0].link">{{ serieAPosts[0].title }}</a>
      </div>
    </div>
    <div class="list-post">
      <a :href="item.link" v-for="(item, index) in serieANew" :key="index"><i class="fa fa-newspaper mr-2" aria-hidden="true"></i>{{ item.title }}</a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.serieANew = this.serieAPosts.splice(1, this.serieAPosts.length - 1);
  },
  data() {
    return {
      serieANew: [],
      serieAPosts: [
        {
          title: "Juventus thắng ở phút bù giờ",
          image: require("@/assets/serieA1.jpg"),
          link: "https://vnexpress.net/juventus-thang-o-phut-bu-4382401.html",
        },
        { title: "Mourinho cáu gắt với phóng viên ", image: "", link: "https://vnexpress.net/mourinho-cau-gat-voi-phong-vien-4382181.html" },
        { title: "Allegri: 'Juventus lãng phí một tháng'", image: "", link: "https://vnexpress.net/allegri-juventus-lang-phi-mot-thang-4380386.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../../public/style.scss";
</style>
