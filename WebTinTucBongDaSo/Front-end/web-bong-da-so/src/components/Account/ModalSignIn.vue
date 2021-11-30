<template>
  <v-row justify="center">
    <v-dialog v-model="dialog" max-width="750">
      <v-card class="pb-4">
        <v-tabs v-model="tab" background-color="transparent" color="#b52759" grow>
          <v-tab class="tabs" v-for="item in items" :key="item">
            {{ item }}
          </v-tab>
        </v-tabs>

        <v-tabs-items v-model="tab">
          <v-tab-item>
            <v-card color="basil" flat>
              <sign-in-tab></sign-in-tab>
            </v-card>
          </v-tab-item>
          <v-tab-item>
            <v-card color="basil" flat>
              <sign-up-tab></sign-up-tab>
            </v-card>
          </v-tab-item>
        </v-tabs-items>
      </v-card>
    </v-dialog>
  </v-row>
</template>
<script>
import SignInTab from "../Account/SignInTab.vue";
import SignUpTab from "../Account/SignUpTab.vue";
import { eventBus } from "../../main";
export default {
  created() {
    eventBus.$on("openModalSignIn", this.openModalSignIn);
    eventBus.$on("LoginSuccess", this.LoginSuccess);
  },
  components: {
    SignInTab,
    SignUpTab,
  },
  data() {
    return {
      dialog: false,
      tab: null,
      items: ["Đăng nhập", "Tạo tài khoản"],
    };
  },
  methods: {
    openModalSignIn() {
      this.dialog = !this.dialog;
    },
    LoginSuccess() {
      this.dialog = false;
    },
  },
};
</script>
<style lang="scss" scoped>
@import "../../../public/style.scss";
.tabs {
  text-transform: none;
  letter-spacing: normal;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 18px;
  font-weight: 600;
}
</style>
