namespace Serelization
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DeadTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Serelizebtn = new System.Windows.Forms.Button();
            this.DeserelizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(169, 45);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(235, 50);
            this.NameTxt.TabIndex = 0;
            // 
            // DeadTxt
            // 
            this.DeadTxt.Location = new System.Drawing.Point(169, 201);
            this.DeadTxt.Multiline = true;
            this.DeadTxt.Name = "DeadTxt";
            this.DeadTxt.Size = new System.Drawing.Size(235, 50);
            this.DeadTxt.TabIndex = 1;
            this.DeadTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(169, 118);
            this.AgeTxt.Multiline = true;
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(235, 50);
            this.AgeTxt.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(50, 59);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(68, 25);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "IsDead";
            // 
            // Serelizebtn
            // 
            this.Serelizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serelizebtn.Location = new System.Drawing.Point(95, 327);
            this.Serelizebtn.Name = "Serelizebtn";
            this.Serelizebtn.Size = new System.Drawing.Size(200, 56);
            this.Serelizebtn.TabIndex = 6;
            this.Serelizebtn.Text = "Serelize";
            this.Serelizebtn.UseVisualStyleBackColor = true;
            this.Serelizebtn.Click += new System.EventHandler(this.Serelizebtn_Click);
            // 
            // DeserelizeBtn
            // 
            this.DeserelizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeserelizeBtn.Location = new System.Drawing.Point(326, 327);
            this.DeserelizeBtn.Name = "DeserelizeBtn";
            this.DeserelizeBtn.Size = new System.Drawing.Size(222, 56);
            this.DeserelizeBtn.TabIndex = 7;
            this.DeserelizeBtn.Text = "Deserelize";
            this.DeserelizeBtn.UseVisualStyleBackColor = true;
            this.DeserelizeBtn.Click += new System.EventHandler(this.DeserelizeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 463);
            this.Controls.Add(this.DeserelizeBtn);
            this.Controls.Add(this.Serelizebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.DeadTxt);
            this.Controls.Add(this.NameTxt);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox DeadTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Serelizebtn;
        private System.Windows.Forms.Button DeserelizeBtn;
    }
}

