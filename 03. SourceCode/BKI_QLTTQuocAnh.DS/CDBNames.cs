﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_QLTTQuocAnh.DS.CDBNames
{
    public class DM_SO_PHIEU_THU {
        public const string ID = "ID";
        public const string MA_SO_QUYEN = "MA_SO_QUYEN";
        public const string TEN_SO = "TEN_SO";
        public const string TU_SO = "TU_SO";
        public const string DEN_SO = "DEN_SO";
        public const string THOI_GIAN_BAT_DAU_SU_DUNG = "THOI_GIAN_BAT_DAU_SU_DUNG";
        public const string THOI_GIAN_KET_THUC_SD = "THOI_GIAN_KET_THUC_SD";
        public const string IS_DELETED = "IS_DELETED";
        public const string IS_ACTIVE = "IS_ACTIVE";
        public const string MO_TA = "MO_TA";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class MAX_SO_PHIEU_THEO_THANG {
        public const string ID = "ID";
        public const string THANG = "THANG";
        public const string ID_LOAI_PHIEU = "ID_LOAI_PHIEU";
        public const string TIEN_TO_PHIEU = "TIEN_TO_PHIEU";
        public const string MAX_SO_PHIEU = "MAX_SO_PHIEU";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class EXCEL_IMPORT_HOC_VIEN {
        public const string STT = "STT";
        public const string MA_HOC_VIEN = "MA_HOC_VIEN";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string SĐT = "SĐT";
        public const string EMAIL = "EMAIL";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string FACEBOOK = "FACEBOOK";
    }

    public class V_DM_HOC_SINH_GD_HOC_DM_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_LOAI_DOI_TUONG = "ID_LOAI_DOI_TUONG";
        public const string TEN_LOAI_DOI_TUONG = "TEN_LOAI_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
        public const string FACEBOOK = "FACEBOOK";
        public const string SKYPE = "SKYPE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string DELETE_YN = "DELETE_YN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TRANG_THAI_LOP_MON = "TRANG_THAI_LOP_MON";
        public const string TONG_SO_BUOI_HOC = "TONG_SO_BUOI_HOC";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string THOI_GIAN_HOC_TO_DATE = "THOI_GIAN_HOC_TO_DATE";
        public const string MOT_NAM_SAU_NGAY_KET_THUC = "MOT_NAM_SAU_NGAY_KET_THUC";
        public const string ID_TRO_GIANG = "ID_TRO_GIANG";
        public const string GHI_CHU = "GHI_CHU";
        public const string TONG_TIEN_KHOA_HOC = "TONG_TIEN_KHOA_HOC";
        public const string ID_GD_HOC = "ID_GD_HOC";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
    }

    public class V_RPT_F460_TINH_HINH_BO_LOP
    {
        public const string ID = "ID";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN = "HO_TEN";
    }

    public class V_F340_LOP_MON_CUA_HS {
        public const string ID = "ID";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class GD_CHI_TIET_PHIEU_THU {
        public const string ID = "ID";
        public const string ID_GD_PHIEU_THU = "ID_GD_PHIEU_THU";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class V_RPT_BAO_CAO_TINH_HINH_DI_HOC
    {
        public const string ID = "ID";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN = "HO_TEN";
        public const string TONG_SO_BUOI_DI_HOC = "TONG_SO_BUOI_DI_HOC";
    }

    public class V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TONG_SO_HS = "TONG_SO_HS";
    }

    public class V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_LOAI_DOI_TUONG = "ID_LOAI_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string TIEN_CON_PHAI_THU = "TIEN_CON_PHAI_THU";
    }

    public class V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string TIEN_CON_PHAI_THU = "TIEN_CON_PHAI_THU";
    }

    public class V_DM_HOC_SINH
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string ID_GD_HOC = "ID_GD_HOC";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string TRANG_THAI_HS = "TRANG_THAI_HS";
    }


    public class V_HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
    }


    public class V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string TONG_PHAI_THU = "TONG_PHAI_THU";
        public const string TONG_GIAM_TRU = "TONG_GIAM_TRU";
        public const string TONG_THUC_THU = "TONG_THUC_THU";
        public const string TONG_CON_NO = "TONG_CON_NO";
    }


    public class V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO_TEN = "HO_TEN";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string TONG_PHAI_THU = "TONG_PHAI_THU";
        public const string TONG_GIAM_TRU = "TONG_GIAM_TRU";
        public const string TONG_THUC_THU = "TONG_THUC_THU";
        public const string TONG_CON_NO = "TONG_CON_NO";
    }

    public class HT_FORM {
        public const string ID =  "ID";
        public const string FORM_NAME =  "FORM_NAME";
        public const string DISPLAY_NAME =  "DISPLAY_NAME";
    }

    public class V_HT_CONTROL_IN_FORM {
        public const string ID =  "ID";
        public const string FORM_NAME =  "FORM_NAME";
        public const string DISPLAY_NAME =  "DISPLAY_NAME";
        public const string CONTROL_NAME =  "CONTROL_NAME";
        public const string CONTROL_TYPE =  "CONTROL_TYPE";
        public const string MA_TU_DIEN =  "MA_TU_DIEN";
        public const string ID_TU_DIEN =  "ID_TU_DIEN";
    }

    
    public enum e_loai_tu_dien
    {
        PHAN_QUYEN = 1
       ,
        DIA_DIEM_QUAN_LY = 2
            ,
        DON_VI_QUAN_LY_CHINH = 3
            ,
        LEVEL_GIANG_VIEN = 4
            ,
        LOAI_HOP_DONG = 5
            ,
        NGANH_DAO_TAO = 6
            ,
        DON_VI_TINH = 7
            ,
        TRANG_THAI_HOP_DONG_KHUNG = 8
            ,
        TRANG_THAI_GIANG_VIEN = 9
            ,
        MA_TAN_SUAT = 10
            ,
        HOC_HAM = 11
            ,
        HOC_VI = 12
            ,
        HINH_THUC_CONG_TAC = 13
            ,
        TRANG_THAI_DOT_THANH_TOAN = 14
            ,
        TRANG_THAI_THANH_TOAN = 15
            ,
        TRANG_THAI_TT_HOP_DONG = 17
            ,
        VAI_TRO_GV = 18
            ,
        LOAI_SU_KIEN = 19
            ,
        TRANG_THAI_SU_KIEN = 20
            ,
        TRANG_THAI_CONG_VIEC_GV = 21
            ,
        TRANG_THAI_HO_SO_GV = 23
            ,
        TRANG_THAI_SU_KIEN_GV = 24
            ,
        LOAI_HO_SO_GV_CM = 25
            ,
        LOAI_HO_SO_GV_HD = 26
            ,
        DV_TO_CHUC_SK = 27
    }

    public class LOAI_TU_DIEN
    {
        public const string PHAN_QUYEN = "PHAN_QUYEN";
        public const string DIA_DIEM_QUAN_LY = "DIA_DIEM_QUAN_LY";
        public const string DON_VI_QUAN_LY_CHINH = "DON_VI_QUAN_LY_CHINH";
        public const string LEVEL_GIANG_VIEN = "LEVEL_GIANG_VIEN";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string TRANG_THAI_HOP_DONG_KHUNG = "TRANG_THAI_HOP_DONG_KHUNG";
        public const string TRANG_THAI_GIANG_VIEN = "TRANG_THAI_GIANG_VIEN";
        public const string HINH_THUC_CONG_TAC = "HINH_THUC_CONG_TAC";
        public const string TRANG_THAI_DOT_THANH_TOAN = "TRANG_THAI_DOT_THANH_TOAN";
        public const string TRANG_THAI_THANH_TOAN = "TRANG_THAI_THANH_TOAN";
        public const string TRANG_THAI_SU_KIEN = "TRANG_THAI_SU_KIEN";
        public const string TRANG_THAI_CONG_VIEC_GV = "TRANG_THAI_CONG_VIEC_GV";
        public const string TRANG_THAI_SU_KIEN_GV = "TRANG_THAI_SU_KIEN_GV";

    }

    public enum e_user_group
    {
        TESTER = 1
        ,
        PM_TD = 2
            ,
        TRUONG_NHOM_PO = 3
            ,
        PO = 4
            ,
        ADMIN = 5
            ,
        GIANG_VIEN = 6
    }


    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }

    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }

    
    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }

    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
    }

    public class HT_CHUC_NANG
    {
        public const string ID = "ID";
        public const string TEN_CHUC_NANG = "TEN_CHUC_NANG";
        public const string URL_FORM = "URL_FORM";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string VI_TRI = "VI_TRI";
        public const string CHUC_NANG_PARENT_ID = "CHUC_NANG_PARENT_ID";
        public const string HIEN_THI_YN = "HIEN_THI_YN";
    }
    public class HT_QUYEN_GROUP
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_USER_GROUP
    {
        public const string ID = "ID";
        public const string USER_GROUP_NAME = "USER_GROUP_NAME";
        public const string DESCRIPTION = "DESCRIPTION";
    }

  
    public class CM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string COMPANY_NAME = "COMPANY_NAME";
        public const string COMPANY_ADDRESS = "COMPANY_ADDRESS";
    }

    public class DM_COMPANY_INFO {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }

    public class DM_HOC_SINH {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_LOAI_DOI_TUONG = "ID_LOAI_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
        public const string NGAY_SINH = "NGAY_SINH";
    }



    public class GD_DIEM_DANH {
        public const string ID = "ID";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string ID_NGUOI_NHAP = "ID_NGUOI_NHAP";
        public const string ID_NGUOI_DIEM_DANH = "ID_NGUOI_DIEM_DANH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string NGAY_HOC = "NGAY_HOC";
        public const string ID_CA_HOC = "ID_CA_HOC";
    }

    public class GD_HOC {
        public const string ID = "ID";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
    }

    public class GD_PHIEU_THU
    {
        public const string ID = "ID";
        public const string SO_PHIEU = "SO_PHIEU";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string ID_NGUOI_NHAP = "ID_NGUOI_NHAP";
        public const string TEN_NGUOI_NOP_TIEN = "TEN_NGUOI_NOP_TIEN";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_THU = "NGAY_THU";
        public const string NGAY_NHAP = "NGAY_NHAP";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string ID_GD_HOC = "ID_GD_HOC";
        public const string ID_SO_PHIEU_THU = "ID_SO_PHIEU_THU";
        public const string GHI_CHU = "GHI_CHU";
        public const string LAN_THU = "LAN_THU";
    }

    public class V_GD_PHIEU_THU {
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_LOAI_DOI_TUONG = "ID_LOAI_DOI_TUONG";
        public const string TEN_LOAI_DOI_TUONG = "TEN_LOAI_DOI_TUONG";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string ID = "ID";
        public const string SO_PHIEU = "SO_PHIEU";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string TEN_NGUOI_THU = "TEN_NGUOI_THU";
        public const string ID_NGUOI_NHAP = "ID_NGUOI_NHAP";
        public const string TEN_NGUOI_NHAP = "TEN_NGUOI_NHAP";
        public const string TEN_NGUOI_NOP_TIEN = "TEN_NGUOI_NOP_TIEN";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_THU = "NGAY_THU";
        public const string NGAY_NHAP = "NGAY_NHAP";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string MA_LOAI_PHIEU_THU = "MA_LOAI_PHIEU_THU";
        public const string TEN_LOAI_PHIEU_THU = "TEN_LOAI_PHIEU_THU";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TEN = "TEN";
        public const string LAN_THU = "LAN_THU";
        public const string ID_SO_PHIEU_THU = "ID_SO_PHIEU_THU";
        public const string GHI_CHU = "GHI_CHU";
    }


    public class V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON
    {
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TONG_TIEN_PHAI_THU = "TONG_TIEN_PHAI_THU";
    }

    public class V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU {
        public const string ID = "ID";
        public const string NGAY_THU = "NGAY_THU";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string TEN_LOAI_PHIEU_THU = "TEN_LOAI_PHIEU_THU";
        public const string SO_PHIEU = "SO_PHIEU";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN_HS = "HO_TEN_HS";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string TEN_NGUOI_THU = "TEN_NGUOI_THU";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string TIEN_CON_PHAI_THU = "TIEN_CON_PHAI_THU";
        public const string MA_SO_QUYEN = "MA_SO_QUYEN";
    }



    public class V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS
    {
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string HO_TEN = "HO_TEN";
        public const string PHAI_THU = "PHAI_THU";
        public const string THUC_THU = "THUC_THU";
        public const string GIAM_TRU = "GIAM_TRU";
        public const string CON_PHAI_THU = "CON_PHAI_THU";
    }

    public class V_RPT_NGHIEP_VU_LAP_PHIEU_THU
    {
        public const string SO_PHIEU = "SO_PHIEU";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN_HOC_SINH = "HO_TEN_HOC_SINH";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string NGUOI_THU = "NGUOI_THU";
        public const string ID_NGUOI_NHAP = "ID_NGUOI_NHAP";
        public const string NGUOI_NHAP = "NGUOI_NHAP";
        public const string TEN_NGUOI_NOP_TIEN = "TEN_NGUOI_NOP_TIEN";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_THU = "NGAY_THU";
        public const string NGAY_NHAP = "NGAY_NHAP";
    }
    public class V_PHIEU_THU
    {
        public const string SO_PHIEU = "SO_PHIEU";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string TEN_HOC_SINH = "TEN_HOC_SINH";
        public const string TEN_NGUOI_NOP_TIEN = "TEN_NGUOI_NOP_TIEN";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string TEN = "TEN";
        public const string NGAY_THU = "NGAY_THU";
        public const string TRANG_THAI = "TRANG_THAI";
    }

    public class V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string ID_LOAI_DOI_TUONG = "ID_LOAI_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string TIEN_CON_PHAI_THU = "TIEN_CON_PHAI_THU";
    }

    public class DM_LOP_MON {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string TRANG_THAI_LOP_MON = "TRANG_THAI_LOP_MON";
        public const string TONG_SO_BUOI_HOC = "TONG_SO_BUOI_HOC";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string THOI_GIAN_HOC_TO_DATE = "THOI_GIAN_HOC_TO_DATE";
        public const string ID_TRO_GIANG = "ID_TRO_GIANG";
        public const string GHI_CHU = "GHI_CHU";
        public const string TONG_TIEN_KHOA_HOC = "TONG_TIEN_KHOA_HOC";
    }

    public class V_GD_HOC {
        public const string ID = "ID";
        public const string TEN_LOP = "TEN_LOP";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string TRANG_THAI_HOC = "TRANG_THAI_HOC";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string MO_TA = "MO_TA";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string SDT_HS = "SDT_HS";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string FACEBOOK = "FACEBOOK";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string DIA_CHI = "DIA_CHI";
    }


    public class V_F316_DM_HOC_SINH_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string ID_GD_HOC = "ID_GD_HOC";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string TRANG_THAI_HS = "TRANG_THAI_HS";
    }
    public class V_HOC_SINH
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
    }

    public class V_RPT_210_DM_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TRANG_THAI_LOP_MON = "TRANG_THAI_LOP_MON";
        public const string TEN = "TEN";
    }

    public class V_RPT_F496_BAO_CAO_SO_GIAO_DICH_THEO_LOP
    {
        public const string ID = "ID";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string CAN_PHAI_THU = "CAN_PHAI_THU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string CHENH_LECH = "CHENH_LECH";
        public const string NGAY_THU_L1 = "NGAY_THU_L1";
        public const string SO_TIEN_L1 = "SO_TIEN_L1";
        public const string NGAY_THU_L2 = "NGAY_THU_L2";
        public const string SO_TIEN_L2 = "SO_TIEN_L2";
        public const string NGAY_THU_L3 = "NGAY_THU_L3";
        public const string SO_TIEN_L3 = "SO_TIEN_L3";
    }

    public class V_RPT_F410_BAO_CAO_TAI_CHINH_THEO_LOP
    {
        public const string ID_LOP_MON = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string CON_PHAI_THU = "CON_PHAI_THU";
    }

    public class V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU2
    {
        public const string ID = "ID";
        public const string NGAY_THU = "NGAY_THU";
        public const string ID_LOAI_PHIEU_THU = "ID_LOAI_PHIEU_THU";
        public const string TEN_LOAI_PHIEU_THU = "TEN_LOAI_PHIEU_THU";
        public const string SO_PHIEU = "SO_PHIEU";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_HOC_SINH = "MA_HOC_SINH";
        public const string HO_TEN_HS = "HO_TEN_HS";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string ID_NGUOI_THU = "ID_NGUOI_THU";
        public const string TEN_NGUOI_THU = "TEN_NGUOI_THU";
        public const string SO_TIEN = "SO_TIEN";
    }

    public class V_F500_BAO_CAO_LUY_KE_THEO_LOP_THEO_THANG
    {
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string CAN_PHAI_THU = "CAN_PHAI_THU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string CON_PHAI_THU = "CON_PHAI_THU";
        public const string PHAN_TRAM_HOAN_THANH = "PHAN_TRAM_HOAN_THANH";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string NGAY_KET_THUC_THANG_1 = "NGAY_KET_THUC_THANG_1";
        public const string TIEN_THUC_THU_LUY_KE_THANG_1 = "TIEN_THUC_THU_LUY_KE_THANG_1";
        public const string NGAY_KET_THUC_THANG_2 = "NGAY_KET_THUC_THANG_2";
        public const string TIEN_THUC_THU_LUY_KE_THANG_2 = "TIEN_THUC_THU_LUY_KE_THANG_2";
        public const string NGAY_KET_THUC_THANG_3 = "NGAY_KET_THUC_THANG_3";
        public const string TIEN_THUC_THU_LUY_KE_THANG_3 = "TIEN_THUC_THU_LUY_KE_THANG_3";
        public const string NGAY_KET_THUC_THANG_4 = "NGAY_KET_THUC_THANG_4";
        public const string TIEN_THUC_THU_LUY_KE_THANG_4 = "TIEN_THUC_THU_LUY_KE_THANG_4";
        public const string NGAY_KET_THUC_THANG_5 = "NGAY_KET_THUC_THANG_5";
        public const string TIEN_THUC_THU_LUY_KE_THANG_5 = "TIEN_THUC_THU_LUY_KE_THANG_5";
    }

    public class V_F510_BAO_CAO_LUY_KE_THEO_LOP_THEO_HOC_SINH_THEO_THANG
    {
        public const string ID_HOC_SINH = "ID_HOC_SINH";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string CAN_PHAI_THU = "CAN_PHAI_THU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
        public const string CON_PHAI_THU = "CON_PHAI_THU";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string NGAY_KET_THUC_THANG_1 = "NGAY_KET_THUC_THANG_1";
        public const string TIEN_THUC_THU_LUY_KE_THANG_1 = "TIEN_THUC_THU_LUY_KE_THANG_1";
        public const string NGAY_KET_THUC_THANG_2 = "NGAY_KET_THUC_THANG_2";
        public const string TIEN_THUC_THU_LUY_KE_THANG_2 = "TIEN_THUC_THU_LUY_KE_THANG_2";
        public const string NGAY_KET_THUC_THANG_3 = "NGAY_KET_THUC_THANG_3";
        public const string TIEN_THUC_THU_LUY_KE_THANG_3 = "TIEN_THUC_THU_LUY_KE_THANG_3";
        public const string NGAY_KET_THUC_THANG_4 = "NGAY_KET_THUC_THANG_4";
        public const string TIEN_THUC_THU_LUY_KE_THANG_4 = "TIEN_THUC_THU_LUY_KE_THANG_4";
        public const string NGAY_KET_THUC_THANG_5 = "NGAY_KET_THUC_THANG_5";
        public const string TIEN_THUC_THU_LUY_KE_THANG_5 = "TIEN_THUC_THU_LUY_KE_THANG_5";
    }

    public class V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY
    {
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string TIEN_PHAI_THU = "TIEN_PHAI_THU";
        public const string TIEN_GIAM_TRU = "TIEN_GIAM_TRU";
        public const string TIEN_THUC_THU = "TIEN_THUC_THU";
    }

    public class V_DM_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string MO_TA = "MO_TA";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string ID_LOP = "ID_LOP";
        public const string ID_MON = "ID_MON";
        public const string TRANG_THAI_LOP_MON = "TRANG_THAI_LOP_MON";
        public const string TONG_SO_BUOI_HOC = "TONG_SO_BUOI_HOC";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string THOI_GIAN_HOC_TO_DATE = "THOI_GIAN_HOC_TO_DATE";
        public const string ID_TRO_GIANG = "ID_TRO_GIANG";
        public const string GHI_CHU = "GHI_CHU";
        public const string TONG_TIEN_KHOA_HOC = "TONG_TIEN_KHOA_HOC";
        public const string MOT_NAM_SAU_NGAY_KET_THUC = "MOT_NAM_SAU_NGAY_KET_THUC";
    }

    public class V_DM_HOC_SINH2
    {
        public const string ID = "ID";
        public const string MA_DOI_TUONG = "MA_DOI_TUONG";
        public const string HO = "HO";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string TRUONG_DANG_HOC = "TRUONG_DANG_HOC";
        public const string EMAIL_HS = "EMAIL_HS";
        public const string EMAIL_PH = "EMAIL_PH";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT_HS = "SDT_HS";
        public const string SDT_PH = "SDT_PH";
        public const string HO_TEN_PH = "HO_TEN_PH";
        public const string SDT_CO_DINH = "SDT_CO_DINH";
        public const string FACEBOOK = "FACEBOOK";
        public const string SKYPE = "SKYPE";
        public const string DELETE_HS_YN = "DELETE_HS_YN";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string TRANG_THAI_GD_HOC = "TRANG_THAI_GD_HOC";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string MA_LOP_MON = "MA_LOP_MON";
        public const string TEN_LOP_MON = "TEN_LOP_MON";
        public const string DON_GIA_BUOI_HOC = "DON_GIA_BUOI_HOC";
        public const string TRANG_THAI_LOP_MON = "TRANG_THAI_LOP_MON";
        public const string THOI_GIAN_HOC_FROM_DATE = "THOI_GIAN_HOC_FROM_DATE";
        public const string THOI_GIAN_HOC_TO_DATE = "THOI_GIAN_HOC_TO_DATE";
        public const string MOT_NAM_SAU_NGAY_KET_THUC = "MOT_NAM_SAU_NGAY_KET_THUC";
    }

}
