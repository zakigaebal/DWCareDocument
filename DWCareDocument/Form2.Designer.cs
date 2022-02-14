namespace DWCareDocument
{
	partial class Form2
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
			this.label9 = new System.Windows.Forms.Label();
			this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.tableLayoutPanelCRUD = new System.Windows.Forms.TableLayoutPanel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.tableLayoutPanelCRUD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(33, 63);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 12);
			this.label9.TabIndex = 30;
			this.label9.Text = "개체번호";
			// 
			// dateTimePickerBirth
			// 
			this.dateTimePickerBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePickerBirth.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerBirth.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBirth.Location = new System.Drawing.Point(101, 121);
			this.dateTimePickerBirth.Name = "dateTimePickerBirth";
			this.dateTimePickerBirth.Size = new System.Drawing.Size(134, 29);
			this.dateTimePickerBirth.TabIndex = 32;
			this.dateTimePickerBirth.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(33, 134);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 12);
			this.label11.TabIndex = 31;
			this.label11.Text = "생년월일";
			// 
			// tableLayoutPanelCRUD
			// 
			this.tableLayoutPanelCRUD.ColumnCount = 3;
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonDelete, 2, 0);
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonModify, 1, 0);
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonSave, 0, 0);
			this.tableLayoutPanelCRUD.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanelCRUD.Location = new System.Drawing.Point(0, 222);
			this.tableLayoutPanelCRUD.Name = "tableLayoutPanelCRUD";
			this.tableLayoutPanelCRUD.RowCount = 1;
			this.tableLayoutPanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelCRUD.Size = new System.Drawing.Size(790, 117);
			this.tableLayoutPanelCRUD.TabIndex = 34;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDelete.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonDelete.Location = new System.Drawing.Point(529, 3);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(258, 111);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "삭제";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonModify
			// 
			this.buttonModify.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonModify.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonModify.Location = new System.Drawing.Point(266, 3);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(257, 111);
			this.buttonModify.TabIndex = 1;
			this.buttonModify.Text = "수정";
			this.buttonModify.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSave.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonSave.Location = new System.Drawing.Point(3, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(257, 111);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "저장";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(101, 60);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(134, 21);
			this.textBoxNumber.TabIndex = 35;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(354, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(227, 183);
			this.dataGridView1.TabIndex = 36;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonSearch.Location = new System.Drawing.Point(659, 0);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(131, 222);
			this.buttonSearch.TabIndex = 37;
			this.buttonSearch.Text = "조회";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 339);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.tableLayoutPanelCRUD);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dateTimePickerBirth);
			this.Controls.Add(this.label11);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.tableLayoutPanelCRUD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCRUD;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSearch;
	}
}