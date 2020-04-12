using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Configurator {
    public partial class ExternalLibParamsForm : Form {

        private KeyValuePair<string, object> _param;

        public KeyValuePair<string, object> Param {
            get {
                return _param;
            }
            set {
                _param = new KeyValuePair<string, object>(value.Key, value.Value);
            }
        }

        public ExternalLibParamsForm() {
            InitializeComponent();
        }

        public ExternalLibParamsForm(KeyValuePair<string, object> param) : this() {
            Param = param;

            KeyBox.Text = _param.Key;
            ValueBox.Text = _param.Value.ToString();
            KeyBox.SelectionLength = 0;
            KeyBox.SelectionStart = KeyBox.Text.Length;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            if (KeyBox.Text.ToLower().Trim() == "filename") {
                MessageBox.Show("Указанное имя параметра является зарезервированным. Выберите другое имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _param = new KeyValuePair<string, object>(KeyBox.Text, ValueBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
