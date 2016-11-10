using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f261_dm_tag : Form
    {
        private readonly TagRepository _tagRepository;
        public f261_dm_tag()
        {
            _tagRepository = new TagRepository();
            InitializeComponent();
            init();
        }

        private void init()
        {
            var data = _tagRepository.getTags();
            gridControl1.DataSource = data;
        }
    }
}
