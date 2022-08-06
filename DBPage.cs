using Feodosiya.Lib.Security;
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
            bool pooling = DBPoolingBox.Checked;
            int connLifetime = (int)DBConnLifetimeBox.Value;

            return string.Format("User={0};Password={1};Database={2};DataSource={3};Charset=WIN1251;Pooling={4};Connection lifetime={5};",
                username,
                password,
                database,
                datasource,
                pooling.ToString().ToLower(),
                connLifetime.ToString());
        }

        private void DBPage_LoadConf() {
            DBDatabaseBox.Text = AppHelper.Configuration.Sql.Database;
            DBDataSourceBox.Text = AppHelper.Configuration.Sql.DataSource;
            DBUsernameBox.Text = AppHelper.Configuration.Sql.Username;
            DBPasswordBox.Text = AppHelper.Configuration.Sql.Password;
            DBPoolingBox.Checked = AppHelper.Configuration.Sql.Pooling;
            DBConnLifetimeBox.Value = AppHelper.Configuration.Sql.ConnectionLifetime;
        }

        private void DBPage_UpdateConf() {
            AppHelper.Configuration.Sql.Database = DBDatabaseBox.Text;
            AppHelper.Configuration.Sql.DataSource = DBDataSourceBox.Text;
            AppHelper.Configuration.Sql.Username = DBUsernameBox.Text;
            AppHelper.Configuration.Sql.Password = Pbkdf2Cryptography.Encrypt(StringHelper.Encoding.GetBytes(DBPasswordBox.Text), StringHelper.PassPhrase);
            AppHelper.Configuration.Sql.Pooling = DBPoolingBox.Checked;
            AppHelper.Configuration.Sql.ConnectionLifetime = (int)DBConnLifetimeBox.Value;
        }

        private void DBTestConnectionButton_Click(object sender, EventArgs e) {
            bool flag = TestConnection(DBPage_GetConnectString());
            MessageBox.Show((flag) ? "Подключение выполнено!" : "Подключение не выполнено!", "Тест подключения", MessageBoxButtons.OK, (flag) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}
