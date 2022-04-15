namespace noteTaker
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MsgTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotesDataGridView = new System.Windows.Forms.DataGridView();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesAppDataSet = new noteTaker.NotesAppDataSet();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.notesTableAdapter = new noteTaker.NotesAppDataSetTableAdapters.NotesTableAdapter();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NoteIDLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(71, 15);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(218, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // MsgTextBox
            // 
            this.MsgTextBox.Location = new System.Drawing.Point(71, 52);
            this.MsgTextBox.Multiline = true;
            this.MsgTextBox.Name = "MsgTextBox";
            this.MsgTextBox.Size = new System.Drawing.Size(218, 145);
            this.MsgTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes List";
            // 
            // NotesDataGridView
            // 
            this.NotesDataGridView.AllowUserToAddRows = false;
            this.NotesDataGridView.AllowUserToDeleteRows = false;
            this.NotesDataGridView.AllowUserToResizeColumns = false;
            this.NotesDataGridView.AllowUserToResizeRows = false;
            this.NotesDataGridView.AutoGenerateColumns = false;
            this.NotesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.titleDataGridViewTextBoxColumn,
            this.Message});
            this.NotesDataGridView.DataSource = this.notesBindingSource;
            this.NotesDataGridView.Location = new System.Drawing.Point(309, 37);
            this.NotesDataGridView.Name = "NotesDataGridView";
            this.NotesDataGridView.ReadOnly = true;
            this.NotesDataGridView.RowHeadersVisible = false;
            this.NotesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NotesDataGridView.Size = new System.Drawing.Size(166, 160);
            this.NotesDataGridView.TabIndex = 5;
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataMember = "Notes";
            this.notesBindingSource.DataSource = this.notesAppDataSet;
            // 
            // notesAppDataSet
            // 
            this.notesAppDataSet.DataSetName = "NotesAppDataSet";
            this.notesAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(214, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(309, 216);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 7;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(400, 216);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(71, 216);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NoteIDLabel
            // 
            this.NoteIDLabel.AutoSize = true;
            this.NoteIDLabel.Location = new System.Drawing.Point(1, 0);
            this.NoteIDLabel.Name = "NoteIDLabel";
            this.NoteIDLabel.Size = new System.Drawing.Size(13, 13);
            this.NoteIDLabel.TabIndex = 10;
            this.NoteIDLabel.Text = "0";
            this.NoteIDLabel.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Visible = false;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 250);
            this.Controls.Add(this.NoteIDLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NotesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox MsgTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView NotesDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button DeleteButton;
        private NotesAppDataSet notesAppDataSet;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private NotesAppDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label NoteIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}

