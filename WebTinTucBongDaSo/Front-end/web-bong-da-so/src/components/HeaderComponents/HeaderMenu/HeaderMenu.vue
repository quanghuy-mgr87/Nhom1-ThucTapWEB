<template>
  <div class="header">
    <ul class="header__menu d-flex align-center justify-space-around">
      <li class="header__menu__item mr-3">
        <a href="/"><v-icon size="20" class="home">mdi-home</v-icon></a>
      </li>
      <li class="header__menu__item" v-for="(item, index) in listItem" :key="index">
        <a href="">{{ item.name }}</a>
        <ul v-if="item.subItems.length > 0" class="header__menu__item__submenu">
          <li class="header__menu__item__submenu__item" v-for="(subItem, subIndex) in item.subItems" :key="subIndex">
            <router-link class="link" :to="subItem.link">{{ subItem.name }}</router-link>
          </li>
        </ul>
      </li>
      <li class="header__menu__item">
        <a href="#"><span>Tất cả</span><v-icon class="ico ml-1" size="19">mdi-menu</v-icon></a>
      </li>
    </ul>
  </div>
</template>
<script>
export default {
  data() {
    return {
      listItem: [
        {
          name: "Bóng đá",
          subItems: [
            { name: "Champions League", link: "/" },
            { name: "Ngoại hạng Anh", link: "/" },
            { name: "La Liga", link: "/" },
            { name: "Serie A", link: "/" },
            { name: "Bundesliga", link: "/" },
            { name: "V-League", link: "/" },
            { name: "J-League", link: "/" },
            { name: "K-League", link: "/" },
            { name: "League 1", link: "/" },
          ],
        },
        {
          name: "Lịch thi đấu",
          subItems: [
            { name: "Lịch thi đấu Champions League", link: "/" },
            { name: "Lịch thi đấu Ngoại hạng Anh", link: "/" },
            { name: "Lịch thi đấu La Liga", link: "/" },
            { name: "Lịch thi đấu Serie A", link: "/" },
            { name: "Lịch thi đấu Bundesliga", link: "/" },
            { name: "Lịch thi đấu V-League", link: "/" },
            { name: "Lịch thi đấu J-League", link: "/" },
            { name: "Lịch thi đấu K-League", link: "/" },
            { name: "Lịch thi đấu League 1", link: "/" },
          ],
        },
        {
          name: "BXH bóng đá",
          subItems: [
            { name: "BXH Champions League", link: "/" },
            { name: "BXH Ngoại hạng Anh", link: "/" },
            { name: "BXH La Liga", link: "/" },
            { name: "BXH Serie A", link: "/" },
            { name: "BXH Bundesliga", link: "/" },
            { name: "BXH V-League", link: "/" },
            { name: "BXH J-League", link: "/" },
            { name: "BXH K-League", link: "/" },
            { name: "BXH League 1", link: "/" },
          ],
        },
        {
          name: "Top ghi bàn",
          subItems: [
            { name: "Top ghi bàn Champions League", link: "/" },
            { name: "Top ghi bàn Ngoại hạng Anh", link: "/" },
            { name: "Top ghi bàn La Liga", link: "/" },
            { name: "Top ghi bàn Serie A", link: "/" },
            { name: "Top ghi bàn Bundesliga", link: "/" },
            { name: "Top ghi bàn V-League", link: "/" },
            { name: "Top ghi bàn J-League", link: "/" },
            { name: "Top ghi bàn K-League", link: "/" },
            { name: "Top ghi bàn League 1", link: "/" },
          ],
        },
        {
          name: "VM 2021",
          subItems: [],
        },
        {
          name: "World Cup 2022",
          subItems: [],
        },
        {
          name: "Hậu trường",
          subItems: [],
        },
        {
          name: "Video",
          subItems: [
            { name: "Video Champions League", link: "/" },
            { name: "Video Ngoại hạng Anh", link: "/" },
            { name: "Video La Liga", link: "/" },
            { name: "Video Serie A", link: "/" },
            { name: "Video Bundesliga", link: "/" },
            { name: "Video V-League", link: "/" },
            { name: "Video J-League", link: "/" },
            { name: "Video K-League", link: "/" },
            { name: "Video League 1", link: "/" },
          ],
        },
        {
          name: "Ảnh",
          subItems: [],
        },
        {
          name: "Trắc nghiệm",
          subItems: [],
        },
        {
          name: "Tường thuật",
          subItems: [],
        },
        {
          name: "Kết quả",
          subItems: [],
        },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../public/style.scss";

.header {
  height: 100%;
  &__menu {
    padding: 0px;
    font-size: 15px;
    font-family: Arial, Helvetica, sans-serif;
    font-weight: 600;
    height: 100%;
    &__item:last-child {
      font-weight: 100;
      a {
        color: $light-gray-color-2;
        transition: color 0.2s linear;
      }
      .ico {
        color: $light-gray-color-2;
        transition: color 0.2s linear;
      }
    }
    &__item {
      display: inline-block;
      margin-right: 15px;
      position: relative;
      height: 100%;
      display: flex;
      align-items: center;
      .home:hover {
        color: #fff;
        background-color: #b52759;
      }
      .home {
        border: 1px solid $light-gray-color;
        border-radius: 50%;
        padding: 3px;
      }
      a {
        text-decoration: none;
        color: $primary-text-color;
        transition: color 0.5s linear;
      }
      &__submenu {
        position: absolute;
        top: 100px;
        opacity: 0;
        left: 0px;
        min-width: 220px;
        z-index: -100;
        border-top: solid 1px $red-brown-color;
        padding: 0;
        box-shadow: 0px 2px 6px -2px $gray-color;
        background-color: #fff;
        transition: top 0.2s 0.1s, opacity 0.25s 0.1s;
        &__item {
          padding: 10px 15px;
          font-weight: 100;
          .link {
            color: $primary-text-color !important;
          }
        }

        &__item:hover {
          text-decoration: underline;
          cursor: pointer;
        }
      }
    }
    &__item:hover {
      a {
        color: $red-brown-color;
      }
      .ico {
        color: $red-brown-color;
      }

      .header__menu__item__submenu {
        z-index: 100;
        top: 100%;
        opacity: 1;
      }
    }
  }
}
</style>
