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
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using DietAdvisor_1._0.Models;
namespace DietAdvisor_1._0
{
public partial class Form1 : Form
    {
        private static string dictionary_path = "C:\\Users\\dawid\\Desktop\\STUDIA MAGISTERSKIE\\III semestr\\Reprezentacja wiedzy i wnioskowanie\\Projekt";
        private static string filename = "foodDiet.csv";
        private static string csv_file_path = dictionary_path + "\\" + filename;


        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Cases> casesFromCSV = new List<Cases>();

               
                var reader = new StreamReader(csv_file_path);
                var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
                var casesList = csv.GetRecords<Cases>();

                foreach (var c in casesList)
                {
                    Cases caseFromCSV = new Cases();
                    caseFromCSV.Person = c.Person;
                    caseFromCSV.Gender = c.Gender;
                    caseFromCSV.Age = c.Age;
                    caseFromCSV.Height = c.Height;
                    caseFromCSV.Weight = c.Weight;
                    caseFromCSV.Diet = c.Diet;
                    caseFromCSV.weight6weeks = c.weight6weeks;

                casesFromCSV.Add(caseFromCSV);
                }
          



        }
    }
    
}
        
    
            
    

       

