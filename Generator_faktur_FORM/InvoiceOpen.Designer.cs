namespace Generator_faktur_FORM
{
    partial class InvoiceOpen
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
            btnClose = new Button();
            lblId = new Label();
            lblDate = new Label();
            lblSupplier = new Label();
            lblCustomer = new Label();
            lblItem = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
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
            lblDate.Location = new Point(240, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "label2";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 14.25F);
            lblSupplier.Location = new Point(240, 133);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(63, 25);
            lblSupplier.TabIndex = 3;
            lblSupplier.Text = "label3";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 14.25F);
            lblCustomer.Location = new Point(240, 173);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(63, 25);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "label4";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI", 14.25F);
            lblItem.Location = new Point(240, 214);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(63, 25);
            lblItem.TabIndex = 5;
            lblItem.Text = "label5";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F);
            lblQuantity.Location = new Point(240, 259);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(63, 25);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "label6";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F);
            lblPrice.Location = new Point(240, 304);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "label7";
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
            label8.Location = new Point(78, 348);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 27;
            label8.Text = "Celkova cena:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(89, 304);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 26;
            label7.Text = "Cena za kus:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(61, 259);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 25;
            label6.Text = "Pocet produktu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(62, 214);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 24;
            label5.Text = "Popis produktu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(53, 173);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 23;
            label4.Text = "Udaje zakaznika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(42, 133);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 22;
            label3.Text = "Udaje dodavatele:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(133, 85);
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
            // InvoiceOpen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblItem);
            Controls.Add(lblCustomer);
            Controls.Add(lblSupplier);
            Controls.Add(lblDate);
            Controls.Add(lblId);
            Controls.Add(btnClose);
            Name = "InvoiceOpen";
            Text = "InvoiceOpen";
            Load += InvoiceOpen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblId;
        private Label lblDate;
        private Label lblSupplier;
        private Label lblCustomer;
        private Label lblItem;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblTotal;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
    }
}