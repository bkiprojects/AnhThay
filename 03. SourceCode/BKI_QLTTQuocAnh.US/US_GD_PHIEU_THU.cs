///************************************************
/// Generated by: tund
/// Date: 17/01/2015 04:20:05
/// Goal: Create User Service Class for GD_PHIEU_THU
///************************************************
/// <summary>
/// Create User Service Class for GD_PHIEU_THU
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US
{

    public class US_GD_PHIEU_THU : US_Object
    {
        private const string c_TableName = "GD_PHIEU_THU";
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

        public string strSO_PHIEU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_PHIEU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_PHIEU"] = value;
            }
        }

        public bool IsSO_PHIEUNull()
        {
            return pm_objDR.IsNull("SO_PHIEU");
        }

        public void SetSO_PHIEUNull()
        {
            pm_objDR["SO_PHIEU"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_THU"] = value;
            }
        }

        public bool IsID_NGUOI_THUNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_THU");
        }

        public void SetID_NGUOI_THUNull()
        {
            pm_objDR["ID_NGUOI_THU"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_NHAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_NHAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_NHAP"] = value;
            }
        }

        public bool IsID_NGUOI_NHAPNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_NHAP");
        }

        public void SetID_NGUOI_NHAPNull()
        {
            pm_objDR["ID_NGUOI_NHAP"] = System.Convert.DBNull;
        }

        public string strTEN_NGUOI_NOP_TIEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_NOP_TIEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NGUOI_NOP_TIEN"] = value;
            }
        }

        public bool IsTEN_NGUOI_NOP_TIENNull()
        {
            return pm_objDR.IsNull("TEN_NGUOI_NOP_TIEN");
        }

        public void SetTEN_NGUOI_NOP_TIENNull()
        {
            pm_objDR["TEN_NGUOI_NOP_TIEN"] = System.Convert.DBNull;
        }

        public string strNOI_DUNG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_DUNG"] = value;
            }
        }

        public bool IsNOI_DUNGNull()
        {
            return pm_objDR.IsNull("NOI_DUNG");
        }

        public void SetNOI_DUNGNull()
        {
            pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN"] = value;
            }
        }

        public bool IsSO_TIENNull()
        {
            return pm_objDR.IsNull("SO_TIEN");
        }

        public void SetSO_TIENNull()
        {
            pm_objDR["SO_TIEN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_THU
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_THU", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_THU"] = value;
            }
        }

        public bool IsNGAY_THUNull()
        {
            return pm_objDR.IsNull("NGAY_THU");
        }

        public void SetNGAY_THUNull()
        {
            pm_objDR["NGAY_THU"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_NHAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_NHAP"] = value;
            }
        }

        public bool IsNGAY_NHAPNull()
        {
            return pm_objDR.IsNull("NGAY_NHAP");
        }

        public void SetNGAY_NHAPNull()
        {
            pm_objDR["NGAY_NHAP"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_PHIEU_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_PHIEU_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_PHIEU_THU"] = value;
            }
        }

        public bool IsID_LOAI_PHIEU_THUNull()
        {
            return pm_objDR.IsNull("ID_LOAI_PHIEU_THU");
        }

        public void SetID_LOAI_PHIEU_THUNull()
        {
            pm_objDR["ID_LOAI_PHIEU_THU"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI"] = value;
            }
        }

        public bool IsID_TRANG_THAINull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI");
        }

        public void SetID_TRANG_THAINull()
        {
            pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
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

        public decimal dcID_SO_PHIEU_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_SO_PHIEU_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_SO_PHIEU_THU"] = value;
            }
        }

        public bool IsID_SO_PHIEU_THUNull()
        {
            return pm_objDR.IsNull("ID_SO_PHIEU_THU");
        }

        public void SetID_SO_PHIEU_THUNull()
        {
            pm_objDR["ID_SO_PHIEU_THU"] = System.Convert.DBNull;
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

        public decimal dcLAN_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LAN_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LAN_THU"] = value;
            }
        }

        public bool IsLAN_THUNull()
        {
            return pm_objDR.IsNull("LAN_THU");
        }

        public void SetLAN_THUNull()
        {
            pm_objDR["LAN_THU"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_PHIEU_THU()
        {
            pm_objDS = new DS_GD_PHIEU_THU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_PHIEU_THU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_PHIEU_THU(decimal i_dbID)
        {
            pm_objDS = new DS_GD_PHIEU_THU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public bool FindSoPhieuYN(string ip_str_so_phieu, ref decimal op_dc_id_phieu)
        {
            CStoredProc v_obj = new CStoredProc("pr_tim_so_phieu_yn");
            SqlParameter v_kq_yn = v_obj.addNVarcharOutputParam("@ket_qua_yn", "");
            SqlParameter v_id_phieu = v_obj.addDecimalOutputParam("@op_dc_id_phieu", 0);

            v_obj.addNVarcharInputParam("@ip_str_so_phieu", ip_str_so_phieu);

            v_obj.ExecuteCommand(this);
            if (v_kq_yn.Value.ToString() == "N")
            {
                return false;
            }
            else
            {
                op_dc_id_phieu = CIPConvert.ToDecimal(v_id_phieu.Value);
                return true;
            }
        }
    }
}
