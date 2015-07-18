///************************************************
/// Generated by: HaiHD
/// Date: 18/07/2015 04:19:03
/// Goal: Create User Service Class for V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY
///************************************************
/// <summary>
/// Create User Service Class for V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY : US_Object
{
	private const string c_TableName = "V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY";
#region "Public Properties"
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

	public bool IsID_LOP_MONNull()	{
		return pm_objDR.IsNull("ID_LOP_MON");
	}

	public void SetID_LOP_MONNull() {
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

	public void SetMA_LOP_MONNull() {
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

	public void SetTEN_LOP_MONNull() {
		pm_objDR["TEN_LOP_MON"] = System.Convert.DBNull;
	}

	public decimal dcTIEN_PHAI_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TIEN_PHAI_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TIEN_PHAI_THU"] = value;
		}
	}

	public bool IsTIEN_PHAI_THUNull()	{
		return pm_objDR.IsNull("TIEN_PHAI_THU");
	}

	public void SetTIEN_PHAI_THUNull() {
		pm_objDR["TIEN_PHAI_THU"] = System.Convert.DBNull;
	}

	public decimal dcTIEN_GIAM_TRU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TIEN_GIAM_TRU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TIEN_GIAM_TRU"] = value;
		}
	}

	public bool IsTIEN_GIAM_TRUNull()	{
		return pm_objDR.IsNull("TIEN_GIAM_TRU");
	}

	public void SetTIEN_GIAM_TRUNull() {
		pm_objDR["TIEN_GIAM_TRU"] = System.Convert.DBNull;
	}

	public decimal dcTIEN_THUC_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TIEN_THUC_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TIEN_THUC_THU"] = value;
		}
	}

	public bool IsTIEN_THUC_THUNull()	{
		return pm_objDR.IsNull("TIEN_THUC_THU");
	}

	public void SetTIEN_THUC_THUNull() {
		pm_objDR["TIEN_THUC_THU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY() 
	{
		pm_objDS = new DS_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY(decimal i_dbID) 
	{
		pm_objDS = new DS_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDataset_by_id_lop_and_ngay_thu(DS_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY op_ds, decimal ip_dc_id_lop_mon, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_obj_spr = new CStoredProc("Pr_f520_bao_cao_thu_thu_giam_tru_theo_lop_theo_ngay");
        v_obj_spr.addDecimalInputParam("@ip_dc_id_lop_mon", ip_dc_id_lop_mon);
        v_obj_spr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
        v_obj_spr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

        v_obj_spr.fillDataSetByCommand(this, op_ds);
    }

    public void FillDataset_by_ngay(DS_V_F520_BAO_CAO_THUC_THU_GIAM_TRU_THEO_NGAY op_ds, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_obj_spr = new CStoredProc("Pr_f520_bao_cao_thu_thu_giam_tru_theo_ngay");
        
        v_obj_spr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
        v_obj_spr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

        v_obj_spr.fillDataSetByCommand(this, op_ds);
    }
}
}
