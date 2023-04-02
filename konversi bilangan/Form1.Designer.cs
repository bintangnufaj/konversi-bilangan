
namespace konversi_bilangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.cbofrom = new System.Windows.Forms.ComboBox();
            this.cboto = new System.Windows.Forms.ComboBox();
            this.lbl_enter = new System.Windows.Forms.Label();
            this.txt_enter = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Number Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_to
            // 
            this.lbl_to.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Montserrat Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(950, 223);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(34, 24);
            this.lbl_to.TabIndex = 1;
            this.lbl_to.Text = "To";
            // 
            // lbl_from
            // 
            this.lbl_from.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Montserrat Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.White;
            this.lbl_from.Location = new System.Drawing.Point(131, 54);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(64, 24);
            this.lbl_from.TabIndex = 4;
            this.lbl_from.Text = "From";
            // 
            // cbofrom
            // 
            this.cbofrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbofrom.BackColor = System.Drawing.Color.LightGray;
            this.cbofrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofrom.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofrom.FormattingEnabled = true;
            this.cbofrom.Items.AddRange(new object[] {
            "Decimal",
            "Biner",
            "Octal",
            "Hexadecimal"});
            this.cbofrom.Location = new System.Drawing.Point(42, 90);
            this.cbofrom.Name = "cbofrom";
            this.cbofrom.Size = new System.Drawing.Size(250, 32);
            this.cbofrom.TabIndex = 5;
            this.cbofrom.SelectedIndexChanged += new System.EventHandler(this.cbofrom_SelectedIndexChanged);
            this.cbofrom.SelectionChangeCommitted += new System.EventHandler(this.cbofrom_SelectionChangeCommitted);
            // 
            // cboto
            // 
            this.cboto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboto.BackColor = System.Drawing.Color.LightGray;
            this.cboto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboto.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboto.FormattingEnabled = true;
            this.cboto.Items.AddRange(new object[] {
            "Decimal",
            "Biner",
            "Octal",
            "Hexadecimal"});
            this.cboto.Location = new System.Drawing.Point(838, 259);
            this.cboto.Name = "cboto";
            this.cboto.Size = new System.Drawing.Size(250, 32);
            this.cboto.TabIndex = 6;
            // 
            // lbl_enter
            // 
            this.lbl_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_enter.AutoSize = true;
            this.lbl_enter.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enter.ForeColor = System.Drawing.Color.White;
            this.lbl_enter.Location = new System.Drawing.Point(653, 320);
            this.lbl_enter.Name = "lbl_enter";
            this.lbl_enter.Size = new System.Drawing.Size(161, 27);
            this.lbl_enter.TabIndex = 7;
            this.lbl_enter.Text = "Enter number";
            this.lbl_enter.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_enter
            // 
            this.txt_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_enter.BackColor = System.Drawing.Color.LightGray;
            this.txt_enter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enter.Location = new System.Drawing.Point(580, 368);
            this.txt_enter.Multiline = true;
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.Size = new System.Drawing.Size(306, 41);
            this.txt_enter.TabIndex = 8;
            // 
            // btn_convert
            // 
            this.btn_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_convert.BackColor = System.Drawing.Color.Green;
            this.btn_convert.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.Color.White;
            this.btn_convert.Location = new System.Drawing.Point(571, 482);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(112, 41);
            this.btn_convert.TabIndex = 9;
            this.btn_convert.Text = "convert";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.Maroon;
            this.btn_reset.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(777, 482);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(112, 41);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.White;
            this.lbl_result.Location = new System.Drawing.Point(695, 579);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(81, 27);
            this.lbl_result.TabIndex = 12;
            this.lbl_result.Text = "Result";
            this.lbl_result.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_result
            // 
            this.txt_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_result.BackColor = System.Drawing.Color.LightGray;
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_result.Font = new System.Drawing.Font("Montserrat Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(583, 623);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(306, 41);
            this.txt_result.TabIndex = 13;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbofrom);
            this.panel2.Controls.Add(this.lbl_from);
            this.panel2.Location = new System.Drawing.Point(305, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 537);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_enter);
            this.Controls.Add(this.lbl_enter);
            this.Controls.Add(this.cboto);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.ComboBox cbofrom;
        private System.Windows.Forms.ComboBox cboto;
        private System.Windows.Forms.Label lbl_enter;
        private System.Windows.Forms.TextBox txt_enter;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

