using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Rogers
{
    public class Desk
    {
        // Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        // member variables
        private int deskWidth;
        private int deskDepth;
        private int drawerNumber;
        private DesktopMaterials material;

        // constructor
        public Desk(int deskWidth, int deskDepth, int drawerNumber, DesktopMaterials material)
        {
            this.deskWidth = deskWidth;
            this.deskDepth = deskDepth;
            this.drawerNumber = drawerNumber;
            this.material = material;
        }

        // member get methods
        public int getDeskWidth()
        {
            return deskWidth;
        }

        public int getDeskDepth()
        {
            return deskDepth;
        }

        public int getDrawerNumber()
        {
            return drawerNumber;
        }

        public DesktopMaterials getMaterial()
        {
            return material;
        }

        // other member methods
        public int calcDeskArea()
        {
            return deskWidth * deskDepth;
        }
    }
    public enum DesktopMaterials
    {
        laminate, oak, rosewood, veneer, pine
    }
}
