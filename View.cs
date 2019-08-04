using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GitHubLanguageStatistics
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();

            linesOfCodeDataGridView.AutoGenerateColumns = false;
            projectsDataGridView.AutoGenerateColumns = false;

            linesOfCodeDataGridView.DataSource = DataSourceByLinesOfCode = new SortableBindingList<Language>();
            projectsDataGridView.DataSource = DataSourceByProject = new SortableBindingList<Language>();

            DataSourceByLinesOfCode.ListChanged += DataSourceByLinesOfCode_ListChanged;
            DataSourceByProject.ListChanged += DataSourceByProject_ListChanged;
        }

        private void DataSourceByLinesOfCode_ListChanged(object sender, ListChangedEventArgs e)
        {
            linesOfCodePanel.Invalidate();
        }

        private void DataSourceByProject_ListChanged(object sender, ListChangedEventArgs e)
        {
            projectsPanel.Invalidate();
        }

        public SortableBindingList<Language> DataSourceByLinesOfCode { get; }
        public SortableBindingList<Language> DataSourceByProject { get; }

        public Presenter Presenter { private get; set; }

        public string Title { set => titleLabel.Text = value; }

        public Color TitleColor { set => titleLabel.ForeColor = value; }

        public string UserName => userNameTextBox.Text;

        public void SortGrids()
        {
            linesOfCodeDataGridView.Sort(linesOfCodeDataGridView.Columns[1], ListSortDirection.Descending);
            projectsDataGridView.Sort(projectsDataGridView.Columns[1], ListSortDirection.Descending);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Presenter.Refresh();
        }

        private void ProjectsPanel_Paint(object sender, PaintEventArgs e)
        {
            IEnumerable<Language> values = DataSourceByProject.OrderByDescending(x => x.Count);
            Size size = (sender as Panel).Size;
            DrawPieChart(e.Graphics, size, values);
        }

        private void LinesOfCodePanel_Paint(object sender, PaintEventArgs e)
        {
            IEnumerable<Language> values = DataSourceByLinesOfCode.OrderByDescending(x => x.Count);
            Size size = (sender as Panel).Size;
            DrawPieChart(e.Graphics, size, values);
        }

        private void DrawPieChart(Graphics graphics, Size size, IEnumerable<Language> values)
        {
            float[] percentages = values.Select(x => x.Count).Select(x => x * 360f / values.Sum(y => y.Count)).ToArray();
            float[] cumulativePercentages = percentages.Select((s, i) => percentages.Take(i).Sum()).ToArray();
            Color[] colors = values.Select(x => x.Color).ToArray();

            for (int i = 0; i < values.Count(); i++)
            {
                using (SolidBrush brush = new SolidBrush(colors[i]))
                {
                    graphics.FillPie(brush, new Rectangle(new Point(0, 0), size), cumulativePercentages[i], percentages[i]);
                }
            }
        }
    }
}
