namespace KMeans
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Itterate = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Centroids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Manual = new System.Windows.Forms.Button();
            this.button_Set = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 433);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(818, 67);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(154, 23);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Load File";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Itterate
            // 
            this.button_Itterate.Location = new System.Drawing.Point(818, 163);
            this.button_Itterate.Name = "button_Itterate";
            this.button_Itterate.Size = new System.Drawing.Size(154, 23);
            this.button_Itterate.TabIndex = 2;
            this.button_Itterate.Text = "Itterate Algorithm";
            this.button_Itterate.UseVisualStyleBackColor = true;
            this.button_Itterate.Click += new System.EventHandler(this.button_Itterate_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(818, 195);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(154, 23);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // textBox_Centroids
            // 
            this.textBox_Centroids.Location = new System.Drawing.Point(932, 14);
            this.textBox_Centroids.Name = "textBox_Centroids";
            this.textBox_Centroids.Size = new System.Drawing.Size(40, 20);
            this.textBox_Centroids.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(818, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "# of Centroids";
            // 
            // button_Manual
            // 
            this.button_Manual.Location = new System.Drawing.Point(818, 99);
            this.button_Manual.Name = "button_Manual";
            this.button_Manual.Size = new System.Drawing.Size(154, 23);
            this.button_Manual.TabIndex = 6;
            this.button_Manual.Text = "Enter Manually";
            this.button_Manual.UseVisualStyleBackColor = true;
            this.button_Manual.Click += new System.EventHandler(this.button_Manual_Click);
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(818, 131);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(154, 23);
            this.button_Set.TabIndex = 7;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.button_Manual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Centroids);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Itterate);
            this.Controls.Add(this.button_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-Means Demonstrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Itterate;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.TextBox textBox_Centroids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Manual;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

