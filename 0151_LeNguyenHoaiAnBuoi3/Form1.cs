using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0151_LeNguyenHoaiAnBuoi3
{
    public partial class FrmNv : Form
    {
        public FrmNv()
        {
            InitializeComponent();
        }
        private void a(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvNhanVien.SelectedItems.Count > 0)
            {
                txtLastName.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                txtFirstName.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = lvNhanVien.SelectedItems[0].SubItems[2].Text;
            }
        }

        //Thêm 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lviAdd = new ListViewItem(txtLastName.Text);
            lviAdd.SubItems.Add(txtFirstName.Text);
            lviAdd.SubItems.Add(txtPhone.Text);
            lvNhanVien.Items.Add(lviAdd);    
        }

        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (lvNhanVien.SelectedItems.Count > 0) 
           {
                lvNhanVien.Items.Remove(lvNhanVien.SelectedItems[0]);
           }
           else
           {
                MessageBox.Show("Chọn ít nhất 1 dòng để xóa!", "Thông báo");     
           }
        }

        //Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
           if (lvNhanVien.SelectedItems.Count > 0)
           {
                lvNhanVien.SelectedItems[0].SubItems[0].Text = txtLastName.Text;
                lvNhanVien.SelectedItems[0].SubItems[1].Text = txtFirstName.Text;
                lvNhanVien.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
           }
           else
           {
                MessageBox.Show("Chọn ít nhất 1 dòng để sửa!", "thông báo"); 
           }
        }

    }
}
