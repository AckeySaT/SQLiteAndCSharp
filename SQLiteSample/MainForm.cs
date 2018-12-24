using System;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Racion2018
{
    public partial class Form1 : Form
    {
        private String dbFileName;
        private DataSet ds = new DataSet();
        private SQLiteConnection m_dbConn = new SQLiteConnection();
        private SQLiteCommand m_sqlCmd = new SQLiteCommand();
        private SQLiteDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            dbFileName = "racion.sqlite";
            lbStatusText.Text = "Disconnected";

            #region Connect
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button)");

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                lbStatusText.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
            #endregion Connect
            
            string sql = "SELECT * FROM ingr_tbl";
            // Создаем объект DataAdapter
            adapter = new SQLiteDataAdapter(sql, m_dbConn);
            // Создаем объект Dataset
            
            // Заполняем Dataset
            adapter.Fill(ds);
           //Очистка грида
            GridViewer.Rows.Clear();
            GridViewer.Columns.Clear();
            GridViewer.Refresh();
            // Отображаем данные
            GridViewer.DataSource = ds.Tables[0];
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, name_ingr TEXT, name_ingr TEXT)";                
                m_sqlCmd.ExecuteNonQuery();

                lbStatusText.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }           
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
        }       

        private void btAdd_Click(object sender, EventArgs e)
        {
            //if (m_dbConn.State != ConnectionState.Open)
            //{
            //    MessageBox.Show("Open connection with database");
            //    return;
            //}

            //AddDataToDb addData = new AddDataToDb();
            //if (addData.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        m_sqlCmd.CommandText = "INSERT INTO Catalog ('name_ingr', 'type_ingr') values ('" +
            //            addData.Author + "' , '" +
            //            addData.Book + "')";

            //        m_sqlCmd.ExecuteNonQuery();                    
            //    }
            //    catch (SQLiteException ex)
            //    {                    
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }

        private void btClearTable_Click(object sender, EventArgs e)
        {
            GridViewer.Rows.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void GridViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAddRow_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void GridViewer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
