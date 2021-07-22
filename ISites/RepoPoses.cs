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
    public partial class RepoPoses : Form
    {
        private ApplicationContext _context;

        public RepoPoses(ApplicationContext _db)
        {
            InitializeComponent();

            _context = _db
               ?? throw new ArgumentException(nameof(_db));
        }

        private void RepoPoses_Load(object sender, EventArgs e)
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
            // var poses = _context.Pos.ToList();

            var poses = _context.Pos.Select(p => new
            {
                Id = p.Id,
                PosCode = p.PosCode,
                PosName = p.PosName,
                Owner = p.Owner.OwnerName,
                Country = p.Owner.Country.Name
            });

            dataGridViewPoses.DataSource = poses.ToList();
            dataGridViewPoses.Columns[0].Visible = false;

            //  }
        }

        private void dataGridViewPoses_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;
            // var pos = ;
            foreach (DataGridViewRow row in dataGridViewPoses.SelectedRows)
               int.TryParse(row.Cells[0].Value.ToString(), out id);

            var issuers = _context.PosIssuer.Where(u=>u.PosId==id).Select(p => new
            {
                Id = p.Id,
                IssuerName = p.Issuer.IssuerName,
                IssuerPosCode = p.IssuerPosCode,
                
            });

            dataGridViewPosIssuer.DataSource = issuers.ToList();
            dataGridViewPosIssuer.Columns[0].Visible = false;
        }

        private void dataGridViewPosIssuer_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;

            foreach (DataGridViewRow row in dataGridViewPosIssuer.SelectedRows)
                int.TryParse(row.Cells[0].Value.ToString(), out id);

            var issuersproduct = _context.IssuerProduct.Where(u => u.PosIssuerId == id).Select(p => new
            {
                ProductName = p.Product.ProductName,
                IssuerProductCode = p.IssuerProductCode,

            });

            dataGridViewIssuerProduct.DataSource = issuersproduct.ToList();
        }

      
    }
}
