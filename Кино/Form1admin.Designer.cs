namespace Кино
{
    partial class Form1admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1284, 702);
            this.tabControl.TabIndex = 0;
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.Coral;
            this.tabDelete.Controls.Add(this.panel2);
            this.tabDelete.Controls.Add(this.comboBox2);
            this.tabDelete.Location = new System.Drawing.Point(4, 30);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(1276, 668);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Удаление";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(218, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 662);
            this.panel2.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Фильм",
            "Киносеанс",
            "Кинотеатр"});
            this.comboBox2.Location = new System.Drawing.Point(23, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 30);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.MouseCaptureChanged += new System.EventHandler(this.comboBox2_MouseCaptureChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фильм",
            "Киносеанс",
            "Кинотеатр"});
            this.comboBox1.Location = new System.Drawing.Point(20, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.MouseCaptureChanged += new System.EventHandler(this.comboBox1_MouseCaptureChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(217, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 662);
            this.panel1.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Khaki;
            this.tabAdd.Controls.Add(this.panel1);
            this.tabAdd.Controls.Add(this.comboBox1);
            this.tabAdd.Location = new System.Drawing.Point(4, 30);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1276, 668);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Добавление";
            // 
            // Form1admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации от имени администратора";
            this.tabControl.ResumeLayout(false);
            this.tabDelete.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}