<template>
  <div>
    <v-dialog v-model="dialog" transition="dialog-bottom-transition" max-width="400">
      <v-card>
        <v-toolbar color="primary" dark dense flat>Chỉnh sửa quyền lợi</v-toolbar>
        <div class="pa-5">
          <v-radio-group row v-model="currentUser.loaiNguoiDungId">
            <v-radio v-for="(item, index) in lstQuyenLoi" :key="index" :label="item.tenLoai" :value="item.loaiNguoiDungId"></v-radio>
          </v-radio-group>
          <v-toolbar flat dense>
            <v-spacer></v-spacer>
            <v-btn @click="Update" color="primary">Cập nhật</v-btn>
          </v-toolbar>
        </div>
      </v-card>
    </v-dialog>
  </div>
</template>
<script>
import { eventBus } from "@/main.js";
import axios from "axios";
export default {
  data() {
    return {
      dialog: false,
      lstQuyenLoi: [],
      currentUser: {},
    };
  },

  created() {
    eventBus.$on("openModalUpdateUserType", this.openModalUpdateUserType);
    this.LayDSQuyenLoi();
  },

  methods: {
    //#region Axios
    LayDSQuyenLoi() {
      axios.get("https://localhost:44379/api/loaiNguoiDung").then((res) => {
        this.lstQuyenLoi = res.data;
      });
    },

    CapNhatNguoiDung() {
      axios
        .put("https://localhost:44379/api/nguoiDung", this.currentUser)
        .then((res) => {
          this.dialog = false;

          alert(res.data);
        })
        .catch((error) => {
          if (error.response) {
            alert(error.response.data);
          }
        });
    },
    //#endregion

    //#region Methods
    openModalUpdateUserType(value) {
      this.dialog = !this.dialog;
      this.currentUser = value;
    },

    Update() {
      this.CapNhatNguoiDung();
    },
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";
</style>
