using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume_Generator
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        // DATA

        class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
            public string Objectives { get; set; }
            public string Company1{ get; set; }
            public string Company2 { get; set; }
            public string Company3 { get; set; }
            public string Position1 { get; set; }
            public string Position2 { get; set; }
            public string Position3 { get; set; }
            public string StartDate1 { get; set; }
            public string StartDate2 { get; set; }
            public string StartDate3 { get; set; }
            public string EndDate1 { get; set; }
            public string ENdDate2 { get; set; }
            public string EndDate3 { get; set; }
            public string WorkAccomplishment1 { get; set; }
            public string WorkAccomplishment2 { get; set; }
            public string WorkAccomplishment3 { get; set; }
            public string HardSkills { get; set; }
            public string SoftSkills { get; set; }
            public string School { get; set; }
            public string YearGraduated { get; set; }
            public string SchoolAccomplishment1 { get; set; }
            public string SchoolAccomplishment2 { get; set; }
            public string SchoolAccomplishment3 { get; set; }
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
