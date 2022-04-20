using BLL.Repository;
using DAL.Context;
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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
           
        }
        BaseRepository<Product>product=new BaseRepository<Product>();
        MyContext db=new MyContext();

        public void GenerateListView()
        {
            listView1.Items.Clear();
            
            foreach (Product p in product.GetList())
            {
                ListViewItem liv = new ListViewItem();
                liv.Text = p.ID.ToString();
                liv.SubItems.Add(p.ProductName);
                liv.SubItems.Add(p.UnitPrice.ToString());
                liv.SubItems.Add(p.UnitsInStock.ToString());
                string result = p.CategoryId== null ? "Tanımsız" : p.Category.CategoryName;
                liv.SubItems.Add(result);
                listView1.Items.Add(liv);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = "Kulaklık";
            p.UnitPrice = 1500;
            p.UnitsInStock = 25;
            p.CategoryId =(int?)cmbCategory.SelectedValue;
            product.Create(p);
            GenerateListView();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = db.Categories.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            product.GetList();
            GenerateListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product gelenUrun = product.Find(2);
            gelenUrun.ProductName = "Bilgisayar";
            gelenUrun.UnitPrice = 15000;
            gelenUrun.UnitsInStock = 5;
            product.Update(gelenUrun);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product silinendeger=product.Find(2);
            product.Delete(silinendeger);
           
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

       
    }
}
