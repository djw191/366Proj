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
using System.Diagnostics;

namespace _366Proj
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=.\\GameDB.db; Version = 3";
        string minVGChartzScoreString = "";
        string minMetascoreString = "";
        string ratingString = "";
        string platformString = "";

        // Bryce Variables
        int yourScore = 0;      // the score of the review being made/edited
        

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
            SearchHelper(searchString);
        }
        private void resultSearch_Click(object sender, EventArgs e)
        {
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }
        private void SearchHelper(string search)
        {
            PopulateTable("SELECT g.name, g.Platform, g.genre, g.ESRB_Rating, v.VGChartzscore, m.metascore, s.global_sales, g.Favorited FROM Game g LEFT JOIN VGChartzScore v ON g.name = v.name AND g.platform = v.platform " +
                    "LEFT JOIN ScoreMetacritic m ON g.name = m.name AND g.platform = m.platform " +
                    "LEFT JOIN Shipped s ON g.name = s.name AND g.platform = s.platform WHERE " + platformString + ratingString + minVGChartzScoreString + minMetascoreString + " g.name LIKE '%" + search + "%' ORDER BY s.global_sales DESC");
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string searchString = searchBox.Text;
                mainPagePanel.Visible = false;
                resultsPage.Visible = true;
                searchResultBox.Text = searchBox.Text;
                SearchHelper(searchString);
            }
        }
        private void resultSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchString = searchResultBox.Text;
                SearchHelper(searchString);
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            resultsPage.Visible = false;
            searchBox.Text = "";
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
           Console.WriteLine(query);
            using(SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                var da = new SQLiteDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                resultsGrid.DataSource = dtbl;
                resultsGrid.Update();
                resultsGrid.Refresh();
                conn.Close();
            }                   
        }

        private void Platform_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach(var item in Platform.CheckedItems)
                checkedItems.Add(item.ToString());
            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(Platform.Items[e.Index].ToString());
            else
                checkedItems.Remove(Platform.Items[e.Index].ToString());
            if (checkedItems.Count < 1)
                platformString = "";
            else
            {
                for(int i = 0; i < checkedItems.Count; i++)
                {
                    if (i == 0)
                        platformString = "(g.platform = '" + checkedItems[0] + "'";
                    else
                        platformString += " OR g.platform = '" + checkedItems[i] + "'";
                }
                platformString += ") AND ";
            }
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void ESRB_Rating_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ratingString = "";
            List<string> checkedItems = new List<string>();
            foreach (var item in ESRB_Rating.CheckedItems)
                checkedItems.Add(item.ToString());
            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(ESRB_Rating.Items[e.Index].ToString());
            else
                checkedItems.Remove(ESRB_Rating.Items[e.Index].ToString());
            if (checkedItems.Count >= 1)
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    if (i == 0)
                        ratingString = "(g.ESRB_Rating = '" + checkedItems[0] + "'";
                    else
                        ratingString += " OR g.ESRB_Rating = '" + checkedItems[i] + "'";
                }
                ratingString += ") AND ";
            }
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void VGChartzScore_ValueChanged(object sender, EventArgs e)
        {
            if (VGChartzScore.Value == 0)
                minVGChartzScoreString = "";
            else
                minVGChartzScoreString =  "v.VGChartzscore > " + VGChartzScore.Value.ToString() + " AND ";
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void Metascore_ValueChanged(object sender, EventArgs e)
        {
            if (Metascore.Value == 0)
                minMetascoreString = "";
            else
                minMetascoreString = "m.metascore > " + Metascore.Value.ToString() + " AND ";
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void resultsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Platform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("/nATTEMPTING LINK/");
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand fmd = conn.CreateCommand())
                {
                    fmd.CommandText = "SELECT v.url FROM Game g LEFT JOIN VGChartzScore v ON g.name = v.name AND g.platform = v.platform WHERE g.name = '" + resultsGrid.Rows[e.RowIndex].Cells[0].Value + "' AND g.platform = '" + resultsGrid.Rows[e.RowIndex].Cells[1].Value + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    r.Read();
                    ProcessStartInfo sInfo = new ProcessStartInfo(r.GetString(0));
                    Process.Start(sInfo);
                }
                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void createUserReviews_Save_Click(object sender, EventArgs e)  // Create Your Review Button
        {
            insertDataIntoTable("YourReviews", "(Name, Platform, yourReview, yourScore)", "(TEST_NAME, TEST_PLATFORM, TEST_TEXT, 7)");
            Console.WriteLine("success");
        }

        private void label4_Click_1(object sender, EventArgs e) // Create Review Game title (displayed)
        {

        }

        private void createUserReviews_Back(object sender, EventArgs e)     // Back button for createUserReviews panel
        {
            viewUserReviewsPanel.Visible = true;
            createUserReviewsPanel.Visible = false;
        }

        private void view_Click_1(object sender, EventArgs e)   // main panel -> "view your reviews" button
        {
            viewUserReviewsPanel.Visible = true;
            mainPagePanel.Visible = false;
            resultsPage.Visible = false;
        }

        private void viewUserReviews_Back_Click(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            resultsPage.Visible = false;
            viewUserReviewsPanel.Visible = false;
        }

        private void viewUserReviews_EDIT_REVIEW_Click(object sender, EventArgs e)
        {
            viewUserReviewsPanel.Visible = false;
            createUserReviewsPanel.Visible = true;

            // TODO: load createUserReviewsPanel with info from selected review
        }

        private void createUserReviewsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createUserReview_Delete_Click(object sender, EventArgs e)      // delete button
        {

        }

        private void createUserReview_score_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            yourScore = 10 - createUserReview_score_dropdown.SelectedIndex;     // gets the number that the user selected from the dropdown list
        }

        public void PopulateAnyTable(string query, DataGridView dataGrid)       // should be exactly the same as PopulateTable(), but this one accepts a dataGridView as a parameter
        {
            Console.WriteLine(query);
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                var da = new SQLiteDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dataGrid.DataSource = dtbl;
                dataGrid.Update();
                dataGrid.Refresh();
                conn.Close();
            }
        }

        private void insertDataIntoTable(string table, string column, string inputData)  // Inserts data into specified table
            // Fornat for column:    "(column1, column2, etc.)"
            // Format for inputData: "(value1, value2, etc.);"
        {
            Console.WriteLine(table);
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                try {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = @"INSERT INTO " + table + " " + column + " VALUES " + inputData;
                    cmd.Connection = conn;

                    conn.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Table: " + table + "\nInput Data: " + inputData);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void getYourReviews()
        {
            PopulateAnyTable("SELECT name, Platform, yourScore" +
                "FROM YourReviews", viewUserReviews_dataGridView);
        }

        private void viewUserReviews_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
