<template>
  <div class="px-5 py-5">
    <v-data-table :headers="headers" :items="dsTaiKhoan" sort-by="name" class="elevation-1 px-5">
      <template v-slot:top>
        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="text-h5">Bạn có muốn xoá bài viết này không?</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="deleteItemConfirm">Có</v-btn>
              <v-btn color="red darken-1" text @click="closeDelete">Không</v-btn>
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
        <ModalUpdateUserType></ModalUpdateUserType>
      </template>
      <template v-slot:[`item.actions`]="{ item }">
        <v-icon color="primary" class="mr-2" @click="editItem(item)"> mdi-account-convert </v-icon>
        <v-icon color="red" @click="deleteItem(item)"> mdi-delete </v-icon>
      </template>
      <template v-slot:no-data>
        <v-btn class="my-2" color="primary" @click="LayDSTaiKhoan"><v-icon class="mr-2">mdi-book-refresh</v-icon> Lấy bài viết </v-btn>
      </template>
    </v-data-table>
  </div>
</template>
<script>
import axios from "axios";
import { eventBus } from "@/main.js";
import ModalUpdateUserType from "./ModalUpdateUserType.vue";
export default {
  components: {
    ModalUpdateUserType,
  },
  data: () => ({
    dialogDelete: false,
    currentUser: 0,
    headers: [
      {
        text: "Tài khoản",
        align: "start",
        value: "taiKhoan",
      },
      { text: "Họ tên", value: "hoTen" },
      { text: "Giới tính", value: "gioiTinh" },
      { text: "Địa chỉ", value: "diaChi" },
      { text: "Ngày tham gia", value: "thoiGianThamGia" },
      { text: "Loại người dùng", value: "loaiNguoiDungId" },
      { text: "Actions", value: "actions", sortable: false },
    ],
    dsTaiKhoan: [],
  }),

  created() {
    eventBus.$on("OpenPostDialogManage", this.OpenPostDialogManage);
    this.LayDSTaiKhoan();
  },

  updated() {},

  methods: {
    //#region Axios
    LayDSTaiKhoan() {
      axios.get("https://localhost:44379/api/nguoiDung").then((res) => {
        this.dsTaiKhoan = res.data;
      });
    },

    XoaNguoiDung(taiKhoan) {
      axios
        .delete(`https://localhost:44379/api/nguoiDung?taiKhoan=${taiKhoan}`)
        .then(() => {
          this.LayDSTaiKhoan();
        })
        .catch((error) => {
          if (error.response) {
            alert(error.response.data);
          }
        });
    },
    //#endregion

    //#region Methods
    OpenPostDialogManage() {
      this.LayDSTaiKhoan();
    },
    editItem(item) {
      eventBus.$emit("openModalUpdateUserType", item);
    },

    deleteItem(item) {
      this.dialogDelete = !this.dialogDelete;
      this.currentUser = item.taiKhoan;
    },

    deleteItemConfirm() {
      this.XoaNguoiDung(this.currentUser);
      this.dialogDelete = false;
    },
    closeDelete() {
      this.dialogDelete = false;
    },
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";
</style>
