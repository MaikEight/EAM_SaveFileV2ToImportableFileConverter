using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MK_EAM_Lib;
using ExaltAccountManager;
using System.Runtime.Serialization.Formatters.Binary;

namespace EAM_SaveFileV2ToImportableFileConverter
{
    public partial class UILoadAccounts : UserControl
    {
        FrmMain frm;

        public UILoadAccounts(FrmMain _frm)
        {
            InitializeComponent();
            frm = _frm;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            lWarning.Visible = false;
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.Title = "Please select your Exalt Account Manager v2.0.8 save file";
                diag.Multiselect = false;
                diag.InitialDirectory = Application.StartupPath;
                diag.Filter = "All files (*.*)|*.*";

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    try
                    {                        
                        byte[] data = File.ReadAllBytes(diag.FileName);
                        AesCryptographyService acs = new AesCryptographyService();
                        frm.Accounts = (List<AccountInfo>)ByteArrayToObject(acs.Decrypt(data));
                    }
                    catch (Exception ex)
                    {
                        lWarning.Visible = true;
                        
                        string errorMessasge = $"File:{Environment.NewLine}{diag.FileName}{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}Stacktrace:{Environment.NewLine}{ex.StackTrace}";
                        MessageBox.Show($"ERROR MESSAGE HAS BEEN COPIED TO YOUR CLIPBOARD{Environment.NewLine}{Environment.NewLine}{errorMessasge}", "Failed to parse save file");
                        Clipboard.SetText(errorMessasge);
                    }
                }
            }
        }

        private object ByteArrayToObject(byte[] arrBytes)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                object obj = (object)binForm.Deserialize(memStream);

                return obj;
            }
        }

        private void lIcons8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com/icons");
        }
    }
}
