import Vue from "vue";
import VueRouter from "vue-router";
import Posts from '../components/MainComponents/Post/Posts.vue'
import PostMain from '../components/MainComponents/Post/PostMain.vue'
import PostPremierLeague from '../components/MainComponents/Post/PostPremierLeague.vue'
import PostChampionsLeague from '../components/MainComponents/Post/PostChampionsLeague.vue'
import PostLaLiga from '../components/MainComponents/Post/PostLaLiga.vue'
import PostBundesliga from '../components/MainComponents/Post/PostBundesliga.vue'
import PostSerieA from '../components/MainComponents/Post/PostSerieA.vue'
import PostDetail from '../components/MainComponents/PostDetail/PostDetail.vue'

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Posts",
    component: Posts,
    children: [
      {
        path: "/",
        component: PostMain
      },
      {
        path: "giai-ngoai-hang-anh",
        component: PostPremierLeague
      }, {
        path: "champions-league",
        component: PostChampionsLeague
      }, {
        path: "la-liga",
        component: PostLaLiga
      },
      {
        path: "bundesliga",
        component: PostBundesliga
      },
      {
        path: "league-1",
        component: PostSerieA
      },
      {
        path: "v-league",
        component: PostSerieA
      },
      {
        path: "j-league",
        component: PostSerieA
      },
      {
        path: "k-league",
        component: PostSerieA
      },
      {
        path: "serie-a",
        component: PostSerieA
      }
    ]
  },
  {
    path: "/chi-tiet-bai-viet",
    component: PostDetail
  },
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
