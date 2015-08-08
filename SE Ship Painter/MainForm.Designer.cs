namespace SE_Ship_Painter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnLoadBlueprint = new System.Windows.Forms.Button();
            this.labelBlueprint = new System.Windows.Forms.Label();
            this.pictureBoxShipColor = new System.Windows.Forms.PictureBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.checkedListArmorTypes = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadBlueprint
            // 
            this.btnLoadBlueprint.Location = new System.Drawing.Point(12, 12);
            this.btnLoadBlueprint.Name = "btnLoadBlueprint";
            this.btnLoadBlueprint.Size = new System.Drawing.Size(89, 23);
            this.btnLoadBlueprint.TabIndex = 0;
            this.btnLoadBlueprint.Text = "Load Blueprint";
            this.btnLoadBlueprint.UseVisualStyleBackColor = true;
            this.btnLoadBlueprint.Click += new System.EventHandler(this.btnLoadBlueprint_Click);
            // 
            // labelBlueprint
            // 
            this.labelBlueprint.AutoSize = true;
            this.labelBlueprint.Location = new System.Drawing.Point(104, 17);
            this.labelBlueprint.Name = "labelBlueprint";
            this.labelBlueprint.Size = new System.Drawing.Size(0, 13);
            this.labelBlueprint.TabIndex = 1;
            // 
            // pictureBoxShipColor
            // 
            this.pictureBoxShipColor.Location = new System.Drawing.Point(12, 49);
            this.pictureBoxShipColor.Name = "pictureBoxShipColor";
            this.pictureBoxShipColor.Size = new System.Drawing.Size(89, 88);
            this.pictureBoxShipColor.TabIndex = 2;
            this.pictureBoxShipColor.TabStop = false;
            this.pictureBoxShipColor.Click += new System.EventHandler(this.pictureBoxShipColor_Click);
            this.pictureBoxShipColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxShipColor_Paint);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(107, 101);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(75, 23);
            this.btnPaint.TabIndex = 3;
            this.btnPaint.Text = "Paint!";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // checkedListArmorTypes
            // 
            this.checkedListArmorTypes.CheckOnClick = true;
            this.checkedListArmorTypes.FormattingEnabled = true;
            this.checkedListArmorTypes.Items.AddRange(new object[] {
            "Light Armor Blocks",
            "Heavy Armor Blocks"});
            this.checkedListArmorTypes.Location = new System.Drawing.Point(107, 61);
            this.checkedListArmorTypes.Name = "checkedListArmorTypes";
            this.checkedListArmorTypes.Size = new System.Drawing.Size(156, 34);
            this.checkedListArmorTypes.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 146);
            this.Controls.Add(this.checkedListArmorTypes);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.pictureBoxShipColor);
            this.Controls.Add(this.labelBlueprint);
            this.Controls.Add(this.btnLoadBlueprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE Ship Painter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadBlueprint;
        private System.Windows.Forms.Label labelBlueprint;
        private System.Windows.Forms.PictureBox pictureBoxShipColor;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.CheckedListBox checkedListArmorTypes;
    }
}

