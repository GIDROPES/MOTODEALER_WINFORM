
namespace SQLCONSOLETEST
{
    partial class UpdateInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfo));
            this.dgv_YourMoto = new System.Windows.Forms.DataGridView();
            this.lbl_for_client = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YourMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_YourMoto
            // 
            this.dgv_YourMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YourMoto.Location = new System.Drawing.Point(28, 161);
            this.dgv_YourMoto.Name = "dgv_YourMoto";
            this.dgv_YourMoto.RowHeadersWidth = 51;
            this.dgv_YourMoto.RowTemplate.Height = 24;
            this.dgv_YourMoto.Size = new System.Drawing.Size(843, 347);
            this.dgv_YourMoto.TabIndex = 0;
            this.dgv_YourMoto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_YourMoto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_YourMoto_CellEnter);
            // 
            // lbl_for_client
            // 
            this.lbl_for_client.AutoSize = true;
            this.lbl_for_client.BackColor = System.Drawing.Color.Transparent;
            this.lbl_for_client.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_for_client.ForeColor = System.Drawing.Color.White;
            this.lbl_for_client.Location = new System.Drawing.Point(37, 51);
            this.lbl_for_client.Name = "lbl_for_client";
            this.lbl_for_client.Size = new System.Drawing.Size(326, 29);
            this.lbl_for_client.TabIndex = 1;
            this.lbl_for_client.Text = "многоуважаемый вот такие дела";
            this.lbl_for_client.Click += new System.EventHandler(this.lbl_for_client_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_accept.Location = new System.Drawing.Point(904, 445);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(161, 63);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "ОФОРМИТЬ";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 545);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.lbl_for_client);
            this.Controls.Add(this.dgv_YourMoto);
            this.Name = "UpdateInfo";
            this.Text = "Выбрать мотоцикл";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YourMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_YourMoto;
        private System.Windows.Forms.Label lbl_for_client;
        private System.Windows.Forms.Button btn_accept;
    }
}