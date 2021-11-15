<template>
  <div app class="container">
    <div class="header d-flex justify-space-between">
      <div class="header__left d-flex">
        <div class="header__left--logo">
          <a href="https://vnexpress.net/"><img src="../../../assets/logo.svg" alt="" /></a>
        </div>
        <span class="header__left--time-now">{{ currentTime }}</span>
      </div>
      <div class="header__right d-flex">
        <div class="header__right__button-box">
          <v-btn outlined class="btn btn--latestNews mr-4"><v-icon size="16" class="pr-1">mdi-clock-outline</v-icon> Mới nhất</v-btn>
          <v-btn outlined class="btn btn--latestNews"><v-img class="btn__image" src="../../../assets/vnex-logo.png" alt=""></v-img> International</v-btn>
        </div>
        <div class="header__right__search-login d-flex">
          <div class="header__right__search-login__searchbox">
            <input class="header__right__search-login__searchbox__input" type="text" placeholder="Tìm kiếm" />
            <button><v-icon>mdi-magnify</v-icon></button>
          </div>
          <v-btn text dense class="btn btn-login ml-2 pr-0"><v-icon>mdi-account</v-icon> Đăng nhập</v-btn>
        </div>
      </div>
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
      let timeStr = moment(new Date()).locale("vi").format("dddd, D/MM/yyyy");
      timeStr = timeStr.substr(0, 1).toUpperCase() + timeStr.substr(1).toLowerCase();
      this.currentTime = timeStr;
    },
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../public/style.scss";
.header {
  padding-top: 11px;
  padding-bottom: 11px;
  color: $gray-color;
  font-size: 14px;
  max-height: 51px;
  &__left {
    &--logo {
      padding: 0px 20px 0px 0px;
      max-width: fit-content;
      height: 28px;
      border-right: solid 1px $light-gray-color;
    }
    &--time-now {
      padding-left: 15px;
      transform: translateY(4px);
    }
  }
  &__right {
    &__button-box {
      border-right: 1px solid $light-gray-color;
      padding-right: 17px;
    }
    &__search-login {
      &__searchbox {
        height: 100%;
        border: 1px solid $gray-color;
        margin-left: 15px;
        max-width: 160px;
        border-radius: 2rem;
        &__input {
          height: 100%;
          padding: 0 5px 0 14px;
          max-width: 80%;
        }
      }
      .btn-login {
        font-size: 15px;
      }
      .btn-login::before {
        background-color: transparent !important;
      }
    }
    .btn__image {
      width: 14px;
      margin-right: 5px;
    }
  }
}
</style>
