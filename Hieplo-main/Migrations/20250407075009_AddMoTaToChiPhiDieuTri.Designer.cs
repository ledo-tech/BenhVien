﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyBenhVienNoiTru.Data;

#nullable disable

namespace QuanLyBenhVienNoiTru.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250407075009_AddMoTaToChiPhiDieuTri")]
    partial class AddMoTaToChiPhiDieuTri
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BacSi", b =>
                {
                    b.Property<int>("MaBacSi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBacSi"));

                    b.Property<string>("ChuyenKhoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaKhoa")
                        .HasColumnType("int");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayNghiViec")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVaoLam")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaBacSi");

                    b.HasIndex("MaKhoa");

                    b.HasIndex("MaTaiKhoan")
                        .IsUnique()
                        .HasFilter("[MaTaiKhoan] IS NOT NULL");

                    b.ToTable("BacSis");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BenhNhan", b =>
                {
                    b.Property<int>("MaBenhNhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBenhNhan"));

                    b.Property<int?>("BacSiMaBacSi")
                        .HasColumnType("int");

                    b.Property<bool>("BaoHiemYTe")
                        .HasColumnType("bit");

                    b.Property<string>("ChanDoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GiuongMaGiuong")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaBacSi")
                        .HasColumnType("int");

                    b.Property<int>("MaKhoa")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhapVien")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXuatVien")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaBenhNhan");

                    b.HasIndex("BacSiMaBacSi");

                    b.HasIndex("MaBacSi");

                    b.HasIndex("MaKhoa");

                    b.ToTable("BenhNhans");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.ChiPhiDieuTri", b =>
                {
                    b.Property<int>("MaChiPhi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiPhi"));

                    b.Property<bool>("DaThanhToan")
                        .HasColumnType("bit");

                    b.Property<int?>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongChiPhi")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaChiPhi");

                    b.HasIndex("MaBenhNhan");

                    b.ToTable("ChiPhiDieuTris");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.DieuTriBenhNhan", b =>
                {
                    b.Property<int>("MaDieuTriBenhNhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDieuTriBenhNhan"));

                    b.Property<string>("KetQua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaBacSi")
                        .HasColumnType("int");

                    b.Property<int?>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int?>("MaDieuTri")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayThucHien")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDieuTriBenhNhan");

                    b.HasIndex("MaBacSi");

                    b.HasIndex("MaBenhNhan");

                    b.HasIndex("MaDieuTri");

                    b.ToTable("DieuTriBenhNhans");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.Giuong", b =>
                {
                    b.Property<int>("MaGiuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGiuong"));

                    b.Property<decimal>("GiaTheoNgay")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("KhoaMaKhoa")
                        .HasColumnType("int");

                    b.Property<int?>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int>("MaKhoa")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenGiuong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaGiuong");

                    b.HasIndex("KhoaMaKhoa");

                    b.HasIndex("MaBenhNhan")
                        .IsUnique()
                        .HasFilter("[MaBenhNhan] IS NOT NULL");

                    b.HasIndex("MaKhoa");

                    b.ToTable("Giuongs");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.HinhThucDieuTri", b =>
                {
                    b.Property<int>("MaDieuTri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDieuTri"));

                    b.Property<int?>("BacSiMaBacSi")
                        .HasColumnType("int");

                    b.Property<int?>("BenhNhanMaBenhNhan")
                        .HasColumnType("int");

                    b.Property<decimal>("ChiPhi")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("MaKhoa")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenDieuTri")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaDieuTri");

                    b.HasIndex("BacSiMaBacSi");

                    b.HasIndex("BenhNhanMaBenhNhan");

                    b.HasIndex("MaKhoa");

                    b.ToTable("HinhThucDieuTris", (string)null);
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.KhachThamBenh", b =>
                {
                    b.Property<int>("MaKhach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhach"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("MoiQuanHe")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhach");

                    b.HasIndex("MaTaiKhoan")
                        .IsUnique()
                        .HasFilter("[MaTaiKhoan] IS NOT NULL");

                    b.ToTable("KhachThamBenhs");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.Khoa", b =>
                {
                    b.Property<int>("MaKhoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhoa"));

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKhoa");

                    b.ToTable("Khoas");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.LichThamBenh", b =>
                {
                    b.Property<int>("MaLich")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLich"));

                    b.Property<int?>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int?>("MaKhach")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ThoiGianTham")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLich");

                    b.HasIndex("MaBenhNhan");

                    b.HasIndex("MaKhach");

                    b.ToTable("LichThamBenhs");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTaiKhoan"));

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTaiKhoan");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BacSi", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.Khoa", "Khoa")
                        .WithMany("BacSis")
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyBenhVienNoiTru.Models.TaiKhoan", "TaiKhoan")
                        .WithOne("BacSi")
                        .HasForeignKey("QuanLyBenhVienNoiTru.Models.BacSi", "MaTaiKhoan")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Khoa");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BenhNhan", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.BacSi", null)
                        .WithMany("BenhNhans")
                        .HasForeignKey("BacSiMaBacSi");

                    b.HasOne("QuanLyBenhVienNoiTru.Models.BacSi", "BacSi")
                        .WithMany()
                        .HasForeignKey("MaBacSi")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("QuanLyBenhVienNoiTru.Models.Khoa", "Khoa")
                        .WithMany("BenhNhans")
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BacSi");

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.ChiPhiDieuTri", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.BenhNhan", "BenhNhan")
                        .WithMany("ChiPhiDieuTris")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("BenhNhan");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.DieuTriBenhNhan", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.BacSi", "BacSi")
                        .WithMany("DieuTriBenhNhans")
                        .HasForeignKey("MaBacSi")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("QuanLyBenhVienNoiTru.Models.BenhNhan", "BenhNhan")
                        .WithMany("DieuTriBenhNhans")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuanLyBenhVienNoiTru.Models.HinhThucDieuTri", "HinhThucDieuTri")
                        .WithMany("DieuTriBenhNhans")
                        .HasForeignKey("MaDieuTri")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("BacSi");

                    b.Navigation("BenhNhan");

                    b.Navigation("HinhThucDieuTri");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.Giuong", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.Khoa", null)
                        .WithMany("Giuongs")
                        .HasForeignKey("KhoaMaKhoa");

                    b.HasOne("QuanLyBenhVienNoiTru.Models.BenhNhan", "BenhNhan")
                        .WithOne()
                        .HasForeignKey("QuanLyBenhVienNoiTru.Models.Giuong", "MaBenhNhan")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("QuanLyBenhVienNoiTru.Models.Khoa", "Khoa")
                        .WithMany()
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BenhNhan");

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.HinhThucDieuTri", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.BacSi", null)
                        .WithMany("HinhThucDieuTris")
                        .HasForeignKey("BacSiMaBacSi");

                    b.HasOne("QuanLyBenhVienNoiTru.Models.BenhNhan", null)
                        .WithMany("HinhThucDieuTris")
                        .HasForeignKey("BenhNhanMaBenhNhan");

                    b.HasOne("QuanLyBenhVienNoiTru.Models.Khoa", "Khoa")
                        .WithMany("HinhThucDieuTris")
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.KhachThamBenh", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.TaiKhoan", "TaiKhoan")
                        .WithOne("KhachThamBenh")
                        .HasForeignKey("QuanLyBenhVienNoiTru.Models.KhachThamBenh", "MaTaiKhoan")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.LichThamBenh", b =>
                {
                    b.HasOne("QuanLyBenhVienNoiTru.Models.BenhNhan", "BenhNhan")
                        .WithMany("LichThamBenhs")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuanLyBenhVienNoiTru.Models.KhachThamBenh", "KhachThamBenh")
                        .WithMany("LichThamBenhs")
                        .HasForeignKey("MaKhach")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("BenhNhan");

                    b.Navigation("KhachThamBenh");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BacSi", b =>
                {
                    b.Navigation("BenhNhans");

                    b.Navigation("DieuTriBenhNhans");

                    b.Navigation("HinhThucDieuTris");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.BenhNhan", b =>
                {
                    b.Navigation("ChiPhiDieuTris");

                    b.Navigation("DieuTriBenhNhans");

                    b.Navigation("HinhThucDieuTris");

                    b.Navigation("LichThamBenhs");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.HinhThucDieuTri", b =>
                {
                    b.Navigation("DieuTriBenhNhans");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.KhachThamBenh", b =>
                {
                    b.Navigation("LichThamBenhs");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.Khoa", b =>
                {
                    b.Navigation("BacSis");

                    b.Navigation("BenhNhans");

                    b.Navigation("Giuongs");

                    b.Navigation("HinhThucDieuTris");
                });

            modelBuilder.Entity("QuanLyBenhVienNoiTru.Models.TaiKhoan", b =>
                {
                    b.Navigation("BacSi");

                    b.Navigation("KhachThamBenh");
                });
#pragma warning restore 612, 618
        }
    }
}
