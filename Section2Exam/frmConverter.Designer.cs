namespace Section2Exam
{
    partial class frmConverter
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
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvertTo = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnBase5 = new System.Windows.Forms.Button();
            this.btnBase7 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConvertFrom.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertFrom.ForeColor = System.Drawing.Color.Black;
            this.txtConvertFrom.Location = new System.Drawing.Point(214, 0);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.Size = new System.Drawing.Size(548, 26);
            this.txtConvertFrom.TabIndex = 0;
            // 
            // txtBase
            // 
            this.txtBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.ForeColor = System.Drawing.Color.Black;
            this.txtBase.Location = new System.Drawing.Point(214, 25);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(548, 26);
            this.txtBase.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(-1, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(763, 65);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(-1, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 63);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(569, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConvertTo
            // 
            this.btnConvertTo.BackColor = System.Drawing.Color.MintCream;
            this.btnConvertTo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertTo.Location = new System.Drawing.Point(-1, 118);
            this.btnConvertTo.Name = "btnConvertTo";
            this.btnConvertTo.Size = new System.Drawing.Size(193, 63);
            this.btnConvertTo.TabIndex = 5;
            this.btnConvertTo.Text = "Convert To";
            this.btnConvertTo.UseVisualStyleBackColor = false;
            this.btnConvertTo.Click += new System.EventHandler(this.btnConvertTo_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.MintCream;
            this.btnBinary.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.Location = new System.Drawing.Point(189, 118);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(193, 63);
            this.btnBinary.TabIndex = 6;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.MintCream;
            this.btnHex.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(189, 178);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(193, 63);
            this.btnHex.TabIndex = 7;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.BackColor = System.Drawing.Color.MintCream;
            this.btnOctal.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(379, 178);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(193, 63);
            this.btnOctal.TabIndex = 8;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = false;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnBase5
            // 
            this.btnBase5.BackColor = System.Drawing.Color.MintCream;
            this.btnBase5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase5.Location = new System.Drawing.Point(379, 118);
            this.btnBase5.Name = "btnBase5";
            this.btnBase5.Size = new System.Drawing.Size(193, 63);
            this.btnBase5.TabIndex = 9;
            this.btnBase5.Text = "Base 5";
            this.btnBase5.UseVisualStyleBackColor = false;
            this.btnBase5.Click += new System.EventHandler(this.btnBase5_Click);
            // 
            // btnBase7
            // 
            this.btnBase7.BackColor = System.Drawing.Color.MintCream;
            this.btnBase7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase7.Location = new System.Drawing.Point(569, 118);
            this.btnBase7.Name = "btnBase7";
            this.btnBase7.Size = new System.Drawing.Size(193, 63);
            this.btnBase7.TabIndex = 10;
            this.btnBase7.Text = "Base 7";
            this.btnBase7.UseVisualStyleBackColor = false;
            this.btnBase7.Click += new System.EventHandler(this.btnBase7_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(3, 2);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(192, 18);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Enter value to convert";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(3, 27);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(202, 18);
            this.lblBase.TabIndex = 12;
            this.lblBase.Text = "Enter base value to use";
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 240);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnBase7);
            this.Controls.Add(this.btnBase5);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnConvertTo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtConvertFrom);
            this.KeyPreview = true;
            this.Name = "frmConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConverter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvertTo;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnBase5;
        private System.Windows.Forms.Button btnBase7;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBase;
    }
}

