using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        private void GlobalPage_LoadConf() {
            ZipCodeBox.Value = AppHelper.Configuration.ZipCode;
            TaskIntervalBox.Value = AppHelper.Configuration.TaskInterval;
            AdditionalTimeBox.Value = AppHelper.Configuration.AdditionalTime;
            DebuggingBox.Checked = AppHelper.Configuration.DebuggingEnabled;
            DebuggingLevelBox.Value = AppHelper.Configuration.DebuggingLevel;

            UpdateServiceBox.Text = AppHelper.Configuration.Updates.UpdaterServiceName;
            CheckUpdatesBox.Checked = AppHelper.Configuration.Updates.CheckUpdates;

            MaxLogLengthBox.Value = AppHelper.Configuration.Logs.MaxLogLength;
            LogsLifetimeBox.Value = AppHelper.Configuration.Logs.CompressedLogsLifetime;
        }

        private void GlobalPage_UpdateConf() {
            AppHelper.Configuration.ZipCode = (int)ZipCodeBox.Value;
            AppHelper.Configuration.TaskInterval = (int)TaskIntervalBox.Value;
            AppHelper.Configuration.AdditionalTime = (int)AdditionalTimeBox.Value;
            AppHelper.Configuration.DebuggingEnabled = DebuggingBox.Checked;
            AppHelper.Configuration.DebuggingLevel = (int)DebuggingLevelBox.Value;

            AppHelper.Configuration.Updates.UpdaterServiceName = UpdateServiceBox.Text;
            AppHelper.Configuration.Updates.CheckUpdates = CheckUpdatesBox.Checked;

            AppHelper.Configuration.Logs.MaxLogLength = (long)MaxLogLengthBox.Value;
            AppHelper.Configuration.Logs.CompressedLogsLifetime = (int)LogsLifetimeBox.Value;
        }
    }
}
