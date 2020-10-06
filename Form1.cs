using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ConsoleApp2
{
    public partial class Form1 : Form
    {
        string conn_string = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void frm_Import_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_result.Columns.Add("N", "N");
                dtg_result.Columns.Add("Mark", "მარკა");
                dtg_result.Columns.Add("Model", "მოდელი");
                dtg_result.Columns.Add("Release Date", "გამოშვების თარიღი");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }


        private void but_import_Click(object sender, EventArgs e)
        {
            try
            {
                //გრიდის გასუფთავება
                dtg_result.Rows.Clear();

                #region დიალოგური ფანჯრის გამოძახება

                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "გთხოვთ აირჩიოთ ფაილი...";
                fdlg.InitialDirectory = @"D:\"; //@"c:\Desktop";
                fdlg.FileName = txt_file_name.Text;
                fdlg.Filter = "Access 2000-2003 (*.mdb)|*.mdb|Access 2007 (*.accdb)|*.accdb";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;

                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    txt_file_name.Text = fdlg.FileName;
                    string file_type = Path.GetExtension(txt_file_name.Text).ToLower().Trim();
                    string path = txt_file_name.Text;

                    #region Connection String-ის ფორმირება

                    if (file_type.Equals(".accdb") || file_type.Equals(".mdb"))
                        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path + "; ";

                    //MessageBox.Show(conn_string);

                    #endregion

                    #region მოთხოვნების გენერირება

                    string query = " SELECT * FROM [Authors]; ";

                    OleDbConnection conn = new OleDbConnection(conn_string);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OleDbCommand com = new OleDbCommand(query, conn);
                    OleDbDataAdapter ad = new OleDbDataAdapter(com);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    ad.Dispose();
                    conn.Close();
                    conn.Dispose();

                    #endregion

                    #region გრიდის შევსება მონაცემებით
                    int rows_counter = 0;
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        dtg_result.Rows.Add();
                        dtg_result.Rows[rows_counter].Cells["N"].Value = rows_counter + 1;
                        dtg_result.Rows[rows_counter].Cells["Mark"].Value = r["Mark"].ToString();
                        dtg_result.Rows[rows_counter].Cells["Model"].Value = r["Model"].ToString();
                        dtg_result.Rows[rows_counter].Cells["Release Date"].Value = r["Release"].ToString();
                        rows_counter++;
                    }

                    #endregion
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //გრიდის გასუფთავება
                dtg_result.Rows.Clear();

                #region დიალოგური ფანჯრის გამოძახება

                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "გთხოვთ აირჩიოთ ექსელის ფაილი...";
                fdlg.InitialDirectory = @"D:\"; //@"c:\Desktop";
                fdlg.FileName = txt_file_name.Text;
                fdlg.Filter = "Excel Sheet(*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;

                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    txt_file_name.Text = fdlg.FileName;
                    string file_type = Path.GetExtension(txt_file_name.Text).ToLower().Trim();
                    string path = txt_file_name.Text;

                    #region Connection String-ის ფორმირება

                    if (file_type.Equals(".xls"))
                        conn_string = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + path
                            + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=2\"";
                    if (file_type.Equals(".xlsx"))
                        conn_string = "Provider=Microsoft.Jet.OLEDB.12.0; Data Source=" + path
                            + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=2\"";


                    //MessageBox.Show(conn_string);

                    #endregion

                    #region მოთხოვნების გენერირება

                    string query = " SELECT * FROM [AuthorList$A2:D8]; ";

                    OleDbConnection conn = new OleDbConnection(conn_string);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OleDbCommand com = new OleDbCommand(query, conn);
                    OleDbDataAdapter ad = new OleDbDataAdapter(com);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    ad.Dispose();
                    conn.Close();
                    conn.Dispose();

                    #endregion

                    #region გრიდის შევსება მონაცემებით
                    int rows_counter = 0;
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        dtg_result.Rows.Add();
                        dtg_result.Rows[rows_counter].Cells["N"].Value = rows_counter + 1;
                        dtg_result.Rows[rows_counter].Cells["Mark"].Value = r[0].ToString();
                        dtg_result.Rows[rows_counter].Cells["Model"].Value = r[1].ToString();
                        dtg_result.Rows[rows_counter].Cells["Release Date"].Value = r[2].ToString();
                        rows_counter++;
                    }

                    #endregion
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void dtg_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
