using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace ConfigurationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrepJson_Click(object sender, EventArgs e)
        {
            string strRawJson = txtRawJson.Text;
            string[] listElements = strRawJson.Split('}');
            foreach (string listElement in listElements)
            {
                decimal amountVal = decimal.Parse(listElement.Split(new string[] { "AMOUNT" }, StringSplitOptions.None)[1].Substring(3, listElement.Split(new string[] { "AMOUNT" }, StringSplitOptions.None)[1].Length - 4));
            }
        }

        private void txtRawJson_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    string conn = string.Empty;
                    DataTable dtexcel = new DataTable();
                    //if (fileExt.CompareTo(".xls") == 0)
                        //conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    //else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007  
                    using (OleDbConnection con = new OleDbConnection(conn))
                    {
                        try
                        {
                            OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1 
                            dtexcel.Clear();
                            dtexcel.Columns.Clear();
                            oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                            if (dtexcel.Rows.Count > 1)
                            {
                                StringBuilder sbBuildJSON = new StringBuilder();
                                sbBuildJSON.Append("[");
                                for (int i = 0; i < dtexcel.Rows.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        sbBuildJSON.AppendLine("{");
                                    }
                                    else
                                    {
                                        sbBuildJSON.AppendLine(",{");
                                    }       
                                        
                                    for (int j = 0; j < dtexcel.Columns.Count; j++)
                                    {
                                        if (j == dtexcel.Columns.Count - 1)
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "receipt")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }                                            
                                        }
                                        else
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "receipt")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                        }
                                        
                                    }
                                    sbBuildJSON.AppendLine("}");        
                                }
                                sbBuildJSON.Append("]");
                                richTextBox1.Text = sbBuildJSON.ToString();
                            }
                        }
                        catch(Exception ex) 
                        {

                        }
                    }
                    // dtexcel;
                }
                catch (IOException)
                {

                }
            }            
        }

        private void btn_UploadPurohita_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    string conn = string.Empty;
                    DataTable dtexcel = new DataTable();
                    //if (fileExt.CompareTo(".xls") == 0)
                    //conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    //else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007  
                    using (OleDbConnection con = new OleDbConnection(conn))
                    {
                        try
                        {
                            OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [aparam$]", con); //here we read data from sheet1 
                            dtexcel.Clear();
                            dtexcel.Columns.Clear();
                            oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                            if (dtexcel.Rows.Count > 1)
                            {
                                StringBuilder sbBuildJSON = new StringBuilder();
                                sbBuildJSON.Append("[");
                                for (int i = 0; i < dtexcel.Rows.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        sbBuildJSON.AppendLine("{");
                                    }
                                    else
                                    {
                                        sbBuildJSON.AppendLine(",{");
                                    }

                                    for (int j = 0; j < dtexcel.Columns.Count; j++)
                                    {
                                        if (j == dtexcel.Columns.Count - 1)
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "amount")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                        }
                                        else
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "amount")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                        }

                                    }
                                    sbBuildJSON.AppendLine("}");
                                }
                                sbBuildJSON.Append("]");
                                richTextBox1.Text = sbBuildJSON.ToString();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    // dtexcel;
                }
                catch (IOException)
                {

                }
            }
        }

        private void btnYaagnikam_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    string conn = string.Empty;
                    DataTable dtexcel = new DataTable();
                    //if (fileExt.CompareTo(".xls") == 0)
                    //conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    //else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007  
                    using (OleDbConnection con = new OleDbConnection(conn))
                    {
                        try
                        {
                            OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [yaagnikam$]", con); //here we read data from sheet1 
                            dtexcel.Clear();
                            dtexcel.Columns.Clear();
                            oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                            if (dtexcel.Rows.Count > 1)
                            {
                                StringBuilder sbBuildJSON = new StringBuilder();
                                sbBuildJSON.Append("[");
                                for (int i = 0; i < dtexcel.Rows.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        sbBuildJSON.AppendLine("{");
                                    }
                                    else
                                    {
                                        sbBuildJSON.AppendLine(",{");
                                    }

                                    for (int j = 0; j < dtexcel.Columns.Count; j++)
                                    {
                                        if (j == dtexcel.Columns.Count - 1)
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "amount")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                        }
                                        else
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "amount")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                        }

                                    }
                                    sbBuildJSON.AppendLine("}");
                                }
                                sbBuildJSON.Append("]");
                                richTextBox1.Text = sbBuildJSON.ToString();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    // dtexcel;
                }
                catch (IOException)
                {

                }
            }
        }

        private void btnAshramamItems_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    string conn = string.Empty;
                    DataTable dtexcel = new DataTable();
                    //if (fileExt.CompareTo(".xls") == 0)
                    //conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    //else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007  
                    using (OleDbConnection con = new OleDbConnection(conn))
                    {
                        try
                        {
                            OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1 
                            dtexcel.Clear();
                            dtexcel.Columns.Clear();
                            oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                            if (dtexcel.Rows.Count > 1)
                            {
                                StringBuilder sbBuildJSON = new StringBuilder();
                                sbBuildJSON.Append("[");
                                for (int i = 0; i < dtexcel.Rows.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        sbBuildJSON.AppendLine("{");
                                    }
                                    else
                                    {
                                        sbBuildJSON.AppendLine(",{");
                                    }

                                    for (int j = 0; j < dtexcel.Columns.Count; j++)
                                    {
                                        if (j == dtexcel.Columns.Count - 1)
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "img")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])));
                                            }
                                        }
                                        else
                                        {
                                            if (dtexcel.Columns[j].ColumnName.ToLower() == "img")
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                            else
                                            {
                                                sbBuildJSON.AppendLine("\"" + dtexcel.Columns[j] + "\":" + (dtexcel.Columns[j].DataType.FullName.Equals("System.String") ? "\"" + (dtexcel.Rows[i][j].Equals(DBNull.Value) ? "" : dtexcel.Rows[i][j]) + "\"" : (dtexcel.Rows[i][j].Equals(DBNull.Value) ? 0 : dtexcel.Rows[i][j])) + ",");
                                            }
                                        }

                                    }
                                    sbBuildJSON.AppendLine("}");
                                }
                                sbBuildJSON.Append("]");
                                richTextBox1.Text = sbBuildJSON.ToString();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    // dtexcel;
                }
                catch (IOException)
                {

                }
            }
        }
    }
}
