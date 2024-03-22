namespace PetStore_MaVanMeo
{
    partial class frmPetDetail
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
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            dtImportDate = new DateTimePicker();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            cboPetGroup = new ComboBox();
            btnSave = new Button();
            btnExit = new Button();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 131);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 10;
            label7.Text = "Pet Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 215);
            label6.Name = "label6";
            label6.Size = new Size(142, 32);
            label6.TabIndex = 9;
            label6.Text = "Import Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 306);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 7;
            label1.Text = "Pet Id";
            // 
            // dtImportDate
            // 
            dtImportDate.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            dtImportDate.Location = new Point(235, 217);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(405, 38);
            dtImportDate.TabIndex = 14;
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetName.Location = new Point(230, 126);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(403, 38);
            txtPetName.TabIndex = 13;
            // 
            // txtPetId
            // 
            txtPetId.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetId.Location = new Point(230, 51);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(403, 38);
            txtPetId.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 391);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 17;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 471);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 16;
            label4.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 555);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 15;
            label2.Text = "Pet Group";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(237, 306);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(403, 38);
            txtPrice.TabIndex = 18;
            // 
            // cboPetGroup
            // 
            cboPetGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPetGroup.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            cboPetGroup.FormattingEnabled = true;
            cboPetGroup.Location = new Point(235, 555);
            cboPetGroup.Name = "cboPetGroup";
            cboPetGroup.Size = new Size(398, 39);
            cboPetGroup.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(93, 738);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 64);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(409, 738);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 64);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(235, 387);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(398, 38);
            txtDescription.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(235, 471);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(398, 38);
            txtQuantity.TabIndex = 20;
            // 
            // frmPetDetail
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 901);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(cboPetGroup);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtImportDate);
            Controls.Add(txtPetName);
            Controls.Add(txtPetId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmPetDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPetDetail";
            Load += frmPetDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private DateTimePicker dtImportDate;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtPrice;
        private ComboBox cboPetGroup;
        private Button btnSave;
        private Button btnExit;
        private TextBox txtDescription;
        private TextBox txtQuantity;
    }
}