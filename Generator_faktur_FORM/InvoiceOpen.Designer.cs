namespace Generator_faktur_FORM
{
    partial class InvoiceOpen
    {
        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnClose = new Button();
            lblId = new Label();
            lblDate = new Label();
            lblSupplier = new Label();
            lblCustomer = new Label();
            lblTotal = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            dgvPreview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(644, 368);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 60);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblId.Location = new Point(240, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(107, 45);
            lblId.TabIndex = 1;
            lblId.Text = "label1";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14.25F);
            lblDate.Location = new Point(156, 76);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "label2";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 14.25F);
            lblSupplier.Location = new Point(423, 76);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(63, 25);
            lblSupplier.TabIndex = 3;
            lblSupplier.Text = "label3";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 14.25F);
            lblCustomer.Location = new Point(423, 112);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(63, 25);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "label4";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F);
            lblTotal.Location = new Point(240, 348);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label8";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(102, 348);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 27;
            label8.Text = "Celkova cena:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(265, 112);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 23;
            label4.Text = "Udaje zakaznika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(254, 76);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 22;
            label3.Text = "Udaje dodavatele:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(78, 76);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 21;
            label2.Text = "Datum:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(23, 19);
            label9.Name = "label9";
            label9.Size = new Size(221, 33);
            label9.TabIndex = 28;
            label9.Text = "Otevreni Faktury:";
            // 
            // dgvPreview
            // 
            dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.Location = new Point(78, 166);
            dgvPreview.Name = "dgvPreview";
            dgvPreview.Size = new Size(669, 158);
            dgvPreview.TabIndex = 29;
            // 
            // InvoiceOpen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPreview);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(lblCustomer);
            Controls.Add(lblSupplier);
            Controls.Add(lblDate);
            Controls.Add(lblId);
            Controls.Add(btnClose);
            Name = "InvoiceOpen";
            Text = "InvoiceOpen";
            Load += InvoiceOpen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnClose;
        private Label lblId;
        private Label lblDate;
        private Label lblSupplier;
        private Label lblCustomer;
        private Label lblTotal;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private DataGridView dgvPreview;
    }
}