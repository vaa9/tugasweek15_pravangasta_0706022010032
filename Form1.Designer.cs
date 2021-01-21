
namespace tugasweek15_pravangasta_0706022010032
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isibaru = new System.Windows.Forms.TextBox();
            this.foodbut = new System.Windows.Forms.RadioButton();
            this.drinkbut = new System.Windows.Forms.RadioButton();
            this.savebut = new System.Windows.Forms.Button();
            this.movebut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.leftbox = new System.Windows.Forms.ListBox();
            this.rightbox = new System.Windows.Forms.ListBox();
            this.foodcheck = new System.Windows.Forms.CheckBox();
            this.drinkcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori :";
            // 
            // isibaru
            // 
            this.isibaru.Location = new System.Drawing.Point(83, 27);
            this.isibaru.Name = "isibaru";
            this.isibaru.Size = new System.Drawing.Size(209, 20);
            this.isibaru.TabIndex = 2;
            // 
            // foodbut
            // 
            this.foodbut.AutoSize = true;
            this.foodbut.Location = new System.Drawing.Point(83, 73);
            this.foodbut.Name = "foodbut";
            this.foodbut.Size = new System.Drawing.Size(70, 17);
            this.foodbut.TabIndex = 3;
            this.foodbut.TabStop = true;
            this.foodbut.Text = "Makanan";
            this.foodbut.UseVisualStyleBackColor = true;
            // 
            // drinkbut
            // 
            this.drinkbut.AutoSize = true;
            this.drinkbut.Location = new System.Drawing.Point(194, 72);
            this.drinkbut.Name = "drinkbut";
            this.drinkbut.Size = new System.Drawing.Size(68, 17);
            this.drinkbut.TabIndex = 4;
            this.drinkbut.TabStop = true;
            this.drinkbut.Text = "Minuman";
            this.drinkbut.UseVisualStyleBackColor = true;
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(83, 96);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 5;
            this.savebut.Text = "Input";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // movebut
            // 
            this.movebut.Location = new System.Drawing.Point(175, 149);
            this.movebut.Name = "movebut";
            this.movebut.Size = new System.Drawing.Size(75, 23);
            this.movebut.TabIndex = 6;
            this.movebut.Text = ">";
            this.movebut.UseVisualStyleBackColor = true;
            this.movebut.Click += new System.EventHandler(this.movebut_Click);
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(175, 178);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 7;
            this.deletebut.Text = "X";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // leftbox
            // 
            this.leftbox.FormattingEnabled = true;
            this.leftbox.Location = new System.Drawing.Point(16, 149);
            this.leftbox.Name = "leftbox";
            this.leftbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.leftbox.Size = new System.Drawing.Size(120, 199);
            this.leftbox.TabIndex = 8;
            this.leftbox.SelectedIndexChanged += new System.EventHandler(this.leftbox_SelectedIndexChanged);
            // 
            // rightbox
            // 
            this.rightbox.AllowDrop = true;
            this.rightbox.FormattingEnabled = true;
            this.rightbox.Location = new System.Drawing.Point(296, 149);
            this.rightbox.Name = "rightbox";
            this.rightbox.Size = new System.Drawing.Size(120, 199);
            this.rightbox.TabIndex = 9;
            // 
            // foodcheck
            // 
            this.foodcheck.AutoSize = true;
            this.foodcheck.Location = new System.Drawing.Point(170, 255);
            this.foodcheck.Name = "foodcheck";
            this.foodcheck.Size = new System.Drawing.Size(70, 17);
            this.foodcheck.TabIndex = 10;
            this.foodcheck.Text = "makanan";
            this.foodcheck.UseVisualStyleBackColor = true;
            this.foodcheck.CheckedChanged += new System.EventHandler(this.foodcheck_CheckedChanged);
            // 
            // drinkcheck
            // 
            this.drinkcheck.AutoSize = true;
            this.drinkcheck.Location = new System.Drawing.Point(170, 289);
            this.drinkcheck.Name = "drinkcheck";
            this.drinkcheck.Size = new System.Drawing.Size(68, 17);
            this.drinkcheck.TabIndex = 11;
            this.drinkcheck.Text = "minuman";
            this.drinkcheck.UseVisualStyleBackColor = true;
            this.drinkcheck.CheckedChanged += new System.EventHandler(this.drinkcheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 358);
            this.Controls.Add(this.drinkcheck);
            this.Controls.Add(this.foodcheck);
            this.Controls.Add(this.rightbox);
            this.Controls.Add(this.leftbox);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.movebut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.drinkbut);
            this.Controls.Add(this.foodbut);
            this.Controls.Add(this.isibaru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Utama ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isibaru;
        private System.Windows.Forms.RadioButton foodbut;
        private System.Windows.Forms.RadioButton drinkbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Button movebut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.ListBox leftbox;
        private System.Windows.Forms.ListBox rightbox;
        private System.Windows.Forms.CheckBox foodcheck;
        private System.Windows.Forms.CheckBox drinkcheck;
    }
}

