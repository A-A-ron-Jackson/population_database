using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDataSet.City);

        }

        private void sortByPopulationAsce_btn_Click(object sender, EventArgs e)
        {

            //Sort the table by population in ascending order.
            /*
                This code uses the SortPopulationAscending method in the cityTableAdapter to sort
                the table by population, then load the data into the table
            */
            this.cityTableAdapter.SortPopulationAscending(this.populationDataSet.City);
        }

        private void sortByPopulationDesc_btn_Click(object sender, EventArgs e)
        {
            //Sort the table by population in decsending order.
            /*
                This code uses the SortPopulationDescending method in the cityTableAdapter to sort
                the table by population, then load the data into the table
            */
            this.cityTableAdapter.SortPopulationDescending(this.populationDataSet.City);
        }

        private void sortByCityName_btn_Click(object sender, EventArgs e)
        {
            //Sort the table by name of cities.
            /*
                This code uses the SortByCityName method in the cityTableAdapter to sort
                the table by city name, then load the data into the table
            */
            this.cityTableAdapter.SortByCityName(this.populationDataSet.City);
        }

        private void totalPopulation_btn_Click(object sender, EventArgs e)
        {
            //show a message box that tells the total population of all the cities combined
            /* 
                This code uses the TotalPopulation method in the cityTableAdapter to add up the 
                sum of all the cities population and store it in the total string variable
            */
            double total = (double)this.cityTableAdapter.TotalPopulation();
            var formattedTotal = $"{total:n0}"; //adding some formating 
            MessageBox.Show("The total population of all cities is: " + formattedTotal.ToString());
        }

        private void avgPopulation_btn_Click(object sender, EventArgs e)
        {
            //show a message box that tells the average population of all the cities combined
            /* 
                This code uses the AveragePopulation method in the cityTableAdapter find
                the average of all the cities population and store it in the average string variable
            */
            double average = (double)this.cityTableAdapter.AveragePopulation();
            var formattedAverage = $"{average:n0}"; //adding some formating
            MessageBox.Show("The average population of all cities is: " + formattedAverage.ToString());
        }

        private void highestPopulation_btn_Click(object sender, EventArgs e)
        {
            //show a message box that tells the name of the city with the highest population
            /* 
                This code uses the HighestPopulation method in the cityTableAdapter find
                the highest population of all the cities and store it in the highestPopulation string variable
            */
            double highestPopulation = (double)this.cityTableAdapter.HighestPopulation();
            var formattedHighestPopulation = $"{highestPopulation:n0}"; //adding some formating
            MessageBox.Show("The highest population is: " + formattedHighestPopulation.ToString());
        }

        private void lowestPopulation_btn_Click(object sender, EventArgs e)
        {
            //show a message box that tells the name of the city with the lowest population
            /* 
                This code uses the LowestPopulation method in the cityTableAdapter find
                the lowest population of all the cities and store it in the lowestPopulation string variable
            */
            double lowestPopulation = (double)this.cityTableAdapter.LowestPopulation();
            var formattedLowestPopulation = $"{lowestPopulation:n0}"; //adding some formating
            MessageBox.Show("The lowest population is: " + formattedLowestPopulation.ToString());
        }
    }
}
