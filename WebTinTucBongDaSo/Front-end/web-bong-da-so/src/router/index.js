import Vue from "vue";
import VueRouter from "vue-router";
import Posts from '../components/MainComponents/Post/Posts.vue'
import PostMain from '../components/MainComponents/Post/PostMain.vue'
import PostPremierLeague from '../components/MainComponents/Post/PostPremierLeague.vue'
import PostChampionsLeague from '../components/MainComponents/Post/PostChampionsLeague.vue'
import PostLaLiga from '../components/MainComponents/Post/PostLaLiga.vue'
import PostBundesliga from '../components/MainComponents/Post/PostBundesliga.vue'
import PostSerieA from '../components/MainComponents/Post/PostSerieA.vue'

Vue.use(VueRouter);

const routes = [
  {
    path: "/bong-da",
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
        path: "serie-a",
        component: PostSerieA
      }
    ]
  },
  // {
  //   path: "/about",
  //   name: "About",
  //   // route level code-splitting
  //   // this generates a separate chunk (about.[hash].js) for this route
  //   // which is lazy-loaded when the route is visited.
  //   component: () =>
  //     import(/* webpackChunkName: "about" */ "../views/About.vue"),
  // },
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
