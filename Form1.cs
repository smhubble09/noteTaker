using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace noteTaker{
    public partial class NotesForm : Form{
        DataTable notesTable;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\repos\noteTaker\NotesApp.accdb; Jet OLEDB:Database Password=notesApp22!";
        public NotesForm(){
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            TitleTextBox.Clear();
            MsgTextBox.Clear();
            NoteIDLabel.Text = "0";
        }

        private void NotesForm_Load(object sender, EventArgs e){
            string query = "SELECT * FROM Notes";
            OleDbConnection conn = new OleDbConnection(connectionString);
            try {
                
                OleDbCommand cmd = new OleDbCommand(query, conn);

                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                notesTable = new DataTable();
                da.Fill(notesTable);

                NotesDataGridView.DataSource = notesTable;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally { 
                conn.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e){
            OleDbConnection conn = new OleDbConnection(connectionString);
            string noteTitle = TitleTextBox.Text;
            string noteMessage = MsgTextBox.Text;
            if (NoteIDLabel.Text == "0") {
                string query = "INSERT INTO Notes (Title,Message)VALUES('" + noteTitle + "','" + noteMessage + "')";
                try {
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show("Failed due to " + ex.Message);
                    conn.Close();
                }
                finally {
                    conn.Close();
                    NotesForm_Load(sender, e);
                    ClearButton_Click(sender, e);
                }
            }
            else {
                string query = "UPDATE Notes SET Title=@a1, Message=a2 WHERE ID=@a0";
                try {
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("a0",NoteIDLabel.Text);
                    cmd.Parameters.AddWithValue("a1", TitleTextBox.Text);
                    cmd.Parameters.AddWithValue("a2", MsgTextBox.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show("Failed due to " + ex.Message);
                    conn.Close();
                }
                finally {
                    conn.Close();
                    NotesForm_Load(sender, e);
                    ClearButton_Click(sender, e);
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            NoteIDLabel.Text = this.NotesDataGridView.CurrentRow.Cells[0].Value.ToString();
            TitleTextBox.Text = this.NotesDataGridView.CurrentRow.Cells[1].Value.ToString();
            MsgTextBox.Text = this.NotesDataGridView.CurrentRow.Cells[2].Value.ToString();    
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            OleDbConnection conn = new OleDbConnection(connectionString);

            try {
                string id = Convert.ToString(NotesDataGridView.Rows[NotesDataGridView.CurrentRow.Index].Cells[0].Value);
                string query = "DELETE FROM Notes WHERE ID=@b0";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("b0", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow item in this.NotesDataGridView.SelectedRows)
                    NotesDataGridView.Rows.RemoveAt(item.Index);
            }
            catch (Exception ex) {
                MessageBox.Show("Failed due to " + ex.Message);
                conn.Close();
            }
            finally {
                conn.Close();
                NotesForm_Load(sender, e);
            }
        }
    }
}
