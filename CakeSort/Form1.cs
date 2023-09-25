using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeSort
{
    public partial class Form1 : Form
    {
        Pastel[] dataset; 
        private CurrencyManager currencyManager = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataset = new Pastel[10];
            dataset[0] = new Pastel("Rojo", 3,"Manzano", 15.23, 8, 8.3, "zarza");
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[dataset];
            dataGridView1.DataSource = dataset;
        }

        private void addCakeButton_Click(object sender, EventArgs e)
        {
            dataset[1] = new Pastel("Rojo", 3, "Manzano", 15.23, 8, 8.3, "zarza");
        }
    }
}
