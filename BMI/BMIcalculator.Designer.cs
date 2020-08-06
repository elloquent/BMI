namespace BMI
{
    partial class BMIcalculator
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sevenbutton = new System.Windows.Forms.Button();
            this.fourbutton = new System.Windows.Forms.Button();
            this.eightbutton = new System.Windows.Forms.Button();
            this.fifthbutton = new System.Windows.Forms.Button();
            this.secondbutton = new System.Windows.Forms.Button();
            this.ninebutton = new System.Windows.Forms.Button();
            this.sixthbutton = new System.Windows.Forms.Button();
            this.thirdbutton = new System.Windows.Forms.Button();
            this.firstbutton = new System.Windows.Forms.Button();
            this.pointbutton = new System.Windows.Forms.Button();
            this.zerobutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poundButton = new System.Windows.Forms.RadioButton();
            this.kiloButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weighttextBox = new System.Windows.Forms.TextBox();
            this.heighttextBox = new System.Windows.Forms.TextBox();
            this.heightlabel = new System.Windows.Forms.Label();
            this.weightlabel = new System.Windows.Forms.Label();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.calulatebutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.sevenbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fourbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fifthbutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.secondbutton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ninebutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sixthbutton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.thirdbutton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pointbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.zerobutton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearbutton, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sevenbutton
            // 
            this.sevenbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.sevenbutton.Location = new System.Drawing.Point(3, 3);
            this.sevenbutton.Name = "sevenbutton";
            this.sevenbutton.Size = new System.Drawing.Size(92, 40);
            this.sevenbutton.TabIndex = 12;
            this.sevenbutton.Tag = "operand";
            this.sevenbutton.Text = "7";
            this.sevenbutton.UseVisualStyleBackColor = false;
            this.sevenbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // fourbutton
            // 
            this.fourbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.fourbutton.Location = new System.Drawing.Point(3, 49);
            this.fourbutton.Name = "fourbutton";
            this.fourbutton.Size = new System.Drawing.Size(92, 40);
            this.fourbutton.TabIndex = 3;
            this.fourbutton.Tag = "operand";
            this.fourbutton.Text = "4";
            this.fourbutton.UseVisualStyleBackColor = false;
            this.fourbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // eightbutton
            // 
            this.eightbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.eightbutton.Location = new System.Drawing.Point(101, 3);
            this.eightbutton.Name = "eightbutton";
            this.eightbutton.Size = new System.Drawing.Size(92, 40);
            this.eightbutton.TabIndex = 13;
            this.eightbutton.Tag = "operand";
            this.eightbutton.Text = "8";
            this.eightbutton.UseVisualStyleBackColor = false;
            this.eightbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // fifthbutton
            // 
            this.fifthbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.fifthbutton.Location = new System.Drawing.Point(101, 49);
            this.fifthbutton.Name = "fifthbutton";
            this.fifthbutton.Size = new System.Drawing.Size(92, 40);
            this.fifthbutton.TabIndex = 4;
            this.fifthbutton.Tag = "operand";
            this.fifthbutton.Text = "5";
            this.fifthbutton.UseVisualStyleBackColor = false;
            this.fifthbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // secondbutton
            // 
            this.secondbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.secondbutton.Location = new System.Drawing.Point(101, 95);
            this.secondbutton.Name = "secondbutton";
            this.secondbutton.Size = new System.Drawing.Size(92, 40);
            this.secondbutton.TabIndex = 1;
            this.secondbutton.Tag = "operand";
            this.secondbutton.Text = "2";
            this.secondbutton.UseVisualStyleBackColor = false;
            this.secondbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // ninebutton
            // 
            this.ninebutton.BackColor = System.Drawing.Color.Fuchsia;
            this.ninebutton.Location = new System.Drawing.Point(199, 3);
            this.ninebutton.Name = "ninebutton";
            this.ninebutton.Size = new System.Drawing.Size(94, 40);
            this.ninebutton.TabIndex = 14;
            this.ninebutton.Tag = "operand";
            this.ninebutton.Text = "9";
            this.ninebutton.UseVisualStyleBackColor = false;
            this.ninebutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // sixthbutton
            // 
            this.sixthbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.sixthbutton.Location = new System.Drawing.Point(199, 49);
            this.sixthbutton.Name = "sixthbutton";
            this.sixthbutton.Size = new System.Drawing.Size(94, 40);
            this.sixthbutton.TabIndex = 5;
            this.sixthbutton.Tag = "operand";
            this.sixthbutton.Text = "6";
            this.sixthbutton.UseVisualStyleBackColor = false;
            this.sixthbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // thirdbutton
            // 
            this.thirdbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.thirdbutton.Location = new System.Drawing.Point(199, 95);
            this.thirdbutton.Name = "thirdbutton";
            this.thirdbutton.Size = new System.Drawing.Size(94, 40);
            this.thirdbutton.TabIndex = 2;
            this.thirdbutton.Tag = "operand";
            this.thirdbutton.Text = "3";
            this.thirdbutton.UseVisualStyleBackColor = false;
            this.thirdbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // firstbutton
            // 
            this.firstbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.firstbutton.Location = new System.Drawing.Point(3, 95);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(92, 40);
            this.firstbutton.TabIndex = 0;
            this.firstbutton.Tag = "operand";
            this.firstbutton.Text = "1";
            this.firstbutton.UseVisualStyleBackColor = false;
            this.firstbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // pointbutton
            // 
            this.pointbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.pointbutton.Location = new System.Drawing.Point(3, 141);
            this.pointbutton.Name = "pointbutton";
            this.pointbutton.Size = new System.Drawing.Size(92, 39);
            this.pointbutton.TabIndex = 15;
            this.pointbutton.Tag = "operand";
            this.pointbutton.Text = ".";
            this.pointbutton.UseVisualStyleBackColor = false;
            this.pointbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // zerobutton
            // 
            this.zerobutton.BackColor = System.Drawing.Color.Goldenrod;
            this.zerobutton.Location = new System.Drawing.Point(101, 141);
            this.zerobutton.Name = "zerobutton";
            this.zerobutton.Size = new System.Drawing.Size(92, 39);
            this.zerobutton.TabIndex = 16;
            this.zerobutton.Tag = "operand";
            this.zerobutton.Text = "0";
            this.zerobutton.UseVisualStyleBackColor = false;
            this.zerobutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.clearbutton.Location = new System.Drawing.Point(199, 141);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(94, 39);
            this.clearbutton.TabIndex = 17;
            this.clearbutton.Tag = "operator";
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.backbutton.BackgroundImage = global::BMI.Properties.Resources.rsz_download_1;
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backbutton.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(151, 209);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(147, 41);
            this.backbutton.TabIndex = 1;
            this.backbutton.Tag = "operator";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.poundButton);
            this.groupBox1.Controls.Add(this.kiloButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-7, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select measurement type";
            // 
            // poundButton
            // 
            this.poundButton.AutoSize = true;
            this.poundButton.BackColor = System.Drawing.Color.Aqua;
            this.poundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundButton.Location = new System.Drawing.Point(181, 24);
            this.poundButton.Name = "poundButton";
            this.poundButton.Size = new System.Drawing.Size(83, 28);
            this.poundButton.TabIndex = 1;
            this.poundButton.TabStop = true;
            this.poundButton.Text = "pound";
            this.poundButton.UseVisualStyleBackColor = false;
            // 
            // kiloButton
            // 
            this.kiloButton.AutoSize = true;
            this.kiloButton.BackColor = System.Drawing.Color.Aqua;
            this.kiloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiloButton.Location = new System.Drawing.Point(34, 23);
            this.kiloButton.Name = "kiloButton";
            this.kiloButton.Size = new System.Drawing.Size(102, 28);
            this.kiloButton.TabIndex = 0;
            this.kiloButton.TabStop = true;
            this.kiloButton.Text = "Kilogram";
            this.kiloButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.weighttextBox);
            this.panel1.Controls.Add(this.heighttextBox);
            this.panel1.Controls.Add(this.heightlabel);
            this.panel1.Controls.Add(this.weightlabel);
            this.panel1.Controls.Add(this.resulttextBox);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 144);
            this.panel1.TabIndex = 3;
            // 
            // weighttextBox
            // 
            this.weighttextBox.BackColor = System.Drawing.SystemColors.Window;
            this.weighttextBox.Location = new System.Drawing.Point(111, 66);
            this.weighttextBox.Multiline = true;
            this.weighttextBox.Name = "weighttextBox";
            this.weighttextBox.Size = new System.Drawing.Size(182, 37);
            this.weighttextBox.TabIndex = 4;
            this.weighttextBox.Click += new System.EventHandler(this.weighttextBox_Click);
            // 
            // heighttextBox
            // 
            this.heighttextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heighttextBox.BackColor = System.Drawing.SystemColors.Window;
            this.heighttextBox.Location = new System.Drawing.Point(111, 102);
            this.heighttextBox.Multiline = true;
            this.heighttextBox.Name = "heighttextBox";
            this.heighttextBox.Size = new System.Drawing.Size(182, 38);
            this.heighttextBox.TabIndex = 3;
            this.heighttextBox.Click += new System.EventHandler(this.heighttextBox_Click);
            // 
            // heightlabel
            // 
            this.heightlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightlabel.Location = new System.Drawing.Point(3, 99);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(93, 38);
            this.heightlabel.TabIndex = 2;
            this.heightlabel.Text = "Height";
            this.heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightlabel
            // 
            this.weightlabel.Location = new System.Drawing.Point(3, 66);
            this.weightlabel.Name = "weightlabel";
            this.weightlabel.Size = new System.Drawing.Size(102, 37);
            this.weightlabel.TabIndex = 1;
            this.weightlabel.Text = "Weight";
            this.weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resulttextBox
            // 
            this.resulttextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resulttextBox.Location = new System.Drawing.Point(-9, 0);
            this.resulttextBox.Multiline = true;
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.ReadOnly = true;
            this.resulttextBox.Size = new System.Drawing.Size(315, 63);
            this.resulttextBox.TabIndex = 0;
            // 
            // calulatebutton
            // 
            this.calulatebutton.BackColor = System.Drawing.Color.Fuchsia;
            this.calulatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calulatebutton.Location = new System.Drawing.Point(5, 209);
            this.calulatebutton.Name = "calulatebutton";
            this.calulatebutton.Size = new System.Drawing.Size(146, 41);
            this.calulatebutton.TabIndex = 4;
            this.calulatebutton.Text = "Calculate";
            this.calulatebutton.UseVisualStyleBackColor = false;
            this.calulatebutton.Click += new System.EventHandler(this.calulatebutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BMIcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.calulatebutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMIcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI_Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button firstbutton;
        private System.Windows.Forms.Button secondbutton;
        private System.Windows.Forms.Button thirdbutton;
        private System.Windows.Forms.Button fourbutton;
        private System.Windows.Forms.Button fifthbutton;
        private System.Windows.Forms.Button sixthbutton;
        private System.Windows.Forms.Button sevenbutton;
        private System.Windows.Forms.Button eightbutton;
        private System.Windows.Forms.Button ninebutton;
        private System.Windows.Forms.Button pointbutton;
        private System.Windows.Forms.Button zerobutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton poundButton;
        private System.Windows.Forms.RadioButton kiloButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox weighttextBox;
        private System.Windows.Forms.TextBox heighttextBox;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.Button calulatebutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

