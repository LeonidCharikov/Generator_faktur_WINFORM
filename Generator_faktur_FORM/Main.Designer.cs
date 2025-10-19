namespace Generator_faktur_FORM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCreator2 = new Label();
            txtCreator = new Label();
            btnOpen = new Button();
            btnCreate = new Button();
            TextMain = new Label();
            datetxt = new Label();
            timetxt = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtCreator2
            // 
            txtCreator2.AutoSize = true;
            txtCreator2.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            txtCreator2.Location = new Point(556, 423);
            txtCreator2.Name = "txtCreator2";
            txtCreator2.Size = new Size(170, 18);
            txtCreator2.TabIndex = 11;
            txtCreator2.Text = "CZU INFO 2025/2026";
            // 
            // txtCreator
            // 
            txtCreator.AutoSize = true;
            txtCreator.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            txtCreator.Location = new Point(556, 403);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(242, 18);
            txtCreator.TabIndex = 10;
            txtCreator.Text = "Created by: Leonid Čarikov";
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOpen.Location = new Point(437, 181);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(130, 88);
            btnOpen.TabIndex = 8;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ButtonFace;
            btnCreate.Font = new Font("Microsoft YaHei UI", 12F);
            btnCreate.Location = new Point(226, 181);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 88);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // TextMain
            // 
            TextMain.AutoSize = true;
            TextMain.Font = new Font("Tahoma", 21.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            TextMain.Location = new Point(283, 77);
            TextMain.Name = "TextMain";
            TextMain.Size = new Size(230, 35);
            TextMain.TabIndex = 6;
            TextMain.Text = "Generator Faktur";
            // 
            // datetxt
            // 
            datetxt.AutoSize = true;
            datetxt.Font = new Font("Tahoma", 15.75F);
            datetxt.Location = new Point(12, 381);
            datetxt.Name = "datetxt";
            datetxt.Size = new Size(53, 25);
            datetxt.TabIndex = 13;
            datetxt.Text = "date";
            // 
            // timetxt
            // 
            timetxt.AutoSize = true;
            timetxt.Font = new Font("Tahoma", 15.75F);
            timetxt.Location = new Point(12, 407);
            timetxt.Name = "timetxt";
            timetxt.Size = new Size(53, 25);
            timetxt.TabIndex = 14;
            timetxt.Text = "time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(timetxt);
            Controls.Add(datetxt);
            Controls.Add(txtCreator2);
            Controls.Add(txtCreator);
            Controls.Add(btnOpen);
            Controls.Add(btnCreate);
            Controls.Add(TextMain);
            Name = "MainForm";
            Text = "Generator Faktur";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCreator2;
        private Label txtCreator;
        private Button btnOpen;
        private Button btnCreate;
        private Label TextMain;
        private Label datetxt;
        private Label timetxt;
        private System.Windows.Forms.Timer timer1;
    }
}
