<template>
  <div>
    <div class="container">
      <div class="container__left">
        <span
          >Tạo tài khoản VnExpress <br />
          Để sử dụng đầy đủ tính năng đọc báo và tham gia cộng đồng hơn 4 triệu thành viên</span
        >
        <v-text-field dense color="#9F224E" label="Nhập tài khoản" v-model="nguoiDung.taiKhoan" outlined></v-text-field>
        <v-text-field
          dense
          color="#9F224E"
          :type="`${showPass ? 'text' : 'password'}`"
          label="Tạo mật khẩu"
          outlined
          :append-icon="`${showPass ? 'mdi-eye' : 'mdi-eye-off'}`"
          @click:append="showPass = !showPass"
          v-model="nguoiDung.matKhau"
        ></v-text-field>
        <v-text-field
          dense
          color="#9F224E"
          :type="`${showPass ? 'text' : 'password'}`"
          label="Nhập lại mật khẩu"
          outlined
          :append-icon="`${showPass ? 'mdi-eye' : 'mdi-eye-off'}`"
          @click:append="showPass = !showPass"
          v-model="xacNhanMatKhau"
        ></v-text-field>
        <v-btn height="50" dark color="#9F224E" class="container__left__button" @click="TaoTaiKhoan">Tạo tài khoản</v-btn>
      </div>
      <div class="container__right">
        <span>Tạo tài khoản với</span>
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
import axios from "axios";
export default {
  data() {
    return {
      showPass: false,
      nguoiDung: {
        taiKhoan: "",
        matKhau: "",
      },
      xacNhanMatKhau: "",
    };
  },

  methods: {
    //#region Axios
    DangKyTaiKhoan() {
      axios
        .post("https://localhost:44379/api/nguoiDung", this.nguoiDung)
        .then((res) => {
          alert(res.data);
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
    TaoTaiKhoan() {
      if (this.nguoiDung.matKhau != this.xacNhanMatKhau) {
        alert("Mật khẩu không trùng khớp!");
        return;
      } else {
        this.DangKyTaiKhoan(this.taiKhoan);
      }
    },

    ClearData() {
      this.nguoiDung.taiKhoan = "";
      this.nguoiDung.matKhau = "";
      this.xacNhanMatKhau = "";
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
