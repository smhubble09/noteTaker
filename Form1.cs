using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteTaker{
    public partial class NotesForm : Form{
        DataTable table;
        public NotesForm(){
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e){
            this.notesTableAdapter.Fill(this.notesAppDataSet.Notes);
        }

        private void SaveButton_Click(object sender, EventArgs e){
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\repos\noteTaker\NotesApp.accdb; Jet OLEDB:Database Password=notesApp22!";

            try {
                conn.Open();
                String noteTitle = TitleTextBox.Text.ToString();
                String noteMessage = MsgTextBox.Text;
                String query = "INSERT INTO Notes (Title,Message)VALUES('" + noteTitle + "','" + noteMessage + "')";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show("Failed due to " + ex.Message);
                conn.Close();
            }
            finally {
                MessageBox.Show("Note Saved!");
                conn.Close();
                //PopulateDataGridView();
            }
        }

        ////Function for retrieving data from ms access database and displaying it on DataGridView
        //public void PopulateDataGridView() {
        //    table = new DataTable();
        //    OleDbConnection conn = new OleDbConnection();
        //    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\repos\noteTaker\NotesApp.accdb; Jet OLEDB:Database Password=notesApp22!";
        //    String query = "SELECT * FROM Notes";
        //    //First, clear all rows before populating datagridview with data from MS Access Database. Check if datagridview rows are empty before clearing.
        //    if (table.Rows.Count > 0) {
        //        table.Rows.Clear();
        //    }

        //    try {
        //        conn.Open();
        //        //OleDbDataAdapter adapter = new OleDbDataAdapter(sqlQuery, acceddDatabaseConnection);
        //        OleDbCommand cmd = new OleDbCommand(query, conn);
        //        OleDbDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read()) {
        //            //Console.WriteLine(reader[8].GetType());
        //            table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (byte[])reader[8]);
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show(ex.StackTrace);
        //    }
        //    finally {
        //        //Finally Close MS Access Database Connection
        //        if (conn != null) {
        //            conn.Close();
        //        }


        //    }
        //}

        private void ClearButton_Click(object sender, EventArgs e) {
            TitleTextBox.Clear();
            MsgTextBox.Clear();
        }

        private void OpenButton_Click(object sender, EventArgs e) {

        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\repos\noteTaker\NotesApp.accdb; Jet OLEDB:Database Password=notesApp22!";

            try {
                DataRow row = (NotesDataGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
                conn.Open();
                String noteTitle = TitleTextBox.Text.ToString();
                String noteMessage = MsgTextBox.Text;
                String query = "DELETE FROM Notes WHERE ID = " + row["ID"];

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show("Failed due to " + ex.Message);
                conn.Close();
            }
            finally {
                MessageBox.Show("Note Deleted!");
                conn.Close();
                //PopulateDataGridView();
            }
        }
    }
}
