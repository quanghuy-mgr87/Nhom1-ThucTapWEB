<template>
  <div app class="container">
    <div class="header d-flex justify-space-between">
      <div class="header__left d-flex">
        <div class="header__left--logo">
          <a href="/"><img src="../../../assets/vnex-logo.png" alt="" /></a>
        </div>
        <span class="header__left--time-now">{{ currentTime }}</span>
      </div>
      <div class="header__right d-flex">
        <div class="header__right__button-box">
          <v-btn outlined class="btn btn--latestNews mr-4"><v-icon size="16" class="pr-1">mdi-clock-outline</v-icon> Mới nhất</v-btn>
          <v-btn outlined class="btn btn--latestNews"><v-img class="btn__image" src="../../../assets/avatar.png" alt=""></v-img> International</v-btn>
        </div>
        <div class="header__right__search-login d-flex">
          <div class="header__right__search-login__searchbox">
            <input class="header__right__search-login__searchbox__input" type="text" placeholder="Tìm kiếm" />
            <button><v-icon>mdi-magnify</v-icon></button>
          </div>
          <v-btn text dense class="btn btn-login ml-2" v-if="!isLogin" @click="openModalSignIn"><v-icon>mdi-account</v-icon> Đăng nhập</v-btn>
          <div class="header__right__search-login__user-info" v-else>
            <v-icon large class="mr-3">mdi-alpha-{{ taiKhoan.substr(0, 1) }}-circle</v-icon>
            <div class="mt-1">
              <span>{{ taiKhoan }}</span>
            </div>
            <v-menu tile offset-y>
              <template v-slot:activator="{ on, attrs }">
                <v-btn x-small fab text v-bind="attrs" v-on="on"><v-icon>mdi-menu-down</v-icon></v-btn>
              </template>
              <v-list>
                <v-list-item link :to="item.link" v-for="(item, index) in menuItems" :key="index">
                  <v-list-item-title
                    >{{ item.title }} <v-icon small>{{ item.icon }}</v-icon></v-list-item-title
                  >
                </v-list-item>
                <v-divider></v-divider>
                <v-list-item link v-if="maLoaiTaiKhoan == 'ADM'" @click="OpenPageManagement">
                  <v-list-item-title>Trang quản lý</v-list-item-title>
                </v-list-item>
                <v-list-item link v-if="maLoaiTaiKhoan == 'ADM' || maLoaiTaiKhoan == 'CTV'" @click="OpenPostDialogManage">
                  <v-list-item-title>Đăng bài</v-list-item-title>
                </v-list-item>
                <v-list-item link @click="SignOut">
                  <v-list-item-title>Thoát <v-icon small>mdi-logout</v-icon></v-list-item-title>
                </v-list-item>
              </v-list>
            </v-menu>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import moment from "moment";
import axios from "axios";
import { eventBus } from "../../../main";
export default {
  data() {
    return {
      currentTime: "",
      isLogin: false,
      taiKhoan: "",
      maLoaiTaiKhoan: "",
      menuItems: [
        { title: "Tin đã lưu", icon: "", link: "" },
        { title: "Tin đã xem", icon: "", link: "" },
        { title: "Tài khoản của tôi", icon: "", link: "" },
      ],
      // adminMenuItem: { title: "Trang quản lý", icon: "", link: "" },
    };
  },

  created() {
    this.GetCurrentTime();
    eventBus.$on("LoginSuccess", this.LoginSuccess);
  },

  methods: {
    //#region Axios
    LayMaLoaiTaiKhoan() {
      axios.get("https://localhost:44379/api/nguoiDung/layMaLoaiNguoiDung?taiKhoan=" + this.taiKhoan).then((res) => {
        this.maLoaiTaiKhoan = res.data;
      });
    },
    //#endregion

    //#region Methods
    GetCurrentTime() {
      let timeStr = moment(new Date()).locale("vi").format("dddd, D/MM/yyyy");
      timeStr = timeStr.substr(0, 1).toUpperCase() + timeStr.substr(1).toLowerCase();
      this.currentTime = timeStr;
    },
    openModalSignIn() {
      eventBus.$emit("openModalSignIn");
    },
    LoginSuccess(value) {
      this.isLogin = true;
      this.taiKhoan = value;
      this.LayMaLoaiTaiKhoan();
    },

    SignOut() {
      this.isLogin = false;
    },

    OpenPostDialogManage() {
      eventBus.$emit("OpenPostDialogManage");
    },

    OpenPageManagement() {
      eventBus.$emit("OpenPageManagement");
    },
    //#endregion
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

      &__user-info {
        max-width: 150px;
        width: 150px;
        display: flex;
        justify-content: flex-end;
        align-items: center;
        span {
          font-size: 15px;
          font-weight: 600;
          display: inline-block;
          height: 100%;
          max-width: 60px;
          overflow: hidden;
          text-overflow: ellipsis;
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
