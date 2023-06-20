namespace REMS_2
{
    partial class PropertyImageFormcs
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
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowPropertyImg = new System.Windows.Forms.Button();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxImagesId = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPropertyImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 40);
            this.label4.TabIndex = 108;
            this.label4.Text = "PROPERTY TYPES:";
            // 
            // listBoxType
            // 
            this.listBoxType.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 40;
            this.listBoxType.Location = new System.Drawing.Point(12, 245);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(294, 404);
            this.listBoxType.TabIndex = 107;
            this.listBoxType.Click += new System.EventHandler(this.listBoxType_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Beige;
            this.buttonRemove.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Brown;
            this.buttonRemove.Location = new System.Drawing.Point(834, 642);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(294, 73);
            this.buttonRemove.TabIndex = 106;
            this.buttonRemove.Text = "REMOVE";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(827, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 40);
            this.label3.TabIndex = 105;
            this.label3.Text = "IMAGES LIST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(351, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 40);
            this.label2.TabIndex = 104;
            this.label2.Text = "PROPERTIES LIST:";
            // 
            // buttonShowPropertyImg
            // 
            this.buttonShowPropertyImg.BackColor = System.Drawing.Color.Beige;
            this.buttonShowPropertyImg.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowPropertyImg.ForeColor = System.Drawing.Color.Brown;
            this.buttonShowPropertyImg.Location = new System.Drawing.Point(358, 655);
            this.buttonShowPropertyImg.Name = "buttonShowPropertyImg";
            this.buttonShowPropertyImg.Size = new System.Drawing.Size(406, 73);
            this.buttonShowPropertyImg.TabIndex = 103;
            this.buttonShowPropertyImg.Text = "CLICK TO SEE THE PROPERTY IMAGES";
            this.buttonShowPropertyImg.UseVisualStyleBackColor = false;
            this.buttonShowPropertyImg.Click += new System.EventHandler(this.buttonShowPropertyImg_Click);
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.BackColor = System.Drawing.Color.Beige;
            this.buttonSelectImage.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImage.ForeColor = System.Drawing.Color.Brown;
            this.buttonSelectImage.Location = new System.Drawing.Point(1203, 166);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(380, 57);
            this.buttonSelectImage.TabIndex = 102;
            this.buttonSelectImage.Text = "SELECT IMAGE";
            this.buttonSelectImage.UseVisualStyleBackColor = false;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Beige;
            this.buttonAdd.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Brown;
            this.buttonAdd.Location = new System.Drawing.Point(1201, 639);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(393, 73);
            this.buttonAdd.TabIndex = 101;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxImagesId
            // 
            this.listBoxImagesId.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxImagesId.FormattingEnabled = true;
            this.listBoxImagesId.ItemHeight = 40;
            this.listBoxImagesId.Location = new System.Drawing.Point(834, 229);
            this.listBoxImagesId.Name = "listBoxImagesId";
            this.listBoxImagesId.Size = new System.Drawing.Size(294, 404);
            this.listBoxImagesId.TabIndex = 99;
            this.listBoxImagesId.Click += new System.EventHandler(this.listBoxImagesId_Click);
            this.listBoxImagesId.SelectedIndexChanged += new System.EventHandler(this.listBoxImagesId_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 420);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(718, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 64);
            this.label1.TabIndex = 97;
            this.label1.Text = "PROPERTY IMAGES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPropertyImage
            // 
            this.pictureBoxPropertyImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxPropertyImage.Location = new System.Drawing.Point(1203, 229);
            this.pictureBoxPropertyImage.Name = "pictureBoxPropertyImage";
            this.pictureBoxPropertyImage.Size = new System.Drawing.Size(380, 404);
            this.pictureBoxPropertyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPropertyImage.TabIndex = 100;
            this.pictureBoxPropertyImage.TabStop = false;
            // 
            // PropertyImageFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1606, 727);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShowPropertyImg);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBoxPropertyImage);
            this.Controls.Add(this.listBoxImagesId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PropertyImageFormcs";
            this.Text = "PropertyImageFormcs";
            this.Load += new System.EventHandler(this.PropertyImageFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowPropertyImg;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxPropertyImage;
        private System.Windows.Forms.ListBox listBoxImagesId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}