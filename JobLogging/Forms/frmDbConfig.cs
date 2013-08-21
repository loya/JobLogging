using System;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace JobLogging.Forms
{
    public partial class frmDbConfig : XtraForm
    {
        public frmDbConfig()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var connectionString = GlobalParams.ConnectionString(txtDataSource.Text, txtUserID.Text, txtPassword.Text);
            var context = new JobLoggingModel.JobLoggingModelContainer(connectionString);
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                if (!context.Roles.Any())
                    new Common.Database().ReInitRoleAndPermission();
                var symmetricMethod = new Common.SymmetricMethod();
                
                Properties.Settings.Default.DataSource = txtDataSource.Text;
                Properties.Settings.Default.UserID = symmetricMethod.EncryptoData(txtUserID.Text);
                Properties.Settings.Default.Password = symmetricMethod.EncryptoData(txtPassword.Text);
                Properties.Settings.Default.Save();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDbConfig_Load(object sender, EventArgs e)
        {
            var symmetricMethod =new Common.SymmetricMethod();

            txtDataSource.Text = Properties.Settings.Default.DataSource;
            txtUserID.Text = symmetricMethod.DecryptoData(Properties.Settings.Default.UserID);
            txtPassword.Text = symmetricMethod.DecryptoData(Properties.Settings.Default.Password);
        }
    }
}