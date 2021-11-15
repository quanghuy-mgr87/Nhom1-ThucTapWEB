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
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
        },
        {
          title: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh",
          description: "Liverpool thua trận đầu tiên ở Ngoại hạng Anh mùa này, với tỷ số 2-3 trên sân của West Ham ở vòng 11 tối 7/11.",
          image: require("../../../../assets/top-story.jpg"),
          link: "https://vnexpress.net/liverpool-thua-tran-dau-tien-o-ngoai-hang-anh-4382634.html",
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
