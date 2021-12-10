using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace _366Proj
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=GameDB.db; Version = 3";
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void search_Click(object sender, EventArgs e)
        {
            string searchString = searchBox.Text;
            mainPagePanel.Visible = false;
            resultsPage.Visible = true;
            searchResultBox.Text = searchBox.Text;
            PopulateTable("SELECT g.name, g.Platform, g.genre, g.ESRB_Rating, v.VGChartzscore, m.metascore, g.Favorited FROM Game g, VGChartzScore v, ScoreMetacritic m WHERE g.name = v.name AND g.platform = v.platform AND g.name = m.name AND g.platform = m.platform ORDER BY g.rank ASC");
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string searchString = searchBox.Text;
                mainPagePanel.Visible = false;
                resultsPage.Visible = true;
                searchResultBox.Text = searchBox.Text;
            }
        }
        private void Form1_load(object sender, EventArgs e)
        {
            sortBy.SelectedIndex = 1;

        }
        private void Back_Click(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            resultsPage.Visible = false;
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PopulateTable(string query)
        {
            using(SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                var da = new SQLiteDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                resultsGrid.DataSource = dtbl;
                conn.Close();
            }                   
        }
    }
}
