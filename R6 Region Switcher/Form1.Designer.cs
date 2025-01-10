
namespace R6_Region_Switcher
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
            this.textBoxCurrentRegion = new System.Windows.Forms.TextBox();
            this.labelCurrentRegion = new System.Windows.Forms.Label();
            this.labelRegions = new System.Windows.Forms.Label();
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCurrentRegion
            // 
            this.textBoxCurrentRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentRegion.Location = new System.Drawing.Point(15, 25);
            this.textBoxCurrentRegion.Name = "textBoxCurrentRegion";
            this.textBoxCurrentRegion.ReadOnly = true;
            this.textBoxCurrentRegion.Size = new System.Drawing.Size(457, 20);
            this.textBoxCurrentRegion.TabIndex = 2;
            // 
            // labelCurrentRegion
            // 
            this.labelCurrentRegion.AutoSize = true;
            this.labelCurrentRegion.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentRegion.Name = "labelCurrentRegion";
            this.labelCurrentRegion.Size = new System.Drawing.Size(97, 13);
            this.labelCurrentRegion.TabIndex = 1;
            this.labelCurrentRegion.Text = "Your current region";
            // 
            // labelRegions
            // 
            this.labelRegions.AutoSize = true;
            this.labelRegions.Location = new System.Drawing.Point(12, 48);
            this.labelRegions.Name = "labelRegions";
            this.labelRegions.Size = new System.Drawing.Size(46, 13);
            this.labelRegions.TabIndex = 2;
            this.labelRegions.Text = "Regions";
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Items.AddRange(new object[] {
            "default",
            "playfab/australiaeast",
            "playfab/brazilsouth",
            "playfab/centralus",
            "playfab/eastasia",
            "playfab/eastus",
            "playfab/japaneast",
            "playfab/northeurope",
            "playfab/southafricanorth",
            "playfab/southcentralus",
            "playfab/southeastasia",
            "playfab/uaenorth",
            "playfab/westeurope",
            "playfab/westus"});
            this.comboBoxRegions.Location = new System.Drawing.Point(15, 64);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(457, 21);
            this.comboBoxRegions.TabIndex = 0;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.Location = new System.Drawing.Point(397, 306);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 1;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.comboBoxRegions);
            this.Controls.Add(this.labelRegions);
            this.Controls.Add(this.labelCurrentRegion);
            this.Controls.Add(this.textBoxCurrentRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 380);
            this.MinimumSize = new System.Drawing.Size(240, 165);
            this.Name = "Form1";
            this.Text = "Rainbow Six Sieg Region Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCurrentRegion;
        private System.Windows.Forms.Label labelCurrentRegion;
        private System.Windows.Forms.Label labelRegions;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Button buttonSet;
    }
}

