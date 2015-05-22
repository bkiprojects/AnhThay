///************************************************
/// Generated by: tund
/// Date: 17/01/2015 04:19:15
/// Goal: Create User Service Class for DM_LOP_MON
///************************************************
/// <summary>
/// Create User Service Class for DM_LOP_MON
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_DM_LOP_MON : US_Object
{
	private const string c_TableName = "DM_LOP_MON";

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

    public string strMO_TA
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MO_TA"] = value;
        }
    }

    public bool IsMO_TANull()
    {
        return pm_objDR.IsNull("MO_TA");
    }

    public void SetMO_TANull()
    {
        pm_objDR["MO_TA"] = System.Convert.DBNull;
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

    public decimal dcID_LOP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOP"] = value;
        }
    }

    public bool IsID_LOPNull()
    {
        return pm_objDR.IsNull("ID_LOP");
    }

    public void SetID_LOPNull()
    {
        pm_objDR["ID_LOP"] = System.Convert.DBNull;
    }

    public decimal dcID_MON
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_MON", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_MON"] = value;
        }
    }

    public bool IsID_MONNull()
    {
        return pm_objDR.IsNull("ID_MON");
    }

    public void SetID_MONNull()
    {
        pm_objDR["ID_MON"] = System.Convert.DBNull;
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

    #endregion
    #region "Init Functions"
    public US_DM_LOP_MON()
    {
        pm_objDS = new DS_DM_LOP_MON();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_DM_LOP_MON(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_DM_LOP_MON(decimal i_dbID)
    {
        pm_objDS = new DS_DM_LOP_MON();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion



    public void Find_id_lop_mon_by_ma_lop_mon(string v_ma_lop_mon, ref decimal op_dc_id_lop)
    {
        CStoredProc v_obj = new CStoredProc("Pr_find_id_lop_mon_by_ma_lop_mon");

        v_obj.addNVarcharInputParam("@ip_str_ma_lop", v_ma_lop_mon);
        SqlParameter v_id_gd_lop_mon = v_obj.addDecimalOutputParam("@op_dc_id_lop", 0);
        v_obj.ExecuteCommand(this);
        op_dc_id_lop = CIPConvert.ToDecimal(v_id_gd_lop_mon.Value);
    }
}
}
