<template>
  <div>
    <champions-league v-if="currentPath != '/bong-da/champions-league'"></champions-league>
    <premier-league v-if="currentPath != '/bong-da/giai-ngoai-hang-anh'"></premier-league>
    <la-liga v-if="currentPath != '/bong-da/la-liga'"></la-liga>
    <serie-a v-if="currentPath != '/bong-da/serie-a'"></serie-a>
    <bundesliga v-if="currentPath != '/bong-da/bundesliga'"></bundesliga>
  </div>
</template>
<script>
import ChampionsLeague from "./HotNewsList/ChampionsLeague.vue";
import PremierLeague from "./HotNewsList/PremierLeague.vue";
import LaLiga from "./HotNewsList/LaLiga.vue";
import SerieA from "./HotNewsList/SerieA.vue";
import Bundesliga from "./HotNewsList/Bundesliga.vue";
export default {
  components: {
    ChampionsLeague,
    PremierLeague,
    LaLiga,
    SerieA,
    Bundesliga,
  },

  data() {
    return {
      currentPath: "",
    };
  },

  created() {
    this.currentPath = this.$route.path;
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
</style>
