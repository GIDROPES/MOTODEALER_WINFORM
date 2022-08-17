
using System.Windows.Forms;

namespace SQLCONSOLETEST
{
    partial class AddNewMoto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMoto));
            this.txtbx_VIN = new System.Windows.Forms.TextBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_PRICE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_COLOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ADDMoto = new System.Windows.Forms.Button();
            this.dgv_Model = new System.Windows.Forms.DataGridView();
            this.motoModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotoPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableMotorcyclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet1 = new SQLCONSOLETEST.MotoDealerDataSet1();
            this.availableMotorcyclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet = new SQLCONSOLETEST.MotoDealerDataSet();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.available_MotorcyclesTableAdapter = new SQLCONSOLETEST.MotoDealerDataSetTableAdapters.Available_MotorcyclesTableAdapter();
            this.available_MotorcyclesTableAdapter1 = new SQLCONSOLETEST.MotoDealerDataSet1TableAdapters.Available_MotorcyclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableMotorcyclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableMotorcyclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_VIN
            // 
            this.txtbx_VIN.Location = new System.Drawing.Point(184, 201);
            this.txtbx_VIN.Name = "txtbx_VIN";
            this.txtbx_VIN.Size = new System.Drawing.Size(436, 22);
            this.txtbx_VIN.TabIndex = 0;
            this.txtbx_VIN.TextChanged += new System.EventHandler(this.txtbx_VIN_TextChanged);
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Model.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Model.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Model.Location = new System.Drawing.Point(12, 73);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(91, 36);
            this.lbl_Model.TabIndex = 2;
            this.lbl_Model.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "VIN-Номер";
            // 
            // txtbx_PRICE
            // 
            this.txtbx_PRICE.Location = new System.Drawing.Point(184, 256);
            this.txtbx_PRICE.Name = "txtbx_PRICE";
            this.txtbx_PRICE.ReadOnly = true;
            this.txtbx_PRICE.Size = new System.Drawing.Size(436, 22);
            this.txtbx_PRICE.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стоимость";
            // 
            // txtbx_COLOR
            // 
            this.txtbx_COLOR.Location = new System.Drawing.Point(184, 306);
            this.txtbx_COLOR.Name = "txtbx_COLOR";
            this.txtbx_COLOR.Size = new System.Drawing.Size(436, 22);
            this.txtbx_COLOR.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цвет";
            // 
            // btn_ADDMoto
            // 
            this.btn_ADDMoto.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_ADDMoto.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ADDMoto.Location = new System.Drawing.Point(380, 388);
            this.btn_ADDMoto.Name = "btn_ADDMoto";
            this.btn_ADDMoto.Size = new System.Drawing.Size(240, 107);
            this.btn_ADDMoto.TabIndex = 8;
            this.btn_ADDMoto.Text = "Оформить заказ";
            this.btn_ADDMoto.UseVisualStyleBackColor = false;
            this.btn_ADDMoto.Click += new System.EventHandler(this.btn_ADDMoto_Click);
            // 
            // dgv_Model
            // 
            this.dgv_Model.AutoGenerateColumns = false;
            this.dgv_Model.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Model.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.motoModelDataGridViewTextBoxColumn,
            this.motoPowerDataGridViewTextBoxColumn,
            this.motoTypeDataGridViewTextBoxColumn,
            this.MotoPrice});
            this.dgv_Model.DataSource = this.availableMotorcyclesBindingSource1;
            this.dgv_Model.Location = new System.Drawing.Point(184, 73);
            this.dgv_Model.Name = "dgv_Model";
            this.dgv_Model.RowHeadersWidth = 51;
            this.dgv_Model.RowTemplate.Height = 24;
            this.dgv_Model.Size = new System.Drawing.Size(436, 113);
            this.dgv_Model.TabIndex = 9;
            this.dgv_Model.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_Model.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Model_CellEnter);
            // 
            // motoModelDataGridViewTextBoxColumn
            // 
            this.motoModelDataGridViewTextBoxColumn.DataPropertyName = "MotoModel";
            this.motoModelDataGridViewTextBoxColumn.HeaderText = "MotoModel";
            this.motoModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoModelDataGridViewTextBoxColumn.Name = "motoModelDataGridViewTextBoxColumn";
            // 
            // motoPowerDataGridViewTextBoxColumn
            // 
            this.motoPowerDataGridViewTextBoxColumn.DataPropertyName = "MotoPower";
            this.motoPowerDataGridViewTextBoxColumn.HeaderText = "MotoPower";
            this.motoPowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoPowerDataGridViewTextBoxColumn.Name = "motoPowerDataGridViewTextBoxColumn";
            // 
            // motoTypeDataGridViewTextBoxColumn
            // 
            this.motoTypeDataGridViewTextBoxColumn.DataPropertyName = "MotoType";
            this.motoTypeDataGridViewTextBoxColumn.HeaderText = "MotoType";
            this.motoTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoTypeDataGridViewTextBoxColumn.Name = "motoTypeDataGridViewTextBoxColumn";
            // 
            // MotoPrice
            // 
            this.MotoPrice.DataPropertyName = "MotoPrice";
            this.MotoPrice.HeaderText = "MotoPrice";
            this.MotoPrice.MinimumWidth = 6;
            this.MotoPrice.Name = "MotoPrice";
            this.MotoPrice.Visible = false;
            // 
            // availableMotorcyclesBindingSource1
            // 
            this.availableMotorcyclesBindingSource1.DataMember = "Available_Motorcycles";
            this.availableMotorcyclesBindingSource1.DataSource = this.motoDealerDataSet1;
            // 
            // motoDealerDataSet1
            // 
            this.motoDealerDataSet1.DataSetName = "MotoDealerDataSet1";
            this.motoDealerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availableMotorcyclesBindingSource
            // 
            this.availableMotorcyclesBindingSource.DataMember = "Available_Motorcycles";
            this.availableMotorcyclesBindingSource.DataSource = this.motoDealerDataSet;
            // 
            // motoDealerDataSet
            // 
            this.motoDealerDataSet.DataSetName = "MotoDealerDataSet";
            this.motoDealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.ImageLocation = "C:\\Users\\MagicBook\\Desktop\\Универ\\yamaha-png-yamaha-logo-black-white-2232.png";
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 417);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(331, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // available_MotorcyclesTableAdapter
            // 
            this.available_MotorcyclesTableAdapter.ClearBeforeFill = true;
            // 
            // available_MotorcyclesTableAdapter1
            // 
            this.available_MotorcyclesTableAdapter1.ClearBeforeFill = true;
            // 
            // AddNewMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 544);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dgv_Model);
            this.Controls.Add(this.btn_ADDMoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_COLOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_PRICE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.txtbx_VIN);
            this.Name = "AddNewMoto";
            this.Text = "AddNewMoto";
            this.Load += new System.EventHandler(this.AddNewMoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableMotorcyclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableMotorcyclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_VIN;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_PRICE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_COLOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ADDMoto;
        private System.Windows.Forms.DataGridView dgv_Model;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MotoDealerDataSet motoDealerDataSet;
        private System.Windows.Forms.BindingSource availableMotorcyclesBindingSource;
        private MotoDealerDataSetTableAdapters.Available_MotorcyclesTableAdapter available_MotorcyclesTableAdapter;
        private MotoDealerDataSet1 motoDealerDataSet1;
        private BindingSource availableMotorcyclesBindingSource1;
        private MotoDealerDataSet1TableAdapters.Available_MotorcyclesTableAdapter available_MotorcyclesTableAdapter1;
        private DataGridViewTextBoxColumn motoModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motoPowerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motoTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MotoPrice;
    }
}