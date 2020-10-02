namespace MegaDesk_Rogers
{
    partial class MainMenu
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
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(55, 78);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(150, 35);
            this.btnAddQuote.TabIndex = 0;
            this.btnAddQuote.Text = "&Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = false;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(55, 134);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(150, 35);
            this.btnViewQuotes.TabIndex = 1;
            this.btnViewQuotes.Text = "&View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = false;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnViewQuotes_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(55, 190);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(150, 35);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "&Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = false;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(55, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 10, 500, 10);
            this.label1.Size = new System.Drawing.Size(808, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to MegaDesk";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Rogers.Properties.Resources.desk_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

