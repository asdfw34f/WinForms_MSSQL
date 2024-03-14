namespace testApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataView = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtName = new TextBox();
            txtCount = new TextBox();
            txtUnit = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(12, 41);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.Size = new Size(485, 397);
            dataView.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(364, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(382, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(645, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 23);
            txtName.TabIndex = 4;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(645, 142);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(143, 23);
            txtCount.TabIndex = 5;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(645, 171);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(143, 23);
            txtUnit.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(645, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 23);
            txtPrice.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 121);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 150);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 179);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 11;
            label4.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 208);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(682, 238);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(570, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(682, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtCount);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtName;
        private TextBox txtCount;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
    }
}
