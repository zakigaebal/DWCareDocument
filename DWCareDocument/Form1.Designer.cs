namespace DWCareDocument
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.panelInput = new System.Windows.Forms.Panel();
			this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.datetimepickeStart = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.textBoxSympton = new System.Windows.Forms.TextBox();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.textBoxInjection = new System.Windows.Forms.TextBox();
			this.textBoxOral = new System.Windows.Forms.TextBox();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelAge = new System.Windows.Forms.Label();
			this.buttonEnroll = new System.Windows.Forms.Button();
			this.tableLayoutPanelCRUD = new System.Windows.Forms.TableLayoutPanel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.comboBoxNumber = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.buttonFileSave = new System.Windows.Forms.Button();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			this.labelCountNb = new System.Windows.Forms.Label();
			this.checkBoxDelShow = new System.Windows.Forms.CheckBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.panelInput.SuspendLayout();
			this.tableLayoutPanelInput.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanelCRUD.SuspendLayout();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.78419F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21581F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panelSearch, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 524);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(670, 93);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(695, 428);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.97727F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02273F));
			this.tableLayoutPanel4.Controls.Add(this.panelInput, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 93);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 428F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 428F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(661, 428);
			this.tableLayoutPanel4.TabIndex = 6;
			// 
			// panelInput
			// 
			this.panelInput.Controls.Add(this.tableLayoutPanelInput);
			this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelInput.Location = new System.Drawing.Point(326, 3);
			this.panelInput.Name = "panelInput";
			this.panelInput.Size = new System.Drawing.Size(332, 422);
			this.panelInput.TabIndex = 5;
			// 
			// tableLayoutPanelInput
			// 
			this.tableLayoutPanelInput.ColumnCount = 2;
			this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94671F));
			this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05329F));
			this.tableLayoutPanelInput.Controls.Add(this.dateTimePickerEnd, 1, 1);
			this.tableLayoutPanelInput.Controls.Add(this.datetimepickeStart, 1, 0);
			this.tableLayoutPanelInput.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanelInput.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanelInput.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanelInput.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanelInput.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanelInput.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanelInput.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanelInput.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxTime, 1, 2);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxSympton, 1, 3);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxCount, 1, 4);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxInjection, 1, 5);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxOral, 1, 6);
			this.tableLayoutPanelInput.Controls.Add(this.textBoxMemo, 1, 7);
			this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelInput.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
			this.tableLayoutPanelInput.RowCount = 8;
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanelInput.Size = new System.Drawing.Size(332, 422);
			this.tableLayoutPanelInput.TabIndex = 4;
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerEnd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(169, 64);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(135, 29);
			this.dateTimePickerEnd.TabIndex = 27;
			this.dateTimePickerEnd.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
			// 
			// datetimepickeStart
			// 
			this.datetimepickeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.datetimepickeStart.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.datetimepickeStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.datetimepickeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datetimepickeStart.Location = new System.Drawing.Point(169, 10);
			this.datetimepickeStart.Name = "datetimepickeStart";
			this.datetimepickeStart.Size = new System.Drawing.Size(135, 29);
			this.datetimepickeStart.TabIndex = 26;
			this.datetimepickeStart.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
			this.datetimepickeStart.ValueChanged += new System.EventHandler(this.datetimepickeStart_ValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "치료시작일";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "치료종료일";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "시간";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "증상";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "횟수";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "주사처방(M)";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(44, 277);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 6;
			this.label7.Text = "경구투여";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(56, 361);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 7;
			this.label8.Text = "메모";
			// 
			// textBoxTime
			// 
			this.textBoxTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxTime.Location = new System.Drawing.Point(187, 114);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(100, 21);
			this.textBoxTime.TabIndex = 10;
			this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
			// 
			// textBoxSympton
			// 
			this.textBoxSympton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxSympton.Location = new System.Drawing.Point(187, 146);
			this.textBoxSympton.Name = "textBoxSympton";
			this.textBoxSympton.Size = new System.Drawing.Size(100, 21);
			this.textBoxSympton.TabIndex = 11;
			this.textBoxSympton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxCount
			// 
			this.textBoxCount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxCount.Location = new System.Drawing.Point(187, 179);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(100, 21);
			this.textBoxCount.TabIndex = 12;
			this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
			// 
			// textBoxInjection
			// 
			this.textBoxInjection.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxInjection.Location = new System.Drawing.Point(187, 220);
			this.textBoxInjection.Name = "textBoxInjection";
			this.textBoxInjection.Size = new System.Drawing.Size(100, 21);
			this.textBoxInjection.TabIndex = 13;
			// 
			// textBoxOral
			// 
			this.textBoxOral.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxOral.Location = new System.Drawing.Point(187, 273);
			this.textBoxOral.Name = "textBoxOral";
			this.textBoxOral.Size = new System.Drawing.Size(100, 21);
			this.textBoxOral.TabIndex = 14;
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMemo.Location = new System.Drawing.Point(145, 316);
			this.textBoxMemo.Multiline = true;
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(184, 103);
			this.textBoxMemo.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelAge);
			this.panel1.Controls.Add(this.buttonEnroll);
			this.panel1.Controls.Add(this.tableLayoutPanelCRUD);
			this.panel1.Controls.Add(this.comboBoxNumber);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dateTimePickerBirth);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(317, 422);
			this.panel1.TabIndex = 30;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(76, 72);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(29, 12);
			this.labelAge.TabIndex = 33;
			this.labelAge.Text = "일령";
			// 
			// buttonEnroll
			// 
			this.buttonEnroll.Location = new System.Drawing.Point(219, 19);
			this.buttonEnroll.Name = "buttonEnroll";
			this.buttonEnroll.Size = new System.Drawing.Size(75, 39);
			this.buttonEnroll.TabIndex = 32;
			this.buttonEnroll.Text = "개체등록";
			this.buttonEnroll.UseVisualStyleBackColor = true;
			this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
			// 
			// tableLayoutPanelCRUD
			// 
			this.tableLayoutPanelCRUD.ColumnCount = 3;
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonDelete, 2, 0);
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonUpdate, 1, 0);
			this.tableLayoutPanelCRUD.Controls.Add(this.buttonSave, 0, 0);
			this.tableLayoutPanelCRUD.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanelCRUD.Location = new System.Drawing.Point(0, 339);
			this.tableLayoutPanelCRUD.Name = "tableLayoutPanelCRUD";
			this.tableLayoutPanelCRUD.RowCount = 1;
			this.tableLayoutPanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelCRUD.Size = new System.Drawing.Size(317, 83);
			this.tableLayoutPanelCRUD.TabIndex = 31;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDelete.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonDelete.Location = new System.Drawing.Point(213, 3);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(101, 77);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "삭제";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonUpdate.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonUpdate.Location = new System.Drawing.Point(108, 3);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(99, 77);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "수정";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSave.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.buttonSave.Location = new System.Drawing.Point(3, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(99, 77);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "저장";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// comboBoxNumber
			// 
			this.comboBoxNumber.FormattingEnabled = true;
			this.comboBoxNumber.Location = new System.Drawing.Point(78, 27);
			this.comboBoxNumber.Name = "comboBoxNumber";
			this.comboBoxNumber.Size = new System.Drawing.Size(134, 20);
			this.comboBoxNumber.TabIndex = 29;
			this.comboBoxNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumber_SelectedIndexChanged);
			this.comboBoxNumber.Click += new System.EventHandler(this.comboBoxNumber_Click);
			this.comboBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxNumber_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 35);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 12);
			this.label9.TabIndex = 1;
			this.label9.Text = "개체번호";
			// 
			// dateTimePickerBirth
			// 
			this.dateTimePickerBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePickerBirth.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerBirth.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBirth.Location = new System.Drawing.Point(84, 113);
			this.dateTimePickerBirth.Name = "dateTimePickerBirth";
			this.dateTimePickerBirth.Size = new System.Drawing.Size(134, 29);
			this.dateTimePickerBirth.TabIndex = 28;
			this.dateTimePickerBirth.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
			this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
			this.dateTimePickerBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerBirth_KeyPress);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(19, 123);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 12);
			this.label11.TabIndex = 3;
			this.label11.Text = "생년월일";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(25, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 2;
			this.label10.Text = "일령";
			// 
			// panelSearch
			// 
			this.panelSearch.Controls.Add(this.buttonFileSave);
			this.panelSearch.Controls.Add(this.comboBoxSearch);
			this.panelSearch.Controls.Add(this.labelCountNb);
			this.panelSearch.Controls.Add(this.checkBoxDelShow);
			this.panelSearch.Controls.Add(this.buttonSearch);
			this.panelSearch.Controls.Add(this.textBoxSearch);
			this.panelSearch.Controls.Add(this.label12);
			this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSearch.Location = new System.Drawing.Point(670, 3);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(695, 84);
			this.panelSearch.TabIndex = 12;
			// 
			// buttonFileSave
			// 
			this.buttonFileSave.Location = new System.Drawing.Point(0, 0);
			this.buttonFileSave.Name = "buttonFileSave";
			this.buttonFileSave.Size = new System.Drawing.Size(73, 34);
			this.buttonFileSave.TabIndex = 2;
			this.buttonFileSave.Text = "파일저장";
			this.buttonFileSave.UseVisualStyleBackColor = true;
			this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.Items.AddRange(new object[] {
            "개체번호",
            "증상"});
			this.comboBoxSearch.Location = new System.Drawing.Point(367, 14);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(89, 20);
			this.comboBoxSearch.TabIndex = 17;
			this.comboBoxSearch.Text = "개체번호";
			this.comboBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSearch_KeyPress);
			// 
			// labelCountNb
			// 
			this.labelCountNb.AutoSize = true;
			this.labelCountNb.Location = new System.Drawing.Point(96, 53);
			this.labelCountNb.Name = "labelCountNb";
			this.labelCountNb.Size = new System.Drawing.Size(69, 12);
			this.labelCountNb.TabIndex = 16;
			this.labelCountNb.Text = "등록개체 수";
			// 
			// checkBoxDelShow
			// 
			this.checkBoxDelShow.AutoSize = true;
			this.checkBoxDelShow.Location = new System.Drawing.Point(462, 49);
			this.checkBoxDelShow.Name = "checkBoxDelShow";
			this.checkBoxDelShow.Size = new System.Drawing.Size(72, 16);
			this.checkBoxDelShow.TabIndex = 14;
			this.checkBoxDelShow.Text = "삭제보기";
			this.checkBoxDelShow.UseVisualStyleBackColor = true;
			this.checkBoxDelShow.CheckedChanged += new System.EventHandler(this.checkBoxDelShow_CheckedChanged);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonSearch.Location = new System.Drawing.Point(564, 0);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(131, 84);
			this.buttonSearch.TabIndex = 13;
			this.buttonSearch.Text = "조회";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(462, 13);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(71, 21);
			this.textBoxSearch.TabIndex = 10;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 53);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 12);
			this.label12.TabIndex = 2;
			this.label12.Text = "등록개체 수 :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::DWCareDocument.Properties.Resources.제목을_입력해주세요__복사본_001__1_;
			this.pictureBox1.Location = new System.Drawing.Point(66, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(534, 84);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1368, 547);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "질병 치료 대장";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.panelInput.ResumeLayout(false);
			this.tableLayoutPanelInput.ResumeLayout(false);
			this.tableLayoutPanelInput.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanelCRUD.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.TextBox textBoxSympton;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.TextBox textBoxInjection;
		private System.Windows.Forms.TextBox textBoxOral;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.Panel panelInput;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.CheckBox checkBoxDelShow;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.DateTimePicker datetimepickeStart;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
		private System.Windows.Forms.ComboBox comboBoxNumber;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCRUD;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonEnroll;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelCountNb;
		private System.Windows.Forms.ComboBox comboBoxSearch;
		private System.Windows.Forms.Button buttonFileSave;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

