using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext();

            // LINQ (Language Intergrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();
        }

        private void btnAllCAVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext();

            // LINQ (Language Intergrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorState)
                                        .ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext();
            
            // Anonymous type
            var results = (from v in dbContext.Vendors
                           select new
                           {
                               v.VendorName,
                               v.VendorState,
                               v.VendorCity
                           }).ToList();
                               
            StringBuilder displayString = new StringBuilder();
            foreach(var vendor in results )
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}, {vendor.VendorState}");
            }
            MessageBox.Show( displayString.ToString() );
            
            // Using additional VendorLocation class
            List<VendorLocation> result2 = (from v in dbContext.Vendors
                                            select new VendorLocation
                                            {
                                                VendorName = v.VendorName,
                                                VendorState = v.VendorState,
                                                VendorCity = v.VendorCity
                                            }).ToList();

            StringBuilder displayString2 = new StringBuilder();
            foreach (VendorLocation vendor in result2)
            {
                displayString2.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}, {vendor.VendorState}");
            }
            MessageBox.Show(displayString2.ToString());
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; }
        public string VendorState { get; set;}
        public string VendorCity { get; set;}

    }
}