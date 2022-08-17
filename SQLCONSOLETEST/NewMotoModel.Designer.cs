
namespace SQLCONSOLETEST
{
    partial class NewMotoModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMotoModel));
            this.txbx_ModelName = new System.Windows.Forms.TextBox();
            this.txbx_MotoType = new System.Windows.Forms.TextBox();
            this.txbx_MotoPower = new System.Windows.Forms.TextBox();
            this.txbx_MotoPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NewMoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_ModelName
            // 
            this.txbx_ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_ModelName.Location = new System.Drawing.Point(266, 118);
            this.txbx_ModelName.Name = "txbx_ModelName";
            this.txbx_ModelName.Size = new System.Drawing.Size(459, 30);
            this.txbx_ModelName.TabIndex = 0;
            // 
            // txbx_MotoType
            // 
            this.txbx_MotoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_MotoType.Location = new System.Drawing.Point(266, 247);
            this.txbx_MotoType.Name = "txbx_MotoType";
            this.txbx_MotoType.Size = new System.Drawing.Size(459, 30);
            this.txbx_MotoType.TabIndex = 1;
            // 
            // txbx_MotoPower
            // 
            this.txbx_MotoPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_MotoPower.Location = new System.Drawing.Point(266, 185);
            this.txbx_MotoPower.Name = "txbx_MotoPower";
            this.txbx_MotoPower.Size = new System.Drawing.Size(459, 30);
            this.txbx_MotoPower.TabIndex = 2;
            this.txbx_MotoPower.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbx_MotoPrice
            // 
            this.txbx_MotoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_MotoPrice.Location = new System.Drawing.Point(266, 310);
            this.txbx_MotoPrice.Name = "txbx_MotoPrice";
            this.txbx_MotoPrice.Size = new System.Drawing.Size(459, 30);
            this.txbx_MotoPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Объем двигателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип мотоцикла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // btn_NewMoto
            // 
            this.btn_NewMoto.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_NewMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NewMoto.Location = new System.Drawing.Point(288, 377);
            this.btn_NewMoto.Name = "btn_NewMoto";
            this.btn_NewMoto.Size = new System.Drawing.Size(228, 47);
            this.btn_NewMoto.TabIndex = 8;
            this.btn_NewMoto.Text = "Добавить";
            this.btn_NewMoto.UseVisualStyleBackColor = false;
            this.btn_NewMoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewMotoModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NewMoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_MotoPrice);
            this.Controls.Add(this.txbx_MotoPower);
            this.Controls.Add(this.txbx_MotoType);
            this.Controls.Add(this.txbx_ModelName);
            this.Name = "NewMotoModel";
            this.Text = "Новая модель мотоцикла";
            this.Load += new System.EventHandler(this.NewMotoModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_ModelName;
        private System.Windows.Forms.TextBox txbx_MotoType;
        private System.Windows.Forms.TextBox txbx_MotoPower;
        private System.Windows.Forms.TextBox txbx_MotoPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NewMoto;
    }
}