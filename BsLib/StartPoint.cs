using System;
using System.Text.RegularExpressions;

namespace BsLib
{
    public class StartPoint : Macro
    {
        private string name = "START_POINT";
        private int id;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public double X { get; set; }
        public double Y { get; set; }
        private double Z { get; set; }

        public StartPoint()
        {
            this.id = this.GetHashCode();
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public StartPoint(double x, double y)
        {
            this.id = this.GetHashCode();
            this.X = x;
            this.Y = y;
            this.Z = 0;
        }

        public StartPoint(int id, double x, double y)
        {
            this.id = id;
            this.X = x;
            this.Y = y;
            this.Z = 0;
        }

        public StartPoint(StartPoint other)
        {
            this.id = other.Id;
            this.X = other.X;
            this.Y = other.Y;
            this.Z = 0;
        }

        public StartPoint(string bppCode){
            string trim = Regex.Replace(bppCode, @"\s+", "");
            string bppPattern = "@" + this.Name +",*?";
            Match match = Regex.Match(trim, bppPattern);

            if (match.Success)
            {
                string [] parts = trim.Split(':');
                if ((parts.Length > 2) || (parts.Length < 1)){
                    string message = String.Format("{0} - is not valid code for bpp {1} macro", bppCode, this.name);
                    throw new ArgumentException(message);
                }
                string [] idparts = parts[0].Split(',');
                if (Regex.Match(idparts[3],@"\d+").Success){
                    this.id = Int32.Parse(idparts[3]);
                } else {
                    string message = String.Format("{0} - id absent in bpp {1} macro", bppCode, this.name);
                    throw new ArgumentException(message);
                }

                string[] dataValues = parts[1].Split(',');
                int numberValues = 3;
                if (dataValues.Length != numberValues){
                    string message = String.Format("{0} - data corruption in bpp {1} macro", bppCode, this.name);
                    throw new ArgumentException(message);
                }

                foreach (var item in dataValues)
                {
                    if (item==""){
                    string message = String.Format("{0} - data corruption in bpp {1} macro", bppCode, this.name);
                    throw new ArgumentException(message);
                    }
                }

                this.X = double.Parse(dataValues[0]);
                this.Y = double.Parse(dataValues[1]);
                this.Z = double.Parse(dataValues[2]);

            }
            else
            {
                string message = String.Format("{0} - is not valid code for bpp {1} macro", bppCode, this.name);
                throw new ArgumentException(message);
            }
        }

        public StartPoint Copy()
        {
            return new StartPoint(this.Id, this.X, this.Y);
        }

        public string ToBpp()
        {
            string strId = Convert.ToString(this.Id);
            string strX = Convert.ToString(this.X);
            string strY = Convert.ToString(this.Y);
            string strZ = Convert.ToString(this.Z);
            return string.Format("  @ START_POINT, \"\", \"\", {0}, \"\", 0 : {1}, {2}, {3}\n", strId, strX, strY, strZ);
        }

        public string ToCix()
        {
            string strId = Convert.ToString(this.Id);
            string strX = Convert.ToString(this.X);
            string strY = Convert.ToString(this.Y);
            string strZ = Convert.ToString(this.Z);
            string result = string.Format("BEGIN MACRO\n\tNAME = START_POINT\n\tPARAM,NAME = ID,VALUE = {0}\n", strId);
            result = result + string.Format("\tPARAM,NAME = X,VALUE = {1}\n", strX);
            result = result + string.Format("\tPARAM,NAME = Y,VALUE = {2}\n", strY);
            result = result + string.Format("\tPARAM,NAME = Z,VALUE = {3}\nEND MACRO\n\n", strZ);
            return result;
        }

    }
}
