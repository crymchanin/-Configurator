using Feodosiya.Lib.IO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Configurator {
    public partial class MainForm : Form {
        private void TasksPage_LoadConf() {
            TasksListView.Items.Clear();

            ListViewItem[] items = new ListViewItem[AppHelper.Configuration.Tasks.Count];
            int index = 0;
            foreach (POFileManagerService.Configuration.Task task in AppHelper.Configuration.Tasks) {
                ListViewItem item = new ListViewItem(task.Name);
                item.UseItemStyleForSubItems = false;
                ListViewItem.ListViewSubItem subItem = item.SubItems.Add(task.Source);
                Color foreColor;
                try {
                    if (IOHelper.IsPathDirectory(task.Source)) {
                        foreColor = (Directory.Exists(task.Source)) ? Color.Black : Color.Magenta;
                    }
                    else {
                        foreColor = (File.Exists(task.Source)) ? Color.Black : Color.Magenta;
                    }
                }
                catch {
                    foreColor = Color.Magenta;
                }
                subItem.ForeColor = foreColor;
                item.Tag = task;

                items[index] = item;
                index++;
            }

            TasksListView.Items.AddRange(items);
        }

        private void AddTaskButton_Click(object sender, EventArgs e) {
            try {
                TaskForm form = new TaskForm();
                if (form.ShowDialog() == DialogResult.OK) {
                    POFileManagerService.Configuration.Task task = new POFileManagerService.Configuration.Task();
                    task.AllowDuplicate = form.Task.AllowDuplicate;
                    task.DayInterval = form.Task.DayInterval;
                    task.ExternalLib = form.Task.ExternalLib;
                    task.ExternalLibParams = form.Task.ExternalLibParams;
                    task.MoveFile = form.Task.MoveFile;
                    task.Name = form.Task.Name;
                    task.Recursive = form.Task.Recursive;
                    task.Regex = form.Task.Regex;
                    task.Source = form.Task.Source;
                    AppHelper.Configuration.Tasks.Add(task);
                    TasksPage_LoadConf();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditTaskButton_Click(object sender, EventArgs e) {
            try {
                if (TasksListView.SelectedItems.Count < 1) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                POFileManagerService.Configuration.Task task = (POFileManagerService.Configuration.Task)TasksListView.SelectedItems[0].Tag;
                TaskForm form = new TaskForm(task);
                if (form.ShowDialog() == DialogResult.OK) {
                    task.AllowDuplicate = form.Task.AllowDuplicate;
                    task.DayInterval = form.Task.DayInterval;
                    task.ExternalLib = form.Task.ExternalLib;
                    task.ExternalLibParams = form.Task.ExternalLibParams;
                    task.MoveFile = form.Task.MoveFile;
                    task.Name = form.Task.Name;
                    task.Recursive = form.Task.Recursive;
                    task.Regex = form.Task.Regex;
                    task.Source = form.Task.Source;
                    TasksPage_LoadConf();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e) {
            try {
                if (TasksListView.SelectedItems.Count < 1) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                POFileManagerService.Configuration.Task task = (POFileManagerService.Configuration.Task)TasksListView.SelectedItems[0].Tag;
                if (MessageBox.Show($"Удалить задачу '{task.Name}'?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    AppHelper.Configuration.Tasks.Remove(task);
                    TasksPage_LoadConf();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
