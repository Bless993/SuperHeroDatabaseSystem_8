using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperHeroDatabaseSystem_8.BusinessLogicLayer;

namespace SuperHeroDatabaseSystem_8.PresentationLayer
{
    
    public partial class MainForm : Form
    {
        SuperheroManager manager = new SuperheroManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtHeroID.Text.Trim();
                string name = txtName.Text.Trim();
                int age = int.Parse(txtAge.Text.Trim());
                string power = txtSuperpower.Text.Trim();
                int score = int.Parse(txtExamScore.Text.Trim());

                Superhero hero = new Superhero(id, name, age, power, score);
                manager.AddHero(hero);

                MessageBox.Show("Superhero added successfully! All superheroes are located in the bin directory as superheroes.txt.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadHeroes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadHeroes();
        }
        private void LoadHeroes()
        {
            dgvHeroes.DataSource = null;
            dgvHeroes.DataSource = manager.GetAllHeroes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHeroID.Text))
                {
                    MessageBox.Show("Please select or enter a Hero ID to update.");
                    return;
                }

                string id = txtHeroID.Text.Trim();
                string name = txtName.Text.Trim();
                int age = int.Parse(txtAge.Text.Trim());
                string power = txtSuperpower.Text.Trim();
                int score = int.Parse(txtExamScore.Text.Trim());

                Superhero hero = new Superhero(id, name, age, power, score);
                manager.UpdateHero(hero);

                MessageBox.Show("Superhero updated successfully! All superheroes are located in the bin directory as superheroes.txt.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHeroes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHeroes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a hero from the list to delete.");
                    return;
                }

                string heroId = dgvHeroes.SelectedRows[0].Cells["HeroID"].Value.ToString();

                var confirm = MessageBox.Show("Are you sure you want to delete this superhero?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    manager.DeleteHero(heroId);
                    MessageBox.Show("Superhero deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHeroes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                var summary = manager.GenerateSummary();

                txtTotalHeroes.Text = summary.TotalHeroes.ToString();
                txtAverageAge.Text = summary.AverageAge.ToString("0.00");
                txtAverageScore.Text = summary.AverageExamScore.ToString("0.00");
                txtHeroesPerRank.Text = $"S:{summary.CountS}  A:{summary.CountA}  B:{summary.CountB}  C:{summary.CountC}";

                // Save summary to file
                manager.SaveSummaryToFile(summary);

                MessageBox.Show("Summary generated and saved to summary.txt!", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating summary: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtHeroID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSuperpower.Clear();
            txtExamScore.Clear();
        }

    }
}
