using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.Win.C1FlexGrid;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using IP.Core.IPCommon;
namespace BKI_QLTTQuocAnh.NghiepVu {


    public class PhieuFactory {
        public string m_type;
        f340_lap_phieu_thu m_f340;
        US_V_GD_PHIEU_THU m_us_pt;

        public PhieuFactory(String ip_str, f340_lap_phieu_thu ip_frm) {
            m_type = ip_str;
            m_f340 = ip_frm;
            SetInitialFormLoad();
        }
        public PhieuFactory(String ip_str, f340_lap_phieu_thu ip_frm, US_V_GD_PHIEU_THU ip_us) {
            m_type = ip_str;
            m_f340 = ip_frm;
            m_us_pt = ip_us;
            SetInitialFormLoad();
        }
        protected ISetInitialFormLoad SetInitialFormLoad(){
            if(m_type.Equals("PHAI_THU")) {
                return new SetInitalFormLoadPhaiThu(m_f340);
            }
            else if(m_type.Equals("THUC_THU")) {
                return new SetInitalFormLoadThucThu(m_f340);
            }
            else if(m_type.Equals("GIAM_TRU")) {
                return new SetInitalFormLoadGiamTru(m_f340);
            }
            else if(m_type.Equals("DISPLAY")) {
                return new Display(m_f340, m_us_pt);
            }
            return new SetInitalFormLoadError(m_f340);
        }
    }
    //------------------------------
    public interface ISetInitialFormLoad {
        void SetInitialFormLoad(f340_lap_phieu_thu ip_frm);
    }
    /**********Set Initial Form Load Lap cac phieu PT,GT,.. ****/
    
    public class SetInitalFormLoadPhaiThu : ISetInitialFormLoad {
        public SetInitalFormLoadPhaiThu(f340_lap_phieu_thu ip_frm){
            SetInitialFormLoad(ip_frm);
        }
        public void SetInitialFormLoad(f340_lap_phieu_thu ip_frm) {
            ip_frm.Text = "F340 - Lập phiếu phải thu lẻ";
            ip_frm.m_lbl_header.Text = "LẬP PHIẾU PHẢI THU";
            ip_frm.m_cmd_ds_phieu.Text = "Danh sách phiếu phải thu";

            ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Nhập số tiền PHẢI THU theo từng lớp TẠI ĐÂY";
        }

    }
    public class SetInitalFormLoadThucThu : ISetInitialFormLoad {
        public SetInitalFormLoadThucThu(f340_lap_phieu_thu ip_frm){
            SetInitialFormLoad(ip_frm);
        }
        public void SetInitialFormLoad(f340_lap_phieu_thu ip_frm) {
            ip_frm.Text = "F340 - Lập phiếu thực thu lẻ";
            ip_frm.m_lbl_header.Text = "LẬP PHIẾU THỰC THU";
            ip_frm.m_cmd_ds_phieu.Text = "Danh sách phiếu thực thu";

            ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Nhập số tiền THỰC THU theo từng lớp TẠI ĐÂY";
        }

    }
    public class SetInitalFormLoadGiamTru : ISetInitialFormLoad {
        public SetInitalFormLoadGiamTru(f340_lap_phieu_thu ip_frm){
            SetInitialFormLoad(ip_frm);
        }
        public void SetInitialFormLoad(f340_lap_phieu_thu ip_frm) {
            ip_frm.Text = "F340 - Lập phiếu giảm trừ";
            ip_frm.m_lbl_header.Text = "LẬP PHIẾU GIẢM TRỪ";
            ip_frm.m_cmd_ds_phieu.Text = "Danh sách phiếu giảm trừ";

            ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Nhập số tiền GIẢM TRỪ theo từng lớp TẠI ĐÂY";
        }

    }
    public class SetInitalFormLoadError : ISetInitialFormLoad {
        public SetInitalFormLoadError(f340_lap_phieu_thu ip_frm){
            SetInitialFormLoad(ip_frm);
        }
        public void SetInitialFormLoad(f340_lap_phieu_thu ip_frm) {
            MessageBox.Show("Đã xảy ra lỗi!");
            return;
        }
    }
    /////End Set initial Form Load Lap Phieu----------------------



    /*******Display From ... *******/
    public class Display : ISetInitialFormLoad {
        public Display(f340_lap_phieu_thu ip_frm, US_V_GD_PHIEU_THU ip_us) {
            SetInitialFormLoad(ip_frm);
            ip_frm.m_txt_so_phieu.Text = ip_us.strSO_PHIEU;
            ip_frm.m_lbl_ten_hs.Text = ip_us.strHO_TEN;
            ip_frm.m_dat_ngay_thu.Value = ip_us.datNGAY_THU;
            ip_frm.m_dat_ngay_nhap.Value = ip_us.datNGAY_NHAP;
            ip_frm.m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;
            ip_frm.m_cbo_nhan_vien_nhap.SelectedValue = ip_us.dcID_NGUOI_NHAP;
            ip_frm.m_txt_ten_nguoi_nop_tien.Text = ip_us.strTEN_NGUOI_NOP_TIEN;
            ip_frm.m_txt_noi_dung.Text = ip_us.strNOI_DUNG;

            ip_frm.m_e_form_mode = DataEntryFormMode.UpdateDataState;

            ip_frm.m_cmd_ds_phieu.Visible = false;
            ip_frm.m_cmd_insert.Text = "Lưu sửa phiếu";
            ip_frm.m_cmd_chon_hs.Visible = false;
           
            

            if(ip_us.dcID_LOAI_PHIEU_THU == ID_LOAI_PHIEU_THU.ID_PHIEU_PHAI_THU) {
                ip_frm.m_txt_so_tien.Text = ip_us.dcSO_TIEN.ToString("#,###");
                ip_frm.m_lbl_header.Text = "CHI TIẾT PHIẾU PHẢI THU";
                ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Số tiền PHẢI THU";
            }
            else if(ip_us.dcID_LOAI_PHIEU_THU == ID_LOAI_PHIEU_THU.ID_PHIEU_GIAM_TRU) {
                ip_frm.m_txt_so_tien.Text = ip_us.dcSO_TIEN.ToString("#,###");
                ip_frm.m_lbl_header.Text = "CHI TIẾT PHIẾU GIẢM TRỪ";
                ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Số tiền GIẢM TRỪ";
            }
            else if(ip_us.dcID_LOAI_PHIEU_THU == ID_LOAI_PHIEU_THU.ID_PHIEU_THUC_THU) {
                ip_frm.m_txt_so_tien.Text = ip_us.dcSO_TIEN.ToString("#,###");
                ip_frm.m_lbl_header.Text = "CHI TIẾT PHIẾU THỰC THU";
                ip_frm.m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Số tiền THỰC THU";
            }
            ip_frm.ShowDialog();
        }
        public void SetInitialFormLoad(f340_lap_phieu_thu ip_frm) {
        }
    }
    //End Display From ....----------------------------
}
