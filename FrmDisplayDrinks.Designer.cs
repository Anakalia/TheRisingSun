
namespace TheRisingSun
{
    partial class FrmDisplayDrinks
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
            this.dgDrinks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDrinks
            // 
            this.dgDrinks.AllowUserToAddRows = false;
            this.dgDrinks.AllowUserToDeleteRows = false;
            this.dgDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrinks.Location = new System.Drawing.Point(12, 12);
            this.dgDrinks.Name = "dgDrinks";
            this.dgDrinks.ReadOnly = true;
            this.dgDrinks.Size = new System.Drawing.Size(776, 364);
            this.dgDrinks.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmDisplayDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDrinks);
            this.Name = "FrmDisplayDrinks";
            this.Text = "DisplayDrinks";
            this.Load += new System.EventHandler(this.FrmDisplayDrinks_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDrinks;
        private System.Windows.Forms.Button button1;
    }
}