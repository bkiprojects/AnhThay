///************************************************
/// Generated by: Vupl
/// Date: 17/05/2015 11:25:22
/// Goal: Create User Service Class for V_DM_HOC_SINH_GD_HOC_DM_LOP_MON
///************************************************
/// <summary>
/// Create User Service Class for V_DM_HOC_SINH_GD_HOC_DM_LOP_MON
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US
{

    public class US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON : US_Object
    {
        private const string c_TableName = "V_DM_HOC_SINH_GD_HOC_DM_LOP_MON";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_DOI_TUONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DOI_TUONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DOI_TUONG"] = value;
            }
        }

        public bool IsMA_DOI_TUONGNull()
        {
            return pm_objDR.IsNull("MA_DOI_TUONG");
        }

        public void SetMA_DOI_TUONGNull()
        {
            pm_objDR["MA_DOI_TUONG"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_DOI_TUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DOI_TUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_DOI_TUONG"] = value;
            }
        }

        public bool IsID_LOAI_DOI_TUONGNull()
        {
            return pm_objDR.IsNull("ID_LOAI_DOI_TUONG");
        }

        public void SetID_LOAI_DOI_TUONGNull()
        {
            pm_objDR["ID_LOAI_DOI_TUONG"] = System.Convert.DBNull;
        }

        public string strTEN_LOAI_DOI_TUONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOAI_DOI_TUONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOAI_DOI_TUONG"] = value;
            }
        }

        public bool IsTEN_LOAI_DOI_TUONGNull()
        {
            return pm_objDR.IsNull("TEN_LOAI_DOI_TUONG");
        }

        public void SetTEN_LOAI_DOI_TUONGNull()
        {
            pm_objDR["TEN_LOAI_DOI_TUONG"] = System.Convert.DBNull;
        }

        public string strHO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO"] = value;
            }
        }

        public bool IsHONull()
        {
            return pm_objDR.IsNull("HO");
        }

        public void SetHONull()
        {
            pm_objDR["HO"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public string strHO_TEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN"] = value;
            }
        }

        public bool IsHO_TENNull()
        {
            return pm_objDR.IsNull("HO_TEN");
        }

        public void SetHO_TENNull()
        {
            pm_objDR["HO_TEN"] = System.Convert.DBNull;
        }

        public string strTRUONG_DANG_HOC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRUONG_DANG_HOC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRUONG_DANG_HOC"] = value;
            }
        }

        public bool IsTRUONG_DANG_HOCNull()
        {
            return pm_objDR.IsNull("TRUONG_DANG_HOC");
        }

        public void SetTRUONG_DANG_HOCNull()
        {
            pm_objDR["TRUONG_DANG_HOC"] = System.Convert.DBNull;
        }

        public string strEMAIL_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_HS"] = value;
            }
        }

        public bool IsEMAIL_HSNull()
        {
            return pm_objDR.IsNull("EMAIL_HS");
        }

        public void SetEMAIL_HSNull()
        {
            pm_objDR["EMAIL_HS"] = System.Convert.DBNull;
        }

        public string strEMAIL_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_PH"] = value;
            }
        }

        public bool IsEMAIL_PHNull()
        {
            return pm_objDR.IsNull("EMAIL_PH");
        }

        public void SetEMAIL_PHNull()
        {
            pm_objDR["EMAIL_PH"] = System.Convert.DBNull;
        }

        public string strDIA_CHI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI"] = value;
            }
        }

        public bool IsDIA_CHINull()
        {
            return pm_objDR.IsNull("DIA_CHI");
        }

        public void SetDIA_CHINull()
        {
            pm_objDR["DIA_CHI"] = System.Convert.DBNull;
        }

        public string strSDT_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_HS"] = value;
            }
        }

        public bool IsSDT_HSNull()
        {
            return pm_objDR.IsNull("SDT_HS");
        }

        public void SetSDT_HSNull()
        {
            pm_objDR["SDT_HS"] = System.Convert.DBNull;
        }

        public string strSDT_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_PH"] = value;
            }
        }

        public bool IsSDT_PHNull()
        {
            return pm_objDR.IsNull("SDT_PH");
        }

        public void SetSDT_PHNull()
        {
            pm_objDR["SDT_PH"] = System.Convert.DBNull;
        }

        public string strHO_TEN_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN_PH"] = value;
            }
        }

        public bool IsHO_TEN_PHNull()
        {
            return pm_objDR.IsNull("HO_TEN_PH");
        }

        public void SetHO_TEN_PHNull()
        {
            pm_objDR["HO_TEN_PH"] = System.Convert.DBNull;
        }

        public string strSDT_CO_DINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_CO_DINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_CO_DINH"] = value;
            }
        }

        public bool IsSDT_CO_DINHNull()
        {
            return pm_objDR.IsNull("SDT_CO_DINH");
        }

        public void SetSDT_CO_DINHNull()
        {
            pm_objDR["SDT_CO_DINH"] = System.Convert.DBNull;
        }

        public string strFACEBOOK
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "FACEBOOK", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["FACEBOOK"] = value;
            }
        }

        public bool IsFACEBOOKNull()
        {
            return pm_objDR.IsNull("FACEBOOK");
        }

        public void SetFACEBOOKNull()
        {
            pm_objDR["FACEBOOK"] = System.Convert.DBNull;
        }

        public string strSKYPE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SKYPE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SKYPE"] = value;
            }
        }

        public bool IsSKYPENull()
        {
            return pm_objDR.IsNull("SKYPE");
        }

        public void SetSKYPENull()
        {
            pm_objDR["SKYPE"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_SINH
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_SINH"] = value;
            }
        }

        public bool IsNGAY_SINHNull()
        {
            return pm_objDR.IsNull("NGAY_SINH");
        }

        public void SetNGAY_SINHNull()
        {
            pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
        }

        public string strDELETE_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DELETE_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DELETE_YN"] = value;
            }
        }

        public bool IsDELETE_YNNull()
        {
            return pm_objDR.IsNull("DELETE_YN");
        }

        public void SetDELETE_YNNull()
        {
            pm_objDR["DELETE_YN"] = System.Convert.DBNull;
        }

        public decimal dcID_LOP_MON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_MON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOP_MON"] = value;
            }
        }

        public bool IsID_LOP_MONNull()
        {
            return pm_objDR.IsNull("ID_LOP_MON");
        }

        public void SetID_LOP_MONNull()
        {
            pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
        }

        public string strMA_LOP_MON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_LOP_MON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_LOP_MON"] = value;
            }
        }

        public bool IsMA_LOP_MONNull()
        {
            return pm_objDR.IsNull("MA_LOP_MON");
        }

        public void SetMA_LOP_MONNull()
        {
            pm_objDR["MA_LOP_MON"] = System.Convert.DBNull;
        }

        public string strTEN_LOP_MON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOP_MON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOP_MON"] = value;
            }
        }

        public bool IsTEN_LOP_MONNull()
        {
            return pm_objDR.IsNull("TEN_LOP_MON");
        }

        public void SetTEN_LOP_MONNull()
        {
            pm_objDR["TEN_LOP_MON"] = System.Convert.DBNull;
        }

        public decimal dcDON_GIA_BUOI_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DON_GIA_BUOI_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DON_GIA_BUOI_HOC"] = value;
            }
        }

        public bool IsDON_GIA_BUOI_HOCNull()
        {
            return pm_objDR.IsNull("DON_GIA_BUOI_HOC");
        }

        public void SetDON_GIA_BUOI_HOCNull()
        {
            pm_objDR["DON_GIA_BUOI_HOC"] = System.Convert.DBNull;
        }

        public decimal dcTRANG_THAI_LOP_MON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TRANG_THAI_LOP_MON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TRANG_THAI_LOP_MON"] = value;
            }
        }

        public bool IsTRANG_THAI_LOP_MONNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_LOP_MON");
        }

        public void SetTRANG_THAI_LOP_MONNull()
        {
            pm_objDR["TRANG_THAI_LOP_MON"] = System.Convert.DBNull;
        }

        public decimal dcTONG_SO_BUOI_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_BUOI_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_SO_BUOI_HOC"] = value;
            }
        }

        public bool IsTONG_SO_BUOI_HOCNull()
        {
            return pm_objDR.IsNull("TONG_SO_BUOI_HOC");
        }

        public void SetTONG_SO_BUOI_HOCNull()
        {
            pm_objDR["TONG_SO_BUOI_HOC"] = System.Convert.DBNull;
        }

        public DateTime datTHOI_GIAN_HOC_FROM_DATE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_HOC_FROM_DATE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["THOI_GIAN_HOC_FROM_DATE"] = value;
            }
        }

        public bool IsTHOI_GIAN_HOC_FROM_DATENull()
        {
            return pm_objDR.IsNull("THOI_GIAN_HOC_FROM_DATE");
        }

        public void SetTHOI_GIAN_HOC_FROM_DATENull()
        {
            pm_objDR["THOI_GIAN_HOC_FROM_DATE"] = System.Convert.DBNull;
        }

        public DateTime datTHOI_GIAN_HOC_TO_DATE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_HOC_TO_DATE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["THOI_GIAN_HOC_TO_DATE"] = value;
            }
        }

        public bool IsTHOI_GIAN_HOC_TO_DATENull()
        {
            return pm_objDR.IsNull("THOI_GIAN_HOC_TO_DATE");
        }

        public void SetTHOI_GIAN_HOC_TO_DATENull()
        {
            pm_objDR["THOI_GIAN_HOC_TO_DATE"] = System.Convert.DBNull;
        }

        public DateTime datMOT_NAM_SAU_NGAY_KET_THUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "MOT_NAM_SAU_NGAY_KET_THUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["MOT_NAM_SAU_NGAY_KET_THUC"] = value;
            }
        }

        public bool IsMOT_NAM_SAU_NGAY_KET_THUCNull()
        {
            return pm_objDR.IsNull("MOT_NAM_SAU_NGAY_KET_THUC");
        }

        public void SetMOT_NAM_SAU_NGAY_KET_THUCNull()
        {
            pm_objDR["MOT_NAM_SAU_NGAY_KET_THUC"] = System.Convert.DBNull;
        }

        public decimal dcID_TRO_GIANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRO_GIANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRO_GIANG"] = value;
            }
        }

        public bool IsID_TRO_GIANGNull()
        {
            return pm_objDR.IsNull("ID_TRO_GIANG");
        }

        public void SetID_TRO_GIANGNull()
        {
            pm_objDR["ID_TRO_GIANG"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public decimal dcTONG_TIEN_KHOA_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_TIEN_KHOA_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_TIEN_KHOA_HOC"] = value;
            }
        }

        public bool IsTONG_TIEN_KHOA_HOCNull()
        {
            return pm_objDR.IsNull("TONG_TIEN_KHOA_HOC");
        }

        public void SetTONG_TIEN_KHOA_HOCNull()
        {
            pm_objDR["TONG_TIEN_KHOA_HOC"] = System.Convert.DBNull;
        }

        public decimal dcID_GD_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_GD_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_GD_HOC"] = value;
            }
        }

        public bool IsID_GD_HOCNull()
        {
            return pm_objDR.IsNull("ID_GD_HOC");
        }

        public void SetID_GD_HOCNull()
        {
            pm_objDR["ID_GD_HOC"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_YN"] = value;
            }
        }

        public bool IsTRANG_THAI_YNNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_YN");
        }

        public void SetTRANG_THAI_YNNull()
        {
            pm_objDR["TRANG_THAI_YN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU"] = value;
            }
        }

        public bool IsNGAY_BAT_DAUNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU");
        }

        public void SetNGAY_BAT_DAUNull()
        {
            pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC"] = value;
            }
        }

        public bool IsNGAY_KET_THUCNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC");
        }

        public void SetNGAY_KET_THUCNull()
        {
            pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON()
        {
            pm_objDS = new DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON(decimal i_dbID)
        {
            pm_objDS = new DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void insert_by_proc(string ip_str_ma_doi_tuong
                                    , string ip_str_ho
                                    , string ip_str_ten
                                    , DateTime ip_dat_ngay_sinh
                                    , string ip_str_email
                                    , string ip_str_dia_chi
                                    , string ip_str_sdt
                                    , string ip_str_facebook
                                    , string ip_str_truong_dang_hoc
                                    , decimal ip_dc_id_lop
                                    , decimal ip_dc_hoc_phi
                                    , DateTime ip_dat_thoi_gian_start
                                    , DateTime ip_dat_thoi_gian_end
                                    , string ip_str_ghi_chu
            )
        {
            BeginTransaction();
            decimal v_op_dc_id_hoc_sinh;
            decimal v_op_dc_id_gd_hoc;

            CStoredProc v_insert_hs_lm = new CStoredProc("pr_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON_Insert");
            v_insert_hs_lm.addNVarcharInputParam("@MA_DOI_TUONG", ip_str_ma_doi_tuong);
            v_insert_hs_lm.addNVarcharInputParam("@HO", ip_str_ho);
            v_insert_hs_lm.addNVarcharInputParam("@TEN", ip_str_ten);
            v_insert_hs_lm.addDatetimeInputParam("@NGAY_SINH", ip_dat_ngay_sinh);
            v_insert_hs_lm.addNVarcharInputParam("@EMAIL_HS", ip_str_email);
            v_insert_hs_lm.addNVarcharInputParam("@DIA_CHI", ip_str_dia_chi);
            v_insert_hs_lm.addNVarcharInputParam("@SDT_HS", ip_str_sdt);
            v_insert_hs_lm.addNVarcharInputParam("@FACEBOOK", ip_str_facebook);
            v_insert_hs_lm.addNVarcharInputParam("@TRUONG_DANG_HOC", ip_str_truong_dang_hoc);
            v_insert_hs_lm.addDecimalInputParam("@ID_LOP_MON", ip_dc_id_lop);
            v_insert_hs_lm.addDecimalInputParam("@DON_GIA_BUOI_HOC", ip_dc_hoc_phi);
            v_insert_hs_lm.addDatetimeInputParam("@THOI_GIAN_HOC_FROM_DATE", ip_dat_thoi_gian_start);
            v_insert_hs_lm.addDatetimeInputParam("@THOI_GIAN_HOC_TO_DATE", ip_dat_thoi_gian_end);
            v_insert_hs_lm.addNVarcharInputParam("@GHI_CHU", ip_str_ghi_chu);
            SqlParameter v_id_hoc_sinh = v_insert_hs_lm.addDecimalOutputParam("@OP_ID_HOC_SINH", 0);

            //SqlParameter v_spr_ma_hv = v_cst.addNVarcharOutputParam("@ID_HOC_SINH", "");
            //SqlParameter v_spr_ten_hv = v_cst.addNVarcharOutputParam("@ID", "")
            v_insert_hs_lm.ExecuteCommand(this);
            v_op_dc_id_hoc_sinh = CIPConvert.ToDecimal(v_id_hoc_sinh.Value);

            CStoredProc v_insert_gd_hoc = new CStoredProc("pr_GD_HOC_Insert2");
            v_insert_gd_hoc.addDecimalInputParam("@ID_HOC_SINH", v_op_dc_id_hoc_sinh);
            v_insert_gd_hoc.addDecimalInputParam("@ID_LOP_MON", ip_dc_id_lop);
            v_insert_gd_hoc.addNVarcharInputParam("@TRANG_THAI_YN", "Y");

            SqlParameter v_id_gd_hoc = v_insert_gd_hoc.addDecimalOutputParam("@ID", 0);

            v_insert_gd_hoc.ExecuteCommand(this);
            v_op_dc_id_gd_hoc = CIPConvert.ToDecimal(v_id_gd_hoc.Value);
            CommitTransaction();
        }

        public void update_by_proc(decimal ip_id_hoc_sinh
                                    , string ip_ma_doi_tuong
                                    , string ip_ho
                                    , string ip_ten
                                    , DateTime ip_ngay_sinh
                                    , string ip_email
                                    , string ip_sdt
                                    , string ip_dia_chi
                                    , string ip_facebook
                                    , string ip_truong_dang_hoc
                                    , decimal ip_id_lop
                                    , decimal ip_hoc_phi
                                    , DateTime ip_thoi_gian_start
                                    , DateTime ip_thoi_gian_end
                                    , string ip_ghi_chu
                                    , decimal ip_id)
        {
            CStoredProc v_cst = new CStoredProc("pr_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON_Update");
            v_cst.addDecimalInputParam("@ID_HOC_SINH", ip_id_hoc_sinh);
            v_cst.addNVarcharInputParam("@MA_DOI_TUONG", ip_ma_doi_tuong);
            v_cst.addNVarcharInputParam("@HO", ip_ho);
            v_cst.addNVarcharInputParam("@TEN", ip_ten);
            v_cst.addDatetimeInputParam("@NGAY_SINH", ip_ngay_sinh);
            v_cst.addNVarcharInputParam("@EMAIL_HS", ip_email);
            v_cst.addNVarcharInputParam("@DIA_CHI", ip_dia_chi);
            v_cst.addNVarcharInputParam("@SDT_HS", ip_sdt);
            v_cst.addNVarcharInputParam("@FACEBOOK", ip_facebook);
            v_cst.addNVarcharInputParam("@TRUONG_DANG_HOC", ip_truong_dang_hoc);
            v_cst.addDecimalInputParam("@ID_LOP_MON", ip_id_lop);
            v_cst.addDecimalInputParam("@DON_GIA_BUOI_HOC", ip_hoc_phi);
            v_cst.addDatetimeInputParam("@THOI_GIAN_HOC_FROM_DATE", ip_thoi_gian_start);
            v_cst.addDatetimeInputParam("@THOI_GIAN_HOC_TO_DATE", ip_thoi_gian_end);
            v_cst.addNVarcharInputParam("@GHI_CHU", ip_ghi_chu);
            v_cst.addDecimalInputParam("@ID", ip_id);

            v_cst.ExecuteCommand(this);
        }

        public void Delete_by_Proc(decimal ip_dc_id_hs, decimal ip_dc_gd_hoc)
        {
            BeginTransaction();
            CStoredProc v_delete_v_hs_lm_gdh = new CStoredProc("pr_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON_Delete");
            v_delete_v_hs_lm_gdh.addDecimalInputParam("@ID_HOC_SINH", ip_dc_id_hs);
            v_delete_v_hs_lm_gdh.addDecimalInputParam("@ID", ip_dc_gd_hoc);

            v_delete_v_hs_lm_gdh.ExecuteCommand(this);
            CommitTransaction();
        }
    }
}
