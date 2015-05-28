///************************************************
/// Generated by: tund
/// Date: 17/01/2015 04:19:06
/// Goal: Create User Service Class for DM_HOC_SINH
///************************************************
/// <summary>
/// Create User Service Class for DM_HOC_SINH
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_DM_HOC_SINH : US_Object
{
	private const string c_TableName = "DM_HOC_SINH";
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

    #endregion
#region "Init Functions"
	public US_DM_HOC_SINH() 
	{
		pm_objDS = new DS_DM_HOC_SINH();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_HOC_SINH(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_HOC_SINH(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_HOC_SINH();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public bool is_exist_ma_hs(string ip_str_ma_hv, ref string op_ten_hv ) {
        CStoredProc v_cst = new CStoredProc("Pr_is_ma_hv_in_db");
        v_cst.addNVarcharInputParam("@ip_str_ma_hv", ip_str_ma_hv);
        SqlParameter v_spr_ma_hv = v_cst.addNVarcharOutputParam("@op_str_ma_hv","");
        SqlParameter v_spr_ten_hv = v_cst.addNVarcharOutputParam("@op_str_ten_hv", "");
        v_cst.ExecuteCommand(this);

        if(v_spr_ma_hv.Value.ToString() == "Y") {
            return true;
        }
        return false;
    }

    public string get_ma_hs_moi_nhat() {
        CStoredProc v_sp = new CStoredProc("Pr_get_ma_hs_them_moi");
        SqlParameter v_para = v_sp.addNVarcharOutputParam("@op_str_ma_hv", "");

        v_sp.ExecuteCommand(this);
        return v_para.Value.ToString();
    }
}
}
