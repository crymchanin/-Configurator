namespace Configurator {
    partial class ExternalLibParamsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValueBox
            // 
            this.ValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBox.BackColor = System.Drawing.Color.Salmon;
            this.ValueBox.Location = new System.Drawing.Point(9, 81);
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ValueBox.Size = new System.Drawing.Size(328, 137);
            this.ValueBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Значение";
            // 
            // KeyBox
            // 
            this.KeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBox.BackColor = System.Drawing.Color.Salmon;
            this.KeyBox.Location = new System.Drawing.Point(9, 35);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(328, 23);
            this.KeyBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя параметра";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(9, 241);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(328, 28);
            this.OkButton.TabIndex = 15;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExternalLibParamsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 281);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExternalLibParamsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
    }
}