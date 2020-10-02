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
    public partial class DisplayQuote : Form
    {
        //variables
        
       
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            Desk desk = quote.getDesk();
            labelCustomerName.Text = quote.getCustomerName();
            labelDeskWidth.Text = desk.getDeskWidth().ToString();
            labelDeskDepth.Text = desk.getDeskDepth().ToString();
            labelDrawerNumber.Text = desk.getDrawerNumber().ToString();
            labelMaterial.Text = desk.getMaterial().ToString();
            labelRushOrder.Text = quote.getRushDays().ToString();
            labelAmount.Text = quote.getQuoteAmount().ToString();
            labelQuoteDate.Text = quote.getQuoteDate().ToString("d MMMM yyyy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Navigate back to the main menu, close Display Quote Form
            MainMenu viewMenu = new MainMenu();
            viewMenu.Tag = this;
            viewMenu.Show(this);
            Hide();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
        }
    }
}
