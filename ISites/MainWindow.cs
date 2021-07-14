using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ISites
{
    public partial class MainWindow : Form
    {
        string VersionPO = "ISites.exe v1.0";

        private ApplicationContext _context;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = VersionPO;

            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            _context = new ApplicationContext(options);
        }

        private void toolStripMenuItemCountries_Click(object sender, EventArgs e)
        {
            RepoCountries wnd = null;

            foreach (Form f in this.MdiChildren)
            {
                if (f is RepoCountries)
                    wnd = f as RepoCountries;
            }

            if (wnd == null)
                wnd = new RepoCountries(_context);

            wnd.MdiParent = this;
            wnd.Show();
            wnd.Activate();
        }
      
    }
}
