namespace Generator_faktur_FORM
{
    partial class CreateInvoice
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
            components = new System.ComponentModel.Container();
            createTxtId = new Label();
            createTxtDate = new Label();
            createTxtSupName = new Label();
            createTxtSupICO = new Label();
            createTxtCustName = new Label();
            createTxtCustICO = new Label();
            txtId = new TextBox();
            txtDate = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierICO = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerICO = new TextBox();
            datetxt = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvItems = new DataGridView();
            txtItemDescription = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAddItem = new Button();
            label8 = new Label();
            btnCreate = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // createTxtId
            // 
            createTxtId.AutoSize = true;
            createTxtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createTxtId.Location = new Point(22, 23);
            createTxtId.Name = "createTxtId";
            createTxtId.Size = new Size(114, 20);
            createTxtId.TabIndex = 1;
            createTxtId.Text = "ID/Číslo faktury:";
            // 
            // createTxtDate
            // 
            createTxtDate.AutoSize = true;
            createTxtDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createTxtDate.Location = new Point(22, 58);
            createTxtDate.Name = "createTxtDate";
            createTxtDate.Size = new Size(257, 20);
            createTxtDate.TabIndex = 2;
            createTxtDate.Text = "Zadejte datum faktury (dd-MM-yyyy):";
            // 
            // createTxtSupName
            // 
            createTxtSupName.AutoSize = true;
            createTxtSupName.Location = new Point(19, 304);
            createTxtSupName.Name = "createTxtSupName";
            createTxtSupName.Size = new Size(147, 15);
            createTxtSupName.TabIndex = 3;
            createTxtSupName.Text = "Zadejte jmeno dodavatele:";
            // 
            // createTxtSupICO
            // 
            createTxtSupICO.AutoSize = true;
            createTxtSupICO.Location = new Point(20, 337);
            createTxtSupICO.Name = "createTxtSupICO";
            createTxtSupICO.Size = new Size(176, 15);
            createTxtSupICO.TabIndex = 4;
            createTxtSupICO.Text = "Zadejte ICO dodavatele (8 cisel):";
            // 
            // createTxtCustName
            // 
            createTxtCustName.AutoSize = true;
            createTxtCustName.Location = new Point(19, 169);
            createTxtCustName.Name = "createTxtCustName";
            createTxtCustName.Size = new Size(136, 15);
            createTxtCustName.TabIndex = 5;
            createTxtCustName.Text = "Zadejte jmeno zakaznika";
            // 
            // createTxtCustICO
            // 
            createTxtCustICO.AutoSize = true;
            createTxtCustICO.Location = new Point(20, 202);
            createTxtCustICO.Name = "createTxtCustICO";
            createTxtCustICO.Size = new Size(165, 15);
            createTxtCustICO.TabIndex = 6;
            createTxtCustICO.Text = "Zadejte ICO zakaznika (8 cisel)";
            // 
            // txtId
            // 
            txtId.Location = new Point(171, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(133, 23);
            txtId.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(171, 81);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(133, 23);
            txtDate.TabIndex = 13;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(172, 301);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(132, 23);
            txtSupplierName.TabIndex = 14;
            // 
            // txtSupplierICO
            // 
            txtSupplierICO.Location = new Point(172, 358);
            txtSupplierICO.Name = "txtSupplierICO";
            txtSupplierICO.Size = new Size(132, 23);
            txtSupplierICO.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(172, 166);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(132, 23);
            txtCustomerName.TabIndex = 16;
            // 
            // txtCustomerICO
            // 
            txtCustomerICO.Location = new Point(172, 220);
            txtCustomerICO.Name = "txtCustomerICO";
            txtCustomerICO.Size = new Size(132, 23);
            txtCustomerICO.TabIndex = 17;
            // 
            // datetxt
            // 
            datetxt.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            datetxt.Location = new Point(643, 9);
            datetxt.Name = "datetxt";
            datetxt.Size = new Size(145, 23);
            datetxt.TabIndex = 0;
            datetxt.Text = "date";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(532, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 23;
            label1.Text = "dnešní datum -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline);
            label2.Location = new Point(13, 256);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 24;
            label2.Text = "Údaje dodavatele ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline);
            label3.Location = new Point(19, 121);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 25;
            label3.Text = "Údaje zákazníka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.Location = new Point(458, 48);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 26;
            label4.Text = "Produkt";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(334, 188);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(454, 164);
            dgvItems.TabIndex = 27;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(430, 89);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(138, 23);
            txtItemDescription.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 92);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 30;
            label5.Text = "Název";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(430, 118);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(138, 23);
            txtQuantity.TabIndex = 31;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(430, 147);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(138, 23);
            txtPrice.TabIndex = 32;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 150);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 34;
            label7.Text = "Cena";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(592, 109);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(122, 38);
            btnAddItem.TabIndex = 36;
            btnAddItem.Text = "Přidat Položku";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 121);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 37;
            label8.Text = "Množství";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(623, 376);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 62);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Vytvořit";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(491, 376);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 62);
            btnBack.TabIndex = 39;
            btnBack.Text = "Zpet";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(label8);
            Controls.Add(btnAddItem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(txtItemDescription);
            Controls.Add(dgvItems);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxt);
            Controls.Add(txtCustomerICO);
            Controls.Add(txtCustomerName);
            Controls.Add(txtSupplierICO);
            Controls.Add(txtSupplierName);
            Controls.Add(txtDate);
            Controls.Add(txtId);
            Controls.Add(createTxtCustICO);
            Controls.Add(createTxtCustName);
            Controls.Add(createTxtSupICO);
            Controls.Add(createTxtSupName);
            Controls.Add(createTxtDate);
            Controls.Add(createTxtId);
            Name = "CreateInvoice";
            Text = "CreateInvoice";
            Load += CreateInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label createTxtId;
        private Label createTxtDate;
        private Label createTxtSupName;
        private Label createTxtSupICO;
        private Label createTxtCustName;
        private Label createTxtCustICO;
        private TextBox txtId;
        private TextBox txtDate;
        private TextBox txtSupplierName;
        private TextBox txtSupplierICO;
        private TextBox txtCustomerName;
        private TextBox txtCustomerICO;
        private Label datetxt;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvItems;
        private TextBox txtItemDescription;
        private Label label5;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label6;
        private Label label7;
        private Button btnAddItem;
        private Label label8;
        private Button btnCreate;
        private Button btnBack;
    }
}