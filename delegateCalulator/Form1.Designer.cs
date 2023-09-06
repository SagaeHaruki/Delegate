namespace delegateCalulator
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
            this.fn_bx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sn_bx = new System.Windows.Forms.TextBox();
            this.cmb_bx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answer_box = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fn_bx
            // 
            this.fn_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn_bx.Location = new System.Drawing.Point(175, 34);
            this.fn_bx.Name = "fn_bx";
            this.fn_bx.Size = new System.Drawing.Size(121, 23);
            this.fn_bx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Second Number:";
            // 
            // sn_bx
            // 
            this.sn_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sn_bx.Location = new System.Drawing.Point(175, 93);
            this.sn_bx.Name = "sn_bx";
            this.sn_bx.Size = new System.Drawing.Size(121, 23);
            this.sn_bx.TabIndex = 2;
            // 
            // cmb_bx
            // 
            this.cmb_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bx.FormattingEnabled = true;
            this.cmb_bx.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmb_bx.Location = new System.Drawing.Point(193, 66);
            this.cmb_bx.Name = "cmb_bx";
            this.cmb_bx.Size = new System.Drawing.Size(81, 21);
            this.cmb_bx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "______________";
            // 
            // answer_box
            // 
            this.answer_box.AutoSize = true;
            this.answer_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_box.Location = new System.Drawing.Point(172, 150);
            this.answer_box.Name = "answer_box";
            this.answer_box.Size = new System.Drawing.Size(15, 15);
            this.answer_box.TabIndex = 7;
            this.answer_box.Text = "0";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(199, 185);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 231);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.answer_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_bx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sn_bx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fn_bx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fn_bx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sn_bx;
        private System.Windows.Forms.ComboBox cmb_bx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label answer_box;
        private System.Windows.Forms.Button calculate;
    }
}

