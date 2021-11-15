<template>
  <div class="posts">
    <div class="posts title-hotnews">Bundesliga</div>
    <div class="new-post">
      <div class="new-post__image hot-news">
        <img :src="bundesligaPosts[0].image" alt="" />
      </div>
      <div class="new-post__title hot-news">
        <a :href="bundesligaPosts[0].link">{{ bundesligaPosts[0].title }}</a>
      </div>
    </div>
    <div class="list-post">
      <a :href="item.link" v-for="(item, index) in bundesligaNew" :key="index"><i class="fa fa-paper-plane mr-2" aria-hidden="true"></i>{{ item.title }}</a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.bundesligaNew = this.bundesligaPosts.splice(1, this.bundesligaPosts.length - 1);
  },
  data() {
    return {
      bundesligaNew: [],
      bundesligaPosts: [
        {
          title: "Bayern ghi bàn nhiều nhất châu Âu",
          image: require("@/assets/bundesliga1.jpg"),
          link: "https://vnexpress.net/bayern-ghi-ban-nhieu-nhat-chau-au-4377830.html",
        },
        { title: "Haaland có thể nghỉ hết năm", image: "", link: "https://vnexpress.net/haaland-co-the-nghi-het-nam-4376881.html" },
        { title: "Dortmund gượng dậy sau thảm bại ở Champions League", image: "", link: "https://vnexpress.net/dortmund-guong-day-sau-tham-bai-o-champions-league-4376032.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../../public/style.scss";
</style>
