<template>
  <div>
    <div class="list-story list-news d-flex" v-for="(item, index) in listStory" :key="index">
      <div class="list-story__text">
        <a :href="`/chi-tiet-bai-viet?baiVietId=${item.maBaiViet}`" class="list-story__text__title list-news__title">
          <h1>{{ item.tieuDe }}</h1>
        </a>
        <a :href="`/chi-tiet-bai-viet?baiVietId=${item.maBaiViet}`" class="list-story__text__description list-news__description">
          <span>{{ item.moTa }}</span>
        </a>
      </div>
      <div class="list-story__image">
        <img :src="require('@/assets/' + item.linkAnh)" alt="" />
      </div>
    </div>
  </div>
</template>
<script>
import axios from "axios";
import { eventBus } from "@/main.js";
export default {
  created() {
    this.LayDanhSachBaiViet(1);
    eventBus.$on("MovePage", this.MovePage);
  },
  data() {
    return {
      listStory: [],
    };
  },

  methods: {
    //#region Axios
    LayDanhSachBaiViet(page) {
      axios.get(`https://localhost:44379/api/baiViet?pageNumber=${page}&pageSize=${13}`).then((res) => {
        this.listStory = res.data;
      });
    },

    MovePage(page) {
      this.LayDanhSachBaiViet(page);
    },
    //#endregion

    //#region Methods
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.list-story {
  padding: 20px 0px;
  border-top: 1px solid $light-gray-color;
  a {
    text-decoration: none;
  }
  &__text {
    max-width: 70%;
    padding-right: 40px;
    &__title {
      h1 {
        font-weight: 400;
      }
    }
  }
  &__image {
    max-width: 30%;
    img {
      max-width: 100%;
      height: 100%;
    }
  }
}
</style>
