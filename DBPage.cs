using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        public bool TestConnection(string connectionString) {
            try {
                using (FbConnection connection = new FbConnection(connectionString)) {
                    connection.Open();

                    bool result = (connection.State == ConnectionState.Open);

                    return result;
                }
            }
            catch {
                return false;
            }
        }

        private string DBPage_GetConnectString() {
            string username = DBUsernameBox.Text;
            string password = DBPasswordBox.Text;
            string database = DBDatabaseBox.Text;
            string datasource = DBDataSourceBox.Text;

            return string.Format("User={0};Password={1};Database={2};DataSource={3};Charset=WIN1251;Pooling=false;Connection lifetime=60;",
                username,
                password,
                database,
                datasource);
        }

        private void DBPage_LoadConf() {
            DBDatabaseBox.Text = AppHelper.Configuration.Sql.Database;
            DBDataSourceBox.Text = AppHelper.Configuration.Sql.DataSource;
            DBUsernameBox.Text = AppHelper.Configuration.Sql.Username;
            DBPasswordBox.Text = AppHelper.Configuration.Sql.Password;
        }

        private void DBPage_UpdateConf() {
            AppHelper.Configuration.Sql.Database = DBDatabaseBox.Text;
            AppHelper.Configuration.Sql.DataSource = DBDataSourceBox.Text;
            AppHelper.Configuration.Sql.Username = DBUsernameBox.Text;
            AppHelper.Configuration.Sql.Password = DBPasswordBox.Text;
        }

        private void DBTestConnectionButton_Click(object sender, EventArgs e) {
            bool flag = TestConnection(DBPage_GetConnectString());
            MessageBox.Show((flag) ? "Подключение выполнено!" : "Подключение не выполнено!", "Тест подключения", MessageBoxButtons.OK, (flag) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}
