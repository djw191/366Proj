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
        string[] selectedGame = new string[2];      // [0] = name of game, [1] = platform of game
        string[] currentReview = { "", "", "" };    // [0] = name of game, [1] = platform of game, [2] = review text;
        int createReviewMode = 0;   // used for save button logic, 0 = create new review, 1 = edit existing review
        int createGameMode = 0;     // used for save button logic, 0 = create new review, 1 = edit existing review


        // End of Bryce Variables

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
            if (search.Contains('"')) //the " character breaks this implementation, no time to do properly
                return;
            PopulateTable("SELECT g.name, g.Platform, g.genre, g.ESRB_Rating, v.VGChartzscore, m.metascore, s.global_sales FROM Game g LEFT JOIN VGChartzScore v ON g.name = v.name AND g.platform = v.platform " +
                    "LEFT JOIN ScoreMetacritic m ON g.name = m.name AND g.platform = m.platform " +
                    "LEFT JOIN Shipped s ON g.name = s.name AND g.platform = s.platform WHERE " + platformString + ratingString + minVGChartzScoreString + minMetascoreString + " g.name LIKE \"%" + search + "%\" ORDER BY s.global_sales DESC LIMIT 500");
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
            using (SQLiteConnection conn = new SQLiteConnection(connString))
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
            foreach (var item in Platform.CheckedItems)
                checkedItems.Add(item.ToString());
            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(Platform.Items[e.Index].ToString());
            else
                checkedItems.Remove(Platform.Items[e.Index].ToString());
            if (checkedItems.Count < 1)
                platformString = "";
            else
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    if (i == 0)
                        platformString = "(g.platform = \"" + checkedItems[0] + "\"";
                    else
                        platformString += " OR g.platform = \"" + checkedItems[i] + "\"";
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
                        ratingString = "(g.ESRB_Rating = \"" + checkedItems[0] + "\"";
                    else
                        ratingString += " OR g.ESRB_Rating = \"" + checkedItems[i] + "\"";
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
                minVGChartzScoreString = "v.VGChartzscore > " + VGChartzScore.Value.ToString() + " AND ";
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void Metascore_ValueChanged(object sender, EventArgs e)
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
                using (SQLiteCommand fmd = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        fmd.CommandText = "SELECT v.url FROM Game g LEFT JOIN VGChartzScore v ON g.name = v.name AND g.platform = v.platform WHERE g.name = \"" + resultsGrid.Rows[e.RowIndex].Cells[0].Value + "\" AND g.platform = \"" + resultsGrid.Rows[e.RowIndex].Cells[1].Value + "\"";
                        fmd.CommandType = CommandType.Text;
                        SQLiteDataReader r = fmd.ExecuteReader();
                        r.Read();
                        ProcessStartInfo sInfo = new ProcessStartInfo(r.GetString(0));
                        Process.Start(sInfo);
                    }
                    catch
                    {
                        MessageBox.Show("A webpage does not exist for this game.");
                    }
                    finally
                    {
                        fmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void PopulateAnyTable(string query, DataGridView dataGrid)       // should be exactly the same as PopulateTable(), but this one accepts a dataGridView parameter for use with any dataGridView
        {
            Console.WriteLine(query);
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                try
                {
                    conn.Open();
                    var da = new SQLiteDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dataGrid.DataSource = dtbl;
                    dataGrid.Update();
                    dataGrid.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void setReviewValues(string Name, string Platform)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = "SELECT Name, Platform, yourReview, yourScore FROM YourReviews WHERE Name = \"" + Name + "\" AND Platform = \"" + Platform + "\"";
                        cmd.Connection = conn;
                        conn.Open();

                        // Read the selected info from the db and store it
                        SQLiteDataReader r = cmd.ExecuteReader();
                        r.Read();
                        currentReview[2] = r.GetValue(2).ToString();    // review text
                        yourScore = r.GetInt32(3);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void insertDataIntoTable(string table, string column, string inputData)  // Inserts data into specified table
                                                                                         // Format for column:    "(column1, column2, etc.)"
                                                                                         // Format for inputData: "(value1, value2, etc.);"
                                                                                         // Example code: insertDataIntoTable("YourReviews", "(Name, Platform, YourScore)", "('Wii Sports', 'WII', 9)");
                                                                                         // Creates a review for Wii Sports on the Wii with a score of 9
        {
            Console.WriteLine(table);
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO " + table + " (" + column + ") VALUES (" + inputData + ")";
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
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void deleteDataFromTable(string table, string statement)
        {
            Console.WriteLine(table);
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = "DELETE FROM " + table + " WHERE " + statement;
                        cmd.Connection = conn;

                        conn.Open();

                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("DELETED FROM " + table + " WHERE " + statement);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void getYourReviews()
        {
            PopulateAnyTable("SELECT Name, Platform, yourScore FROM YourReviews", viewUserReviews_dataGridView);
        }

        private void view_Click_1(object sender, EventArgs e)                   // main panel -> "view your reviews" button
        {
            viewUserReviewsPanel.Visible = true;
            mainPagePanel.Visible = false;

            getYourReviews();
        }

        private void viewUserReviews_Back_Click(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            viewUserReviewsPanel.Visible = false;
        }

        private void viewUserReviews_NEW_REVIEW_Click(object sender, EventArgs e)
        {
            createReviewMode = 0;

            viewUserReviewsPanel.Visible = false;
            createUserReviewsPanel.Visible = true;

            // allow user to edit the name and platform
            createReviewGameTitle_Label.Visible = true;
            createReviewGameTitle_textBox.Visible = true;
            createReviewPlatform_Label.Visible = true;
            createReviewPlatform_textBox.Visible = true;

            createReviewGameTitle_textBox.Clear();
            createReviewPlatform_textBox.Clear();
            createUserReview_TextReview.Clear();

            // Set score dropdown value to be blank
            yourScore = 0;
            createUserReview_score_dropdown.SelectedIndex = 0;
        }

        private void viewUserReviews_EDIT_REVIEW_Click(object sender, EventArgs e)
        {
            createReviewMode = 1;

            if (currentReview[0] != "" && currentReview[1] != "")
            {
                viewUserReviewsPanel.Visible = false;
                createUserReviewsPanel.Visible = true;

                // Call createUserReviewsPanel with the info from the selected review
                createReviewGameTitle.Text = currentReview[0];
                createReviewPlatform.Text = currentReview[1];
                createUserReview_TextReview.Text = currentReview[2];
                createReviewGameTitle.Refresh();

                // Set score dropdown value to the score saved on the database
                int scoreIndex = 11 - yourScore;
                if (0 > scoreIndex || scoreIndex > 10)
                {
                    createUserReview_score_dropdown.SelectedIndex = 0;
                }
                else
                {
                    createUserReview_score_dropdown.SelectedIndex = scoreIndex;
                }

            }
        }

        private void createUserReviewsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createUserReviews_Back(object sender, EventArgs e)         // Back button for createUserReviews panel
        {
            getYourReviews();

            viewUserReviewsPanel.Visible = true;
            createUserReviewsPanel.Visible = false;

            createReviewGameTitle_Label.Visible = false;
            createReviewGameTitle_textBox.Visible = false;
            createReviewPlatform_Label.Visible = false;
            createReviewPlatform_textBox.Visible = false;
        }

        private void createUserReviews_Save_Click(object sender, EventArgs e)   // Save button
        {
            if (createReviewMode == 0)
            {
                string newName = createReviewGameTitle_textBox.Text.ToString();
                string newPlatform = createReviewPlatform_textBox.Text.ToString();


                if (newName != "" && newPlatform != "")
                {
                    // first delete the old review (if it exists), then insert the new one
                    string arguments = "Name = \"" + newName + "\" AND Platform = \"" + newPlatform + "\"";
                    deleteDataFromTable("YourReviews", arguments);
                    string textReview = createUserReview_TextReview.Text;
                    insertDataIntoTable("YourReviews", "Name, Platform, yourReview, yourScore", "\"" + newName + "\", \"" + newPlatform + "\", \"" + textReview + "\", " + yourScore);
                }
                else
                {
                    MessageBox.Show("Please enter a name and platform for the game being reviewed.");
                }
            }
            else
            {
                if (currentReview[0] != "" && currentReview[1] != "")
                {
                    // first delete the old review, then insert the new one
                    string arguments = "Name = \"" + currentReview[0] + "\" AND Platform = \"" + currentReview[1] + "\"";
                    deleteDataFromTable("YourReviews", arguments);
                    string textReview = createUserReview_TextReview.Text;
                    insertDataIntoTable("YourReviews", "Name, Platform, yourReview, yourScore", "\"" + currentReview[0] + "\", \"" + currentReview[1] + "\", \"" + textReview + "\", " + yourScore);
                }
            }
        }

        private void createUserReview_Delete_Click(object sender, EventArgs e)  // Delete button
        {
            // Could improve this by making a function specificially for YourReviews
            if (currentReview[0] != "" && currentReview[1] != "")
            {
                deleteDataFromTable("YourReviews", "Name = \"" + currentReview[0] + "\" AND Platform = \"" + currentReview[1] + "\"");
            }
            viewUserReviewsPanel.Visible = true;
            createUserReviewsPanel.Visible = false;
            getYourReviews();
        }

        private void createUserReview_score_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            yourScore = 11 - createUserReview_score_dropdown.SelectedIndex;     // gets the number that the user selected from the dropdown list
            if (yourScore == 11)
                yourScore = 0;
        }

        private void viewUserReviews_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentReview[0] = viewUserReviews_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); // name
            currentReview[1] = viewUserReviews_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(); // platform
            currentReview[2] = viewUserReviews_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(); // review text

            setReviewValues(currentReview[0], currentReview[1]);
        }

        private void add_Click(object sender, EventArgs e)  // main panel -> add new game button
        {
            addNewGamePanel.Visible = true;
            mainPagePanel.Visible = false;
        }

        private void addNewGame_Back_Click(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            addNewGamePanel.Visible = false;
            
            // Clear all textboxes in the add new game panel
            TextBox[] textBoxes = { title_textBox, Platform_textBox, Rank_textBox, genre_textBox, ESRB_textBox, publisherTextBox, developer_textBox, playerCount_textBox, ReleaseDate_textBox, year_textBox };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
            favorite_checkBox.Checked = false;  // Clear favorite checkbox in the add new game panel

            if (createGameMode == 1)
            {
                mainPagePanel.Visible = false;
                resultsPage.Visible = true;

                SearchHelper(searchResultBox.Text);
            }
        }

        private void insertNewGameIntoDB(string sqlite_stmt)
        {
            title_textBox.ReadOnly = false;
            Platform_textBox.ReadOnly = false;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {

                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = sqlite_stmt;
                        cmd.Connection = conn;

                        conn.Open();

                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Succesfully added game to database.");
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private bool checkIfGameExists(string name, string platform)
        {
            bool gameExists = true;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {

                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = "SELECT " + name + " FROM Game WHERE Name = \"" + name + "\" AND Platform = \"" + platform + "\"";
                        cmd.Connection = conn;

                        conn.Open();
                        
                    }
                    catch (Exception e)
                    {
                        gameExists = false;
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
            return gameExists;
        }

        private void addNewGame_Save_Click(object sender, EventArgs e)  // Insert a game into the database
        {
            // get info from every text box that will be a TEXT data type in the db
            string[] gameInfo = new string[8];
            gameInfo[0] = title_textBox.Text;
            gameInfo[1] = Platform_textBox.Text;
            gameInfo[2] = genre_textBox.Text;
            gameInfo[3] = ESRB_textBox.Text;
            gameInfo[4] = publisherTextBox.Text;
            gameInfo[5] = developer_textBox.Text;
            gameInfo[6] = playerCount_textBox.Text;
            gameInfo[7] = ReleaseDate_textBox.Text;

            StringBuilder sb = new StringBuilder();
            foreach (string s in gameInfo)
            {
                if (s != null)
                {
                    sb.Append("\"" + s + "\", ");    // appends ['(string)', ]
                }
                else
                {
                    sb.Append("\"NULL\", ");
                }
            }

            // get rank
            string gameRank = Rank_textBox.Text;
            if (gameRank == "")
            {
                gameRank = "NULL";
            }

            // get year
            string gameYear = year_textBox.Text;
            if (gameYear == "")
            {
                gameYear = "NULL";
            }
            

            //get favorite check box state
            string favorite = "NULL";
            if (favorite_checkBox.Checked == true)
            {
                favorite = "1";
            }

            if (title_textBox.Text != "" && Platform_textBox.Text != "")
            {
                // make sure that the game doesn't already exist
                bool gameExists = checkIfGameExists(gameInfo[0], gameInfo[1]);

                if (gameExists)
                {
                    if (createGameMode == 0)
                    {
                        // Warn user that this will delete the existing review
                        DialogResult dialogResult = MessageBox.Show("A game with the title \"" + gameInfo[0] + "\" and for the " + gameInfo[1] + " already exists in this database. " +
                            "Would you like to overwrite the existing entry with the input information?\n\n" +
                            "WARNING: This action will permanetly delete the existing entry and will replace it replace it with your new entry.", "", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            // Delete old entry and insert the new one
                            deleteDataFromTable("Game", "Name = \"" + gameInfo[0] + "\" AND Platform = \"" + gameInfo[1] + "\"");

                            string sqlite_stmt = "INSERT INTO Game (Name, Platform, Genre, ESRB_Rating, Publisher, Developer, PlayerCount, ReleaseDate, Rank, Year, Favorited) VALUES (" + sb + gameRank + ", " + gameYear + ", " + favorite + ")";
                            MessageBox.Show("Attemping to add \"" + gameInfo[0] + "\" for the " + gameInfo[1] + " into the database.");
                            insertNewGameIntoDB(sqlite_stmt);
                        }
                
                    }
                    else if (createGameMode == 1)
                    {
                        // Ask the user if they are sure that they want to update the review
                        DialogResult dialogResult = MessageBox.Show("Are you sure that you want to update the data of the game " + gameInfo[0] + " for " + gameInfo[1] + "?", "", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            // Delete old entry and insert the new one
                            deleteDataFromTable("Game", "Name = \"" + gameInfo[0] + "\" AND Platform = \"" + gameInfo[1] + "\"");

                            string sqlite_stmt = "INSERT INTO Game (Name, Platform, Genre, ESRB_Rating, Publisher, Developer, PlayerCount, ReleaseDate, Rank, Year, Favorited) VALUES (" + sb + gameRank + ", " + gameYear + ", " + favorite + ")";
                            MessageBox.Show("Attemping to add \"" + gameInfo[0] + "\" for the " + gameInfo[1] + " into the database.");
                            insertNewGameIntoDB(sqlite_stmt);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The game must have both a name and platform to be saved.");
            }
        }

        private void addNewGame_delete_Click(object sender, EventArgs e)
        {

            if (createGameMode == 1)
            {
                StringBuilder sb = new StringBuilder();

                string name = title_textBox.Text.ToString();
                string platform = Platform_textBox.Text.ToString();

                deleteDataFromTable("Game", "Name = \"" + name + "\" AND Platform = \"" + platform + "\"");
            }

            // Clear all textboxes in the add new game panel
            TextBox[] textBoxes = { title_textBox, Platform_textBox, Rank_textBox, genre_textBox, ESRB_textBox, publisherTextBox, developer_textBox, playerCount_textBox, ReleaseDate_textBox, year_textBox };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
            favorite_checkBox.Checked = false;  // Clear favorite checkbox in the add new game panel
        }

        private void year_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Rank_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void editGameData_Click(object sender, EventArgs e)
        {
            createGameMode = 1;

            resultsPage.Visible = false;
            addNewGamePanel.Visible = true;

            if (selectedGame[0] == null && selectedGame[1] == null)
            {
                selectedGame[0] = resultsGrid.Rows[0].Cells[0].Value.ToString();
                selectedGame[1] = resultsGrid.Rows[0].Cells[1].Value.ToString();
                retrieveGameInfo(selectedGame[0], selectedGame[1]);
            }
            else
            {
                retrieveGameInfo(selectedGame[0], selectedGame[1]);
            }
        }

        private void resultsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedGame[0] = resultsGrid.Rows[e.RowIndex].Cells[0].Value.ToString(); // name
                selectedGame[1] = resultsGrid.Rows[e.RowIndex].Cells[1].Value.ToString(); // name
            }
            catch
            {

            }
        }

        private void retrieveGameInfo(string Name, string Platform)
        {
            TextBox[] textBoxes = { title_textBox, Platform_textBox, genre_textBox, ESRB_textBox, publisherTextBox, developer_textBox, playerCount_textBox, ReleaseDate_textBox, };
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        cmd.CommandText = "SELECT Name, Platform, Genre, ESRB_Rating, Publisher, Developer, PlayerCount, ReleaseDate, Rank, Year FROM Game WHERE Name = \"" + Name + "\" AND Platform = \"" + Platform + "\"";
                        cmd.Connection = conn;
                        conn.Open();

                        // Read the selected info from the db
                        SQLiteDataReader r = cmd.ExecuteReader();
                        r.Read();

                        // set strings
                        for (int i = 0; i < textBoxes.Length - 1; i++)
                        {
                            textBoxes[i].Text = r.GetValue(i).ToString();
                        }
                        
                        // set ints 
                        Rank_textBox.Text = r.GetValue(8).ToString();
                        year_textBox.Text = r.GetValue(9).ToString();
                    }
                    catch
                    {
                        
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void viewUserReviews_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createUserReview_TextReview_Enter(object sender, EventArgs e)
        {
            if(createUserReview_TextReview.Text == "Write Review Here...")
            {
                createUserReview_TextReview.Text = "";
                createUserReview_TextReview.ForeColor = Color.Black;
            }
        }

        private void createUserReview_TextReview_Leave(object sender, EventArgs e)
        {
            if (createUserReview_TextReview.Text == "")
            {
                createUserReview_TextReview.Text = "Write Review Here...";
                createUserReview_TextReview.ForeColor = Color.Silver;
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            if(searchBox.Text == "Search...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search...";
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void Metascore_MouseUp(object sender, MouseEventArgs e)
        {
            if (Metascore.Value == 0)
                minMetascoreString = "";
            else
                minMetascoreString = "m.metascore > " + Metascore.Value.ToString() + " AND ";
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }

        private void VGChartzScore_MouseUp(object sender, MouseEventArgs e)
        {
            if (VGChartzScore.Value == 0)
                minVGChartzScoreString = "";
            else
                minVGChartzScoreString = "v.VGChartzscore > " + VGChartzScore.Value.ToString() + " AND ";
            string searchString = searchResultBox.Text;
            SearchHelper(searchString);
        }
    }
}
