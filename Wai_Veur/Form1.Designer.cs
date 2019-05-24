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
            this.TbCity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvCroisiere = new System.Windows.Forms.ListView();
            this.clHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWeather = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Controls.Add(this.LblCity);
            this.GbSearch.Controls.Add(this.TbCity);
            this.GbSearch.Location = new System.Drawing.Point(507, 44);
            this.GbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbSearch.Size = new System.Drawing.Size(567, 108);
            this.GbSearch.TabIndex = 1;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(344, 24);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 35);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(9, 37);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(154, 24);
            this.LblCity.TabIndex = 1;
            this.LblCity.Text = "City/Postal Code :";
            // 
            // TbCity
            // 
            this.TbCity.Location = new System.Drawing.Point(188, 29);
            this.TbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(148, 26);
            this.TbCity.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lvCroisiere
            // 
            this.lvCroisiere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clHour,
            this.clWeather,
            this.clTemp,
            this.clWind});
            this.lvCroisiere.FullRowSelect = true;
            this.lvCroisiere.Location = new System.Drawing.Point(204, 261);
            this.lvCroisiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvCroisiere.Name = "lvCroisiere";
            this.lvCroisiere.Size = new System.Drawing.Size(985, 270);
            this.lvCroisiere.TabIndex = 12;
            this.lvCroisiere.UseCompatibleStateImageBehavior = false;
            this.lvCroisiere.View = System.Windows.Forms.View.Details;
            // 
            // clHour
            // 
            this.clHour.Text = "Hour";
            this.clHour.Width = 200;
            // 
            // clWeather
            // 
            this.clWeather.Text = "Weather";
            this.clWeather.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clWeather.Width = 150;
            // 
            // clTemp
            // 
            this.clTemp.Text = "Temperature °C";
            this.clTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clTemp.Width = 150;
            // 
            // clWind
            // 
            this.clWind.Text = "Wind";
            this.clWind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clWind.Width = 150;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 933);
            this.Controls.Add(this.lvCroisiere);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GbSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvCroisiere;
        private System.Windows.Forms.ColumnHeader clHour;
        private System.Windows.Forms.ColumnHeader clWeather;
        private System.Windows.Forms.ColumnHeader clTemp;
        private System.Windows.Forms.ColumnHeader clWind;
    }
}

