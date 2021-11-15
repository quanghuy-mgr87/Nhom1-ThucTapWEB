<template>
  <div class="posts">
    <div class="posts title-hotnews">Champions League</div>
    <div class="new-post">
      <div class="new-post__image hot-news">
        <img :src="championsLeaguePosts[0].image" alt="" />
      </div>
      <div class="new-post__title hot-news">
        <a :href="championsLeaguePosts[0].link">{{ championsLeaguePosts[0].title }}</a>
      </div>
    </div>
    <div class="list-post">
      <a :href="item.link" v-for="(item, index) in championsLeagueNew" :key="index"><i class="fa fa-paper-plane mr-2" aria-hidden="true"></i>{{ item.title }}</a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.championsLeagueNew = this.championsLeaguePosts.splice(1, this.championsLeaguePosts.length - 1);
  },
  data() {
    return {
      championsLeagueNew: [],
      championsLeaguePosts: [
        {
          title: "Solskjaer: 'Man Utd đã quên trận thua Liverpool'",
          image: require("@/assets/championsleague1.jpg"),
          link: "https://vnexpress.net/solskjaer-man-utd-da-quen-tran-thua-liverpool-4380624.html",
        },
        { title: "Ajax và bóng đá tổng lực kiểu Erik ten Hag", image: "", link: "https://vnexpress.net/ajax-va-bong-da-tong-luc-kieu-erik-ten-hag-4381808.html" },
        { title: "Klopp: 'Liverpool không cần hơn người để áp đảo Atletico'", image: "", link: "https://vnexpress.net/klopp-liverpool-khong-can-hon-nguoi-de-ap-dao-atletico-4381479.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../../public/style.scss";
</style>
