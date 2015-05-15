using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BKI_QLTTQuocAnh.NghiepVu;
using System.Windows.Forms;
namespace BKI_QLTTQuocAnh.NghiepVu {
    public class FactoryPhieu {
        string m_str_type_frm;
        F350_lap_phieu_thu m_frm;
        public FactoryPhieu() {

        }
        public FactoryPhieu(F350_lap_phieu_thu ip_f350, string ip_type_frm) {
            m_str_type_frm = ip_type_frm;
            m_frm = ip_f350;
            set_initial_form_load();
        }

        public ISetFormLoad set_initial_form_load() {
            switch(m_str_type_frm) {
                case "PHAI_THU":
                return new ISetFormLoadPhaiThu(m_frm);
                break;
                case "THUC_THU":
                return new ISetFormLoadThucThu(m_frm);
                break;
                case "GIAM_TRU":
                return new ISetFormLoadGiamTru(m_frm);
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
    }
    //

    public class ISetFormLoadPhaiThu : ISetFormLoad {
        public ISetFormLoadPhaiThu(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            ip_f350.Text = "LẬP PHIẾU PHẢI THU";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;

            ip_f350.m_lbl_so_phieu_thu.Visible = false;
            ip_f350.m_sle_so_phieu_thu.Visible = false;

            ip_f350.m_lbl_lan_thu.Visible = false;
            ip_f350.m_txt_lan_thu.Visible = false;
        }
    }



    ///Giam tru
    public class ISetFormLoadGiamTru : ISetFormLoad {
        public ISetFormLoadGiamTru(F350_lap_phieu_thu ip_f350) {
            set_form_load(ip_f350);
        }
        public void set_form_load(F350_lap_phieu_thu ip_f350) {
            ip_f350.Text = "LẬP PHIẾU GIẢM TRỪ";
            ip_f350.m_lbl_header_left.Text = ip_f350.Text;
            ip_f350.m_lbl_so_phieu_thu.Visible = false;
            ip_f350.m_sle_so_phieu_thu.Visible = false;

            ip_f350.m_lbl_lan_thu.Visible = false;
            ip_f350.m_txt_lan_thu.Visible = false;
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
    }
}
