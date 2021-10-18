
namespace TheRisingSun
{
    partial class FrmDrinks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.dgvDrinks = new System.Windows.Forms.DataGridView();
            this.gbDrinks = new System.Windows.Forms.GroupBox();
            this.btnHot = new System.Windows.Forms.Button();
            this.btnSundries = new System.Windows.Forms.Button();
            this.btnShots = new System.Windows.Forms.Button();
            this.btnWines = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.btnBottles = new System.Windows.Forms.Button();
            this.btnDraughts = new System.Windows.Forms.Button();
            this.btnSpirits = new System.Windows.Forms.Button();
            this.gbDrinkDetails = new System.Windows.Forms.GroupBox();
            this.btnDGBack = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
            this.gbDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(164, 692);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 50);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Location = new System.Drawing.Point(427, 692);
            this.btnListAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(156, 50);
            this.btnListAll.TabIndex = 7;
            this.btnListAll.Text = "LIST ALL";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // dgvDrinks
            // 
            this.dgvDrinks.AllowUserToAddRows = false;
            this.dgvDrinks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrinks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinks.Location = new System.Drawing.Point(771, 13);
            this.dgvDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDrinks.MultiSelect = false;
            this.dgvDrinks.Name = "dgvDrinks";
            this.dgvDrinks.ReadOnly = true;
            this.dgvDrinks.RowHeadersWidth = 51;
            this.dgvDrinks.Size = new System.Drawing.Size(601, 357);
            this.dgvDrinks.TabIndex = 18;
            // 
            // gbDrinks
            // 
            this.gbDrinks.BackColor = System.Drawing.Color.Transparent;
            this.gbDrinks.Controls.Add(this.btnHot);
            this.gbDrinks.Controls.Add(this.btnSundries);
            this.gbDrinks.Controls.Add(this.btnShots);
            this.gbDrinks.Controls.Add(this.btnWines);
            this.gbDrinks.Controls.Add(this.btnSoftDrinks);
            this.gbDrinks.Controls.Add(this.btnBottles);
            this.gbDrinks.Controls.Add(this.btnDraughts);
            this.gbDrinks.Controls.Add(this.btnSpirits);
            this.gbDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDrinks.Location = new System.Drawing.Point(44, 28);
            this.gbDrinks.Name = "gbDrinks";
            this.gbDrinks.Size = new System.Drawing.Size(657, 520);
            this.gbDrinks.TabIndex = 19;
            this.gbDrinks.TabStop = false;
            // 
            // btnHot
            // 
            this.btnHot.BackgroundImage = global::TheRisingSun.Properties.Resources.hot;
            this.btnHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHot.Location = new System.Drawing.Point(381, 371);
            this.btnHot.Margin = new System.Windows.Forms.Padding(4);
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(157, 135);
            this.btnHot.TabIndex = 17;
            this.btnHot.UseVisualStyleBackColor = true;
            this.btnHot.Click += new System.EventHandler(this.btnHot_Click);
            // 
            // btnSundries
            // 
            this.btnSundries.BackgroundImage = global::TheRisingSun.Properties.Resources.sundries;
            this.btnSundries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSundries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSundries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSundries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSundries.Location = new System.Drawing.Point(473, 189);
            this.btnSundries.Margin = new System.Windows.Forms.Padding(4);
            this.btnSundries.Name = "btnSundries";
            this.btnSundries.Size = new System.Drawing.Size(157, 135);
            this.btnSundries.TabIndex = 16;
            this.btnSundries.UseVisualStyleBackColor = true;
            // 
            // btnShots
            // 
            this.btnShots.BackgroundImage = global::TheRisingSun.Properties.Resources.Shot;
            this.btnShots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShots.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShots.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShots.Location = new System.Drawing.Point(165, 371);
            this.btnShots.Margin = new System.Windows.Forms.Padding(4);
            this.btnShots.Name = "btnShots";
            this.btnShots.Size = new System.Drawing.Size(157, 135);
            this.btnShots.TabIndex = 15;
            this.btnShots.UseVisualStyleBackColor = true;
            this.btnShots.Click += new System.EventHandler(this.btnShots_Click);
            // 
            // btnWines
            // 
            this.btnWines.BackgroundImage = global::TheRisingSun.Properties.Resources.wine;
            this.btnWines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWines.Location = new System.Drawing.Point(245, 189);
            this.btnWines.Margin = new System.Windows.Forms.Padding(4);
            this.btnWines.Name = "btnWines";
            this.btnWines.Size = new System.Drawing.Size(157, 135);
            this.btnWines.TabIndex = 12;
            this.btnWines.UseVisualStyleBackColor = true;
            this.btnWines.Click += new System.EventHandler(this.btnWines_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.BackgroundImage = global::TheRisingSun.Properties.Resources.softdrinks;
            this.btnSoftDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoftDrinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSoftDrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSoftDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftDrinks.Location = new System.Drawing.Point(29, 189);
            this.btnSoftDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(157, 135);
            this.btnSoftDrinks.TabIndex = 11;
            this.btnSoftDrinks.UseVisualStyleBackColor = true;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // btnBottles
            // 
            this.btnBottles.BackgroundImage = global::TheRisingSun.Properties.Resources.bottles;
            this.btnBottles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBottles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBottles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBottles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottles.Location = new System.Drawing.Point(473, 15);
            this.btnBottles.Margin = new System.Windows.Forms.Padding(4);
            this.btnBottles.Name = "btnBottles";
            this.btnBottles.Size = new System.Drawing.Size(157, 135);
            this.btnBottles.TabIndex = 10;
            this.btnBottles.UseVisualStyleBackColor = true;
            this.btnBottles.Click += new System.EventHandler(this.btnBottles_Click);
            // 
            // btnDraughts
            // 
            this.btnDraughts.BackgroundImage = global::TheRisingSun.Properties.Resources.daught;
            this.btnDraughts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDraughts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDraughts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDraughts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraughts.Location = new System.Drawing.Point(245, 15);
            this.btnDraughts.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraughts.Name = "btnDraughts";
            this.btnDraughts.Size = new System.Drawing.Size(157, 135);
            this.btnDraughts.TabIndex = 9;
            this.btnDraughts.UseVisualStyleBackColor = true;
            this.btnDraughts.Click += new System.EventHandler(this.btnDraughts_Click);
            // 
            // btnSpirits
            // 
            this.btnSpirits.BackgroundImage = global::TheRisingSun.Properties.Resources.spirits;
            this.btnSpirits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpirits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSpirits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSpirits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpirits.Location = new System.Drawing.Point(29, 15);
            this.btnSpirits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpirits.Name = "btnSpirits";
            this.btnSpirits.Size = new System.Drawing.Size(157, 135);
            this.btnSpirits.TabIndex = 8;
            this.btnSpirits.UseVisualStyleBackColor = true;
            this.btnSpirits.Click += new System.EventHandler(this.btnSpirits_Click);
            // 
            // gbDrinkDetails
            // 
            this.gbDrinkDetails.Enabled = false;
            this.gbDrinkDetails.Location = new System.Drawing.Point(771, 399);
            this.gbDrinkDetails.Name = "gbDrinkDetails";
            this.gbDrinkDetails.Size = new System.Drawing.Size(598, 270);
            this.gbDrinkDetails.TabIndex = 19;
            this.gbDrinkDetails.TabStop = false;
            this.gbDrinkDetails.Text = "Details";
            this.gbDrinkDetails.Visible = false;
            // 
            // btnDGBack
            // 
            this.btnDGBack.Enabled = false;
            this.btnDGBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGBack.Location = new System.Drawing.Point(860, 692);
            this.btnDGBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnDGBack.Name = "btnDGBack";
            this.btnDGBack.Size = new System.Drawing.Size(156, 50);
            this.btnDGBack.TabIndex = 20;
            this.btnDGBack.Text = "BACK";
            this.btnDGBack.UseVisualStyleBackColor = true;
            this.btnDGBack.Visible = false;
            this.btnDGBack.Click += new System.EventHandler(this.btnDGBack_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1112, 692);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 50);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Add to Order";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            // 
            // FrmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 775);
            this.Controls.Add(this.dgvDrinks);
            this.Controls.Add(this.gbDrinkDetails);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDGBack);
            this.Controls.Add(this.gbDrinks);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDrinks";
            this.Text = "Drinks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
            this.gbDrinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnSpirits;
        private System.Windows.Forms.Button btnDraughts;
        private System.Windows.Forms.Button btnBottles;
        private System.Windows.Forms.Button btnSoftDrinks;
        private System.Windows.Forms.Button btnWines;
        private System.Windows.Forms.Button btnShots;
        private System.Windows.Forms.Button btnSundries;
        private System.Windows.Forms.Button btnHot;
        private System.Windows.Forms.GroupBox gbDrinks;
        private System.Windows.Forms.GroupBox gbDrinkDetails;
        private System.Windows.Forms.Button btnDGBack;
        private System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.DataGridView dgvDrinks;
    }
}