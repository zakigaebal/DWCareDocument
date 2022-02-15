﻿using System;
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
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string Connect = "datasource=127.0.0.1;port=3306;database=dawoon;username=root;password=ekdnsel;Charset=utf8";
				string Query2 = "";
				Query2 = "SELECT careSeq,number,birth,flagYN,regDate,issueDate,issueID FROM dc_careenroll WHERE " + "flagYN = 'Y'";
				MySqlConnection con = new MySqlConnection(Connect);
				con.Open();
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
				dataGridView1.Columns[2].HeaderText = "생일";
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
				string Query = "SELECT MAX(careSeq)+1 AS seqMax FROM dawoon.dc_careenroll;";
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
			string Query = "select COUNT(careSeq) cnt from dawoon.dc_careenroll WHERE number ='" + textBoxNumber.Text + "' AND flagYN ='Y';";
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
				// 지출이 계정이고 . 들어오는값이 용돈이고 용돈이 서브에 포함되
				else
				{
					// 지출인데 보너스가 없으면 보너스를 추가
					string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
					string QuerySave = "insert into dawoon.dc_careenroll(careSeq,number,birth,flagYN,regDate,issueDate,issueID) values('"
							+ seqCount() + "','" + textBoxNumber.Text.Trim() + "','" + dateTimePickerBirth.Text
							+ "','Y',now(),now(),'CDY')" + ";";
					MySqlConnection con = new MySqlConnection(Connect);
					MySqlCommand Comm = new MySqlCommand(QuerySave, con);
					MySqlDataReader Read;
					con.Open();
					Read = Comm.ExecuteReader();
					MessageBox.Show("저장완료");
					clear();
					buttonSearch_Click(sender, e);

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
	}
}

	