using FluentFTP;
using System;
using System.Net;
using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        private bool TestFtpConnection(string host, int port, string user, string password, string cwd, out string message) {
            try {
                using (FtpClient ftpClient = new FtpClient(host, port, new NetworkCredential(user, password))) {
                    ftpClient.Connect();
                    ftpClient.SetWorkingDirectory(cwd);
                    ftpClient.Disconnect();
                }
                message = "";
            }
            catch (Exception ex) {
                message = ex.Message;
                return false;
            }
            return true;
        }

        private void ExternalFtp_LoadConf() {
            ExternalHostBox.Text = AppHelper.Configuration.Ftp.Host;
            ExternalLoginBox.Text = AppHelper.Configuration.Ftp.Username;
            ExternalPortBox.Value = AppHelper.Configuration.Ftp.Port;
            ExternalPasswordBox.Text = AppHelper.Configuration.Ftp.Password;
            ExternalCwdBox.Text = AppHelper.Configuration.Ftp.Cwd;
        }

        private void ExternalFtp_UpdateConf() {
            AppHelper.Configuration.Ftp.Host = ExternalHostBox.Text;
            AppHelper.Configuration.Ftp.Username = ExternalLoginBox.Text;
            AppHelper.Configuration.Ftp.Port = (int)ExternalPortBox.Value;
            AppHelper.Configuration.Ftp.Password = ExternalPasswordBox.Text;
            AppHelper.Configuration.Ftp.Cwd = ExternalCwdBox.Text;
        }

        private void ExternalTestConnectionButton_Click(object sender, EventArgs e) {
            string message;
            if (TestFtpConnection(ExternalHostBox.Text, (int)ExternalPortBox.Value, ExternalLoginBox.Text, ExternalPasswordBox.Text, ExternalCwdBox.Text, out message)) {
                MessageBox.Show("Соединение было успешно установлено", "Хост: " + ExternalHostBox.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                MessageBox.Show(message, "Хост: " + ExternalHostBox.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
