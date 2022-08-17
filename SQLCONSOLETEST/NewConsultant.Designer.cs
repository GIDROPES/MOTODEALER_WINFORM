
namespace SQLCONSOLETEST
{
    partial class NewConsultant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConsultant));
            this.txbx_ConsName = new System.Windows.Forms.TextBox();
            this.txbx_ConsPhone = new System.Windows.Forms.TextBox();
            this.txbx_ConsMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateCons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_ConsName
            // 
            this.txbx_ConsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_ConsName.Location = new System.Drawing.Point(316, 111);
            this.txbx_ConsName.Name = "txbx_ConsName";
            this.txbx_ConsName.Size = new System.Drawing.Size(421, 30);
            this.txbx_ConsName.TabIndex = 0;
            // 
            // txbx_ConsPhone
            // 
            this.txbx_ConsPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_ConsPhone.Location = new System.Drawing.Point(316, 168);
            this.txbx_ConsPhone.Name = "txbx_ConsPhone";
            this.txbx_ConsPhone.Size = new System.Drawing.Size(421, 30);
            this.txbx_ConsPhone.TabIndex = 1;
            // 
            // txbx_ConsMail
            // 
            this.txbx_ConsMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_ConsMail.Location = new System.Drawing.Point(316, 231);
            this.txbx_ConsMail.Name = "txbx_ConsMail";
            this.txbx_ConsMail.Size = new System.Drawing.Size(421, 30);
            this.txbx_ConsMail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО Консультанта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер консультанта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Почта консультанта";
            // 
            // btn_CreateCons
            // 
            this.btn_CreateCons.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_CreateCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CreateCons.ForeColor = System.Drawing.Color.Black;
            this.btn_CreateCons.Location = new System.Drawing.Point(246, 346);
            this.btn_CreateCons.Name = "btn_CreateCons";
            this.btn_CreateCons.Size = new System.Drawing.Size(324, 64);
            this.btn_CreateCons.TabIndex = 6;
            this.btn_CreateCons.Text = "СОЗДАТЬ";
            this.btn_CreateCons.UseVisualStyleBackColor = false;
            this.btn_CreateCons.Click += new System.EventHandler(this.btn_CreateCons_Click);
            // 
            // NewConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateCons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_ConsMail);
            this.Controls.Add(this.txbx_ConsPhone);
            this.Controls.Add(this.txbx_ConsName);
            this.Name = "NewConsultant";
            this.Text = "Новый консультант";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_ConsName;
        private System.Windows.Forms.TextBox txbx_ConsPhone;
        private System.Windows.Forms.TextBox txbx_ConsMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CreateCons;
    }
}