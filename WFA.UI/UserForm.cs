using BLL.Repository;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        UserRepository<AppUser>user=new UserRepository<AppUser>();
        public void GenerateListView()
        {
            foreach (AppUser a in user.GetList())
            {
                ListViewItem liv = new ListViewItem();
                liv.Text = a.ID.ToString();
                liv.SubItems.Add(a.Username);
                liv.SubItems.Add(a.Email);
                liv.SubItems.Add(a.Username);

                listView1.Items.Add(liv);
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            AppUser u = new AppUser();
            u.ID = 1;
            u.Username = "Sevil";
            u.Email = "sevil@gmail.com";
            u.Password = "1234";
            user.GetList().Add(u);

        }
    }
}
