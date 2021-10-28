namespace print_barcode
{
    partial class Form1
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxBarcodeHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarcodeX = new System.Windows.Forms.TextBox();
            this.textBoxBarcodeY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodeX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodeY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPaperWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPaperHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(25, 322);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(109, 36);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBarcode.Location = new System.Drawing.Point(19, 165);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(246, 20);
            this.textBoxBarcode.TabIndex = 0;
            this.textBoxBarcode.Text = "1010101111";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(19, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 88);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(202, 322);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(109, 36);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxText.Location = new System.Drawing.Point(19, 3);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(246, 20);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.Text = "Product name";
            // 
            // textBoxBarcodeHeight
            // 
            this.textBoxBarcodeHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxBarcodeHeight.Location = new System.Drawing.Point(144, 163);
            this.textBoxBarcodeHeight.Name = "textBoxBarcodeHeight";
            this.textBoxBarcodeHeight.Size = new System.Drawing.Size(50, 20);
            this.textBoxBarcodeHeight.TabIndex = 6;
            this.textBoxBarcodeHeight.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkodyn beyikligi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Barkodyn oni:";
            // 
            // textBoxBarcodeX
            // 
            this.textBoxBarcodeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxBarcodeX.Location = new System.Drawing.Point(144, 137);
            this.textBoxBarcodeX.Name = "textBoxBarcodeX";
            this.textBoxBarcodeX.Size = new System.Drawing.Size(50, 20);
            this.textBoxBarcodeX.TabIndex = 8;
            this.textBoxBarcodeX.Text = "40";
            // 
            // textBoxBarcodeY
            // 
            this.textBoxBarcodeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxBarcodeY.Location = new System.Drawing.Point(144, 111);
            this.textBoxBarcodeY.Name = "textBoxBarcodeY";
            this.textBoxBarcodeY.Size = new System.Drawing.Size(50, 20);
            this.textBoxBarcodeY.TabIndex = 8;
            this.textBoxBarcodeY.Text = "35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Barkodyn yokarsy:";
            // 
            // textBoxCodeX
            // 
            this.textBoxCodeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxCodeX.Location = new System.Drawing.Point(144, 250);
            this.textBoxCodeX.Name = "textBoxCodeX";
            this.textBoxCodeX.Size = new System.Drawing.Size(50, 20);
            this.textBoxCodeX.TabIndex = 8;
            this.textBoxCodeX.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Haryt kodyn oni:";
            // 
            // textBoxCodeY
            // 
            this.textBoxCodeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxCodeY.Location = new System.Drawing.Point(144, 224);
            this.textBoxCodeY.Name = "textBoxCodeY";
            this.textBoxCodeY.Size = new System.Drawing.Size(50, 20);
            this.textBoxCodeY.TabIndex = 8;
            this.textBoxCodeY.Text = "35";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Haryt kodunyn yokarsy:";
            // 
            // textBoxNameX
            // 
            this.textBoxNameX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxNameX.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameX.Location = new System.Drawing.Point(144, 85);
            this.textBoxNameX.Name = "textBoxNameX";
            this.textBoxNameX.Size = new System.Drawing.Size(50, 20);
            this.textBoxNameX.TabIndex = 8;
            this.textBoxNameX.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Haryt adynyn oni:";
            // 
            // textBoxNameY
            // 
            this.textBoxNameY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxNameY.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameY.Location = new System.Drawing.Point(144, 62);
            this.textBoxNameY.Name = "textBoxNameY";
            this.textBoxNameY.Size = new System.Drawing.Size(50, 20);
            this.textBoxNameY.TabIndex = 8;
            this.textBoxNameY.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Haryt adynyn yokarsy:";
            // 
            // textBoxPaperWidth
            // 
            this.textBoxPaperWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxPaperWidth.Location = new System.Drawing.Point(343, 58);
            this.textBoxPaperWidth.Name = "textBoxPaperWidth";
            this.textBoxPaperWidth.Size = new System.Drawing.Size(50, 20);
            this.textBoxPaperWidth.TabIndex = 8;
            this.textBoxPaperWidth.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(262, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kagyzyn ini:";
            // 
            // textBoxPaperHeight
            // 
            this.textBoxPaperHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxPaperHeight.Location = new System.Drawing.Point(144, 194);
            this.textBoxPaperHeight.Name = "textBoxPaperHeight";
            this.textBoxPaperHeight.Size = new System.Drawing.Size(50, 20);
            this.textBoxPaperHeight.TabIndex = 8;
            this.textBoxPaperHeight.Text = "79";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kagyzyn beyikligi:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Location = new System.Drawing.Point(202, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 188);
            this.panel1.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(377, 322);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 36);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPaperHeight);
            this.Controls.Add(this.textBoxPaperWidth);
            this.Controls.Add(this.textBoxNameY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameX);
            this.Controls.Add(this.textBoxCodeY);
            this.Controls.Add(this.textBoxCodeX);
            this.Controls.Add(this.textBoxBarcodeY);
            this.Controls.Add(this.textBoxBarcodeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBarcodeHeight);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Setting size";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxBarcodeHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBarcodeX;
        private System.Windows.Forms.TextBox textBoxBarcodeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodeX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodeY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPaperWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPaperHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
    }
}

