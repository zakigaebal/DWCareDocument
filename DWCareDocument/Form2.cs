using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DWCareDocument
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
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

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;database=dawoon;username=root;password=ekdnsel;Charset=utf8";
				string Query2 = "";
				Query2 = "SELECT enrollSeq,number,birth,age,flagYN,regDate,issueDate,issueID FROM dc_careenroll WHERE " + "flagYN = 'Y'";
				MySqlConnection con = new MySqlConnection(Connect);
				con.Open();
				MySqlCommand Comm = new MySqlCommand(Query2, con);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
				MyAdapter.SelectCommand = Comm;
				DataTable dTable = new DataTable();
				MyAdapter.Fill(dTable);
				dataGridView1.DataSource = dTable;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[3].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
				dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
				dataGridView1.Columns[1].HeaderText = "개체번호";
				dataGridView1.Columns[2].HeaderText = "생일";
				//dataGridView1.Columns[3].HeaderText = "일령";
			}
			catch (Exception ex) { 
			if(ex.Message.ToString() == "Unable to connect to any of the specified MySQL hosts.")
				{
					MessageBox.Show("데이터베이스가 없거나 실행되지않았습니다.");
				}
			}
		}

		private string seqCount()
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
				string Query = "SELECT MAX(enrollSeq)+1 AS seqMax FROM dawoon.dc_careenroll;";
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

		public void buttonSave_Click(object sender, EventArgs e)
		{
			string constring = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
			string Query = "select COUNT(enrollSeq) cnt from dawoon.dc_careenroll WHERE number ='" + textBoxNumber.Text + "' AND flagYN ='Y';";
	

			MySqlConnection con3 = new MySqlConnection(constring);
			MySqlCommand Comm3 = new MySqlCommand(Query, con3);
			MySqlDataReader Read3;
			con3.Open();
			Read3 = Comm3.ExecuteReader();
			while (Read3.Read())
			{
				
				string cnt = Read3.GetString("cnt");
				if (Convert.ToInt32(cnt) > 0)
				{
					MessageBox.Show(textBoxNumber.Text + "키워드가 이미 들어가 있습니다.");
					// 2. 키값이랑 텍스트박스 서브젝트랑 존재하면 메세지박스 띄우기
				}
				
				else
				{
					


						// 지출인데 보너스가 없으면 보너스를 추가

						string QuerySave = "insert into dawoon.dc_careenroll(enrollSeq,number,birth,age,flagYN,regDate,issueDate,issueID) values('"
							+ seqCount() + "','" + textBoxNumber.Text.Trim() + "','" + dateTimePickerBirth.Text + "','" + "1"
							+ "','Y',now(),now(),'CDY')" + ";";
					CrudSql(QuerySave, "저장완료");
					buttonSearch_Click(sender, e);
					clear();

					Form1 MainForm = (Form1)Owner;
					//메인폼안에 있는 버튼서치메소드를 호출할 수 있다
					MainForm.buttonSearch_Click(sender, e);

				}
		
			}
		}

		private void clear()
		{
			textBoxNumber.Text = "";
			dateTimePickerBirth.Text = "";
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			buttonSearch_Click(sender,e);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Form1 MainForm = (Form1)Owner;

			string birthString = dateTimePickerBirth.Text;
			string careStartString = MainForm.datetimepickeStart.Text;
			//string careStartString = rdr.GetString("careStart");

			DateTime cares = new DateTime();
			DateTime birthd = new DateTime();
			TimeSpan remain = new TimeSpan();
			cares = Convert.ToDateTime(careStartString);
			birthd = Convert.ToDateTime(birthString);
			remain = cares - birthd;

			cares = Convert.ToDateTime(careStartString);
			string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			string QueryUpdate = "update dawoon.dc_careenroll " +
			"SET enrollSeq='" + seqstr +
			"',number='" + textBoxNumber.Text +
			"',birth='" + dateTimePickerBirth.Text +
			"' where enrollSeq='" + seqstr + "';";
			CrudSql(QueryUpdate, "수정완료");
			clear();
			buttonSearch_Click(sender, e);

			//메인폼안에 있는 버튼서치메소드를 호출할 수 있다
			
			MainForm.buttonSearch_Click(sender, e);


			string QueryUpdate3 = "update dawoon.dc_caredocument 문서 RIGHT JOIN dawoon.dc_careenroll AS 등록 " +
				"ON (문서.number = 등록.number)" +
				"set 문서.enrollSeq='" + seqstr + "',문서.age='" + MainForm.labelAge.Text
				+ " where 문서.enrollSeq='" + seqstr + "' and 문서.flagYN = 'Y';";


			string QueryUpdate2 = "update dawoon.dc_caredocument set age='" + remain.Days.ToString() + "' where enrollSeq='" +seqstr + "';";
			string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
			MySqlConnection con = new MySqlConnection(Connect);
			MySqlCommand Comm = new MySqlCommand(QueryUpdate2, con);
			MySqlDataReader Read;
			con.Open();
			Read = Comm.ExecuteReader();

			con.Close();

			MainForm.buttonSearch_Click(sender, e);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			textBoxNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			dateTimePickerBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
				string QueryDelete = "update dawoon.dc_careenroll set flagYN='N' WHERE enrollSeq=" + seqstr;
				CrudSql(QueryDelete, "삭제완료");
				buttonSearch_Click(sender, e);
				clear();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

	