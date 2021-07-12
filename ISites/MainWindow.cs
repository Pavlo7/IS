using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISites
{
    public partial class MainWindow : Form
    {
        string VersionPO = "ISites.exe v1.0";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = VersionPO;
            using (ApplicationContext db = new ApplicationContext())
            {

            }
        }
    }
}
