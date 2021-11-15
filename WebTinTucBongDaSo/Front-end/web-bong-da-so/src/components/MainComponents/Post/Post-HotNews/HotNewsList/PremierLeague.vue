<template>
  <div class="posts">
    <div class="posts title-hotnews">Ngoại hạng Anh</div>
    <div class="new-post">
      <div class="new-post__image hot-news">
        <img :src="premierLeaguePosts[0].image" alt="" />
      </div>
      <div class="new-post__title hot-news">
        <a :href="premierLeaguePosts[0].link">{{ premierLeaguePosts[0].title }}</a>
      </div>
    </div>
    <div class="list-post">
      <a :href="item.link" v-for="(item, index) in premierLeagueNew" :key="index"><i class="fa fa-paper-plane mr-2" aria-hidden="true"></i>{{ item.title }}</a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.premierLeagueNew = this.premierLeaguePosts.splice(1, this.premierLeaguePosts.length - 1);
  },
  data() {
    return {
      premierLeagueNew: [],
      premierLeaguePosts: [
        {
          title: "Neville: ‘Không ai ngờ Man Utd lún sâu đến thế’ ",
          image: require("@/assets/premierLeague1.jpg"),
          link: "https://vnexpress.net/neville-khong-ai-ngo-man-utd-lun-sau-den-the-4382550.html",
        },
        { title: "Tuchel ám chỉ đối thủ 'ăn cắp điểm’ ", image: "", link: "https://vnexpress.net/tuchel-am-chi-doi-thu-an-cap-diem-4382546.html" },
        { title: "Roy Keane ‘đầu hàng’ cầu thủ Man Utd", image: "", link: "https://vnexpress.net/roy-keane-dau-hang-cau-thu-man-utd-4382510.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../../public/style.scss";
</style>
