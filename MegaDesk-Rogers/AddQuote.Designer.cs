namespace MegaDesk_Rogers
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDeskWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDeskDepth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDrawerNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMaterialType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputRushOrder = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.messageDeskWidth = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.messageDeskDepth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name";
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCustomerName.Location = new System.Drawing.Point(48, 81);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(207, 26);
            this.inputCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width of desk";
            // 
            // inputDeskWidth
            // 
            this.inputDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDeskWidth.Location = new System.Drawing.Point(48, 144);
            this.inputDeskWidth.Name = "inputDeskWidth";
            this.inputDeskWidth.Size = new System.Drawing.Size(207, 26);
            this.inputDeskWidth.TabIndex = 3;
            this.inputDeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.inputDeskWidth_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth of desk";
            // 
            // inputDeskDepth
            // 
            this.inputDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDeskDepth.Location = new System.Drawing.Point(48, 209);
            this.inputDeskDepth.Name = "inputDeskDepth";
            this.inputDeskDepth.Size = new System.Drawing.Size(207, 26);
            this.inputDeskDepth.TabIndex = 5;
            this.inputDeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDeskDepth_KeyPress);
            this.inputDeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.inputDeskDepth_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of drawers";
            // 
            // inputDrawerNumber
            // 
            this.inputDrawerNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDrawerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDrawerNumber.FormattingEnabled = true;
            this.inputDrawerNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.inputDrawerNumber.Location = new System.Drawing.Point(48, 273);
            this.inputDrawerNumber.Name = "inputDrawerNumber";
            this.inputDrawerNumber.Size = new System.Drawing.Size(207, 28);
            this.inputDrawerNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Material type";
            // 
            // inputMaterialType
            // 
            this.inputMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMaterialType.FormattingEnabled = true;
            this.inputMaterialType.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.inputMaterialType.Location = new System.Drawing.Point(48, 338);
            this.inputMaterialType.Name = "inputMaterialType";
            this.inputMaterialType.Size = new System.Drawing.Size(207, 28);
            this.inputMaterialType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Order processing time";
            // 
            // inputRushOrder
            // 
            this.inputRushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRushOrder.FormattingEnabled = true;
            this.inputRushOrder.Items.AddRange(new object[] {
            "Regular",
            "7 Day",
            "5 Day",
            "3 Day",
            ""});
            this.inputRushOrder.Location = new System.Drawing.Point(48, 404);
            this.inputRushOrder.Name = "inputRushOrder";
            this.inputRushOrder.Size = new System.Drawing.Size(207, 28);
            this.inputRushOrder.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(531, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // messageDeskWidth
            // 
            this.messageDeskWidth.AutoSize = true;
            this.messageDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDeskWidth.ForeColor = System.Drawing.Color.Red;
            this.messageDeskWidth.Location = new System.Drawing.Point(261, 147);
            this.messageDeskWidth.Name = "messageDeskWidth";
            this.messageDeskWidth.Size = new System.Drawing.Size(0, 20);
            this.messageDeskWidth.TabIndex = 13;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(668, 403);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(120, 35);
            this.btnSubmitOrder.TabIndex = 14;
            this.btnSubmitOrder.Text = "Submit";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // messageDeskDepth
            // 
            this.messageDeskDepth.AutoSize = true;
            this.messageDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDeskDepth.ForeColor = System.Drawing.Color.Red;
            this.messageDeskDepth.Location = new System.Drawing.Point(261, 212);
            this.messageDeskDepth.Name = "messageDeskDepth";
            this.messageDeskDepth.Size = new System.Drawing.Size(0, 20);
            this.messageDeskDepth.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, -1);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(15, 10, 635, 10);
            this.label7.Size = new System.Drawing.Size(800, 51);
            this.label7.TabIndex = 16;
            this.label7.Text = "New Quote";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Rogers.Properties.Resources.desk_background;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.messageDeskDepth);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.messageDeskWidth);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.inputRushOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputMaterialType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDrawerNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputDeskDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDeskWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDeskWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDeskDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputDrawerNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputMaterialType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputRushOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label messageDeskWidth;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Label messageDeskDepth;
        private System.Windows.Forms.Label label7;
    }
}