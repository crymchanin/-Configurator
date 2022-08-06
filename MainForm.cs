using Feodosiya.Lib.Conf;
using Feodosiya.Lib.Security;
using POFileManagerService.Configuration;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {

        private void LoadConfiguration(string confPath) {
            try {
                if (!File.Exists(confPath)) {
                    throw new Exception("Выбранный файл конфигурации приложения не существует");
                }
                InfoStatusLabel.Text = confPath;

                AppHelper.ConfHelper = new ConfHelper(confPath);
                AppHelper.Configuration = AppHelper.ConfHelper.LoadConfig<Global>();
                if (!AppHelper.ConfHelper.Success) {
                    throw new Exception(AppHelper.ConfHelper.LastError.ToString());
                }

                GlobalPage_LoadConf();
                DBPage_LoadConf();
                ExternalFtp_LoadConf();
                ExchangePage_LoadConf();
                TasksPage_LoadConf();

                AppHelper.IsSaved = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MainForm() {
            InitializeComponent();

            StringHelper.Encoding = Encoding.UTF8;
            StringHelper.PassPhrase = "22644ccf-87ac-426a-b9dc-1f1207bdbfcc";
            AppHelper.AdminPermisiions = SecurityHelper.IsAdministrator();
            if (AppHelper.AdminPermisiions) {
                Text = Text + " [Администратор]";
            }
            else {
                Text = Text + " [Пользователь]";
            }
            ShowPasswordViewControls();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1) {
                LoadConfiguration(args[1]);
            }
        }

        private Button CreatePassPrevButton(int x, int y, TextBox passBox, int passBoxW) {
            passBox.Width = passBoxW;
            Button prevButton = new Button();
            prevButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prevButton.BackgroundImage = Properties.Resources.hide;
            prevButton.BackgroundImageLayout = ImageLayout.Center;
            prevButton.FlatAppearance.BorderSize = 0;
            prevButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            prevButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            prevButton.Cursor = Cursors.Hand;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Location = new System.Drawing.Point(x, y);
            prevButton.Size = new System.Drawing.Size(23, 23);
            prevButton.TabIndex = 4;
            prevButton.UseVisualStyleBackColor = true;
            prevButton.MouseDown += (s, e) => {
                (s as Button).BackgroundImage = Properties.Resources.show;
                passBox.UseSystemPasswordChar = false;
            };
            prevButton.MouseUp += (s, e) => {
                (s as Button).BackgroundImage = Properties.Resources.hide;
                passBox.UseSystemPasswordChar = true;
            };

            return prevButton;
        }

        private void ShowPasswordViewControls() {
            if (AppHelper.AdminPermisiions) {
                DBGroupBox.Controls.Add(CreatePassPrevButton(497, 90, DBPasswordBox, 225));
                ExternalGroupBox.Controls.Add(CreatePassPrevButton(497, 90, ExternalPasswordBox, 225));
                ExchangeGroupBox.Controls.Add(CreatePassPrevButton(497, 90, ExPasswordBox, 225));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            try {
                bool isNewFile = false;
                if (AppHelper.ConfHelper == null) {
                    if (MessageBox.Show("Файл конфигурации не открыт. Создать новый?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        string newFile = Path.Combine(Feodosiya.Lib.IO.IOHelper.GetCurrentDir(System.Reflection.Assembly.GetExecutingAssembly()),
                            "POFileManagerService.conf");
                        if (File.Exists(newFile)) {
                            if (MessageBox.Show(string.Format("Файл '{0}' уже существует. Заменить?", newFile),
                                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                                return;
                            }
                        }
                        isNewFile = true;
                        InfoStatusLabel.Text = newFile;
                        AppHelper.ConfHelper = new ConfHelper(newFile);
                        AppHelper.ConfHelper.SaveConfig(new Global(), Encoding.UTF8, true);
                        if (!AppHelper.ConfHelper.Success) {
                            throw new Exception(AppHelper.ConfHelper.LastError.ToString());
                        }

                        LoadConfiguration(newFile);
                    }
                    else {
                        System.Media.SystemSounds.Beep.Play();
                        return;
                    }
                }
                else {
                    if (!AppHelper.ConfHelper.Success) {
                        throw new Exception(AppHelper.ConfHelper.LastError.ToString());
                    }
                }

                if (!isNewFile) {
                    if (MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        GlobalPage_UpdateConf();
                        DBPage_UpdateConf();
                        ExternalFtp_UpdateConf();
                        ExchangePage_UpdateConf();
                        AppHelper.ConfHelper.SaveConfig(AppHelper.Configuration, Encoding.UTF8, true);
                        if (!AppHelper.ConfHelper.Success) {
                            MessageBox.Show(AppHelper.ConfHelper.LastError.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else {
                            AppHelper.IsSaved = true;
                            MessageBox.Show("Файл конфигурации сохранен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK) {
                LoadConfiguration(MainOpenFileDialog.FileName);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (AppHelper.IsSaved) {
                return;
            }
            if (MessageBox.Show("Выйти без сохранения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                e.Cancel = true;
            }
        }

        private void DebuggingBox_CheckedChanged(object sender, EventArgs e) {
            DebuggingLevelLabel.Visible = DebuggingBox.Checked;
            DebuggingLevelBox.Visible = DebuggingBox.Checked;
        }

        private void CheckUpdatesBox_CheckedChanged(object sender, EventArgs e) {
            UpdateServiceLabel.Visible = CheckUpdatesBox.Checked;
            UpdateServiceBox.Visible = CheckUpdatesBox.Checked;
        }
    }
}
