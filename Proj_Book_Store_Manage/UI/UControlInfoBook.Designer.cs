
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlInfoBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.gbInfoBook = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbIDPublisher = new System.Windows.Forms.ComboBox();
            this.txtPriceExport = new System.Windows.Forms.TextBox();
            this.txtPriceImport = new System.Windows.Forms.TextBox();
            this.lblPriceExport = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPriceImport = new System.Windows.Forms.Label();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.ptbBook = new System.Windows.Forms.PictureBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.gbAuthor = new System.Windows.Forms.GroupBox();
            this.cbaddAuthor = new System.Windows.Forms.ComboBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lblNameAuthor = new System.Windows.Forms.Label();
            this.gbCategoryBook = new System.Windows.Forms.GroupBox();
            this.cbaddCategory = new System.Windows.Forms.ComboBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnSaveCate = new System.Windows.Forms.Button();
            this.btnEditCate = new System.Windows.Forms.Button();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.gpSearch.SuspendLayout();
            this.gbInfoBook.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panelCategory.SuspendLayout();
            this.gbAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.gbCategoryBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(33, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 32);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(7, 16);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(109, 23);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Thuộc tính";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.btnSearch);
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSearch.Location = new System.Drawing.Point(486, 6);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(293, 168);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(181, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttributeSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(11, 43);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(246, 31);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(519, 187);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(87, 44);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(115, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(418, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(216, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(317, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNameBook
            // 
            this.txtNameBook.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBook.Location = new System.Drawing.Point(106, 84);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(147, 32);
            this.txtNameBook.TabIndex = 2;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(10, 129);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(85, 23);
            this.lbl10.TabIndex = 1;
            this.lbl10.Text = "Số lượng";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(10, 85);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(96, 23);
            this.lblNameBook.TabIndex = 0;
            this.lblNameBook.Text = "Tên Sách";
            // 
            // gbInfoBook
            // 
            this.gbInfoBook.Controls.Add(this.lblAmount);
            this.gbInfoBook.Controls.Add(this.cbIDPublisher);
            this.gbInfoBook.Controls.Add(this.txtPriceExport);
            this.gbInfoBook.Controls.Add(this.txtPriceImport);
            this.gbInfoBook.Controls.Add(this.txtNameBook);
            this.gbInfoBook.Controls.Add(this.lblPriceExport);
            this.gbInfoBook.Controls.Add(this.lblPublisher);
            this.gbInfoBook.Controls.Add(this.lblPriceImport);
            this.gbInfoBook.Controls.Add(this.lbl10);
            this.gbInfoBook.Controls.Add(this.lblIDBook);
            this.gbInfoBook.Controls.Add(this.label1);
            this.gbInfoBook.Controls.Add(this.lblNameBook);
            this.gbInfoBook.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoBook.Location = new System.Drawing.Point(4, 6);
            this.gbInfoBook.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfoBook.Name = "gbInfoBook";
            this.gbInfoBook.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfoBook.Size = new System.Drawing.Size(458, 170);
            this.gbInfoBook.TabIndex = 0;
            this.gbInfoBook.TabStop = false;
            this.gbInfoBook.Text = "Thông tin Sách";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(101, 127);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(21, 23);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "0";
            // 
            // cbIDPublisher
            // 
            this.cbIDPublisher.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIDPublisher.FormattingEnabled = true;
            this.cbIDPublisher.Items.AddRange(new object[] {
            "3"});
            this.cbIDPublisher.Location = new System.Drawing.Point(359, 39);
            this.cbIDPublisher.Name = "cbIDPublisher";
            this.cbIDPublisher.Size = new System.Drawing.Size(99, 31);
            this.cbIDPublisher.TabIndex = 3;
            // 
            // txtPriceExport
            // 
            this.txtPriceExport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceExport.Location = new System.Drawing.Point(364, 131);
            this.txtPriceExport.Name = "txtPriceExport";
            this.txtPriceExport.Size = new System.Drawing.Size(87, 32);
            this.txtPriceExport.TabIndex = 2;
            // 
            // txtPriceImport
            // 
            this.txtPriceImport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceImport.Location = new System.Drawing.Point(364, 86);
            this.txtPriceImport.Name = "txtPriceImport";
            this.txtPriceImport.Size = new System.Drawing.Size(87, 32);
            this.txtPriceImport.TabIndex = 2;
            // 
            // lblPriceExport
            // 
            this.lblPriceExport.AutoSize = true;
            this.lblPriceExport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceExport.Location = new System.Drawing.Point(268, 131);
            this.lblPriceExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceExport.Name = "lblPriceExport";
            this.lblPriceExport.Size = new System.Drawing.Size(86, 23);
            this.lblPriceExport.TabIndex = 1;
            this.lblPriceExport.Text = "Giá Bán";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(268, 39);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(54, 23);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "NXB";
            // 
            // lblPriceImport
            // 
            this.lblPriceImport.AutoSize = true;
            this.lblPriceImport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceImport.Location = new System.Drawing.Point(268, 88);
            this.lblPriceImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceImport.Name = "lblPriceImport";
            this.lblPriceImport.Size = new System.Drawing.Size(97, 23);
            this.lblPriceImport.TabIndex = 1;
            this.lblPriceImport.Text = "Giá Nhập";
            // 
            // lblIDBook
            // 
            this.lblIDBook.AutoSize = true;
            this.lblIDBook.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBook.Location = new System.Drawing.Point(101, 39);
            this.lblIDBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDBook.Name = "lblIDBook";
            this.lblIDBook.Size = new System.Drawing.Size(58, 23);
            this.lblIDBook.TabIndex = 0;
            this.lblIDBook.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUploadImg);
            this.panel1.Controls.Add(this.ptbBook);
            this.panel1.Controls.Add(this.gpSearch);
            this.panel1.Controls.Add(this.gbInfoBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 180);
            this.panel1.TabIndex = 3;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImg.Location = new System.Drawing.Point(972, 68);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(75, 44);
            this.btnUploadImg.TabIndex = 3;
            this.btnUploadImg.Text = "Up Ảnh";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // ptbBook
            // 
            this.ptbBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ptbBook.Location = new System.Drawing.Point(811, 6);
            this.ptbBook.Name = "ptbBook";
            this.ptbBook.Size = new System.Drawing.Size(155, 153);
            this.ptbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBook.TabIndex = 2;
            this.ptbBook.TabStop = false;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(15, 246);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(602, 269);
            this.dgvBook.TabIndex = 5;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.gbAuthor);
            this.panelCategory.Controls.Add(this.gbCategoryBook);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCategory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategory.Location = new System.Drawing.Point(640, 180);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(415, 341);
            this.panelCategory.TabIndex = 7;
            // 
            // gbAuthor
            // 
            this.gbAuthor.Controls.Add(this.cbaddAuthor);
            this.gbAuthor.Controls.Add(this.dgvAuthor);
            this.gbAuthor.Controls.Add(this.btnEditAuthor);
            this.gbAuthor.Controls.Add(this.btnSaveAuthor);
            this.gbAuthor.Controls.Add(this.btnDeleteAuthor);
            this.gbAuthor.Controls.Add(this.btnAddAuthor);
            this.gbAuthor.Controls.Add(this.lblNameAuthor);
            this.gbAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAuthor.Location = new System.Drawing.Point(12, 180);
            this.gbAuthor.Name = "gbAuthor";
            this.gbAuthor.Size = new System.Drawing.Size(400, 181);
            this.gbAuthor.TabIndex = 0;
            this.gbAuthor.TabStop = false;
            this.gbAuthor.Text = "Tác giả";
            // 
            // cbaddAuthor
            // 
            this.cbaddAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbaddAuthor.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbaddAuthor.Location = new System.Drawing.Point(230, 33);
=======
            this.cbaddAuthor.Location = new System.Drawing.Point(210, 26);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.cbaddAuthor.Name = "cbaddAuthor";
            this.cbaddAuthor.Size = new System.Drawing.Size(121, 31);
            this.cbaddAuthor.TabIndex = 2;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvAuthor.Location = new System.Drawing.Point(15, 70);
=======
            this.dgvAuthor.Location = new System.Drawing.Point(15, 60);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.RowHeadersWidth = 51;
            this.dgvAuthor.RowTemplate.Height = 24;
            this.dgvAuthor.Size = new System.Drawing.Size(211, 95);
            this.dgvAuthor.TabIndex = 0;
            this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAuthor.Location = new System.Drawing.Point(320, 60);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnEditAuthor.TabIndex = 1;
            this.btnEditAuthor.Text = "Sửa";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAuthor.Location = new System.Drawing.Point(320, 109);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnSaveAuthor.TabIndex = 1;
            this.btnSaveAuthor.Text = "Lưu";
            this.btnSaveAuthor.UseVisualStyleBackColor = true;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.Location = new System.Drawing.Point(246, 109);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnDeleteAuthor.TabIndex = 1;
            this.btnDeleteAuthor.Text = "Xóa";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(246, 60);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "Thêm";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lblNameAuthor
            // 
            this.lblNameAuthor.AutoSize = true;
            this.lblNameAuthor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblNameAuthor.Location = new System.Drawing.Point(76, 33);
=======
            this.lblNameAuthor.Location = new System.Drawing.Point(101, 26);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.lblNameAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameAuthor.Name = "lblNameAuthor";
            this.lblNameAuthor.Size = new System.Drawing.Size(121, 23);
            this.lblNameAuthor.TabIndex = 0;
            this.lblNameAuthor.Text = "Tên Tác Giả";
            // 
            // gbCategoryBook
            // 
            this.gbCategoryBook.Controls.Add(this.cbaddCategory);
            this.gbCategoryBook.Controls.Add(this.dgvCategory);
            this.gbCategoryBook.Controls.Add(this.btnSaveCate);
            this.gbCategoryBook.Controls.Add(this.btnEditCate);
            this.gbCategoryBook.Controls.Add(this.btnDeleteCate);
            this.gbCategoryBook.Controls.Add(this.btnAddCate);
            this.gbCategoryBook.Controls.Add(this.lblNameCategory);
            this.gbCategoryBook.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoryBook.Location = new System.Drawing.Point(12, 15);
            this.gbCategoryBook.Name = "gbCategoryBook";
            this.gbCategoryBook.Size = new System.Drawing.Size(417, 159);
            this.gbCategoryBook.TabIndex = 0;
            this.gbCategoryBook.TabStop = false;
            this.gbCategoryBook.Text = "Thể loại sách";
            // 
            // cbaddCategory
            // 
            this.cbaddCategory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbaddCategory.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbaddCategory.Location = new System.Drawing.Point(230, 30);
=======
            this.cbaddCategory.Location = new System.Drawing.Point(246, 8);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.cbaddCategory.Name = "cbaddCategory";
            this.cbaddCategory.Size = new System.Drawing.Size(121, 31);
            this.cbaddCategory.TabIndex = 2;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvCategory.Location = new System.Drawing.Point(15, 70);
=======
            this.dgvCategory.Location = new System.Drawing.Point(15, 51);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(211, 92);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // btnSaveCate
            // 
            this.btnSaveCate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCate.Location = new System.Drawing.Point(320, 104);
            this.btnSaveCate.Name = "btnSaveCate";
            this.btnSaveCate.Size = new System.Drawing.Size(68, 43);
            this.btnSaveCate.TabIndex = 1;
            this.btnSaveCate.Text = "Lưu";
            this.btnSaveCate.UseVisualStyleBackColor = true;
            this.btnSaveCate.Click += new System.EventHandler(this.btnSaveCate_Click);
            // 
            // btnEditCate
            // 
            this.btnEditCate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCate.Location = new System.Drawing.Point(320, 51);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(68, 43);
            this.btnEditCate.TabIndex = 1;
            this.btnEditCate.Text = "Sửa";
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCate.Location = new System.Drawing.Point(246, 104);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(68, 43);
            this.btnDeleteCate.TabIndex = 1;
            this.btnDeleteCate.Text = "Xóa";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCate.Location = new System.Drawing.Point(246, 51);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(68, 43);
            this.btnAddCate.TabIndex = 1;
            this.btnAddCate.Text = "Thêm";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblNameCategory.Location = new System.Drawing.Point(75, 33);
=======
            this.lblNameCategory.Location = new System.Drawing.Point(137, 13);
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031
            this.lblNameCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(122, 23);
            this.lblNameCategory.TabIndex = 0;
            this.lblNameCategory.Text = "Tên Thể loại";
            // 
            // UControlInfoBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBook);
            this.Name = "UControlInfoBook";
            this.Size = new System.Drawing.Size(1055, 521);
            this.Load += new System.EventHandler(this.UControlInfoBook_Load);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.gbInfoBook.ResumeLayout(false);
            this.gbInfoBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panelCategory.ResumeLayout(false);
            this.gbAuthor.ResumeLayout(false);
            this.gbAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.gbCategoryBook.ResumeLayout(false);
            this.gbCategoryBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.GroupBox gbInfoBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblPriceExport;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPriceImport;
        private System.Windows.Forms.TextBox txtPriceExport;
        private System.Windows.Forms.TextBox txtPriceImport;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.GroupBox gbAuthor;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.GroupBox gbCategoryBook;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox ptbBook;
        private System.Windows.Forms.Button btnSaveAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label lblNameAuthor;
        private System.Windows.Forms.Button btnSaveCate;
        private System.Windows.Forms.Button btnDeleteCate;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.ComboBox cbIDPublisher;
        private System.Windows.Forms.ComboBox cbaddAuthor;
        private System.Windows.Forms.ComboBox cbaddCategory;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnEditCate;
        private System.Windows.Forms.Label lblIDBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSearch;
    }
}
