<template>
  <div>
    <v-dialog v-model="dialog" transition="dialog-bottom-transition" max-width="1000">
      <v-card>
        <v-toolbar color="primary" dark>Chỉnh sửa bài viết</v-toolbar>
        <div>
          <v-toolbar flat>
            <v-spacer></v-spacer>
            <v-btn class="addButton" height="45" color="primary" @click="SuaBaiViet"><v-icon class="mr-2">mdi-book-check</v-icon>Lưu bài viết</v-btn>
          </v-toolbar>
          <div class="px-5 pb-5 form">
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Tiêu đề:</h2>
            <v-text-field color="#b52759" label="Nhập tiêu đề" v-model="baiViet.tieuDe"></v-text-field>
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Mô tả:</h2>
            <v-text-field color="#b52759" label="Nhập mô tả" v-model="baiViet.moTa"></v-text-field>
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Hình ảnh:</h2>
            <v-file-input color="#b52759" label="Chọn hình ảnh" accept="image/png, image/jpeg, image/bmp" filled prepend-icon="mdi-camera" @change="onFilePicked"></v-file-input>
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Chủ đề:</h2>
            <v-select color="#b52759" :items="lstChuDe" item-text="tenChuDe" item-value="maChuDe" label="Chọn chủ đề" v-model="baiViet.maChuDe"></v-select>
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Tên tác giả:</h2>
            <v-text-field color="#b52759" label="Nhập tên tác giả" v-model="baiViet.tenTacGia"></v-text-field>
            <h2 class="title"><v-icon>mdi-book-edit</v-icon> Nội dung:</h2>
            <div class="app">
              <ckeditor class="ckeditor" :editor="editor" v-model="baiViet.noiDung" :config="editorConfig"></ckeditor>
            </div>
          </div>
        </div>
      </v-card>
    </v-dialog>
  </div>
</template>
<script>
import ClassicEditor from "@ckeditor/ckeditor5-build-classic";
import { eventBus } from "@/main.js";
import axios from "axios";
export default {
  data() {
    return {
      dialog: false,
      baiViet: {},
      lstChuDe: [],
      editor: ClassicEditor,
      editorConfig: {
        // The configuration of the editor.
      },
    };
  },

  created() {
    eventBus.$on("openUpdatePost", this.openUpdatePost);
    this.LayDSChuDe();
  },

  methods: {
    //#region Axios
    LayDSChuDe() {
      axios.get("https://localhost:44379/api/chuDe").then((res) => {
        this.lstChuDe = res.data;
      });
    },

    SuaBaiViet() {
      axios
        .put("https://localhost:44379/api/chuDe", this.baiViet)
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
    openUpdatePost(value) {
      this.dialog = !this.dialog;
      this.baiViet = value;
    },
    
    onFilePicked(e) {
      this.baiViet.linkAnh = e.name;
    },

    CheckNull() {
      if (this.baiViet.tieuDe == "" || this.baiViet.moTa == "" || this.baiViet.linkAnh == "" || this.baiViet.noiDung == "" || this.baiViet.maChuDe == 0 || this.baiViet.tenTacGia == "") {
        return false;
      } else {
        return true;
      }
    },

    ClearData() {
      this.baiViet.maBaiViet = 0;
      this.baiViet.tieuDe = "";
      this.baiViet.moTa = "";
      this.baiViet.linkAnh = "";
      this.baiViet.noiDung = "";
      this.baiViet.maChuDe = 0;
      this.baiViet.tenTacGia = "";
      this.baiViet.taiKhoanNguoiDang = localStorage.getItem("Username");
      this.baiViet.ngayTao = "0001-01-01";
      this.baiViet.ngayCapNhat = "0001-01-01";
    },

    UpdatePost() {},
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.form {
  max-height: 700px;
  overflow: scroll;
}
</style>
