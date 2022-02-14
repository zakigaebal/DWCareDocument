using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DWCareDocument
{
	public partial class Form1 : Form
	{
		MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8");
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{


			try
			{
				buttonSearch_Click(sender, e);

				DateTime dateStart = DateTime.Now.AddDays(1 - DateTime.Now.Day);
				datetimepickeStart.Value = dateStart;

				DateTime dateEnd = DateTime.Now;
				dateTimePickerEnd.Value = dateEnd;


				string selectQuery = "";
				연결(selectQuery);
				comboBoxNumber.SelectedIndex = 0;
			}
			catch (Exception ex) { }
		}
		private void 연결(string selectQuery)
		{
			selectQuery = "SELECT * FROM dawoon.dc_careenroll where flagYN = 'Y';";
			connection.Open();
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				comboBoxNumber.Items.Add(reader.GetString("number"));
			}
			connection.Close();
		}
		private void CrudSql(string Query, string 메세지)
		{
			string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
			MySqlConnection con = new MySqlConnection(Connect);
			MySqlCommand Comm = new MySqlCommand(Query, con);
			MySqlDataReader Read;
			con.Open();
			Read = Comm.ExecuteReader();
			MessageBox.Show(메세지);
			con.Close();
		}
		private string seqCount()
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
				string Query = "SELECT MAX(careSeq)+1 AS seqMax FROM dawoon.dc_caredocument;";
				MySqlConnection con = new MySqlConnection(Connect);
				con.Open();
				MySqlCommand cmd = new MySqlCommand(Query, con);
				MySqlDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					if (rdr["seqMax"].ToString() == "")
					{
						string a;
						a = rdr["seqMax"].ToString();
						a = "1";
						return a;
					}
					return rdr["seqMax"].ToString();
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return "";
		}
		public void buttonSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;database=dawoon;username=root;password=ekdnsel;Charset=utf8";
				string searchtext = textBoxSearch.Text.Trim();
				string Query32 = "SELECT number,birth,careStart FROM dawoon.dc_caredocument WHERE NUMBER = '" + comboBoxNumber.Text + "';";
				string field = "";
				string keyText = comboBoxSearch.Text;
				string flagYN = "";
				string Query2 = "";
				string Query4 = "";

				if (keyText == "개체번호") field = "number ";
				else if (keyText == "증상") field = "sympton ";

				if (checkBoxDelShow.Checked == true)
				{
					flagYN = "flagYN = 'N'";
				}
				else
				{
					flagYN = "flagYN = 'Y'";
				}
				// SELECT  accSeq, usedDate, dc_items.acount, dc_items.itemSeq, dc_items.subject, money, content, memo, dc_items.flagYN, dc_items.regDate, dc_items.issueDate, dc_items.issueID FROM dc_account LEFT JOIN dc_items ON dc_account.subject = dc_items.subject;
				// Query32 = "SELECT number,birth FROM dawoon.dc_careenroll WHERE NUMBER = '" + comboBoxNumber.Text + "';";
				Query32 = "SELECT 등록.number, 등록.birth, 문서.careStart FROM dawoon.dc_caredocument 문서 RIGHT JOIN dawoon.dc_careenroll 등록 ON (등록.number = 문서.number) WHERE 등록.number  = '" + comboBoxNumber.Text + "';";
				Query2 = "SELECT * FROM dc_caredocument WHERE " + field + "like '" + "%" + searchtext + "%" + "' AND " + flagYN;
				Query4 = "select COUNT(careSeq) cnt from dawoon.dc_caredocument WHERE flagYN ='Y';";
				//  + field + "like '%" + searchtext + "'% AND " + flagYN;
				//  " RIGHT JOIN dc_items 항목 ON (가계부.subject = 항목.subject) WHERE " + flagYN;
				MySqlConnection con = new MySqlConnection(Connect);

				con.Open();
				MySqlCommand Comm = new MySqlCommand(Query2, con);

				MySqlCommand CommNumber = new MySqlCommand(Query32, con);
				MySqlDataReader rdr = CommNumber.ExecuteReader();

				while (rdr.Read())
				{
					try
					{

						// 1. 키값을 가져와서 저장시켜야됨. 저장시키고 변수 선언
						string birthString = rdr.GetString("birth");
						string careStartString = rdr.GetString("careStart");
						string numberString = rdr.GetString("number");

						dateTimePickerBirth.Text = birthString;

						DateTime cares = new DateTime();
						DateTime birthd = new DateTime();
						TimeSpan remain = new TimeSpan();
						cares = Convert.ToDateTime(careStartString);
						birthd = Convert.ToDateTime(birthString);
						remain = cares - birthd;
						labelAge.Text = remain.Days.ToString();
					}
					catch (Exception ex)
					{
						labelAge.Text = "";
						string birthString = rdr.GetString("birth");



						dateTimePickerBirth.Text = birthString;


					}


				}



				rdr.Close();
				MySqlCommand CommNumber2 = new MySqlCommand(Query4, con);
				MySqlDataReader rdr2 = CommNumber2.ExecuteReader();
				while (rdr2.Read())
				{


					string cnt = rdr2.GetString("cnt");
					// sub.Contains(subject2)
					labelCountNb.Text = cnt;
				}
				rdr2.Close();

				MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
				MyAdapter.SelectCommand = Comm;
				DataTable dTable = new DataTable();
				MyAdapter.Fill(dTable);
				dataGridView1.DataSource = dTable;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
				dataGridView1.Columns[0].HeaderText = "고유번호";
				dataGridView1.Columns[1].HeaderText = "개체번호";
				dataGridView1.Columns[2].HeaderText = "치료시작일";
				dataGridView1.Columns[3].HeaderText = "치료종료일";
				dataGridView1.Columns[4].HeaderText = "시간";
				dataGridView1.Columns[5].HeaderText = "증상";
				dataGridView1.Columns[6].HeaderText = "횟수";
				dataGridView1.Columns[7].HeaderText = "주사처방(M)";
				dataGridView1.Columns[8].HeaderText = "경구투여";
				dataGridView1.Columns[9].HeaderText = "일령";
				dataGridView1.Columns[10].HeaderText = "생년월일";
				dataGridView1.Columns[11].HeaderText = "메모";
			}
			catch (Exception ex) { }

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (comboBoxNumber.Text == "")
			{
				MessageBox.Show("내용을 입력해주세요");
				comboBoxNumber.Focus();
				return;
			}
			else if (textBoxTime.Text == "")
			{
				MessageBox.Show("시간을 입력하세요");
				return;
			}
			try
			{
				string birthString = dateTimePickerBirth.Text;
				string careStartString = datetimepickeStart.Text;

				DateTime cares = new DateTime();
				DateTime birthd = new DateTime();
				TimeSpan remain = new TimeSpan();
				cares = Convert.ToDateTime(careStartString);
				birthd = Convert.ToDateTime(birthString);
				remain = cares - birthd;

				string QuerySave = "insert into dawoon.dc_caredocument(careSeq,number,careStart,careFinish,time,sympton,count,injection,oral,age,birth,memo,flagYN,regDate,issueDate,issueID) values('"
				+ seqCount() + "','"
				+ comboBoxNumber.Text + "','"
				+ datetimepickeStart.Text + "','"
				+ dateTimePickerEnd.Text + "','"
				+ textBoxTime.Text + "','"
				+ textBoxSympton.Text + "','"
				+ textBoxCount.Text + "','"
				+ textBoxInjection.Text + "','"
				+ textBoxOral.Text + "','"
				+ remain + "','"
				+ dateTimePickerBirth.Text + "','"
				+ textBoxMemo.Text
				+ "','Y',now(),now(),'CDY');";
				CrudSql(QuerySave, "저장완료");
				buttonSearch_Click(sender, e);
				clear();
			}

			catch (Exception ex)
			{

			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (textBoxCount.Text == "")
			{
				MessageBox.Show("횟수를 입력해주세요");
				textBoxCount.Focus();
				return;
			}
			try
			{
				string birthString = dateTimePickerBirth.Text;
				string careStartString = datetimepickeStart.Text;

				DateTime cares = new DateTime();
				DateTime birthd = new DateTime();
				TimeSpan remain = new TimeSpan();
				cares = Convert.ToDateTime(careStartString);
				birthd = Convert.ToDateTime(birthString);
				remain = cares - birthd;

				string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
				string QueryUpdate = "update dawoon.dc_caredocument " +

					"SET careSeq='" + seqstr +
					"',careStart='" + datetimepickeStart.Text +
					"',careFinish='" + dateTimePickerEnd.Text +
					"',time='" + textBoxTime.Text +
					"',sympton='" + textBoxSympton.Text +
					"',count='" + textBoxCount.Text +
					"',injection='" + textBoxInjection.Text +
					"',oral='" + textBoxOral.Text +
					"',age='" + remain +
					"',memo='" + textBoxMemo.Text + "' where careSeq='" + seqstr + "';";
				CrudSql(QueryUpdate, "수정완료");
				clear();
				buttonSearch_Click(sender, e);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void textBoxTime_TextChanged(object sender, EventArgs e)
		{
			string prevValue = string.Empty;
			TextBox textBox = sender as TextBox;

			string text = textBox.Text.Replace(",", ""); // 입력되는 텍스트들의 ','를 전부 삭제하기

			long num = 0;
			if (long.TryParse(text, out num))//숫자형태의 값일 때만 처리
			{

				textBox.SelectionStart = textBox.TextLength;//커서를 항상 글자 제일 뒤로 위치시킴
				textBox.SelectionLength = 0;
			}
			else
			{
				textBox.Text = prevValue;//숫자형태의 값이 아니면 이전값으로 설정
			}

			prevValue = textBox.Text;
		}




		private void textBoxCount_TextChanged(object sender, EventArgs e)
		{
			string prevValue = string.Empty;
			TextBox textBox = sender as TextBox;

			string text = textBox.Text.Replace(",", ""); // 입력되는 텍스트들의 ','를 전부 삭제하기

			long num = 0;
			if (long.TryParse(text, out num))//숫자형태의 값일 때만 처리
			{

				textBox.SelectionStart = textBox.TextLength;//커서를 항상 글자 제일 뒤로 위치시킴
				textBox.SelectionLength = 0;
			}
			else
			{
				textBox.Text = prevValue;//숫자형태의 값이 아니면 이전값으로 설정
			}

			prevValue = textBox.Text;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			comboBoxNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			datetimepickeStart.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dateTimePickerEnd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBoxTime.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBoxSympton.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			textBoxCount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			textBoxInjection.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			textBoxOral.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			labelAge.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
			dateTimePickerBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
			textBoxMemo.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();


		}

		private void comboBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			ageChanger();


		}

		private void buttonEnroll_Click(object sender, EventArgs e)
		{
			Form2 newform2 = new Form2();
			newform2.ShowDialog(this);
		}

		private void ageChanger()
		{
			string Connect = "datasource=127.0.0.1;port=3306;database=dawoon;username=root;password=ekdnsel;Charset=utf8";
			string Query32 = "SELECT number,birth,careStart FROM dawoon.dc_caredocument WHERE NUMBER = '" + comboBoxNumber.Text + "';";
			string flagYN = "";
			if (checkBoxDelShow.Checked == true)
			{
				flagYN = "flagYN = 'N'";
			}
			else
			{
				flagYN = "flagYN = 'Y'";
			}
			Query32 = "SELECT 등록.number, 등록.birth, 문서.careStart FROM dawoon.dc_caredocument 문서 RIGHT JOIN dawoon.dc_careenroll 등록 ON (등록.number = 문서.number) WHERE 등록.number  = '" + comboBoxNumber.Text + "';";
			MySqlConnection con = new MySqlConnection(Connect);
			con.Open();
			MySqlCommand CommNumber = new MySqlCommand(Query32, con);
			MySqlDataReader rdr = CommNumber.ExecuteReader();
			while (rdr.Read())
			{
				try
				{
					// 1. 키값을 가져와서 저장시켜야됨. 저장시키고 변수 선언
					string birthString = rdr.GetString("birth");
					string careStartString = rdr.GetString("careStart");
					string numberString = rdr.GetString("number");
					dateTimePickerBirth.Text = birthString;
					DateTime cares = new DateTime();
					DateTime birthd = new DateTime();
					TimeSpan remain = new TimeSpan();
					cares = Convert.ToDateTime(careStartString);
					birthd = Convert.ToDateTime(birthString);
					remain = cares - birthd;
					labelAge.Text = remain.Days.ToString();
				}
				catch (Exception ex)
				{
					labelAge.Text = "";
					string birthString = rdr.GetString("birth");
					dateTimePickerBirth.Text = birthString;
				}
			}
			rdr.Close();
		}

		private void comboBoxNumber_Click(object sender, EventArgs e)
		{
			comboBoxNumber.Items.Clear();
			string selectQuery = "";
			연결(selectQuery);


		}



		private void clear()
		{
			comboBoxNumber.Items.Clear();
			datetimepickeStart.Text = "";
			dateTimePickerEnd.Text = "";
			textBoxTime.Text = "";
			textBoxSympton.Text = "";
			textBoxCount.Text = "";
			textBoxInjection.Text = "";
			textBoxOral.Text = "";

			dateTimePickerBirth.Text = "";
			textBoxMemo.Text = "";
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
				string QueryDelete = "update dawoon.dc_caredocument set flagYN='N' WHERE careSeq=" + seqstr;
				CrudSql(QueryDelete, "삭제완료");
				buttonSearch_Click(sender, e);
				clear();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
		{

		}

		private void datetimepickeStart_ValueChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void dateTimePickerBirth_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void checkBoxDelShow_CheckedChanged(object sender, EventArgs e)
		{
			buttonSearch_Click(sender, e);
		}

		private void comboBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			buttonSearch_Click(sender, e);
		}

		private void buttonFileSave_Click(object sender, EventArgs e)
		{
			ExportToCSV();
		}

		private void ExportToCSV()
		{
			SaveFileDialog saveFileDialog = GetCsvSave();
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Save_Csv(saveFileDialog.FileName, dataGridView1, true); // dataGridView에 데이터를 세팅하는 메서드를 호출
			}



		}

		bool headerText = true;
		private void Save_Csv(string fileName, DataGridView dataGridView1, bool v)
		{
			string delimiter = ",";  // 구분자
			FileStream fs = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
			StreamWriter csvExport = new StreamWriter(fs, System.Text.Encoding.UTF8); //UTF8로 엔코딩

			if (dataGridView1.Rows.Count == 0) return;

			// header가 true면 헤더정보 출력
			if (headerText)
			{
				for (int i = 1; i < dataGridView1.Columns.Count-4; i++)
				{
					csvExport.Write(dataGridView1.Columns[i].HeaderText);
					if (i != dataGridView1.Columns.Count - 1)
					{
						csvExport.Write(delimiter);
					}
				}
			}

			csvExport.Write(csvExport.NewLine); // add new line

			// 데이터 출력
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (!row.IsNewRow)
				{
					for (int i = 1; i < dataGridView1.Columns.Count-4; i++)
					{
						csvExport.Write(row.Cells[i].Value);
						if (i != dataGridView1.Columns.Count - 1)
						{
							csvExport.Write(delimiter);
						}
					}
					csvExport.Write(csvExport.NewLine); // write new line
				}
			}
			


			csvExport.Flush();
			csvExport.Close();
			fs.Close();

			MessageBox.Show("CSV 파일 저장 완료！");
		}

		private SaveFileDialog GetCsvSave()
		{
			//Getting the location and file name of the excel to save from user.
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.CheckPathExists = true;
			saveDialog.AddExtension = true;
			saveDialog.ValidateNames = true;

			string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string filepath = Path.GetDirectoryName(path);


			saveDialog.InitialDirectory = filepath;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			saveDialog.DefaultExt = ".csv";
			saveDialog.Filter = "csv (*.csv) | *.csv";
			saveDialog.FileName = "export".ToString();

			return saveDialog;
		}
	}
}
