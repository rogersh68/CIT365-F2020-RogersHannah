using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Rogers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            //show the Add Quote Form, hide Main Menu Form
            AddQuote addNewQuote = new AddQuote();
            addNewQuote.Tag = this;
            addNewQuote.Show(this);
            Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            //show the View All Quotes Form, hid Main Menu Form
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the Main Menu Form
            Close();
        }
    }
}
