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
        { id: 1, name: "Champions League", link: "/bong-da/champions-league", status: "" },
        { id: 2, name: "Ngoại hạng Anh", link: "/bong-da/giai-ngoai-hang-anh", status: "" },
        { id: 3, name: "La Liga", link: "/bong-da/la-liga", status: "" },
        { id: 4, name: "Serie A", link: "/bong-da/serie-a", status: "" },
        { id: 5, name: "Bundesliga", link: "/bong-da/bundesliga", status: "" },
        { id: 6, name: "Các giải khác", link: "", status: "" },
      ],
    };
  },
  watch: {
    //watch current route to change active status
    $route() {
      if (this.$router.currentRoute.path == "/bong-da") {
        this.clearStatus();
      }
    },
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
  padding: 0;
  border-bottom: solid 1px $light-gray-color;
  .active {
    .link {
      color: $green-color-2;
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
      background: $green-color-2;
      bottom: -1px;
      left: 50%;
      transition: width 0.2s 0.2s, left 0.2s 0.2s;
    }
  }
  &__item:hover {
    .link {
      color: $green-color-2;
    }
    .link::after {
      width: 100%;
      left: 0;
    }
  }
}
</style>
