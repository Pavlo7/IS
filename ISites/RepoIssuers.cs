using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISites.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ISites
{
    public partial class RepoIssuers : Form
    {
        private ApplicationContext _context;

        public RepoIssuers(ApplicationContext _db)
        {
            InitializeComponent();

            _context = _db
              ?? throw new ArgumentException(nameof(_db));
        }

        private void RepoIssuers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            LoadData();
        }

        private void LoadData()
        {
            // получение
            //  using (ApplicationContext db = new ApplicationContext(options))
            //  {
            // получаем объекты из бд и выводим на консоль
            var countries = _context.Issuer.ToList();

            dataGridViewIssuers.DataSource = countries;

            //  }
        }
    }
}
