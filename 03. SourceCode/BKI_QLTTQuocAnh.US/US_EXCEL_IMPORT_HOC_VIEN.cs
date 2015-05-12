///************************************************
/// Generated by: TuyenNT
/// Date: 06/04/2015 08:10:34
/// Goal: Create User Service Class for EXCEL_IMPORT_HOC_VIEN
///************************************************
/// <summary>
/// Create User Service Class for EXCEL_IMPORT_HOC_VIEN
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_EXCEL_IMPORT_HOC_VIEN : US_Object
{
	private const string c_TableName = "EXCEL_IMPORT_HOC_VIEN";
    #region "Public Properties"
    public decimal dcSTT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "STT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["STT"] = value;
        }
    }

    public bool IsSTTNull()
    {
        return pm_objDR.IsNull("STT");
    }

    public void SetSTTNull()
    {
        pm_objDR["STT"] = System.Convert.DBNull;
    }

    public string strMA_HOC_VIEN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_HOC_VIEN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_HOC_VIEN"] = value;
        }
    }

    public bool IsMA_HOC_VIENNull()
    {
        return pm_objDR.IsNull("MA_HOC_VIEN");
    }

    public void SetMA_HOC_VIENNull()
    {
        pm_objDR["MA_HOC_VIEN"] = System.Convert.DBNull;
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

    public string strSĐT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "SĐT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["SĐT"] = value;
        }
    }

    public bool IsSĐTNull()
    {
        return pm_objDR.IsNull("SĐT");
    }

    public void SetSĐTNull()
    {
        pm_objDR["SĐT"] = System.Convert.DBNull;
    }

    public string strEMAIL
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["EMAIL"] = value;
        }
    }

    public bool IsEMAILNull()
    {
        return pm_objDR.IsNull("EMAIL");
    }

    public void SetEMAILNull()
    {
        pm_objDR["EMAIL"] = System.Convert.DBNull;
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

    public string strQUE_QUAN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "QUE_QUAN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["QUE_QUAN"] = value;
        }
    }

    public bool IsQUE_QUANNull()
    {
        return pm_objDR.IsNull("QUE_QUAN");
    }

    public void SetQUE_QUANNull()
    {
        pm_objDR["QUE_QUAN"] = System.Convert.DBNull;
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

    #endregion
#region "Init Functions"
	public US_EXCEL_IMPORT_HOC_VIEN() 
	{
		pm_objDS = new DS_EXCEL_IMPORT_HOC_VIEN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_EXCEL_IMPORT_HOC_VIEN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_EXCEL_IMPORT_HOC_VIEN(decimal i_dbID) 
	{
		pm_objDS = new DS_EXCEL_IMPORT_HOC_VIEN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}