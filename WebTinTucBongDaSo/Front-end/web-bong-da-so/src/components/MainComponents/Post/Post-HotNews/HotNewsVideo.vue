<template>
  <div class="hot-news-video">
    <div class="hot-news-video__newVideo">
      <span class="hot-news-video__newVideo title-hotnews">
        <a href="https://video.vnexpress.net/"><span>Video</span></a>
      </span>
      <a :href="listVideo[0].link">
        <picture>
          <img :src="listVideo[0].image" alt="" />
        </picture>
        <span>{{ listVideo[0].title }}</span>
      </a>
    </div>
    <div class="hot-news-video__listVideo" v-for="(item, index) in listVideoNew" :key="index">
      <a :href="item.link">
        <div class="image">
          <img :src="item.image" alt="" />
        </div>
        <div class="title">
          <span>{{ item.title }}</span>
        </div>
      </a>
    </div>
  </div>
</template>
<script>
export default {
  created() {
    this.listVideoNew = this.listVideo.splice(1, this.listVideo.length - 1);
  },
  data() {
    return {
      listVideo: [
        { title: "Djokovic 2-0 Fritz ", image: require("@/assets/video1.png"), link: "https://video.vnexpress.net/tin-tuc/the-thao/djokovic-2-0-fritz-4382109.html" },
        { title: "Roma 2-2 Bodo/Glimt ", image: require("@/assets/video2.jpg"), link: "https://video.vnexpress.net/tin-tuc/the-thao/roma-2-2-bodoglimt-4381578.html" },
        { title: "Tottenham 3-2 Vitesse", image: require("@/assets/video3.jpg"), link: "https://video.vnexpress.net/tin-tuc/the-thao/tottenham-3-2-vitesse-4381577.html" },
        { title: "HLV Park lại tráo số áo của cầu thủ Việt Nam", image: require("@/assets/video4.jpg"), link: "https://vnexpress.net/hlv-park-lai-trao-so-ao-cua-cau-thu-viet-nam-4367209.html" },
      ],

      listVideoNew: [],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
span {
  font-family: Merriweather, serif;
  color: #000;
}
a {
  text-decoration: none;
}

a:hover span {
  color: #087cce;
}
.hot-news-video {
  margin-top: 20px;
  &__newVideo {
    span {
      font-weight: 700;
    }
  }

  &__listVideo {
    padding: 10px 0px;
    border-top: 1px solid $light-gray-color;
    margin: 10px 0px;
    a {
      display: flex;
      .image {
        margin-right: 10px;
        img {
          max-width: 120px;
          width: 120px;
        }
      }
      .title {
        span {
          font-size: 14px;
          line-height: 0;
        }
      }
    }
  }
}
</style>
