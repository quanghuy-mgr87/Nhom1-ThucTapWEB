<template>
  <div class="container footer-page">
    <div class="footer__container">
      <div class="footer d-flex">
        <ul class="footer__menu">
          <li>Trang chủ</li>
          <li>Video</li>
          <li>Ảnh</li>
          <li>Infographics</li>
          <li style="border-top: 1px solid #e5e5e5; padding-top: 15px">Mới nhất</li>
          <li>Xem nhiều</li>
          <li>Tin nóng</li>
        </ul>
        <ul class="footer__menu">
          <li>Thời sự</li>
          <li>Góc nhìn</li>
          <li>Thế giới</li>
          <li>Kinh doanh</li>
          <li>Giải trí</li>
        </ul>
        <ul class="footer__menu">
          <li>Thể thao</li>
          <li>Pháp luật</li>
          <li>Giáo dục</li>
          <li>Sức khoẻ</li>
          <li>Đời sống</li>
          <li>Du lịch</li>
        </ul>
        <ul class="footer__menu">
          <li>Khoa học</li>
          <li>Số hoá</li>
          <li>Xe</li>
          <li>Ý kiến</li>
          <li>Tâm sự</li>
          <li>Hài</li>
        </ul>
        <ul class="footer__menu">
          <li>Rao vặt</li>
          <li>Shop VnExpress</li>
          <li>Startup</li>
          <li>Mua ảnh VnExpress</li>
          <li>Vhome</li>
          <li>eBox</li>
        </ul>
        <div class="footer__contact">
          <div class="footer__contact__download-app">
            <p>Tải ứng dụng</p>
            <div class="d-flex justify-space-between">
              <v-btn outlined class="btn footer__contact__download-app__button"><v-img class="btn__image" src="../../assets/vnex-logo.png" alt=""></v-img>VnExpress</v-btn>
              <v-btn outlined class="btn footer__contact__download-app__button"><v-img class="btn__image" src="../../assets/vnex-logo.png" alt=""></v-img>International</v-btn>
            </div>
          </div>
          <div class="footer__contact__contact-link">
            <p>Liên hệ</p>
            <div class="d-flex justify-space-between footer__contact__contact-link__link">
              <div><img src="../../assets/logo-letter.png" alt="" /><a href="">Toà soạn</a></div>
              <div><a href="">Quảng cáo</a></div>
            </div>
            <img src="../../assets/logo-banquyen.png" alt="" /><a href="">Hợp tác bản quyền</a>
          </div>
          <div class="footer__contact__hotline">
            <p>Đường dây nóng</p>
            <div class="left">
              <strong>083.888.0123</strong>
              <p>(Hà Nội)</p>
            </div>
            <div class="right">
              <strong>082.233.3555</strong>
              <p>(TP. Hồ Chí Minh)</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";
.footer__container {
  padding: 37px 15px 0px 15px;
}
.footer {
  border-top: 5px solid $light-gray-color;
  border-bottom: 1px solid $light-gray-color;
  padding: 20px 0px;
  &__menu {
    padding-left: 0px;
    padding-right: 30px;
    max-width: 170px;
    width: 100%;
    font-size: 14px;
    line-height: 15px;
    font-family: Arial, Helvetica, sans-serif;
    li {
      margin-bottom: 15px;
    }
    li:hover {
      text-decoration: underline;
      cursor: pointer;
    }
  }
  &__menu:nth-child(1) {
    font-weight: 700;
  }
  &__menu:nth-child(5) {
    position: relative;
  }
  &__menu:nth-child(5)::before {
    content: "";
    position: absolute;
    width: 1px;
    height: 100%;
    background-color: $light-gray-color;
    left: -15px;
  }
  &__contact {
    font-size: 14px;
    position: relative;
    width: calc(100% - (170px * 5));
    p {
      margin: 0;
    }
    &__download-app {
      margin-bottom: 8px;
      p {
        margin-bottom: 6px;
      }
      &__button {
        max-width: 50%;
        width: 48%;
      }
      .btn__image {
        max-width: 14px;
        margin-right: 5px;
      }
    }
    &__contact-link {
      position: relative;
      &__link {
        div {
          width: 50%;
        }
      }
      img {
        width: 15px;
        margin-right: 4px;
      }
      p {
        margin-bottom: 6px;
      }
      a {
        text-decoration: none;
        color: currentColor;
        line-height: 30px;
      }
      a:nth-child(4) {
        width: 100%;
      }
      a:hover {
        color: #087cce;
      }
    }
    &__contact-link::after {
      content: "";
      width: 100%;
      height: 1px;
      background-color: $light-gray-color;
      position: absolute;
      left: 0;
      bottom: -8px;
    }
    &__hotline {
      padding-top: 15px;
      .left {
        float: left;
        p {
          font-size: 11.5px;
          color: $gray-color;
        }
      }
      .right {
        float: right;
        p {
          font-size: 11.5px;
          color: $gray-color;
        }
      }

      strong {
        font-weight: 700;
        font-size: 15px;
        line-height: 20px;
      }
    }
  }
  &__contact::before {
    content: "";
    width: 1px;
    height: 100%;
    background-color: $light-gray-color;
    position: absolute;
    left: -15px;
  }
}
</style>
