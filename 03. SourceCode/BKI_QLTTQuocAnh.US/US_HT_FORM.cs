///************************************************
/// Generated by: THAIPH
/// Date: 23/03/2014 09:06:26
/// Goal: Create User Service Class for HT_FORM
///************************************************
/// <summary>
/// Create User Service Class for HT_FORM
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US {

public class US_HT_FORM : US_Object
{
	private const string c_TableName = "HT_FORM";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strFORM_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "FORM_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["FORM_NAME"] = value;
		}
	}

	public bool IsFORM_NAMENull() 
	{
		return pm_objDR.IsNull("FORM_NAME");
	}

	public void SetFORM_NAMENull() {
		pm_objDR["FORM_NAME"] = System.Convert.DBNull;
	}

	public string strDISPLAY_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DISPLAY_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DISPLAY_NAME"] = value;
		}
	}

	public bool IsDISPLAY_NAMENull() 
	{
		return pm_objDR.IsNull("DISPLAY_NAME");
	}

	public void SetDISPLAY_NAMENull() {
		pm_objDR["DISPLAY_NAME"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_HT_FORM() 
	{
		pm_objDS = new DS_HT_FORM();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_HT_FORM(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_HT_FORM(decimal i_dbID) 
	{
		pm_objDS = new DS_HT_FORM();
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
