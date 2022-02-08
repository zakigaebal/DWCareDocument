using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		}

		private void 연결(string selectQuery, string account)
		{

			selectQuery = "SELECT * FROM dawoon.dc_items where flagYN = 'Y';";
			connection.Open();
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
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
			string Query2 = "SELECT 가계부.accSeq," +
				 " 가계부.usedDate," +
				 " 항목.acount," +
				 " 항목.subject," +
				 " 가계부.money," +
				 " 가계부.content," +
				 " 가계부.memo," +
				 " 가계부.flagYN," +
				 " 가계부.regDate," +
				 " 가계부.issueDate," +
				 " 가계부.issueID" +
				 " FROM dc_account 가계부" +
				 " RIGHT JOIN dc_items 항목 ON (가계부.subject = 항목.subject) WHERE '" + field + "'" + " like '%" + searchtext + "'% AND " + flagYN;

	

			if (checkBoxDelShow.Checked == true)
			{
				flagYN = "가계부.flagYN = 'N'";
			}
			else
			{
				flagYN = "가계부.flagYN = 'Y'";
			}
			// SELECT  accSeq, usedDate, dc_items.acount, dc_items.itemSeq, dc_items.subject, money, content, memo, dc_items.flagYN, dc_items.regDate, dc_items.issueDate, dc_items.issueID FROM dc_account LEFT JOIN dc_items ON dc_account.subject = dc_items.subject;

			Query2 = "SELECT 가계부.accSeq," +
				 " 가계부.usedDate," +
				 " 항목.acount," +
				 " 항목.subject," +
				 " 가계부.money," +
				 " 가계부.content," +
				 " 가계부.memo," +
				 " 가계부.flagYN," +
				 " 가계부.regDate," +
				 " 가계부.issueDate," +
				 " 가계부.issueID" +
				 " FROM dc_account 가계부" +
				 " RIGHT JOIN dc_items 항목 ON (가계부.subject = 항목.subject) WHERE "  + flagYN;
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
				
		}
	}
}
