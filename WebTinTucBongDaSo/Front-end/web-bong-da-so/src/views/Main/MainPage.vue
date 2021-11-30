<template>
  <div>
    <!-- <post-main></post-main> -->
    <div class="modal">
      <modal-sign-in></modal-sign-in>
      <post-dialog-manage></post-dialog-manage>
      <PageMangement></PageMangement>
    </div>

    <router-view />
  </div>
</template>
<script>
import PostDialogManage from "../../components/MainComponents/Post/Post-Dialog-Manage/PostDialogManage.vue";
import ModalSignIn from "../../components/Account/ModalSignIn.vue";
import PageMangement from "../../components/PageManagement/PageMangement.vue";
export default {
  components: {
    ModalSignIn,
    PostDialogManage,
    PageMangement,
  },
};
</script>
<style lang="scss" scoped>
.modal {
  position: absolute;
}
</style>
