<template>
  <div class="top-story list-news d-flex">
    <div class="top-story__image">
      <img :src="topStory.image" alt="" />
    </div>
    <div class="top-story__text">
      <a :href="topStory.link" class="top-story__text__title list-news__title">
        <h1>{{ topStory.title }}</h1>
      </a>
      <a :href="topStory.link" class="top-story__text__description list-news__description">
        <span>{{ topStory.description }}</span>
      </a>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      topStory: {
        title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
        description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
        image: require("../../../../assets/top-story.jpg"),
        link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
      },
    };
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
