<template>
  <div>
    <div class="container">
      <div class="container__left">
        <span>Đăng nhập với tài khoản</span>
        <v-text-field dense color="#9F224E" v-model="nguoiDung.taiKhoan" label="Tài khoản" outlined></v-text-field>
        <v-text-field
          dense
          color="#9F224E"
          :type="`${showPass ? 'text' : 'password'}`"
          label="Mật khẩu"
          outlined
          :append-icon="`${showPass ? 'mdi-eye' : 'mdi-eye-off'}`"
          @click:append="showPass = !showPass"
          v-model="nguoiDung.matKhau"
        ></v-text-field>
        <v-btn height="50" dark color="#9F224E" class="container__left__button" @click="Login">Đăng nhập</v-btn>
        <a href="#">Lấy lại mật khẩu</a>
      </div>
      <div class="container__right">
        <span>Đăng nhập với</span>
        <v-btn height="50" dark color="#3B5999" outlined class="container__right__button">
          <v-icon class="mr-2">mdi-facebook</v-icon>
          Facebook
        </v-btn>
        <v-btn height="50" dark color="#4E8DF2" outlined class="container__right__button"> <v-icon class="mr-2">mdi-google</v-icon>Google</v-btn>
        <v-btn height="50" dark color="#222222" outlined class="container__right__button"> <v-icon class="mr-2">mdi-apple</v-icon>Apple</v-btn>
      </div>
    </div>
  </div>
</template>
<script>
import { eventBus } from "../../main";
import axios from "axios";
export default {
  data() {
    return {
      showPass: false,
      nguoiDung: {
        taiKhoan: "admin",
        matKhau: "admin",
      },
    };
  },
  methods: {
    //#region Axios
    Login() {
      axios
        .post("https://localhost:44379/api/nguoiDung/kiemTraDangNhap", this.nguoiDung)
        .then(() => {
          eventBus.$emit("LoginSuccess", this.nguoiDung.taiKhoan);
          localStorage.setItem("Username", this.nguoiDung.taiKhoan);
          this.ClearData();
        })
        .catch((error) => {
          if (error.response) {
            alert(error.response.data);
          }
        });
    },
    //#endregion

    //#region Methods
    ClearData() {
      this.nguoiDung.taiKhoan = "";
      this.nguoiDung.matKhau = "";
    },
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";
.container {
  display: flex;
  padding: 0;
  &__left {
    max-width: 55%;
    width: 100%;
    text-align: center;
    position: relative;
    padding: 10px 30px;
    &__button {
      width: 100%;
      letter-spacing: normal;
      text-transform: none;
      font-weight: 700;
    }
    span {
      display: inline-block;
      padding-bottom: 30px;
      padding-top: 20px;
    }
    a {
      display: inline-block;
      text-decoration: none;
      color: $primary-text-color;
      margin-top: 10px;
    }

    a:hover {
      color: $red-brown-color;
    }
  }

  &__left::after {
    content: "";
    width: 1px;
    height: 100%;
    background-color: $light-gray-color;
    position: absolute;
    top: 30px;
    right: 0;
  }

  &__right {
    max-width: 45%;
    width: 100%;
    text-align: center;
    padding: 10px 50px;
    span {
      display: inline-block;
      width: 100%;
      padding: 20px 0px 10px 0px;
    }
    &__button {
      width: 100%;
      letter-spacing: normal;
      text-transform: none;
      font-weight: 700;
      margin-top: 20px;
    }
  }
}
</style>
