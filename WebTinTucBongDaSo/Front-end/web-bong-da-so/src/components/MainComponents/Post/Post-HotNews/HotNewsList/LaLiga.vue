<template>
  <div class="posts">
    <div class="posts title-hotnews">La Liga</div>
    <div class="new-post">
      <div class="new-post__image hot-news">
        <img :src="laLigaPosts[0].image" alt="" />
      </div>
      <div class="new-post__title hot-news">
        <a :href="laLigaPosts[0].link">{{ laLigaPosts[0].title }}</a>
      </div>
    </div>
    <div class="list-post">
      <a :href="item.link" v-for="(item, index) in laLigaNew" :key="index"><i class="fa fa-newspaper mr-2" aria-hidden="true"></i>{{ item.title }}</a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.laLigaNew = this.laLigaPosts.splice(1, this.laLigaPosts.length - 1);
  },
  data() {
    return {
      laLigaNew: [],
      laLigaPosts: [
        {
          title: "Barca rơi chiến thắng dù dẫn ba bàn",
          image: require("@/assets/laliga1.jpg"),
          link: "https://vnexpress.net/barca-roi-chien-thang-du-dan-ba-ban-4382397.html",
        },
        { title: "Xavi phải trả nửa phí đền bù thay Barca", image: "", link: "https://vnexpress.net/xavi-phai-tra-nua-phi-den-bu-thay-barca-4382238.html" },
        { title: "Xavi trở thành HLV Barca ", image: "", link: "https://vnexpress.net/xavi-tro-thanh-hlv-barca-4382028.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../../public/style.scss";
</style>
