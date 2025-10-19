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
            createTxtItemDesc = new Label();
            createTxtItemQuant = new Label();
            createTxtItemPrice = new Label();
            btnBack = new Button();
            btnCreate = new Button();
            txtId = new TextBox();
            txtDate = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierICO = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerICO = new TextBox();
            txtItemDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            datetxt = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // createTxtId
            // 
            createTxtId.AutoSize = true;
            createTxtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createTxtId.Location = new Point(155, 26);
            createTxtId.Name = "createTxtId";
            createTxtId.Size = new Size(114, 20);
            createTxtId.TabIndex = 1;
            createTxtId.Text = "ID/Číslo faktury:";
            // 
            // createTxtDate
            // 
            createTxtDate.AutoSize = true;
            createTxtDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createTxtDate.Location = new Point(12, 70);
            createTxtDate.Name = "createTxtDate";
            createTxtDate.Size = new Size(257, 20);
            createTxtDate.TabIndex = 2;
            createTxtDate.Text = "Zadejte datum faktury (dd-MM-yyyy):";
            // 
            // createTxtSupName
            // 
            createTxtSupName.AutoSize = true;
            createTxtSupName.Location = new Point(62, 165);
            createTxtSupName.Name = "createTxtSupName";
            createTxtSupName.Size = new Size(147, 15);
            createTxtSupName.TabIndex = 3;
            createTxtSupName.Text = "Zadejte jmeno dodavatele:";
            // 
            // createTxtSupICO
            // 
            createTxtSupICO.AutoSize = true;
            createTxtSupICO.Location = new Point(33, 198);
            createTxtSupICO.Name = "createTxtSupICO";
            createTxtSupICO.Size = new Size(176, 15);
            createTxtSupICO.TabIndex = 4;
            createTxtSupICO.Text = "Zadejte ICO dodavatele (8 cisel):";
            // 
            // createTxtCustName
            // 
            createTxtCustName.AutoSize = true;
            createTxtCustName.Location = new Point(382, 165);
            createTxtCustName.Name = "createTxtCustName";
            createTxtCustName.Size = new Size(136, 15);
            createTxtCustName.TabIndex = 5;
            createTxtCustName.Text = "Zadejte jmeno zakaznika";
            // 
            // createTxtCustICO
            // 
            createTxtCustICO.AutoSize = true;
            createTxtCustICO.Location = new Point(353, 198);
            createTxtCustICO.Name = "createTxtCustICO";
            createTxtCustICO.Size = new Size(165, 15);
            createTxtCustICO.TabIndex = 6;
            createTxtCustICO.Text = "Zadejte ICO zakaznika (8 cisel)";
            // 
            // createTxtItemDesc
            // 
            createTxtItemDesc.AutoSize = true;
            createTxtItemDesc.Location = new Point(74, 280);
            createTxtItemDesc.Name = "createTxtItemDesc";
            createTxtItemDesc.Size = new Size(122, 15);
            createTxtItemDesc.TabIndex = 7;
            createTxtItemDesc.Text = "Zadejte popis polozky";
            // 
            // createTxtItemQuant
            // 
            createTxtItemQuant.AutoSize = true;
            createTxtItemQuant.Location = new Point(50, 388);
            createTxtItemQuant.Name = "createTxtItemQuant";
            createTxtItemQuant.Size = new Size(141, 15);
            createTxtItemQuant.TabIndex = 8;
            createTxtItemQuant.Text = "Zadejte mnozstvi polozky";
            // 
            // createTxtItemPrice
            // 
            createTxtItemPrice.AutoSize = true;
            createTxtItemPrice.Location = new Point(42, 344);
            createTxtItemPrice.Name = "createTxtItemPrice";
            createTxtItemPrice.Size = new Size(154, 15);
            createTxtItemPrice.TabIndex = 9;
            createTxtItemPrice.Text = "Zadejte cenu polozky za kus";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.AntiqueWhite;
            btnBack.Location = new Point(559, 368);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 54);
            btnBack.TabIndex = 10;
            btnBack.Text = "Zpět";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.AntiqueWhite;
            btnCreate.Location = new Point(675, 368);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(88, 54);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Vytvořit";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(275, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(133, 23);
            txtId.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(275, 71);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(133, 23);
            txtDate.TabIndex = 13;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(212, 162);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(132, 23);
            txtSupplierName.TabIndex = 14;
            // 
            // txtSupplierICO
            // 
            txtSupplierICO.Location = new Point(212, 195);
            txtSupplierICO.Name = "txtSupplierICO";
            txtSupplierICO.Size = new Size(132, 23);
            txtSupplierICO.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(525, 162);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(132, 23);
            txtCustomerName.TabIndex = 16;
            // 
            // txtCustomerICO
            // 
            txtCustomerICO.Location = new Point(525, 195);
            txtCustomerICO.Name = "txtCustomerICO";
            txtCustomerICO.Size = new Size(132, 23);
            txtCustomerICO.TabIndex = 17;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(212, 277);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(259, 48);
            txtItemDescription.TabIndex = 18;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(212, 385);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(132, 23);
            txtQuantity.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(212, 344);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(132, 23);
            txtPrice.TabIndex = 20;
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
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 24;
            label2.Text = "Údaje dodavatele ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline);
            label3.Location = new Point(356, 119);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 25;
            label3.Text = "Údaje zákazníka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.Location = new Point(128, 239);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 26;
            label4.Text = "Produkt";
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxt);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemDescription);
            Controls.Add(txtCustomerICO);
            Controls.Add(txtCustomerName);
            Controls.Add(txtSupplierICO);
            Controls.Add(txtSupplierName);
            Controls.Add(txtDate);
            Controls.Add(txtId);
            Controls.Add(btnCreate);
            Controls.Add(btnBack);
            Controls.Add(createTxtItemPrice);
            Controls.Add(createTxtItemQuant);
            Controls.Add(createTxtItemDesc);
            Controls.Add(createTxtCustICO);
            Controls.Add(createTxtCustName);
            Controls.Add(createTxtSupICO);
            Controls.Add(createTxtSupName);
            Controls.Add(createTxtDate);
            Controls.Add(createTxtId);
            Name = "CreateInvoice";
            Text = "CreateInvoice";
            Load += CreateInvoice_Load;
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
        private Label createTxtItemDesc;
        private Label createTxtItemQuant;
        private Label createTxtItemPrice;
        private Button btnBack;
        private Button btnCreate;
        private TextBox txtId;
        private TextBox txtDate;
        private TextBox txtSupplierName;
        private TextBox txtSupplierICO;
        private TextBox txtCustomerName;
        private TextBox txtCustomerICO;
        private TextBox txtItemDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label datetxt;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}