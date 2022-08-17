
namespace SQLCONSOLETEST
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.AdminButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.Window;
            this.AdminButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(81, 276);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(164, 60);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Администратор";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.SystemColors.Window;
            this.ClientButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientButton.Location = new System.Drawing.Point(556, 276);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(164, 60);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.Text = "Клиент";
            this.ClientButton.UseVisualStyleBackColor = false;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_start.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_start.Location = new System.Drawing.Point(106, 74);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(583, 50);
            this.lbl_start.TabIndex = 2;
            this.lbl_start.Text = "В каком режиме вы хотите начать работу?";
            this.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.AdminButton);
            this.Name = "StartForm";
            this.Text = "Режим работы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Label lbl_start;
    }
}