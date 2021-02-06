using System;
using System.Text.RegularExpressions;

namespace BsLib
{
    public class EndPath : Macro
    {
        private string name = "ENDPATH";
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

        public EndPath()
        {
            this.id = this.GetHashCode();
        }

        public EndPath(int Id)
        {
            this.id = Id;
        }

        public EndPath(string bppCode)
        {
            string trim = Regex.Replace(bppCode, @"\s+", "");
            string endPathPattern = "@ENDPATH,\\\"\\w*\\\",\\\"\\w*\\\",(?<digit>\\d+),\\\"\\w*\\\",0:";
            Match match = Regex.Match(trim, endPathPattern);

            if (match.Success)
            {
                Group grp = match.Groups["digit"];
                this.id = Int32.Parse(grp.Value);
            }
            else
            {
                throw new ArgumentException(String.Format("{0} - is not valid code for bpp ENDPATH macro", bppCode));
            }
        }

        public EndPath(EndPath other) : this(other.Id) { }

        public EndPath Copy()
        {
            return new EndPath(this.id);
        }



        public string ToBpp()
        {
            return String.Format("  @ ENDPATH, \"\", \"\", {0}, \"\", 0 :\n", this.Id);
        }

        public string ToCix()
        {
            return String.Format("BEGIN MACRO\n\tNAME=ENDPATH\n\tPARAM,NAME=ID,VALUE={0}\nEND MACRO\n\n", this.Id);
        }

    }
}
