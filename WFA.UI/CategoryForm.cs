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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        BaseRepository<Category>category=new BaseRepository<Category>();

        public void GenerateListView()
        {
            foreach ( Category c in category.GetList())
            {
                ListViewItem liv = new ListViewItem();
                liv.Text = c.ID.ToString();
                liv.SubItems.Add(c.CategoryName);
               
                listView1.Items.Add(liv);
            }
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.ID = 1;
            c.CategoryName = "Teknoloji";
            category.Create(c);
            GenerateListView();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            category.GetList();
            GenerateListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category gelenkategori = category.Find(1);
            gelenkategori.CategoryName = "Giyim";
            category.Update(gelenkategori);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Category silinenkategori=category.Find(1);
            category.Delete(silinenkategori);
           
        }
    }
}
