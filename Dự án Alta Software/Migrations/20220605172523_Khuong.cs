using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dự_án_Alta_Software.Migrations
{
    public partial class Khuong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiBaiKiemTra",
                columns: table => new
                {
                    id_loaibaikiemtra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    baikiemtrasaptoi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    baidahoanthanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    baichuahoanthanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBaiKiemTra", x => x.id_loaibaikiemtra);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyen",
                columns: table => new
                {
                    id_quyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenquyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyen", x => x.id_quyen);
                });

            migrationBuilder.CreateTable(
                name: "BaiKiemTra",
                columns: table => new
                {
                    id_baikiemtra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenmon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    noidungkiemtra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    giangvien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ngaylambai = table.Column<DateTime>(type: "datetime2", nullable: false),
                    thoigian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tinhtrang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    bailam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LoaiBaiKiemTraid_loaibaikiemtra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiKiemTra", x => x.id_baikiemtra);
                    table.ForeignKey(
                        name: "FK_BaiKiemTra_LoaiBaiKiemTra_LoaiBaiKiemTraid_loaibaikiemtra",
                        column: x => x.LoaiBaiKiemTraid_loaibaikiemtra,
                        principalTable: "LoaiBaiKiemTra",
                        principalColumn: "id_loaibaikiemtra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    id_taikhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tentaikhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    matkhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhanQuyenid_quyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.id_taikhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_PhanQuyen_PhanQuyenid_quyen",
                        column: x => x.PhanQuyenid_quyen,
                        principalTable: "PhanQuyen",
                        principalColumn: "id_quyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    id_monhoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenmonhoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaiKiemTraid_baikiemtra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.id_monhoc);
                    table.ForeignKey(
                        name: "FK_MonHoc_BaiKiemTra_BaiKiemTraid_baikiemtra",
                        column: x => x.BaiKiemTraid_baikiemtra,
                        principalTable: "BaiKiemTra",
                        principalColumn: "id_baikiemtra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    id_giangvien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tengiangvien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sdt = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiKhoanid_taikhoan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.id_giangvien);
                    table.ForeignKey(
                        name: "FK_GiangVien_TaiKhoan_TaiKhoanid_taikhoan",
                        column: x => x.TaiKhoanid_taikhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "id_taikhoan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    id_hocsinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    namsinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sdt = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaiKhoanid_taikhoan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.id_hocsinh);
                    table.ForeignKey(
                        name: "FK_HocSinh_TaiKhoan_TaiKhoanid_taikhoan",
                        column: x => x.TaiKhoanid_taikhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "id_taikhoan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    id_diem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenmonhoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tengiangvien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    diemchuyencan = table.Column<double>(type: "float", nullable: false),
                    kiemtramieng = table.Column<double>(type: "float", nullable: false),
                    heso2 = table.Column<double>(type: "float", nullable: false),
                    heso3 = table.Column<double>(type: "float", nullable: false),
                    diemtrungbinh = table.Column<double>(type: "float", nullable: false),
                    diemtongket = table.Column<double>(type: "float", nullable: false),
                    ketqua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    danhgia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ngaycapnhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonHocid_monhoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem", x => x.id_diem);
                    table.ForeignKey(
                        name: "FK_Diem_MonHoc_MonHocid_monhoc",
                        column: x => x.MonHocid_monhoc,
                        principalTable: "MonHoc",
                        principalColumn: "id_monhoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    id_lophoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenlophoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thoigian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    chude = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    monhoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    giangvien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    trangthai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    link_online = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    matkhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MonHocid_monhoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.id_lophoc);
                    table.ForeignKey(
                        name: "FK_LopHoc_MonHoc_MonHocid_monhoc",
                        column: x => x.MonHocid_monhoc,
                        principalTable: "MonHoc",
                        principalColumn: "id_monhoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    id_phancong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenbang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    thoigian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sotiet = table.Column<int>(type: "int", nullable: false),
                    GiangVienid_giangvien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => x.id_phancong);
                    table.ForeignKey(
                        name: "FK_PhanCong_GiangVien_GiangVienid_giangvien",
                        column: x => x.GiangVienid_giangvien,
                        principalTable: "GiangVien",
                        principalColumn: "id_giangvien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiLieu",
                columns: table => new
                {
                    id_tailieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tentailieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sotrang = table.Column<int>(type: "int", nullable: false),
                    noidung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nguoibiensoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiangVienid_giangvien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiLieu", x => x.id_tailieu);
                    table.ForeignKey(
                        name: "FK_TaiLieu_GiangVien_GiangVienid_giangvien",
                        column: x => x.GiangVienid_giangvien,
                        principalTable: "GiangVien",
                        principalColumn: "id_giangvien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietLopHoc",
                columns: table => new
                {
                    LopHocid_lophoc = table.Column<int>(type: "int", nullable: false),
                    lopsapmo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lopdahoanthanh = table.Column<int>(type: "int", nullable: false),
                    lopchuahoanthanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ChiTietLopHoc_LopHoc_LopHocid_lophoc",
                        column: x => x.LopHocid_lophoc,
                        principalTable: "LopHoc",
                        principalColumn: "id_lophoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    id_khoahoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkhoahoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayketthuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hocky = table.Column<int>(type: "int", nullable: false),
                    LopHocid_lophoc = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanid_taikhoan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.id_khoahoc);
                    table.ForeignKey(
                        name: "FK_KhoaHoc_LopHoc_LopHocid_lophoc",
                        column: x => x.LopHocid_lophoc,
                        principalTable: "LopHoc",
                        principalColumn: "id_lophoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoaHoc_TaiKhoan_TaiKhoanid_taikhoan",
                        column: x => x.TaiKhoanid_taikhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "id_taikhoan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoiLop",
                columns: table => new
                {
                    id_khoilop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkhoi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LopHocid_lophoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoiLop", x => x.id_khoilop);
                    table.ForeignKey(
                        name: "FK_KhoiLop_LopHoc_LopHocid_lophoc",
                        column: x => x.LopHocid_lophoc,
                        principalTable: "LopHoc",
                        principalColumn: "id_lophoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTaiLieu",
                columns: table => new
                {
                    id_loaitailieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tentailieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false),
                    TaiLieuid_tailieu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTaiLieu", x => x.id_loaitailieu);
                    table.ForeignKey(
                        name: "FK_LoaiTaiLieu_TaiLieu_TaiLieuid_tailieu",
                        column: x => x.TaiLieuid_tailieu,
                        principalTable: "TaiLieu",
                        principalColumn: "id_tailieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiKiemTra_LoaiBaiKiemTraid_loaibaikiemtra",
                table: "BaiKiemTra",
                column: "LoaiBaiKiemTraid_loaibaikiemtra");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietLopHoc_LopHocid_lophoc",
                table: "ChiTietLopHoc",
                column: "LopHocid_lophoc");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_MonHocid_monhoc",
                table: "Diem",
                column: "MonHocid_monhoc");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_TaiKhoanid_taikhoan",
                table: "GiangVien",
                column: "TaiKhoanid_taikhoan");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_TaiKhoanid_taikhoan",
                table: "HocSinh",
                column: "TaiKhoanid_taikhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_LopHocid_lophoc",
                table: "KhoaHoc",
                column: "LopHocid_lophoc");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_TaiKhoanid_taikhoan",
                table: "KhoaHoc",
                column: "TaiKhoanid_taikhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhoiLop_LopHocid_lophoc",
                table: "KhoiLop",
                column: "LopHocid_lophoc");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiTaiLieu_TaiLieuid_tailieu",
                table: "LoaiTaiLieu",
                column: "TaiLieuid_tailieu");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MonHocid_monhoc",
                table: "LopHoc",
                column: "MonHocid_monhoc");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_BaiKiemTraid_baikiemtra",
                table: "MonHoc",
                column: "BaiKiemTraid_baikiemtra");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_GiangVienid_giangvien",
                table: "PhanCong",
                column: "GiangVienid_giangvien");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_PhanQuyenid_quyen",
                table: "TaiKhoan",
                column: "PhanQuyenid_quyen");

            migrationBuilder.CreateIndex(
                name: "IX_TaiLieu_GiangVienid_giangvien",
                table: "TaiLieu",
                column: "GiangVienid_giangvien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietLopHoc");

            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "KhoiLop");

            migrationBuilder.DropTable(
                name: "LoaiTaiLieu");

            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "TaiLieu");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "BaiKiemTra");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "LoaiBaiKiemTra");

            migrationBuilder.DropTable(
                name: "PhanQuyen");
        }
    }
}
