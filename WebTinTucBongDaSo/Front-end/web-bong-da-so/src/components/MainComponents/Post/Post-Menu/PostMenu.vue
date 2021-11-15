<template>
  <div class="container">
    <ul class="menu d-flex">
      <li :class="`menu__item ${item.status}`" v-for="(item, index) in listItem" :key="index" @click="active(item)">
        <router-link class="link" :to="item.link">{{ item.name }}</router-link>
      </li>
    </ul>
  </div>
</template>
<script>
export default {
  data() {
    return {
      listItem: [
        { id: 1, name: "Bóng đá", link: "/bong-da", status: "active" },
        { id: 2, name: "Lịch thi đấu", link: "", status: "" },
        { id: 3, name: "Tennis", link: "", status: "" },
        { id: 4, name: "VM 2021", link: "", status: "" },
        { id: 6, name: "Bundesliga", link: "", status: "" },
        { id: 7, name: "Các môn khác", link: "", status: "" },
        { id: 8, name: "World Cup 2022", link: "", status: "" },
        { id: 9, name: "Hậu trường", link: "", status: "" },
        { id: 10, name: "Video", link: "", status: "" },
        { id: 11, name: "Ảnh", link: "", status: "" },
        { id: 12, name: "V-Race", link: "", status: "" },
        { id: 13, name: "Trắc nghiệm", link: "", status: "" },
        { id: 14, name: "Tường thuật", link: "", status: "" },
      ],
    };
  },
  methods: {
    clearStatus() {
      for (let index = 0; index < this.listItem.length; index++) {
        if (this.listItem[index].status != "") {
          this.listItem[index].status = "";
          return;
        }
      }
    },
    active(item) {
      this.clearStatus();
      let index = this.listItem.indexOf(item);
      this.listItem[index].status = "active";
    },
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
.menu {
  font-size: 14px;
  font-weight: 700;
  padding: 0;
  border-bottom: solid 1px $light-gray-color;
  .active {
    .link {
      color: $green-color-1;
    }
    .link::after {
      width: 100%;
      left: 0;
    }
  }
  &__item {
    margin-right: 15px;
    line-height: 17px;
    padding: 12px 0px;
    position: relative;
    .link {
      text-decoration: none;
      color: $primary-text-color;
    }
    .link::after {
      content: "";
      position: absolute;
      width: 0;
      height: 1px;
      background: $green-color-1;
      bottom: -1px;
      left: 50%;
      transition: width 0.2s 0.2s, left 0.2s 0.2s;
    }
  }
  &__item:hover {
    .link {
      color: $green-color-1;
    }
    .link::after {
      width: 100%;
      left: 0;
    }
  }
}
</style>
