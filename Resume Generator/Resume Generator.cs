using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using SautinSoft.Document;

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
        Data info;
        public void saveFunc()
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
            info = JsonConvert.DeserializeObject<Data>(jobSeekerData);
        }

        private void writerFunc()
        {
            // PATH

            string docPath = @"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Resume Generator\resume.pdf";

            //DOCUMENT TOOLS

            DocumentCore dc = new DocumentCore();
            DocumentBuilder db = new DocumentBuilder(dc);

            // SIZE

            Section section = db.Document.Sections[0];
            section.PageSetup.PaperType = PaperType.A4;

            // NAME

            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 25;
            db.CharacterFormat.Bold = true;
            db.Write(info.Name.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // CONTACT

            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 12;
            db.CharacterFormat.Bold = false;
            db.Write(info.Email.ToString() + " | " + info.Contact.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // OBJECTIVES

            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 18;
            db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
            db.CharacterFormat.Bold = true;
            db.Write("Objectives");

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = false;
            db.Write(info.Objectives.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // WORK EXPERIENCE

            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 18;
            db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
            db.CharacterFormat.Bold = true;
            db.Write("Work Experience");

            // WORK EXPERIENCE 1
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Company1.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Position1.ToString() + " | " + info.StartDate1.ToString() + " - " + info.EndDate1.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = false;
            db.Write(info.WorkAccomplishment1.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // WORK EXPERIENCE 2

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Company2.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Position2.ToString() + " | " + info.StartDate2.ToString() + " - " + info.EndDate2.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = false;
            db.Write(info.WorkAccomplishment2.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // WORK EXPERIENCE 3
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Company3.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.Position3.ToString() + " | " + info.StartDate3.ToString() + " - " + info.EndDate3.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = false;
            db.Write(info.WorkAccomplishment3.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            // SKILLS
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 18;
            db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
            db.CharacterFormat.Bold = true;
            db.Write("Skills");

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write("Hard Skills");
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.CharacterFormat.Bold = false;
            db.Write(info.HardSkills.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write("Soft Skills");
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.CharacterFormat.Bold = false;
            db.Write(info.SoftSkills.ToString());

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);


            // EDUCATION
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 18;
            db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
            db.CharacterFormat.Bold = true;
            db.Write("Education");
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.FontName = "Times New Roman";
            db.CharacterFormat.Size = 10;
            db.CharacterFormat.Bold = true;
            db.Write(info.School.ToString() + " | " + "Graduated " + info.YearGraduated.ToString());
            db.CharacterFormat.Bold = false;
            db.Write(info.WorkAccomplishment3.ToString());

            // SAVE
            dc.Save(docPath, new PdfSaveOptions());
        }

        // BUTTON
        private void generateBTN_Click(object sender, EventArgs e)
        {
            saveFunc();
            writerFunc();
        }
    }
}
