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
        title: "Cafu: 'Về kỹ thuật, Neymar giỏi hơn Messi và Ronaldo'",
        description: "Theo hậu vệ hai lần vô địch World Cup Cafu, nếu tập trung hết mức cho bóng đá, Neymar có thể vượt Lionel Messi và Cristiano Ronaldo.",
        image: require("../../../../assets/top-story.jpg"),
        link: "https://vnexpress.net/bong-da/giai-ngoai-hang-anh",
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
