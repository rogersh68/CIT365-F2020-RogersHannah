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
    public partial class AddQuote : Form
    {
        //variables
        private string customerName;
        private int deskWidth;
        private int deskDepth;
        private int drawerNumber;
        private DesktopMaterials material;
        private int rushDays;
        DeskQuote quote;
        
        
        //methods
        public AddQuote()
        {
            InitializeComponent();
           

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void inputDeskWidth_Validating(object sender, CancelEventArgs e)
        {
            int width;

            // check if input is an integer
            bool isInt = int.TryParse(inputDeskWidth.Text, out width);
            if (!isInt)
            {
                messageDeskWidth.Text = "Please enter a number";
            }
            else
            {
                if (width < Desk.MINWIDTH || width > Desk.MAXWIDTH) //check that input is in valid range
                {
                    inputDeskWidth.Text = String.Empty; //empty input box
                    messageDeskWidth.Text = "Invalid desk width"; 
                }
                else
                {
                    messageDeskWidth.Text = String.Empty; //empty message
                    deskWidth = width;//set desk width
                }
            }
            
        }

        private void inputDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                messageDeskDepth.Text = "Please enter a number";
            }
            else
            {
                messageDeskDepth.Text = String.Empty;
            }
            

        }

        private void inputDeskDepth_Validating(object sender, CancelEventArgs e)
        {
            int depth;
            bool isInt = int.TryParse(inputDeskDepth.Text, out depth);
            if (!isInt)
            {
                messageDeskDepth.Text = "Please enter a number";
            }
            else
            {
                if (depth < Desk.MINDEPTH || depth > Desk.MAXDEPTH) //check that input is in valid range
                {
                    inputDeskDepth.Text = String.Empty; //empty input box
                    messageDeskDepth.Text = "Invalid desk depth";
                }
                else
                {
                    messageDeskDepth.Text = String.Empty; //empty message
                }
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Navigate back to the main menu, close Add Quote Form
            MainMenu viewMenu = (MainMenu)Tag;
            viewMenu.Show();
            Close();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            //check all fields are filled out (use try catch?)
            if (checkForm())
            {
                //create desk and desk quote objects
                Desk desk = new Desk(deskWidth, deskDepth, drawerNumber, material);
                quote = new DeskQuote(desk, customerName, rushDays);

                //send to and open Display Quote Form, close Add Quote Form
                DisplayQuote displayQuote = new DisplayQuote(quote);
                displayQuote.Tag = this;
                displayQuote.Show(this);
                Hide();
            } 
        }
       

        private bool checkForm()
        {
            try
            {
                // verify all fields are filled out
                if (String.IsNullOrEmpty(inputCustomerName.Text) 
                    || String.IsNullOrEmpty(inputDeskWidth.Text) 
                    || String.IsNullOrEmpty(inputDeskDepth.Text) 
                    || String.IsNullOrEmpty(inputDrawerNumber.Text))
                {
                    throw(new Exception());
                }
                else
                {
                    // set variables and return true
                    customerName = inputCustomerName.Text;
                    deskWidth = int.Parse(inputDeskWidth.Text);
                    deskDepth = int.Parse(inputDeskDepth.Text);
                    drawerNumber = int.Parse(inputDrawerNumber.Text);

                    // convert to DesktopMaterial
                    switch(inputMaterialType.Text)
                    {
                        case "laminate":
                            material = DesktopMaterials.laminate;
                            break;
                        case "oak":
                            material = DesktopMaterials.oak;
                            break;
                        case "rosewood":
                            material = DesktopMaterials.rosewood;
                            break;
                        case "veneer":
                            material = DesktopMaterials.veneer;
                            break;
                        case "pine":
                            material = DesktopMaterials.pine;
                            break;
                    }

                    // convert to int
                    switch(inputRushOrder.Text)
                    {
                        case "Regular":
                            rushDays = 14;
                            break;
                        case "7 Day":
                            rushDays = 7;
                            break;
                        case "5 Day":
                            rushDays = 5;
                            break;
                        case "3 Day":
                            rushDays = 3;
                            break;
                    }

                    return true;
                }
                    
                
            }
            catch (Exception)
            {
                // send user message about incomplete form, return false
                MessageBox.Show("INCOMPLETE: Please fill out all fields before submitting.");
                return false;
            }
        }

        
    }
}
