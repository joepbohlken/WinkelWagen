using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinkelWagenProgramma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Categorie categorie = new Categorie();
            groupBoxCategorie.Text = categorie.name;
            categorie.addToCategorieList();

            button1.Text = categorie.CategorieList[0];
            button2.Text = categorie.CategorieList[1];
            button3.Text = categorie.CategorieList[2];
            button4.Text = categorie.CategorieList[3];
            button5.Text = categorie.CategorieList[4];
        }
    }
}
