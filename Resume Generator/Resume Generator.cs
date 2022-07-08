using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace Resume_Generator
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        // DATA VARIABLES

        class Data
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
            public string EndDate2 { get; set; }
            public string EndDate3 { get; set; }
            public string WorkAccomplishment1 { get; set; }
            public string WorkAccomplishment2 { get; set; }
            public string WorkAccomplishment3 { get; set; }
            public string HardSkills { get; set; }
            public string SoftSkills { get; set; }
            public string School { get; set; }
            public string YearGraduated { get; set; }
            public string SchoolAccomplishment { get; set; }
        }

        // JSON MAKER

        public void personList()
        {
            Data jobSeeker = new Data()
            {
                Name = nameData.Text,
                Email = emailData.Text,
                Contact = contactData.Text,
                Objectives = objectivesData.Text,
                Company1 = companyData1.Text,
                Company2 = companyData2.Text,
                Company3 = companyData3.Text,
                Position1 = positionData1.Text,
                Position2 = positionData2.Text,
                Position3 = positionData3.Text,
                StartDate1 = startDateData1.Text,
                StartDate2 = startDateData2.Text,
                StartDate3 = startDateData3.Text,
                EndDate1 = endDateData1.Text,
                EndDate2 = endDateData2.Text,
                EndDate3 = endDateData3.Text,
                WorkAccomplishment1 = workAccomplishmentData1.Text,
                WorkAccomplishment2 = workAccomplishmentData2.Text,
                WorkAccomplishment3 = workAccomplishmentData3.Text,
                HardSkills = hardSkillsData.Text,
                SoftSkills = softSkillsData.Text,
                School = schoolData.Text,
                YearGraduated = graduationData.Text,
                SchoolAccomplishment = schoolAccomplishmentData.Text,
            };

            string jobSeekerData = JsonConvert.SerializeObject(jobSeeker);
            File.WriteAllText(@"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Resume Generator\data.json", jobSeekerData);

            jobSeekerData = String.Empty;
            jobSeekerData = File.ReadAllText(@"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Resume Generator\data.json");
            var info = JsonConvert.DeserializeObject<Data>(jobSeekerData);
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            personList();
        }
    }
}
