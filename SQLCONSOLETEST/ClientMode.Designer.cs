
namespace SQLCONSOLETEST
{
    partial class ClientMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMode));
            this.motoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet4 = new SQLCONSOLETEST.MotoDealerDataSet4();
            this.motoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet2 = new SQLCONSOLETEST.MotoDealerDataSet2();
            this.motoInfoTableAdapter = new SQLCONSOLETEST.MotoDealerDataSet2TableAdapters.MotoInfoTableAdapter();
            this.consultantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet3 = new SQLCONSOLETEST.MotoDealerDataSet3();
            this.consultantsTableAdapter = new SQLCONSOLETEST.MotoDealerDataSet3TableAdapters.ConsultantsTableAdapter();
            this.lbl_VNalichii = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbx_MODEL_SALE = new System.Windows.Forms.TextBox();
            this.txtbx_TEL_NUMBER = new System.Windows.Forms.TextBox();
            this.txtbx_FIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SUMMA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.VIN_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moto_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moto_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engine_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moto_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoInfoTableAdapter1 = new SQLCONSOLETEST.MotoDealerDataSet4TableAdapters.MotoInfoTableAdapter();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_model_name = new System.Windows.Forms.Label();
            this.pb_MotoPic = new System.Windows.Forms.PictureBox();
            this.dataGrid_Cons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MotoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cons)).BeginInit();
            this.SuspendLayout();
            // 
            // motoInfoBindingSource1
            // 
            this.motoInfoBindingSource1.DataMember = "MotoInfo";
            this.motoInfoBindingSource1.DataSource = this.motoDealerDataSet4;
            // 
            // motoDealerDataSet4
            // 
            this.motoDealerDataSet4.DataSetName = "MotoDealerDataSet4";
            this.motoDealerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoInfoBindingSource
            // 
            this.motoInfoBindingSource.DataMember = "MotoInfo";
            this.motoInfoBindingSource.DataSource = this.motoDealerDataSet2;
            // 
            // motoDealerDataSet2
            // 
            this.motoDealerDataSet2.DataSetName = "MotoDealerDataSet2";
            this.motoDealerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoInfoTableAdapter
            // 
            this.motoInfoTableAdapter.ClearBeforeFill = true;
            // 
            // consultantsBindingSource
            // 
            this.consultantsBindingSource.DataMember = "Consultants";
            this.consultantsBindingSource.DataSource = this.motoDealerDataSet3;
            // 
            // motoDealerDataSet3
            // 
            this.motoDealerDataSet3.DataSetName = "MotoDealerDataSet3";
            this.motoDealerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultantsTableAdapter
            // 
            this.consultantsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_VNalichii
            // 
            this.lbl_VNalichii.AutoSize = true;
            this.lbl_VNalichii.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_VNalichii.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_VNalichii.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_VNalichii.Location = new System.Drawing.Point(284, 104);
            this.lbl_VNalichii.Name = "lbl_VNalichii";
            this.lbl_VNalichii.Size = new System.Drawing.Size(101, 29);
            this.lbl_VNalichii.TabIndex = 2;
            this.lbl_VNalichii.Text = "Мотоциклы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(433, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Консультанты";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Забронировать покупку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbx_MODEL_SALE
            // 
            this.txtbx_MODEL_SALE.Location = new System.Drawing.Point(166, 363);
            this.txtbx_MODEL_SALE.Name = "txtbx_MODEL_SALE";
            this.txtbx_MODEL_SALE.ReadOnly = true;
            this.txtbx_MODEL_SALE.Size = new System.Drawing.Size(247, 22);
            this.txtbx_MODEL_SALE.TabIndex = 7;
            // 
            // txtbx_TEL_NUMBER
            // 
            this.txtbx_TEL_NUMBER.Location = new System.Drawing.Point(166, 321);
            this.txtbx_TEL_NUMBER.Name = "txtbx_TEL_NUMBER";
            this.txtbx_TEL_NUMBER.Size = new System.Drawing.Size(247, 22);
            this.txtbx_TEL_NUMBER.TabIndex = 8;
            // 
            // txtbx_FIO
            // 
            this.txtbx_FIO.Location = new System.Drawing.Point(166, 275);
            this.txtbx_FIO.Name = "txtbx_FIO";
            this.txtbx_FIO.Size = new System.Drawing.Size(247, 22);
            this.txtbx_FIO.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО покупателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тел. номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Модель";
            // 
            // lbl_SUMMA
            // 
            this.lbl_SUMMA.AutoSize = true;
            this.lbl_SUMMA.BackColor = System.Drawing.Color.Gold;
            this.lbl_SUMMA.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_SUMMA.ForeColor = System.Drawing.Color.Black;
            this.lbl_SUMMA.Location = new System.Drawing.Point(260, 454);
            this.lbl_SUMMA.Name = "lbl_SUMMA";
            this.lbl_SUMMA.Size = new System.Drawing.Size(53, 40);
            this.lbl_SUMMA.TabIndex = 14;
            this.lbl_SUMMA.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(28, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "В наличии";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.ImageLocation = "C:\\Users\\MagicBook\\Desktop\\Универ\\yamaha-png-yamaha-logo-black-white-2232.png";
            this.pictureBoxLogo.Location = new System.Drawing.Point(32, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(353, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // VIN_Number
            // 
            this.VIN_Number.DataPropertyName = "VIN_Number";
            this.VIN_Number.HeaderText = "VIN_Number";
            this.VIN_Number.MinimumWidth = 6;
            this.VIN_Number.Name = "VIN_Number";
            this.VIN_Number.Visible = false;
            this.VIN_Number.Width = 125;
            // 
            // motoNameDataGridViewTextBoxColumn
            // 
            this.motoNameDataGridViewTextBoxColumn.DataPropertyName = "Moto_Name";
            this.motoNameDataGridViewTextBoxColumn.HeaderText = "Moto_Name";
            this.motoNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoNameDataGridViewTextBoxColumn.Name = "motoNameDataGridViewTextBoxColumn";
            this.motoNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // motoTypeDataGridViewTextBoxColumn
            // 
            this.motoTypeDataGridViewTextBoxColumn.DataPropertyName = "Moto_Type";
            this.motoTypeDataGridViewTextBoxColumn.HeaderText = "Moto_Type";
            this.motoTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoTypeDataGridViewTextBoxColumn.Name = "motoTypeDataGridViewTextBoxColumn";
            this.motoTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // engineVolumeDataGridViewTextBoxColumn
            // 
            this.engineVolumeDataGridViewTextBoxColumn.DataPropertyName = "Engine_Volume";
            this.engineVolumeDataGridViewTextBoxColumn.HeaderText = "Engine_Volume";
            this.engineVolumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineVolumeDataGridViewTextBoxColumn.Name = "engineVolumeDataGridViewTextBoxColumn";
            this.engineVolumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // motoColorDataGridViewTextBoxColumn
            // 
            this.motoColorDataGridViewTextBoxColumn.DataPropertyName = "Moto_Color";
            this.motoColorDataGridViewTextBoxColumn.HeaderText = "Moto_Color";
            this.motoColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motoColorDataGridViewTextBoxColumn.Name = "motoColorDataGridViewTextBoxColumn";
            this.motoColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VIN_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "VIN_Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Moto_Name
            // 
            this.Moto_Name.DataPropertyName = "Moto_Name";
            this.Moto_Name.HeaderText = "Moto_Name";
            this.Moto_Name.MinimumWidth = 6;
            this.Moto_Name.Name = "Moto_Name";
            this.Moto_Name.Width = 125;
            // 
            // Moto_Type
            // 
            this.Moto_Type.DataPropertyName = "Moto_Type";
            this.Moto_Type.HeaderText = "Moto_Type";
            this.Moto_Type.MinimumWidth = 6;
            this.Moto_Type.Name = "Moto_Type";
            this.Moto_Type.Width = 125;
            // 
            // Engine_Volume
            // 
            this.Engine_Volume.DataPropertyName = "Engine_Volume";
            this.Engine_Volume.HeaderText = "Engine_Volume";
            this.Engine_Volume.MinimumWidth = 6;
            this.Engine_Volume.Name = "Engine_Volume";
            this.Engine_Volume.Width = 125;
            // 
            // Moto_Color
            // 
            this.Moto_Color.DataPropertyName = "Moto_Color";
            this.Moto_Color.HeaderText = "Moto_Color";
            this.Moto_Color.MinimumWidth = 6;
            this.Moto_Color.Name = "Moto_Color";
            this.Moto_Color.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "VIN_Number";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Moto_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Moto_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Moto_Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Moto_Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Engine_Volume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Engine_Volume";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Moto_Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Moto_Color";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // motoInfoTableAdapter1
            // 
            this.motoInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Black;
            this.btn_previous.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_previous.ForeColor = System.Drawing.Color.Gold;
            this.btn_previous.Location = new System.Drawing.Point(431, 321);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(103, 46);
            this.btn_previous.TabIndex = 18;
            this.btn_previous.Text = "< <";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.Gold;
            this.btn_next.Location = new System.Drawing.Point(894, 321);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(103, 46);
            this.btn_next.TabIndex = 19;
            this.btn_next.Text = "> >";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_model_name
            // 
            this.lbl_model_name.AutoSize = true;
            this.lbl_model_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_model_name.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_model_name.ForeColor = System.Drawing.Color.White;
            this.lbl_model_name.Location = new System.Drawing.Point(661, 275);
            this.lbl_model_name.Name = "lbl_model_name";
            this.lbl_model_name.Size = new System.Drawing.Size(153, 40);
            this.lbl_model_name.TabIndex = 20;
            this.lbl_model_name.Text = "model name";
            // 
            // pb_MotoPic
            // 
            this.pb_MotoPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_MotoPic.BackColor = System.Drawing.Color.Transparent;
            this.pb_MotoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_MotoPic.ImageLocation = "C:\\Users\\MagicBook\\Desktop\\Универ\\yamaha-png-yamaha-logo-black-white-2232.png";
            this.pb_MotoPic.Location = new System.Drawing.Point(506, 29);
            this.pb_MotoPic.Name = "pb_MotoPic";
            this.pb_MotoPic.Size = new System.Drawing.Size(421, 207);
            this.pb_MotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MotoPic.TabIndex = 21;
            this.pb_MotoPic.TabStop = false;
            // 
            // dataGrid_Cons
            // 
            this.dataGrid_Cons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Cons.Location = new System.Drawing.Point(564, 382);
            this.dataGrid_Cons.Name = "dataGrid_Cons";
            this.dataGrid_Cons.RowHeadersWidth = 51;
            this.dataGrid_Cons.RowTemplate.Height = 24;
            this.dataGrid_Cons.Size = new System.Drawing.Size(433, 191);
            this.dataGrid_Cons.TabIndex = 22;
            this.dataGrid_Cons.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Cons_CellEnter);
            // 
            // ClientMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 611);
            this.Controls.Add(this.dataGrid_Cons);
            this.Controls.Add(this.pb_MotoPic);
            this.Controls.Add(this.lbl_model_name);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_SUMMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_FIO);
            this.Controls.Add(this.txtbx_TEL_NUMBER);
            this.Controls.Add(this.txtbx_MODEL_SALE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_VNalichii);
            this.Name = "ClientMode";
            this.Text = "ClientMode";
            this.Load += new System.EventHandler(this.ClientMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MotoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MotoDealerDataSet2 motoDealerDataSet2;
        private System.Windows.Forms.BindingSource motoInfoBindingSource;
        private MotoDealerDataSet2TableAdapters.MotoInfoTableAdapter motoInfoTableAdapter;
        private MotoDealerDataSet3 motoDealerDataSet3;
        private System.Windows.Forms.BindingSource consultantsBindingSource;
        private MotoDealerDataSet3TableAdapters.ConsultantsTableAdapter consultantsTableAdapter;
        private System.Windows.Forms.Label lbl_VNalichii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbx_MODEL_SALE;
        private System.Windows.Forms.TextBox txtbx_TEL_NUMBER;
        private System.Windows.Forms.TextBox txtbx_FIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SUMMA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moto_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moto_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engine_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moto_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MotoDealerDataSet4 motoDealerDataSet4;
        private System.Windows.Forms.BindingSource motoInfoBindingSource1;
        private MotoDealerDataSet4TableAdapters.MotoInfoTableAdapter motoInfoTableAdapter1;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_model_name;
        private System.Windows.Forms.PictureBox pb_MotoPic;
        private System.Windows.Forms.DataGridView dataGrid_Cons;
    }
}