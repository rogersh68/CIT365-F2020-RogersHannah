using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Rogers
{
    public class DeskQuote
    {
        //member variables
        private Desk desk;
        private string customerName;
        private int rushDays;
        private DateTime quoteDate;
        private int quoteAmount;

        //constructor
        public DeskQuote(Desk desk, string customerName, int rushDays)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.rushDays = rushDays;
            quoteDate = DateTime.UtcNow.Date;
        }

        // get methods
        public Desk getDesk()
        {
            return desk;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public int getRushDays()
        {
            return rushDays;
        }

        public DateTime getQuoteDate()
        {
            return quoteDate;
        }

        public int getQuoteAmount()
        {
            calcQuoteAmount();
            return quoteAmount;
        }

        // other member methods
        public void calcQuoteAmount()
        {
            int area = desk.calcDeskArea();
            int drawerAmount = desk.getDrawerNumber() * 50;
            int materialAmount;

            // determine material type and set materialAmount
            switch(desk.getMaterial())
            {
                case DesktopMaterials.oak:
                    materialAmount = 200;
                    break;
                case DesktopMaterials.laminate:
                    materialAmount = 100;
                    break;
                case DesktopMaterials.pine:
                    materialAmount = 50;
                    break;
                case DesktopMaterials.rosewood:
                    materialAmount = 300;
                    break;
                case DesktopMaterials.veneer:
                    materialAmount = 125;
                    break;
                default:
                    materialAmount = 0;
                    break;
            }

            // determine the rush day amount
            int rushAmount = calcRushPrice(area);

            // add amounts to total quote amount
            quoteAmount = 200 + area + drawerAmount + materialAmount + rushAmount;
        }

        public int calcRushPrice(int area)
        {
            switch (rushDays)
            {
                case 3:
                    if(area < 1000)
                    {
                        return 60;
                    }
                    else if(area < 2000)
                    {
                        return 80;
                    }
                    else
                    {
                        return 70;
                    }
                case 5:
                    if (area < 1000)
                    {
                        return 40;
                    }
                    else if (area > 2000)
                    {
                        return 60;
                    }
                    else
                    {
                        return 50;
                    }
                case 7:
                    if (area < 1000)
                    {
                        return 30;
                    }
                    else if (area > 2000)
                    {
                        return 40;
                    }
                    else
                    {
                        return 35;
                    }
                default:
                    return 0;
            }
        }
    }

    
}
