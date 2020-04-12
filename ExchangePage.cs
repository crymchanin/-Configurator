using Configurator.ru.crimeanpost.cas;
using System;
using System.Net;
using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        private bool CheckConnection(string host, string domain, string username, string password, out string message) {
            try {
                message = string.Empty;

                ExchangeServiceBinding bind = new ExchangeServiceBinding();
                bind.Credentials = new NetworkCredential(username, password, domain);
                bind.Url = "https://" + host + "/EWS/Exchange.asmx";

                FindItemType findType = new FindItemType();
                findType.Traversal = ItemQueryTraversalType.Shallow;
                findType.ItemShape = new ItemResponseShapeType();
                findType.ItemShape.BaseShape = DefaultShapeNamesType.IdOnly;

                DistinguishedFolderIdType folder = new DistinguishedFolderIdType();
                folder.Id = DistinguishedFolderIdNameType.inbox;
                findType.ParentFolderIds = new BaseFolderIdType[] { folder };

                FindItemResponseType findResp = bind.FindItem(findType);
            }
            catch (Exception error) {
                message = error.Message;
                return false;
            }

            return true;
        }

        private void ExchangePage_LoadConf() {
            ExHostBox.Text = AppHelper.Configuration.Mail.Host;
            ExDomainBox.Text = AppHelper.Configuration.Mail.Domain;
            ExUsernameBox.Text = AppHelper.Configuration.Mail.Username;
            ExPasswordBox.Text = AppHelper.Configuration.Mail.Password;
            ExRecipientBox.Text = AppHelper.Configuration.Mail.ToRecipient;
            ExCertBox.Text = AppHelper.Configuration.Mail.CertificateName;
        }

        private void ExchangePage_UpdateConf() {
            AppHelper.Configuration.Mail.Host = ExHostBox.Text;
            AppHelper.Configuration.Mail.Domain = ExDomainBox.Text;
            AppHelper.Configuration.Mail.Username = ExUsernameBox.Text;
            AppHelper.Configuration.Mail.Password = ExPasswordBox.Text;
            AppHelper.Configuration.Mail.ToRecipient = ExRecipientBox.Text;
            AppHelper.Configuration.Mail.CertificateName = ExCertBox.Text;
        }

        private void ExchangeTestButton_Click(object sender, EventArgs e) {
            string message;
            if (CheckConnection(ExHostBox.Text, ExDomainBox.Text, ExUsernameBox.Text, ExPasswordBox.Text, out message)) {
                MessageBox.Show("Подключение установлено", string.Format("Хост: {0}", ExHostBox.Text),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show(string.Format("Подключение не установлено. Текст ошибки:\r\n{0}", message), string.Format("Хост: {0}",
                    ExHostBox.Text), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
