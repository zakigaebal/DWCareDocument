using System;
using System.Data;
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
			buttonSearch_Click(sender, e);

      DateTime dateStart = DateTime.Now.AddDays(1 - DateTime.Now.Day);
      datetimepickeStart.Value = dateStart;
			string selectQuery = "SELECT * FROM dawoon.dc_caredocument";
			연결(selectQuery);
			comboBoxNumber.SelectedIndex = 0;
		}

		private void 연결(string selectQuery)
		{

			selectQuery = "SELECT * FROM dawoon.dc_caredocument where flagYN = 'Y';";
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
		//a
		private string seqCount()
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
				string Query = "SELECT MAX(accSeq)+1 AS seqMax FROM dawoon.dc_account;";
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

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string Connect = "datasource=127.0.0.1;port=3306;database=dawoon;username=root;password=ekdnsel;Charset=utf8";
			string searchtext = textBoxSearch.Text.Trim();
		
			string field = "";
			string flagYN = "";
			string Query2 = "";
			if (checkBoxDelShow.Checked == true)
			{
				flagYN = "flagYN = 'N'";
			}
			else
			{
				flagYN = "flagYN = 'Y'";
			}
			// SELECT  accSeq, usedDate, dc_items.acount, dc_items.itemSeq, dc_items.subject, money, content, memo, dc_items.flagYN, dc_items.regDate, dc_items.issueDate, dc_items.issueID FROM dc_account LEFT JOIN dc_items ON dc_account.subject = dc_items.subject;

			Query2 = "SELECT * FROM dc_caredocument WHERE " + flagYN;
			//  + field + "like '%" + searchtext + "'% AND " + flagYN;
			//  " RIGHT JOIN dc_items 항목 ON (가계부.subject = 항목.subject) WHERE " + flagYN;
			MySqlConnection con = new MySqlConnection(Connect);
			MySqlCommand Comm = new MySqlCommand(Query2, con);
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

		private void buttonSave_Click(object sender, EventArgs e)
		{
				if(textBoxTime.Text == "")
			{
				MessageBox.Show("시간을 입력하세요");
				return;
			}



			try
			{
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
				+ textBoxAge.Text + "','"
				+ dateTimePickerBirth.Text + "','"
				+ textBoxMemo.Text
				+ "','Y',now(),now(),'CDY');";
				CrudSql(QuerySave, "저장완료");
				buttonSearch_Click(sender, e);
			}

			catch(Exception ex)
			{

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
	}
}
