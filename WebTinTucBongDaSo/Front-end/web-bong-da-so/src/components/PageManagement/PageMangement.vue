<template>
  <v-row justify="center">
    <v-dialog v-model="dialog" fullscreen hide-overlay transition="dialog-bottom-transition">
      <v-card>
        <v-toolbar dark color="secondary" tile flat>
          <v-toolbar-title>Quản lý trang</v-toolbar-title>
          <v-spacer></v-spacer>
          <v-btn icon dark @click="dialog = false">
            <v-icon>mdi-close</v-icon>
          </v-btn>
        </v-toolbar>
        <template>
          <v-card flat>
            <v-tabs vertical>
              <v-tab class="tab">
                <v-icon left> mdi-book-account </v-icon>
                Quản lý người dùng
              </v-tab>
              <v-tab class="tab">
                <v-icon left> mdi-account-cog </v-icon>
                Quản lý loại người dùng
              </v-tab>
              <v-tab class="tab">
                <v-icon left> mdi-book-cog </v-icon>
                Quản lý chủ đề
              </v-tab>

              <v-tab-item>
                <v-card flat>
                  <user-management></user-management>
                </v-card>
              </v-tab-item>
              <v-tab-item>
                <v-card flat>
                  <v-card-text> </v-card-text>
                </v-card>
              </v-tab-item>
              <v-tab-item>
                <v-card flat>
                  <v-card-text> </v-card-text>
                </v-card>
              </v-tab-item>
            </v-tabs>
          </v-card>
        </template>
      </v-card>
    </v-dialog>
  </v-row>
</template>
<script>
import { eventBus } from "@/main.js";
import UserManagement from "./UserManagement.vue";
export default {
  components: { UserManagement },

  data() {
    return {
      dialog: false,
    };
  },

  created() {
    eventBus.$on("OpenPageManagement", this.OpenPageManagement);
  },

  methods: {
    OpenPageManagement() {
      this.dialog = !this.dialog;
    },
  },
};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";

.tab {
  display: flex;
  justify-content: left;
  letter-spacing: normal;
  text-transform: none;
}
</style>
