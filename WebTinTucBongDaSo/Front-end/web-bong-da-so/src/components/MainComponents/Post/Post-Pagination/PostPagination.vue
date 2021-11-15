<template>
  <div class="pagination text-center">
    <v-pagination color="#9F224E" v-model="page" :length="15" :total-visible="7"></v-pagination>
  </div>
</template>
<script>
export default {
  data() {
    return {
      page: 1,
    };
  },
};
</script>
<style lang="scss" scoped>
.pagination{
    margin: 15px 0px;
}
</style>
