
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.pbSundries = new System.Windows.Forms.PictureBox();
            this.pbWine = new System.Windows.Forms.PictureBox();
            this.pbSoftDrinks = new System.Windows.Forms.PictureBox();
            this.pbBottles = new System.Windows.Forms.PictureBox();
            this.pbDraughts = new System.Windows.Forms.PictureBox();
            this.pbSpirits = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSundries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoftDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraughts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpirits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(123, 562);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Location = new System.Drawing.Point(320, 562);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(117, 41);
            this.btnListAll.TabIndex = 7;
            this.btnListAll.Text = "LIST ALL";
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // pbSundries
            // 
            this.pbSundries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSundries.Image = global::TheRisingSun.Properties.Resources.sundries;
            this.pbSundries.Location = new System.Drawing.Point(296, 381);
            this.pbSundries.Name = "pbSundries";
            this.pbSundries.Size = new System.Drawing.Size(170, 147);
            this.pbSundries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSundries.TabIndex = 5;
            this.pbSundries.TabStop = false;
            this.pbSundries.Click += new System.EventHandler(this.pbSundries_Click);
            // 
            // pbWine
            // 
            this.pbWine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWine.Image = global::TheRisingSun.Properties.Resources.wine;
            this.pbWine.Location = new System.Drawing.Point(99, 381);
            this.pbWine.Name = "pbWine";
            this.pbWine.Size = new System.Drawing.Size(170, 147);
            this.pbWine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWine.TabIndex = 4;
            this.pbWine.TabStop = false;
            this.pbWine.Click += new System.EventHandler(this.pbWine_Click);
            // 
            // pbSoftDrinks
            // 
            this.pbSoftDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSoftDrinks.Image = global::TheRisingSun.Properties.Resources.softdrinks;
            this.pbSoftDrinks.Location = new System.Drawing.Point(296, 209);
            this.pbSoftDrinks.Name = "pbSoftDrinks";
            this.pbSoftDrinks.Size = new System.Drawing.Size(170, 147);
            this.pbSoftDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSoftDrinks.TabIndex = 3;
            this.pbSoftDrinks.TabStop = false;
            this.pbSoftDrinks.Click += new System.EventHandler(this.pbSoftDrinks_Click);
            // 
            // pbBottles
            // 
            this.pbBottles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBottles.Image = global::TheRisingSun.Properties.Resources.bottles;
            this.pbBottles.Location = new System.Drawing.Point(99, 209);
            this.pbBottles.Name = "pbBottles";
            this.pbBottles.Size = new System.Drawing.Size(170, 147);
            this.pbBottles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBottles.TabIndex = 2;
            this.pbBottles.TabStop = false;
            this.pbBottles.Click += new System.EventHandler(this.pbBottles_Click);
            // 
            // pbDraughts
            // 
            this.pbDraughts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDraughts.Image = global::TheRisingSun.Properties.Resources.daught;
            this.pbDraughts.Location = new System.Drawing.Point(296, 35);
            this.pbDraughts.Name = "pbDraughts";
            this.pbDraughts.Size = new System.Drawing.Size(170, 146);
            this.pbDraughts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDraughts.TabIndex = 1;
            this.pbDraughts.TabStop = false;
            this.pbDraughts.Click += new System.EventHandler(this.pbDraughts_Click);
            // 
            // pbSpirits
            // 
            this.pbSpirits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSpirits.Image = global::TheRisingSun.Properties.Resources.spirits;
            this.pbSpirits.Location = new System.Drawing.Point(99, 35);
            this.pbSpirits.Name = "pbSpirits";
            this.pbSpirits.Size = new System.Drawing.Size(170, 146);
            this.pbSpirits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpirits.TabIndex = 0;
            this.pbSpirits.TabStop = false;
            this.pbSpirits.Click += new System.EventHandler(this.pbSpirits_Click);
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 630);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbSundries);
            this.Controls.Add(this.pbWine);
            this.Controls.Add(this.pbSoftDrinks);
            this.Controls.Add(this.pbBottles);
            this.Controls.Add(this.pbDraughts);
            this.Controls.Add(this.pbSpirits);
            this.Name = "Drinks";
            this.Text = "Drinks";
            ((System.ComponentModel.ISupportInitialize)(this.pbSundries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoftDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraughts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpirits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpirits;
        private System.Windows.Forms.PictureBox pbDraughts;
        private System.Windows.Forms.PictureBox pbBottles;
        private System.Windows.Forms.PictureBox pbSoftDrinks;
        private System.Windows.Forms.PictureBox pbWine;
        private System.Windows.Forms.PictureBox pbSundries;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnListAll;
    }
}