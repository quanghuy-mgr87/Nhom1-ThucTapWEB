<template>
  <div class="container">
    <div class="header d-flex justify-space-between align-center">
      <h1 class="header__title">Thể thao</h1>
      <div class="header__searchbox">
        <input class="header__searchbox__input" type="text" placeholder="Tìm kiếm trong chuyên mục" />
        <button><v-icon>mdi-magnify</v-icon></button>
      </div>
    </div>
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.header {
  padding-top: 20px;
  padding-bottom: 10px;
  &__title {
    font-weight: 700;
    font-family: "Merriweather", serif;
    font-size: 32px;
    line-height: 40px;
    color: $green-color-1;
  }
  &__searchbox {
    max-width: 300px;
    width: 100%;
    height: 32px;
    border: solid 1px $gray-color;
    border-radius: 2rem;
    padding-left: 14px;
    &__input {
      width: 254px;
      height: 100%;
      font-size: 14px;
    }
  }
}
</style>
