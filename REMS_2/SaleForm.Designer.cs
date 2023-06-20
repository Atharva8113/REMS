namespace REMS_2
{
    partial class SaleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPropertyId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickersalesDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSoldProperties = new System.Windows.Forms.Button();
            this.buttonNotSoldProperties = new System.Windows.Forms.Button();
            this.buttonAllProperties = new System.Windows.Forms.Button();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(822, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 55);
            this.label1.TabIndex = 64;
            this.label1.Text = "SALE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSellingPrice
            // 
            this.textBoxSellingPrice.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSellingPrice.Location = new System.Drawing.Point(162, 344);
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            this.textBoxSellingPrice.Size = new System.Drawing.Size(144, 35);
            this.textBoxSellingPrice.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(-1, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 40);
            this.label6.TabIndex = 62;
            this.label6.Text = "SELLING PRICE:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientId.Location = new System.Drawing.Point(162, 282);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.ReadOnly = true;
            this.textBoxClientId.Size = new System.Drawing.Size(144, 35);
            this.textBoxClientId.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(53, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 40);
            this.label5.TabIndex = 60;
            this.label5.Text = "CLIENT ID:";
            // 
            // textBoxPropertyId
            // 
            this.textBoxPropertyId.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPropertyId.Location = new System.Drawing.Point(162, 220);
            this.textBoxPropertyId.Name = "textBoxPropertyId";
            this.textBoxPropertyId.ReadOnly = true;
            this.textBoxPropertyId.Size = new System.Drawing.Size(144, 35);
            this.textBoxPropertyId.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 40);
            this.label3.TabIndex = 58;
            this.label3.Text = "PROPERTY ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(162, 158);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(144, 35);
            this.textBoxID.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 40);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(97, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 40);
            this.label4.TabIndex = 65;
            this.label4.Text = "DATE:";
            // 
            // dateTimePickersalesDate
            // 
            this.dateTimePickersalesDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickersalesDate.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickersalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickersalesDate.Location = new System.Drawing.Point(162, 406);
            this.dateTimePickersalesDate.Name = "dateTimePickersalesDate";
            this.dateTimePickersalesDate.Size = new System.Drawing.Size(144, 35);
            this.dateTimePickersalesDate.TabIndex = 66;
            this.dateTimePickersalesDate.ValueChanged += new System.EventHandler(this.dateTimePickersalesDate_ValueChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Beige;
            this.buttonRemove.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Brown;
            this.buttonRemove.Location = new System.Drawing.Point(8, 560);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(148, 73);
            this.buttonRemove.TabIndex = 78;
            this.buttonRemove.Text = "REMOVE";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Beige;
            this.buttonEdit.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Brown;
            this.buttonEdit.Location = new System.Drawing.Point(162, 481);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 73);
            this.buttonEdit.TabIndex = 77;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Beige;
            this.buttonAdd.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Brown;
            this.buttonAdd.Location = new System.Drawing.Point(6, 481);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 73);
            this.buttonAdd.TabIndex = 76;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AllowUserToDeleteRows = false;
            this.dataGridViewProperties.AllowUserToResizeColumns = false;
            this.dataGridViewProperties.AllowUserToResizeRows = false;
            this.dataGridViewProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProperties.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(1178, 142);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersWidth = 51;
            this.dataGridViewProperties.RowTemplate.Height = 24;
            this.dataGridViewProperties.Size = new System.Drawing.Size(382, 506);
            this.dataGridViewProperties.TabIndex = 81;
            this.dataGridViewProperties.Click += new System.EventHandler(this.dataGridViewProperties_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(1171, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 40);
            this.label7.TabIndex = 82;
            this.label7.Text = "PROPERTY LIST:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(792, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 40);
            this.label8.TabIndex = 83;
            this.label8.Text = "CLIENTS LIST:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(328, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 40);
            this.label9.TabIndex = 84;
            this.label9.Text = "SALES LIST:";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(335, 142);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.RowTemplate.Height = 24;
            this.dataGridViewSales.Size = new System.Drawing.Size(449, 506);
            this.dataGridViewSales.TabIndex = 85;
            this.dataGridViewSales.Click += new System.EventHandler(this.dataGridViewSales_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeColumns = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(799, 142);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(363, 506);
            this.dataGridViewClients.StandardTab = true;
            this.dataGridViewClients.TabIndex = 86;
            this.dataGridViewClients.Click += new System.EventHandler(this.dataGridViewClients_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Beige;
            this.buttonRefresh.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Brown;
            this.buttonRefresh.Location = new System.Drawing.Point(162, 560);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(155, 73);
            this.buttonRefresh.TabIndex = 87;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSoldProperties
            // 
            this.buttonSoldProperties.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonSoldProperties.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoldProperties.ForeColor = System.Drawing.Color.Brown;
            this.buttonSoldProperties.Location = new System.Drawing.Point(1178, 654);
            this.buttonSoldProperties.Name = "buttonSoldProperties";
            this.buttonSoldProperties.Size = new System.Drawing.Size(382, 48);
            this.buttonSoldProperties.TabIndex = 89;
            this.buttonSoldProperties.Text = "SOLD PROPERTIES";
            this.buttonSoldProperties.UseVisualStyleBackColor = false;
            this.buttonSoldProperties.Click += new System.EventHandler(this.buttonSoldProperties_Click);
            // 
            // buttonNotSoldProperties
            // 
            this.buttonNotSoldProperties.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonNotSoldProperties.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotSoldProperties.ForeColor = System.Drawing.Color.Brown;
            this.buttonNotSoldProperties.Location = new System.Drawing.Point(1178, 708);
            this.buttonNotSoldProperties.Name = "buttonNotSoldProperties";
            this.buttonNotSoldProperties.Size = new System.Drawing.Size(382, 48);
            this.buttonNotSoldProperties.TabIndex = 90;
            this.buttonNotSoldProperties.Text = "NOT SOLD PROPERTIES";
            this.buttonNotSoldProperties.UseVisualStyleBackColor = false;
            this.buttonNotSoldProperties.Click += new System.EventHandler(this.buttonNotSoldProperties_Click);
            // 
            // buttonAllProperties
            // 
            this.buttonAllProperties.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonAllProperties.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllProperties.ForeColor = System.Drawing.Color.Brown;
            this.buttonAllProperties.Location = new System.Drawing.Point(1178, 763);
            this.buttonAllProperties.Name = "buttonAllProperties";
            this.buttonAllProperties.Size = new System.Drawing.Size(382, 48);
            this.buttonAllProperties.TabIndex = 91;
            this.buttonAllProperties.Text = "ALL PROPERTIES";
            this.buttonAllProperties.UseVisualStyleBackColor = false;
            this.buttonAllProperties.Click += new System.EventHandler(this.buttonAllProperties_Click);
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonAddNewClient.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewClient.ForeColor = System.Drawing.Color.Brown;
            this.buttonAddNewClient.Location = new System.Drawing.Point(799, 654);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(363, 48);
            this.buttonAddNewClient.TabIndex = 92;
            this.buttonAddNewClient.Text = "ADD A NEW CLIENT";
            this.buttonAddNewClient.UseVisualStyleBackColor = false;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1629, 823);
            this.Controls.Add(this.buttonAddNewClient);
            this.Controls.Add(this.buttonAllProperties);
            this.Controls.Add(this.buttonNotSoldProperties);
            this.Controls.Add(this.buttonSoldProperties);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProperties);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickersalesDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSellingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPropertyId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSellingPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPropertyId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickersalesDate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSoldProperties;
        private System.Windows.Forms.Button buttonNotSoldProperties;
        private System.Windows.Forms.Button buttonAllProperties;
        private System.Windows.Forms.Button buttonAddNewClient;
    }
}