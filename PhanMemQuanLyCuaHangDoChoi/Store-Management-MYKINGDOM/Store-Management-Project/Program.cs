using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmLogin loginForm = null;
        public static frmMain mainForm = null;
        public static frmCustomer customerForm = null;
        public static frmBrand brandForm = null;
        public static frmCategories categoriesForm = null;
        public static frmStaff staffForm = null;
        public static frmOrder orderForm = null;
        public static frmImport importForm = null;
        public static frmImportFinsh importfinishForm = null;
        public static frmWarehouse warehouseForm = null;
        public static frmProduct productForm = null;
        public static frmAccountStaff accountStaffForm = null;
        public static frmBillManagement billManagementForm = null;
        public static frmAccountCustomer accountCustomerForm = null;
        public static frmOrderOnline orderOnlineForm = null;
        public static frmStatistics statisticsForm = null;
        public static frmVoucher voucherForm = null;
        public static frmChangePassword changePasswordForm = null;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
