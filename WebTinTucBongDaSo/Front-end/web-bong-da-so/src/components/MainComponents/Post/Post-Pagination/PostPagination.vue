<template>
  <div class="pagination text-center">
    <v-pagination color="#9F224E" v-model="page" :length="totalPage" :total-visible="7"></v-pagination>
  </div>
</template>
<script>
import axios from "axios";
import { eventBus } from "@/main.js";
export default {
  data() {
    return {
      page: 1,
      totalPage: 0,
    };
  },

  created() {
    axios.get("https://localhost:44379/api/pagination").then((res) => {
      this.totalPage = res.data;
    });
  },

  watch: {
    page() {
      eventBus.$emit("MovePage", this.page);
    },
  },
};
</script>
<style lang="scss" scoped>
.pagination {
  margin: 15px 0px;
}
</style>
