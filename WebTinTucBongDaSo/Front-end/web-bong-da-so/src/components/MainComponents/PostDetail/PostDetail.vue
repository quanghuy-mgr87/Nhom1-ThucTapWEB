<template>
  <div class="container">
    <div class="post-detail d-flex">
      <div class="post-detail__left-col">
        <div class="post-detail__left-col__tool-bar">
          <span class="post-detail__left-col__tool-bar__time-now">{{ currentTime }}</span>
        </div>
        <div class="post-detail__left-col__title">
          <h1>Ferdinand: 'Solskjaer nên ngẩng cao đầu rời Man Utd'</h1>
        </div>
        <div class="post-detail__left-content"></div>
      </div>
      <div class="post-detail__right-col"></div>
    </div>
  </div>
</template>
<script>
import moment from "moment";
export default {
  data() {
    return {
      currentTime: "",
    };
  },
  created() {
    this.GetCurrentTime();
  },

  methods: {
    GetCurrentTime() {
      let timeStr = moment(new Date()).locale("vi").format("dddd, D/MM/yyyy, hh:mm");
      timeStr = timeStr.substr(0, 1).toUpperCase() + timeStr.substr(1).toLowerCase();
      this.currentTime = timeStr;
    },
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
    &__tool-bar {
      text-align: right;
      padding-right: 30px;
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
    }
  }

  &__right-col {
    max-width: 30%;
    width: 100%;
  }
}
</style>
