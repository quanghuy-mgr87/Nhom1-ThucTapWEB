<template>
  <div>
    <div class="list-story list-news d-flex" v-for="(item, index) in listStory" :key="index">
      <div class="list-story__text">
        <a :href="item.link" class="list-story__text__title list-news__title">
          <h1>{{ item.title }}</h1>
        </a>
        <a :href="item.link" class="list-story__text__description list-news__description">
          <span>{{ item.description }}</span>
        </a>
      </div>
      <div class="list-story__image">
        <img :src="item.image" alt="" />
      </div>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      listStory: [
        {
          title: "Ferdinand: 'Solskjaer nên ngẩng cao đầu rời Man Utd'",
          description: "Không muốn tự dối lòng, cựu trung vệ Rio Ferdinand thừa nhận rằng đồng đội cũ Ole Gunnar Solskjaer không thể giúp Man Utd cạnh tranh danh hiệu.",
          image: require("../../../../assets/post-list.jpg"),
          link: "/detail",
        },
      ],
    };
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
