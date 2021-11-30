<template>
  <div class="px-5">
    <v-toolbar flat>
      <v-spacer></v-spacer>
      <v-btn class="addButton" height="45" color="primary" @click="DangBai"><v-icon class="mr-2">mdi-book-check</v-icon> Đăng bài </v-btn>
    </v-toolbar>
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
</template>
<script>
import ClassicEditor from "@ckeditor/ckeditor5-build-classic";
import axios from "axios";
export default {
  created() {
    this.LayDSChuDe();
  },
  data() {
    return {
      baiViet: {
        maBaiViet: 0,
        tieuDe: "",
        moTa: "",
        linkAnh: "",
        noiDung: "",
        maChuDe: 0,
        tenTacGia: "",
        taiKhoanNguoiDang: "",
        ngayTao: "0001-01-01",
        ngayCapNhat: "0001-01-01",
      },
      lstChuDe: [],
      editor: ClassicEditor,
      editorConfig: {
        // The configuration of the editor.
      },
    };
  },

  methods: {
    //#region Axios
    LayDSChuDe() {
      axios.get("https://localhost:44379/api/chuDe").then((res) => {
        this.lstChuDe = res.data;
      });
    },

    DangBai() {
      this.baiViet.taiKhoanNguoiDang = localStorage.getItem("Username");
      if (!this.CheckNull()) {
        alert("Bạn chưa nhập đủ dữ liệu!");
      } else {
        axios
          .post("https://localhost:44379/api/baiViet", this.baiViet)
          .then((res) => {
            this.ClearData();
            alert(res.data);
          })
          .catch((error) => {
            if (error.response) {
              alert(error.response.data);
            }
          });
      }
    },
    //#endregion

    //#region Methods
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
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.title {
  font-family: "Merriweather", serif !important;
  font-size: 20px !important;
  font-weight: 600;
}
.addButton {
  width: 10%;
}
</style>
