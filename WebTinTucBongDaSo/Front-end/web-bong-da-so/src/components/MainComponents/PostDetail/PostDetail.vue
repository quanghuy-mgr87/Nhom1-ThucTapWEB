<template>
  <div class="container">
    <div class="post-detail d-flex">
      <div class="post-detail__left-col">
        <div class="post-detail__left-col__tool-bar">
          <span class="post-detail__left-col__tool-bar__time-now">{{ currentTime }}</span>
        </div>
        <div class="post-detail__left-col__title">
          <h3>{{ postDetail.tieuDe }}</h3>
        </div>
        <div class="post-detail__left-content" v-html="postDetail.noiDung"></div>
      </div>
      <div class="post-detail__right-col">
        <hot-news-list></hot-news-list>
      </div>
    </div>
  </div>
</template>
<script>
import moment from "moment";
import axios from "axios";
import HotNewsList from "../Post/Post-HotNews/HotNewsList.vue";
export default {
  components: { HotNewsList },
  created() {
    this.GetCurrentTime();
    this.GetPostById();
    // console.log(this.$route.fullPath);
  },

  data() {
    return {
      currentTime: "",
      postDetail: {},
    };
  },

  methods: {
    //#region Axios
    GetPostById() {
      axios.get("https://localhost:44379/api/baiViet/" + this.$route.fullPath.substr(1)).then((res) => {
        this.postDetail = res.data;
        console.log(res.data);
      });
    },
    //#endregion

    //#region Methods
    GetCurrentTime() {
      let timeStr = moment(new Date()).locale("vi").format("dddd, D/MM/yyyy, hh:mm");
      timeStr = timeStr.substr(0, 1).toUpperCase() + timeStr.substr(1).toLowerCase();
      this.currentTime = timeStr;
    },
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../public/style.scss";
.post-detail {
  padding: 20px 0px;
  &__left-col {
    max-width: 70%;
    width: 100%;
    padding-right: 35px;
    margin-right: 30px;
    border-right: solid 1px $light-gray-color;
    &__tool-bar {
      margin-bottom: 10px;
      &__time-now {
        font-size: 14px;
        color: #757575;
      }
    }
    &__title {
      font-family: "Merriweather", serif;
      font-weight: 700;
      font-size: 32px;
      margin-bottom: 20px;
    }
  }

  &__left-content {
    text-align: justify;
    font-size: 18px;
    font-weight: 200;
    color: black;

    i {
      font-style: italic;
    }

    strong,
    b {
      font-weight: bold;
    }
  }

  &__right-col {
    max-width: 30%;
    width: 100%;
  }
}
</style>
