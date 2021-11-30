<template>
  <div class="px-5 py-5">
    <v-data-table :headers="headers" :items="dsBaiViet" sort-by="name" class="elevation-1 px-5">
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
        <update-post></update-post>
      </template>
      <template v-slot:[`item.actions`]="{ item }">
        <v-icon small color="secondary" class="mr-2" @click="editItem(item)"> mdi-pencil </v-icon>
        <v-icon small color="red" @click="deleteItem(item)"> mdi-delete </v-icon>
      </template>
      <template v-slot:no-data>
        <v-btn class="my-2" color="primary" @click="LayDSBaiVietCaNhan"><v-icon class="mr-2">mdi-book-refresh</v-icon> Lấy bài viết </v-btn>
      </template>
    </v-data-table>
  </div>
</template>
<script>
import axios from "axios";
import { eventBus } from "@/main.js";
import UpdatePost from "./UpdatePost.vue";
export default {
  components: {
    UpdatePost,
  },
  data: () => ({
    dialogDelete: false,
    currentPostId: 0,
    headers: [
      {
        text: "Mã bài viết",
        align: "start",
        value: "maBaiViet",
      },
      { text: "Tiêu đề", value: "tieuDe" },
      { text: "Hình ảnh", value: "linkAnh" },
      { text: "Chủ đề", value: "maChuDe" },
      { text: "Ngày tạo", value: "ngayTao" },
      { text: "Ngày cập nhật", value: "ngayCapNhat" },
      { text: "Tài khoản người đăng", value: "taiKhoanNguoiDang" },
      { text: "Tên tác giả", value: "tenTacGia" },
      { text: "Actions", value: "actions", sortable: false },
    ],
    dsBaiViet: [],
  }),

  created() {
    eventBus.$on("OpenPostDialogManage", this.OpenPostDialogManage);
    this.LayDSBaiVietCaNhan();
  },

  updated() {},

  methods: {
    //#region Axios
    LayDSBaiVietCaNhan() {
      let currentUser = localStorage.getItem("Username");
      axios.get(`https://localhost:44379/api/baiViet?tieuDe=&taiKhoan=${currentUser}`).then((res) => {
        this.dsBaiViet = res.data;
      });
    },

    XoaBaiViet(maBaiViet) {
      axios
        .delete(`https://localhost:44379/api/baiViet?maBaiViet=${maBaiViet}`)
        .then(() => {
          this.LayDSBaiVietCaNhan();
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
      this.LayDSBaiVietCaNhan();
    },
    editItem(item) {
      eventBus.$emit("openUpdatePost", item);
    },

    deleteItem(item) {
      this.dialogDelete = !this.dialogDelete;
      this.currentPostId = item.maBaiViet;
    },

    deleteItemConfirm() {
      this.XoaBaiViet(this.currentPostId);
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
@import "../../../../../public/style.scss";
</style>
