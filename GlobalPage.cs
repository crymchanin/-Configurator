using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        private void GlobalPage_LoadConf() {
            ZipCodeBox.Value = AppHelper.Configuration.ZipCode;
            TaskIntervalBox.Value = AppHelper.Configuration.TaskInterval;
            AdditionalTimeBox.Value = AppHelper.Configuration.AdditionalTime;
            DebuggingBox.Checked = AppHelper.Configuration.DebuggingEnabled;

            UpdateServiceBox.Text = AppHelper.Configuration.UpdaterServiceName;
        }

        private void GlobalPage_UpdateConf() {
            AppHelper.Configuration.ZipCode = (int)ZipCodeBox.Value;
            AppHelper.Configuration.TaskInterval = (int)TaskIntervalBox.Value;
            AppHelper.Configuration.AdditionalTime = (int)AdditionalTimeBox.Value;
            AppHelper.Configuration.DebuggingEnabled = DebuggingBox.Checked;

            AppHelper.Configuration.UpdaterServiceName = UpdateServiceBox.Text;
        }
    }
}
