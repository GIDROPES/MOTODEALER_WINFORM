
using System.Windows.Forms;

namespace SQLCONSOLETEST
{
    partial class AdminMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMode));
            this.motoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoInfoDataSet = new SQLCONSOLETEST.MotoInfoDataSet();
            this.motoInfoTableAdapter = new SQLCONSOLETEST.MotoInfoDataSetTableAdapters.MotoInfoTableAdapter();
            this.MotoQuantity = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Seller_Journal = new System.Windows.Forms.Label();
            this.salesJournalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motoDealerDataSet6 = new SQLCONSOLETEST.MotoDealerDataSet6();
            this.sellerJournalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerJournalDataSet = new SQLCONSOLETEST.SellerJournalDataSet();
            this.btn_addNewMoto = new System.Windows.Forms.Button();
            this.motoDealerDataSet5 = new SQLCONSOLETEST.MotoDealerDataSet5();
            this.salesJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_JournalTableAdapter = new SQLCONSOLETEST.MotoDealerDataSet5TableAdapters.Sales_JournalTableAdapter();
            this.sales_JournalTableAdapter1 = new SQLCONSOLETEST.MotoDealerDataSet6TableAdapters.Sales_JournalTableAdapter();
            this.dgv_Journal = new System.Windows.Forms.DataGridView();
            this.journalSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalSales = new SQLCONSOLETEST.JournalSales();
            this.dgv_motoAvailable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesJournalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerJournalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerJournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Journal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motoAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // motoInfoBindingSource
            // 
            this.motoInfoBindingSource.DataMember = "MotoInfo";
            this.motoInfoBindingSource.DataSource = this.motoInfoDataSet;
            // 
            // motoInfoDataSet
            // 
            this.motoInfoDataSet.DataSetName = "MotoInfoDataSet";
            this.motoInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoInfoTableAdapter
            // 
            this.motoInfoTableAdapter.ClearBeforeFill = true;
            // 
            // MotoQuantity
            // 
            this.MotoQuantity.AutoSize = true;
            this.MotoQuantity.BackColor = System.Drawing.Color.Transparent;
            this.MotoQuantity.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotoQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MotoQuantity.Location = new System.Drawing.Point(25, 71);
            this.MotoQuantity.Name = "MotoQuantity";
            this.MotoQuantity.Size = new System.Drawing.Size(234, 36);
            this.MotoQuantity.TabIndex = 1;
            this.MotoQuantity.Text = "Мотоциклы в наличии";
            this.MotoQuantity.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.ImageLocation = "C:\\Users\\MagicBook\\Desktop\\Универ\\yamaha-png-yamaha-logo-black-white-2232.png";
            this.pictureBoxLogo.Location = new System.Drawing.Point(775, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(374, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Seller_Journal
            // 
            this.Seller_Journal.AutoSize = true;
            this.Seller_Journal.BackColor = System.Drawing.Color.Transparent;
            this.Seller_Journal.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seller_Journal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Seller_Journal.Location = new System.Drawing.Point(25, 345);
            this.Seller_Journal.Name = "Seller_Journal";
            this.Seller_Journal.Size = new System.Drawing.Size(176, 36);
            this.Seller_Journal.TabIndex = 3;
            this.Seller_Journal.Text = "Журнал продаж";
            // 
            // salesJournalBindingSource1
            // 
            this.salesJournalBindingSource1.DataMember = "Sales_Journal";
            this.salesJournalBindingSource1.DataSource = this.motoDealerDataSet6;
            // 
            // motoDealerDataSet6
            // 
            this.motoDealerDataSet6.DataSetName = "MotoDealerDataSet6";
            this.motoDealerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerJournalDataSetBindingSource
            // 
            this.sellerJournalDataSetBindingSource.DataSource = this.sellerJournalDataSet;
            this.sellerJournalDataSetBindingSource.Position = 0;
            // 
            // sellerJournalDataSet
            // 
            this.sellerJournalDataSet.DataSetName = "SellerJournalDataSet";
            this.sellerJournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_addNewMoto
            // 
            this.btn_addNewMoto.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_addNewMoto.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addNewMoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addNewMoto.Location = new System.Drawing.Point(31, 708);
            this.btn_addNewMoto.Name = "btn_addNewMoto";
            this.btn_addNewMoto.Size = new System.Drawing.Size(1118, 63);
            this.btn_addNewMoto.TabIndex = 5;
            this.btn_addNewMoto.Text = "Заказать мотоцикл";
            this.btn_addNewMoto.UseVisualStyleBackColor = false;
            this.btn_addNewMoto.Click += new System.EventHandler(this.btn_addNewMoto_Click);
            // 
            // motoDealerDataSet5
            // 
            this.motoDealerDataSet5.DataSetName = "MotoDealerDataSet5";
            this.motoDealerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesJournalBindingSource
            // 
            this.salesJournalBindingSource.DataMember = "Sales_Journal";
            this.salesJournalBindingSource.DataSource = this.motoDealerDataSet5;
            // 
            // sales_JournalTableAdapter
            // 
            this.sales_JournalTableAdapter.ClearBeforeFill = true;
            // 
            // sales_JournalTableAdapter1
            // 
            this.sales_JournalTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_Journal
            // 
            this.dgv_Journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Journal.Location = new System.Drawing.Point(31, 401);
            this.dgv_Journal.Name = "dgv_Journal";
            this.dgv_Journal.RowHeadersWidth = 51;
            this.dgv_Journal.RowTemplate.Height = 24;
            this.dgv_Journal.Size = new System.Drawing.Size(1118, 272);
            this.dgv_Journal.TabIndex = 6;
            this.dgv_Journal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Journal_CellContentClick);
            // 
            // journalSalesBindingSource
            // 
            this.journalSalesBindingSource.DataSource = this.journalSales;
            this.journalSalesBindingSource.Position = 0;
            // 
            // journalSales
            // 
            this.journalSales.DataSetName = "JournalSales";
            this.journalSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_motoAvailable
            // 
            this.dgv_motoAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_motoAvailable.Location = new System.Drawing.Point(31, 120);
            this.dgv_motoAvailable.Name = "dgv_motoAvailable";
            this.dgv_motoAvailable.RowHeadersWidth = 51;
            this.dgv_motoAvailable.RowTemplate.Height = 24;
            this.dgv_motoAvailable.Size = new System.Drawing.Size(1118, 200);
            this.dgv_motoAvailable.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(308, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Новый консультант";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(546, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Новая модель";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 799);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_motoAvailable);
            this.Controls.Add(this.dgv_Journal);
            this.Controls.Add(this.btn_addNewMoto);
            this.Controls.Add(this.Seller_Journal);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.MotoQuantity);
            this.Name = "AdminMode";
            this.Text = "Администратор Мотосалона";
            this.Load += new System.EventHandler(this.AdminMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesJournalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerJournalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerJournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoDealerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Journal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motoAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MotoInfoDataSet motoInfoDataSet;
        private System.Windows.Forms.BindingSource motoInfoBindingSource;
        private MotoInfoDataSetTableAdapters.MotoInfoTableAdapter motoInfoTableAdapter;
        private System.Windows.Forms.Label MotoQuantity;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Label Seller_Journal;
        private BindingSource sellerJournalDataSetBindingSource;
        private SellerJournalDataSet sellerJournalDataSet;
        private Button btn_addNewMoto;
        private MotoDealerDataSet5 motoDealerDataSet5;
        private BindingSource salesJournalBindingSource;
        private MotoDealerDataSet5TableAdapters.Sales_JournalTableAdapter sales_JournalTableAdapter;
        private MotoDealerDataSet6 motoDealerDataSet6;
        private BindingSource salesJournalBindingSource1;
        private MotoDealerDataSet6TableAdapters.Sales_JournalTableAdapter sales_JournalTableAdapter1;
        private DataGridView dgv_Journal;
        private BindingSource journalSalesBindingSource;
        private JournalSales journalSales;
        private DataGridView dgv_motoAvailable;
        private Button button1;
        private Button button2;
    }
}