<template>
  <div class="header">
    <ul class="header__menu d-flex align-center">
      <li class="header__menu__item mr-3">
        <a href="/bong-da"><v-icon size="20" class="home">mdi-home</v-icon></a>
      </li>
      <li class="header__menu__item" v-for="(item, index) in listItem" :key="index">
        <a href="">{{ item.name }}</a>
        <ul class="header__menu__item__submenu">
          <li class="header__menu__item__submenu__item" v-for="(subItem, subIndex) in item.subItems" :key="subIndex">
            <router-link class="link" :to="subItem.link">{{ subItem.name }}</router-link>
          </li>
        </ul>
      </li>
      <li class="header__menu__item">
        <a href="#"><span>Tất cả</span><v-icon class="ico ml-1" size="19">mdi-menu</v-icon></a>
      </li>
    </ul>
  </div>
</template>
<script>
export default {
  data() {
    return {
      listItem: [
        {
          name: "Thời sự",
          subItems: [
            { name: "Chính trị", link: "/" },
            { name: "Dân sinh", link: "/" },
            { name: "Giao thông", link: "/" },
            { name: "Mekong", link: "/" },
            { name: "Quỹ Hy vọng", link: "/" },
          ],
        },
        {
          name: "Góc nhìn",
          subItems: [
            { name: "Bình luận nhiều", link: "/" },
            { name: "Covid 19", link: "/" },
            { name: "Chính trị & chính sách", link: "/" },
            { name: "Y tế & sức khoẻ", link: "/" },
            { name: "Kinh doanh & quản trị", link: "/" },
            { name: "Giáo dục & tri thức", link: "/" },
            { name: "Môi trường", link: "/" },
            { name: "Văn hoá & lỗi sống", link: "/" },
            { name: "Tác giả", link: "/" },
          ],
        },
        {
          name: "Thế giới",
          subItems: [
            { name: "Tư liệu", link: "/" },
            { name: "Phân tích", link: "/" },
            { name: "Người Việt 5 châu", link: "/" },
            { name: "Cuộc sống đó đây", link: "/" },
            { name: "Quân sự", link: "/" },
          ],
        },
        {
          name: "Video",
          subItems: [
            { name: "Thời sự", link: "/" },
            { name: "Nhịp sống", link: "/" },
            { name: "Sports Life", link: "/" },
            { name: "Food", link: "/" },
            { name: "Cuộc sống 4.0", link: "/" },
            { name: "Tôi kể", link: "/" },
            { name: "Chuyện núi rừng", link: "/" },
            { name: "Toạ đàm kinh tế", link: "/" },
            { name: "Giải trí", link: "/" },
            { name: "Du lịch", link: "/" },
            { name: "Thế giới", link: "/" },
            { name: "Pháp luật", link: "/" },
            { name: "Kinh doanh", link: "/" },
            { name: "Khoa học", link: "/" },
            { name: "Giáo dục", link: "/" },
            { name: "Sức khoẻ", link: "/" },
          ],
        },
        {
          name: "Kinh doanh",
          subItems: [
            { name: "Quốc tế", link: "/" },
            { name: "Doanh nghiệp", link: "/" },
            { name: "Chứng khoán", link: "/" },
            { name: "Bất động sản", link: "/" },
            { name: "Ebank", link: "/" },
            { name: "Vĩ mô", link: "/" },
            { name: "Tiền của tôi", link: "/" },
            { name: "Bảo hiểm", link: "/" },
            { name: "Hàng hoá", link: "/" },
            { name: "Startup", link: "/" },
            { name: "E-commerce 4.0", link: "/" },
            { name: "ViEF", link: "/" },
            { name: "Vhome", link: "/" },
            { name: "FPT eCovax", link: "/" },
            { name: "eBox", link: "/" },
          ],
        },
        {
          name: "Khoa học",
          subItems: [
            { name: "Khoa học trong nước", link: "/" },
            { name: "Tin tức", link: "/" },
            { name: "Phát minh", link: "/" },
            { name: "Ứng dụng", link: "/" },
            { name: "Thế giới tự nhiên", link: "/" },
            { name: "Thường thức", link: "/" },
          ],
        },
        {
          name: "Giải trí",
          subItems: [
            { name: "Giới sao", link: "/" },
            { name: "Video", link: "/" },
            { name: "Phim", link: "/" },
            { name: "Nhạc", link: "/" },
            { name: "Thời trang", link: "/" },
            { name: "Làm đẹp", link: "/" },
            { name: "Sách", link: "/" },
            { name: "Sân khấu - Mỹ thuật", link: "/" },
          ],
        },
        {
          name: "Thể thao",
          subItems: [
            { name: "Bóng đá", link: "/bong-da" },
            { name: "Lịch thi đấu", link: "/" },
            { name: "Tennis", link: "/" },
            { name: "VM 2021", link: "/" },
            { name: "Bundesliga", link: "/" },
            { name: "Các môn khác", link: "/" },
            { name: "World cup 2022", link: "/" },
            { name: "Hậu trường", link: "/" },
            { name: "Video", link: "/" },
            { name: "Ảnh", link: "/" },
            { name: "V-Race", link: "/" },
            { name: "Trắc nghiệm", link: "/" },
            { name: "Tường thuật", link: "/" },
          ],
        },
        {
          name: "Pháp luật",
          subItems: [
            { name: "Hồ sơ phá án", link: "/" },
            { name: "Tư vấn", link: "/" },
          ],
        },
        {
          name: "Giáo dục",
          subItems: [
            { name: "Tuyển sinh", link: "/" },
            { name: "Điểm thi", link: "/" },
            { name: "Tra cứu đại học", link: "/" },
            { name: "Du học", link: "/" },
            { name: "Học tiếng Anh", link: "/" },
            { name: "Giáo dục 4.0", link: "/" },
            { name: "Debate", link: "/" },
            { name: "EduConnect", link: "/" },
          ],
        },
        {
          name: "Sức khoẻ",
          subItems: [
            { name: "Tin tức", link: "/" },
            { name: "Tư vấn", link: "/" },
            { name: "Dinh dưỡng", link: "/" },
            { name: "Khoẻ đẹp", link: "/" },
            { name: "Đàn ông", link: "/" },
            { name: "Các bệnh", link: "/" },
            { name: "Vaccine", link: "/" },
          ],
        },
        {
          name: "Đời sống",
          subItems: [
            { name: "Tổ ấm", link: "/" },
            { name: "Bài học cuộc sống", link: "/" },
            { name: "Nhà", link: "/" },
            { name: "Tiêu dùng", link: "/" },
            { name: "Cooking", link: "/" },
          ],
        },
        {
          name: "Du lịch",
          subItems: [
            { name: "Điểm đến", link: "/" },
            { name: "Dấu chân", link: "/" },
            { name: "Tư vấn", link: "/" },
            { name: "Ảnh", link: "/" },
            { name: "Ăn và chơi", link: "/" },
          ],
        },
        {
          name: "Số hoá",
          subItems: [
            { name: "Công nghệ", link: "/" },
            { name: "Sản phẩm", link: "/" },
            { name: "Sản phẩm tôi yêu", link: "/" },
          ],
        },
        {
          name: "Xe",
          subItems: [
            { name: "Thị trường", link: "/" },
            { name: "Tư vấn", link: "/" },
            { name: "V-Car", link: "/" },
            { name: "Diễn đàn", link: "/" },
            { name: "Đánh giá", link: "/" },
            { name: "Video", link: "/" },
            { name: "Bảng giá ôtô", link: "/" },
            { name: "Xe điện", link: "/" },
            { name: "Cẩm nang mua xe", link: "/" },
            { name: "Thi bằng lái", link: "/" },
            { name: "Mua bán", link: "/" },
          ],
        },
        {
          name: "Ý kiến",
          subItems: [
            { name: "Thời sự", link: "/" },
            { name: "Đời sống", link: "/" },
          ],
        },
        {
          name: "Tâm sự",
          subItems: [
            { name: "Chuyên gia gỡ rối", link: "/" },
            { name: "Hẹn hò", link: "/" },
          ],
        },
        {
          name: "Hài",
          subItems: [
            { name: "Cười", link: "/" },
            { name: "Đố vui", link: "/" },
            { name: "Chuyện lạ", link: "/" },
            { name: "Thú cưng", link: "/" },
          ],
        },
      ],
    };
  },
};
</script>
<style lang="scss" scoped>
@import "../../../../public/style.scss";

.header {
  height: 100%;
  &__menu {
    padding: 0px;
    font-size: 14px;
    font-family: Arial, Helvetica, sans-serif;
    font-weight: 600;
    height: 100%;
    &__item:last-child {
      font-weight: 100;
      a {
        color: $light-gray-color-2;
        transition: color 0.2s linear;
      }
      .ico {
        color: $light-gray-color-2;
        transition: color 0.2s linear;
      }
    }
    &__item {
      display: inline-block;
      margin-right: 15px;
      position: relative;
      height: 100%;
      display: flex;
      align-items: center;
      .home:hover {
        color: #fff;
        background-color: #b52759;
      }
      .home {
        border: 1px solid $light-gray-color;
        border-radius: 50%;
        padding: 3px;
      }
      a {
        text-decoration: none;
        color: $primary-text-color;
        transition: color 0.5s linear;
      }
      &__submenu {
        position: absolute;
        top: 100px;
        opacity: 0;
        left: 0px;
        width: 200px;
        z-index: -100;
        border-top: solid 1px $red-brown-color;
        padding: 0;
        box-shadow: 0px 2px 6px -2px $gray-color;
        background-color: #fff;
        transition: top 0.2s 0.1s, opacity 0.25s 0.1s;
        &__item {
          padding: 10px 15px;
          font-weight: 100;
          .link {
            color: $primary-text-color !important;
          }
        }

        &__item:hover {
          text-decoration: underline;
          cursor: pointer;
        }
      }
    }
    &__item:hover {
      a {
        color: $red-brown-color;
      }
      .ico {
        color: $red-brown-color;
      }

      .header__menu__item__submenu {
        z-index: 1;
        top: 100%;
        opacity: 1;
      }
    }
  }
}
</style>
