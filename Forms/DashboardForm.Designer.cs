namespace UniversitySystem.Forms
{
    partial class DashboardForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ToCreateMaterialFormButton = new System.Windows.Forms.Button();
            this.ToMangeMaterialFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(11, 409);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 50);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ToCreateMaterialFormButton
            // 
            this.ToCreateMaterialFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToCreateMaterialFormButton.Location = new System.Drawing.Point(336, 95);
            this.ToCreateMaterialFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.ToCreateMaterialFormButton.Name = "ToCreateMaterialFormButton";
            this.ToCreateMaterialFormButton.Size = new System.Drawing.Size(245, 50);
            this.ToCreateMaterialFormButton.TabIndex = 4;
            this.ToCreateMaterialFormButton.Text = "Create Material";
            this.ToCreateMaterialFormButton.UseVisualStyleBackColor = true;
            // 
            // ToMangeMaterialFormButton
            // 
            this.ToMangeMaterialFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMangeMaterialFormButton.Location = new System.Drawing.Point(336, 160);
            this.ToMangeMaterialFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.ToMangeMaterialFormButton.Name = "ToMangeMaterialFormButton";
            this.ToMangeMaterialFormButton.Size = new System.Drawing.Size(245, 50);
            this.ToMangeMaterialFormButton.TabIndex = 5;
            this.ToMangeMaterialFormButton.Text = "Mange Material";
            this.ToMangeMaterialFormButton.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ToMangeMaterialFormButton);
            this.Controls.Add(this.ToCreateMaterialFormButton);
            this.Controls.Add(this.LogoutButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ToCreateMaterialFormButton;
        private System.Windows.Forms.Button ToMangeMaterialFormButton;
    }
}