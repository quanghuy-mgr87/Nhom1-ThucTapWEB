<template>
  <v-row justify="center">
    <v-dialog v-model="dialog" fullscreen hide-overlay transition="dialog-bottom-transition">
      <v-card>
        <v-toolbar dark color="secondary" tile>
          <v-toolbar-title>Quản lý bài viết</v-toolbar-title>
          <v-spacer></v-spacer>
          <v-btn icon dark @click="dialog = false">
            <v-icon>mdi-close</v-icon>
          </v-btn>
        </v-toolbar>
        <v-card class="pb-4" flat>
          <v-tabs v-model="tab" background-color="transparent" color="#b52759" grow>
            <v-tab class="tabs" v-for="item in items" :key="item">
              {{ item }}
            </v-tab>
          </v-tabs>

          <v-tabs-items v-model="tab">
            <v-tab-item>
              <v-card color="basil" flat>
                <list-post></list-post>
              </v-card>
            </v-tab-item>
            <v-tab-item>
              <v-card color="basil" flat>
                <add-post></add-post>
              </v-card>
            </v-tab-item>
          </v-tabs-items>
        </v-card>
      </v-card>
    </v-dialog>
  </v-row>
</template>
<script>
import { eventBus } from "@/main.js";
import AddPost from "./AddPost.vue";
import ListPost from "./ListPost.vue";
export default {
  components: {
    AddPost,
    ListPost,
  },
  created() {
    eventBus.$on("OpenPostDialogManage", this.OpenPostDialogManage);
  },
  data() {
    return {
      dialog: false,
      tab: null,
      items: ["Bài viết của tôi", "Đăng bài"],
      username: "",
    };
  },

  methods: {
    OpenPostDialogManage() {
      this.dialog = !this.dialog;
    },
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../../public/style.scss";
</style>
