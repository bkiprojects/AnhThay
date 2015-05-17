using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BKI_QLTTQuocAnh.NghiepVu;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
namespace BKI_QLTTQuocAnh.NghiepVu {
    public class FactoryPhieu {
        string m_str_type_frm;
        F350_lap_phieu_thu m_frm;
        US_V_GD_PHIEU_THU m_us_v_pt;
        public FactoryPhieu() {

        }
        public FactoryPhieu(F350_lap_phieu_thu ip_f350, string ip_type_frm) {
            m_str_type_frm = ip_type_frm;
            m_frm = ip_f350;
            set_initial_form_load();
        }
        public FactoryPhieu(F350_lap_phieu_thu ip_f350, string ip_type_frm, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
            m_str_type_frm = ip_type_frm;
            m_frm = ip_f350;
            m_us_v_pt = ip_us_v_pt;
            set_initial_form_load();
        }

        public ISetFormLoad set_initial_form_load() {
            switch(m_str_type_frm) {
                case "PHIEU_PHAI_THU":
                return new ISetFormLoadPhaiThu(m_frm);
                break;
                case "PHIEU_THUC_THU":
                return new ISetFormLoadThucThu(m_frm);
                break;
                case "PHIEU_GIAM_TRU":
                return new ISetFormLoadGiamTru(m_frm);
                break;
                case "SUA_PHIEU":
                return new ISetFormLoadF430(m_frm, m_us_v_pt);
                break;
                default:
                break;
            }
            return new ISetFormLoadError(m_frm);
        }
    }
    //
    //Interface set_form_load
    public interface ISetFormLoad {
        void set_form_load(F350_lap_phieu_thu ip_f350);
        void set_form_load(F350_lap_phieu_thu ip_f350,US_V_GD_PHIEU_THU ip_us_v_pt);
    }
    //

    public class ISetFormLoadPhaiThu : ISetFormLoad {
        public ISetFormLoadPhaiThu(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            ip_f350.Text = "LẬP HỌC PHÍ HỌC VIÊN";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;

            ip_f350.m_lbl_so_phieu_thu.Visible = false;
            ip_f350.m_sle_so_phieu_thu.Visible = false;

            ip_f350.m_lbl_lan_thu.Visible = false;
            ip_f350.m_txt_lan_thu.Visible = false;
            ip_f350.Name = "PHIEU_PHAI_THU";
            ip_f350.m_txt_so_phieu.Visible = false;
            ip_f350.m_lbl_so_phieu.Visible = false;
            ip_f350.m_lbl_check_so_phieu.Visible = false;
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
        }
    }



    ///Giam tru
    public class ISetFormLoadGiamTru : ISetFormLoad {
        public ISetFormLoadGiamTru(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            ip_f350.Text = "LẬP GIẢM TRỪ HỌC VIÊN";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;
            ip_f350.m_lbl_so_phieu_thu.Visible = false;
            ip_f350.m_sle_so_phieu_thu.Visible = false;

            ip_f350.m_lbl_lan_thu.Visible = false;
            ip_f350.m_txt_lan_thu.Visible = false;
            ip_f350.Name = "PHIEU_GIAM_TRU";
            ip_f350.m_txt_so_phieu.Visible = false;
            ip_f350.m_lbl_so_phieu.Visible = false;
            ip_f350.m_lbl_check_so_phieu.Visible = false;
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
        }
    }


    ///Thuc thu
    public class ISetFormLoadThucThu : ISetFormLoad {
        public ISetFormLoadThucThu(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            ip_f350.Text = "LẬP PHIẾU THỰC THU";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;

            ip_f350.m_txt_lan_thu.Enabled = false;
            ip_f350.Name = "PHIEU_THUC_THU";
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
        }
    }

    //Error
    public class ISetFormLoadError : ISetFormLoad {
        public ISetFormLoadError(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            MessageBox.Show("Đã có lỗi xảy ra");
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
        }
    }

    //Hien thi phieu thu
    public class ISetFormLoadF430 : ISetFormLoad
    {
        public ISetFormLoadF430(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
            set_form_load(ip_f350, ip_us_v_pt);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350, US_V_GD_PHIEU_THU ip_us_v_pt)
        {
            ip_f350.m_e_form_mode = IP.Core.IPCommon.DataEntryFormMode.UpdateDataState;
            ip_f350.Text = "SỬA PHIẾU THU";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;
            ip_f350.m_sle_so_phieu_thu.EditValue = 1; //sua sau neu nhieu hon mot so
            ip_f350.m_txt_so_phieu.Text = ip_us_v_pt.strSO_PHIEU;
            ip_f350.m_dat_ngay_thu.EditValue = ip_us_v_pt.datNGAY_THU;
            ip_f350.m_sle_lop.EditValue = ip_us_v_pt.dcID_LOP_MON;
            ip_f350.m_sle_ma_hv.EditValue = ip_us_v_pt.dcID_HOC_SINH;
            ip_f350.m_lbl_ten_hs.Text = ip_us_v_pt.strHO_TEN;
            ip_f350.m_txt_lan_thu.Text = ip_us_v_pt.dcLAN_THU.ToString() ;
            ip_f350.m_txt_so_tien.Text = ip_us_v_pt.dcSO_TIEN.ToString();
            ip_f350.m_txt_noi_dung.Text = ip_us_v_pt.strNOI_DUNG;
            ip_f350.m_lbl_nv_thu.Text = ip_us_v_pt.strTEN_NGUOI_THU;
            ip_f350.m_lbl_nv_nhap.Text = ip_us_v_pt.strTEN_NGUOI_NHAP;
            ip_f350.m_dat_ngay_nhap.EditValue = DateTime.Now.Date;
            ip_f350.Name = "SUA_PHIEU";
            
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350)
        {
        }
    }
}
