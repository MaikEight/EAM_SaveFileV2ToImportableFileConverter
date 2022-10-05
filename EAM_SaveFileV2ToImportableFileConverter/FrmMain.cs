using CsvHelper.Configuration;
using ExaltAccountManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAM_SaveFileV2ToImportableFileConverter
{
    public partial class FrmMain : Form
    {
        UILoadAccounts uiLoadAccounts;

        public List<AccountInfo> Accounts
        {
            get => accountsValue;
            set 
            {
                accountsValue = value;
                AccountsChanged();
            }
        }
        private List<AccountInfo> accountsValue = new List<AccountInfo>();

        public FrmMain()
        {
            InitializeComponent();

            uiLoadAccounts = new UILoadAccounts(this)
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(uiLoadAccounts);
            this.Controls.SetChildIndex(uiLoadAccounts, 0);
        }

        public void AccountsChanged()
        {     
            if (accountsValue == null || accountsValue.Count == 0)
            {
                MessageBox.Show("Found no accounts, please select another File.", "No Accounts Found");
                return;
            }
            this.Controls.Remove(uiLoadAccounts);

            lAccountsFound.Text = accountsValue.Count.ToString();
        }

        private void ConvertToCSV(string path)
        {
            try
            {
                List<ExportCSVAccount> export = new List<ExportCSVAccount>();

                for (int i = 0; i < accountsValue.Count; i++)
                    export.Add(new ExportCSVAccount(accountsValue[i]));

                using (var writer = new StreamWriter(path))
                using (var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<ExportCSVAccountMap>();
                    csv.WriteRecords(export);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to accounts convert to a CSV file, please try again.{Environment.NewLine}{e.Message}{Environment.NewLine}{e.StackTrace}", "Convertion failed");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.Title = "Save your converted accounts!";
                diag.InitialDirectory = Application.StartupPath;
                diag.Filter = "CSV (*.csv)|*.csv";

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ConvertToCSV(diag.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to accounts export file, please try again.{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}", "Export failed");
                    }
                }
            }
        }
    }

    public class ExportCSVAccount
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public ExportCSVAccount() { }
        public ExportCSVAccount(AccountInfo info)
        {
            username = info.name;
            email = info.email;
            password = info.password;
        }
    }

    public sealed class ExportCSVAccountMap : ClassMap<ExportCSVAccount>
    {
        public ExportCSVAccountMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.username).Ignore();
        }
    }
}
