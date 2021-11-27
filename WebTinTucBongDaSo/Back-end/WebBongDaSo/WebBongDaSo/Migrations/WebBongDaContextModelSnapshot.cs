﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBongDaSo.Entities;

namespace WebBongDaSo.Migrations
{
    [DbContext(typeof(WebBongDaContext))]
    partial class WebBongDaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBongDaSo.Entities.BaiViet", b =>
                {
                    b.Property<int>("MaBaiViet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChuDeMaChuDe")
                        .HasColumnType("int");

                    b.Property<string>("LinkAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaChuDe")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiDungTaiKhoan")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoanNguoiDang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTacGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TieuDe")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaBaiViet");

                    b.HasIndex("ChuDeMaChuDe");

                    b.HasIndex("NguoiDungTaiKhoan");

                    b.ToTable("BaiViets");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.ChuDe", b =>
                {
                    b.Property<int>("MaChuDe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoLuongBaiViet")
                        .HasColumnType("int");

                    b.Property<string>("TenChuDe")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaChuDe");

                    b.ToTable("ChuDes");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.LoaiNguoiDung", b =>
                {
                    b.Property<int>("LoaiNguoiDungId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenLoai")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("LoaiNguoiDungId");

                    b.ToTable("LoaiNguoiDungs");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.NguoiDung", b =>
                {
                    b.Property<string>("TaiKhoan")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LoaiNguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianThamGia")
                        .HasColumnType("datetime2");

                    b.HasKey("TaiKhoan");

                    b.HasIndex("LoaiNguoiDungId");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.QuyenHan", b =>
                {
                    b.Property<int>("QuyenHanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenQuyenHan")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("QuyenHanId");

                    b.ToTable("QuyenHans");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.QuyenHan_LoaiNguoiDung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoaiNguoiDungId")
                        .HasColumnType("int");

                    b.Property<int>("QuyenHanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoaiNguoiDungId");

                    b.HasIndex("QuyenHanId");

                    b.ToTable("QuyenHan_LoaiNguoiDungs");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.BaiViet", b =>
                {
                    b.HasOne("WebBongDaSo.Entities.ChuDe", "ChuDe")
                        .WithMany("BaiViets")
                        .HasForeignKey("ChuDeMaChuDe");

                    b.HasOne("WebBongDaSo.Entities.NguoiDung", "NguoiDung")
                        .WithMany("BaiViets")
                        .HasForeignKey("NguoiDungTaiKhoan");

                    b.Navigation("ChuDe");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.NguoiDung", b =>
                {
                    b.HasOne("WebBongDaSo.Entities.LoaiNguoiDung", "LoaiNguoiDung")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("LoaiNguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiNguoiDung");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.QuyenHan_LoaiNguoiDung", b =>
                {
                    b.HasOne("WebBongDaSo.Entities.LoaiNguoiDung", "LoaiNguoiDung")
                        .WithMany("QuyenHan_LoaiNguoiDungs")
                        .HasForeignKey("LoaiNguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebBongDaSo.Entities.QuyenHan", "QuyenHan")
                        .WithMany("QuyenHan_LoaiNguoiDungs")
                        .HasForeignKey("QuyenHanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiNguoiDung");

                    b.Navigation("QuyenHan");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.ChuDe", b =>
                {
                    b.Navigation("BaiViets");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.LoaiNguoiDung", b =>
                {
                    b.Navigation("NguoiDungs");

                    b.Navigation("QuyenHan_LoaiNguoiDungs");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.NguoiDung", b =>
                {
                    b.Navigation("BaiViets");
                });

            modelBuilder.Entity("WebBongDaSo.Entities.QuyenHan", b =>
                {
                    b.Navigation("QuyenHan_LoaiNguoiDungs");
                });
#pragma warning restore 612, 618
        }
    }
}
