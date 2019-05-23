namespace Wai_Veur
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LstCity = new System.Windows.Forms.ListView();
            this.PBWeather = new System.Windows.Forms.PictureBox();
            this.LbTemp = new System.Windows.Forms.Label();
            this.LbWeather = new System.Windows.Forms.Label();
            this.LbCity = new System.Windows.Forms.Label();
            this.TBTemp = new System.Windows.Forms.TextBox();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.TbWeather = new System.Windows.Forms.TextBox();
            this.TbWind = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Controls.Add(this.LblCity);
            this.GbSearch.Controls.Add(this.TxtCity);
            this.GbSearch.Location = new System.Drawing.Point(170, 12);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Size = new System.Drawing.Size(378, 70);
            this.GbSearch.TabIndex = 1;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(244, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(6, 24);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(98, 15);
            this.LblCity.TabIndex = 1;
            this.LblCity.Text = "City/Postal Code :";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(125, 19);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(100, 20);
            this.TxtCity.TabIndex = 0;
            // 
            // LstCity
            // 
            this.LstCity.Location = new System.Drawing.Point(667, 12);
            this.LstCity.Name = "LstCity";
            this.LstCity.Size = new System.Drawing.Size(121, 426);
            this.LstCity.TabIndex = 2;
            this.LstCity.UseCompatibleStateImageBehavior = false;
            // 
            // PBWeather
            // 
            this.PBWeather.Image = ((System.Drawing.Image)(resources.GetObject("PBWeather.Image")));
            this.PBWeather.Location = new System.Drawing.Point(170, 200);
            this.PBWeather.Name = "PBWeather";
            this.PBWeather.Size = new System.Drawing.Size(272, 214);
            this.PBWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBWeather.TabIndex = 3;
            this.PBWeather.TabStop = false;
            // 
            // LbTemp
            // 
            this.LbTemp.AutoSize = true;
            this.LbTemp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTemp.Location = new System.Drawing.Point(28, 155);
            this.LbTemp.Name = "LbTemp";
            this.LbTemp.Size = new System.Drawing.Size(78, 15);
            this.LbTemp.TabIndex = 4;
            this.LbTemp.Text = "Temperature :";
            // 
            // LbWeather
            // 
            this.LbWeather.AutoSize = true;
            this.LbWeather.Location = new System.Drawing.Point(494, 155);
            this.LbWeather.Name = "LbWeather";
            this.LbWeather.Size = new System.Drawing.Size(54, 13);
            this.LbWeather.TabIndex = 5;
            this.LbWeather.Text = "Weather :";
            // 
            // LbCity
            // 
            this.LbCity.AutoSize = true;
            this.LbCity.Location = new System.Drawing.Point(301, 155);
            this.LbCity.Name = "LbCity";
            this.LbCity.Size = new System.Drawing.Size(30, 13);
            this.LbCity.TabIndex = 6;
            this.LbCity.Text = "City :";
            // 
            // TBTemp
            // 
            this.TBTemp.Location = new System.Drawing.Point(107, 152);
            this.TBTemp.Name = "TBTemp";
            this.TBTemp.Size = new System.Drawing.Size(100, 20);
            this.TBTemp.TabIndex = 7;
            // 
            // TBCity
            // 
            this.TBCity.Location = new System.Drawing.Point(337, 152);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(100, 20);
            this.TBCity.TabIndex = 8;
            // 
            // TbWeather
            // 
            this.TbWeather.Location = new System.Drawing.Point(554, 152);
            this.TbWeather.Name = "TbWeather";
            this.TbWeather.Size = new System.Drawing.Size(100, 20);
            this.TbWeather.TabIndex = 9;
            // 
            // TbWind
            // 
            this.TbWind.Location = new System.Drawing.Point(497, 378);
            this.TbWind.Name = "TbWind";
            this.TbWind.Size = new System.Drawing.Size(100, 20);
            this.TbWind.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wai_Veur.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(806, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbWind);
            this.Controls.Add(this.TbWeather);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.TBTemp);
            this.Controls.Add(this.LbCity);
            this.Controls.Add(this.LbWeather);
            this.Controls.Add(this.LbTemp);
            this.Controls.Add(this.PBWeather);
            this.Controls.Add(this.LstCity);
            this.Controls.Add(this.GbSearch);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.ListView LstCity;
        private System.Windows.Forms.PictureBox PBWeather;
        private System.Windows.Forms.Label LbTemp;
        private System.Windows.Forms.Label LbWeather;
        private System.Windows.Forms.Label LbCity;
        private System.Windows.Forms.TextBox TBTemp;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.TextBox TbWeather;
        private System.Windows.Forms.TextBox TbWind;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

