using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private CountriesContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CountriesContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Continents.Load();

            this.continentBindingSource.DataSource = dbContext.Continents.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var continent = (Continent)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (continent != null)
                {
                    this.dbContext.Entry(continent).Collection(e => e.Countries).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }
}