<template>
  <div class="top-story list-news d-flex">
    <div class="top-story__image">
      <img :src="require('@/assets/' + topStory.linkAnh)" alt="" />
    </div>
    <div class="top-story__text">
      <a :href="`/chi-tiet-bai-viet?baiVietId=${topStory.maBaiViet}`" class="top-story__text__title list-news__title">
        <h1>{{ topStory.tieuDe }}</h1>
      </a>
      <a :href="`/chi-tiet-bai-viet?baiVietId=${topStory.maBaiViet}`" class="top-story__text__description list-news__description">
        <span>{{ topStory.moTa }}</span>
      </a>
    </div>
  </div>
</template>
<script>
import axios from "axios";
export default {
  created() {
    this.LayBaiVietMoiNhat();
  },

  data() {
    return {
      topStory: {},
    };
  },

  methods: {
    //#region Axios
    LayBaiVietMoiNhat() {
      axios.get("https://localhost:44379/api/baiViet/bai-viet-moi-nhat").then((res) => {
        this.topStory = res.data;
      });
    },
    //#endregion
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.top-story {
  background-color: $light-gray-color-1;
  margin-bottom: 20px;
  a {
    text-decoration: none;
  }
  &__image {
    max-width: 65%;
    img {
      max-width: 100%;
      height: 100%;
    }
  }
  &__text {
    max-width: 35%;
    padding: 20px;
    &__title {
      h1 {
        font-weight: 700;
        font-size: 20px;
      }
    }
  }
}
</style>
