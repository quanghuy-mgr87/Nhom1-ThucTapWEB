<template>
  <div class="container footer-page">
    <div class="footer__container copyright">
      <p>
        <a href="/">
          <img src="../../assets/vnex-logo.png" alt="" />
        </a>
      </p>
      <div class="footer__container__right-flexbox">
        <a href="">RSS</a>
        <span>Theo dõi Bongdanet trên</span>
        <a class="social" href="/"><i class="fab fa-facebook-f"></i></a>
        <a class="social" href="/"><i class="fab fa-twitter"></i></a>
        <a class="social" href="/"><i class="fab fa-youtube"></i></a>
      </div>
    </div>
  </div>
</template>
<style lang="scss" scoped>
@import "../../../public/style.scss";
.footer__container {
  padding-top: 10px;
  padding-bottom: 10px;
  max-height: 52px;
  display: flex;
  justify-content: space-between;
  font-size: 14px;
  color: $gray-color;
  a {
    text-decoration: none;
    color: currentColor;
  }
  span {
    border-left: 1px solid $light-gray-color;
    margin-left: 10px;
    padding-left: 10px;
  }
  &__right-flexbox {
    display: flex;
    align-items: center;
    padding: 0px;
    .social {
      display: inline-block;
      border-radius: 50px;
      font-size: 15px;
      line-height: 32px;
      border: 1px solid $light-gray-color;
      width: 32px;
      height: 32px;
      text-align: center;
      margin-left: 10px;
    }
    a:nth-child(1):hover {
      text-decoration: underline;
    }
    a:nth-child(3):hover {
      color: #fff;
      background-color: #3b5999;
    }
    a:nth-child(4):hover {
      color: #fff;
      background-color: #55acee;
    }
    a:nth-child(5):hover {
      color: #fff;
      background-color: #cc0000;
    }
  }
}
</style>
