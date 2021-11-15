<template>
  <div class="box-tin-moi">
    <div class="box-tin-moi__content">
      <div class="article d-flex" v-for="(item, index) in listArticle" :key="index">
        <div class="title">
          <a :href="item.link">{{ item.title }}</a>
        </div>
        <div class="image">
          <img :src="item.imageLink" alt="" />
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      listArticle: [
        {
          title: "Mỹ điều tra hình sự vụ giẫm đạp tại lễ hội âm nhạc",
          imageLink: require("@/assets/article1.jpg"),
          link: "https://vnexpress.net/my-dieu-tra-hinh-su-vu-giam-dap-tai-le-hoi-am-nhac-4382506.html",
        },
        {
          title: "Điều đơn giản nhưng không nên làm khi đi du lịch",
          imageLink: require("@/assets/article2.jpg"),
          link: "https://vnexpress.net/dieu-don-gian-nhung-khong-nen-lam-khi-di-du-lich-4381851.html",
        },
        { title: "Nhà vô địch PGA Tour lên tay với gậy mượn", imageLink: require("@/assets/article3.jpg"), link: "https://vnexpress.net/nha-vo-dich-pga-tour-len-tay-voi-gay-muon-4382513.html" },
        { title: "Roy Keane ‘đầu hàng’ cầu thủ Man Utd", imageLink: require("@/assets/article4.jpg"), link: "https://vnexpress.net/roy-keane-dau-hang-cau-thu-man-utd-4382510.html" },
        {
          title: "Cô giáo Lịch sử thi lại đại học, thành thủ khoa hội họa",
          imageLink: require("@/assets/article5.jpg"),
          link: "https://vnexpress.net/co-giao-lich-su-thi-lai-dai-hoc-thanh-thu-khoa-hoi-hoa-4382481.html",
        },
        {
          title: "Dừng thi công đào hố móng, hầm phụ dự án nhà máy thuỷ điện Hoà Bình mở rộng",
          imageLink: require("@/assets/article6.jpg"),
          link: "https://vnexpress.net/dung-thi-cong-dao-ho-mong-ham-phu-du-an-nha-may-thuy-dien-hoa-binh-mo-rong-4382394.html",
        },
        { title: "Trương Quỳnh Anh bên con sau 4 tháng xa cách", imageLink: require("@/assets/article7.jpg"), link: "https://vnexpress.net/truong-quynh-anh-ben-con-sau-4-thang-xa-cach-4382464.html" },
        {
          title: "7 ngày 'đọc vị' kẻ chăn bò trút hận vào bé 8 tuổi",
          imageLink: require("@/assets/article8.jpg"),
          link: "https://vnexpress.net/7-ngay-truy-tim-ke-chan-bo-trut-han-vao-be-trai-8-tuoi-4382482.html",
        },
        {
          title: "Thiếu nữ thoát nạn nhờ ra ký hiệu với người đi đường",
          imageLink: require("@/assets/article9.jpg"),
          link: "https://vnexpress.net/thieu-nu-mat-tich-duoc-cuu-nho-dung-ky-hieu-tay-tren-tiktok-4382466.html",
        },
        { title: "Solskjaer kiên quyết ở lại Man Utd", imageLink: require("@/assets/article10.png"), link: "https://vnexpress.net/solskjaer-kien-quyet-o-lai-man-utd-4382504.html" },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
@include scrollbar;
.box-tin-moi {
  margin-top: 15px;
  border: 1px solid $light-gray-color;
  padding: 15px 0px 0 15px;
  position: relative;
  &__content {
    max-height: 557px;
    overflow: scroll;
    padding-right: 4px;
    margin-right: 4px;
    .article {
      padding-bottom: 12px;
      margin-bottom: 12px;
      border-bottom: 1px solid $light-gray-color;
      .title {
        max-width: 63%;
        padding-right: 10px;
        a {
          font-size: 14px;
          text-decoration: none;
          color: #000;
          font-family: Merriweather, serif;
          line-height: 0;
          font-weight: 400;
          text-align: justify;
        }
        a:hover {
          color: #087cce;
        }
      }
      .image {
        max-width: 37%;
        img {
          max-width: 100%;
        }
      }
    }
    .article:last-child {
      border-bottom: none;
    }
  }
}
.box-tin-moi::after {
  background: linear-gradient(180deg, rgba(255, 255, 255, 0) 0%, #fff 100%);
  width: 100%;
  height: 60px;
  content: "";
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 1;
}
</style>
