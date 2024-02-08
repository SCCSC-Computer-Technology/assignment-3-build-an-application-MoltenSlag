/* Alex Gann
 CPT-206-A01S
 Lab 2 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseQueryLibrary;

namespace AlexGann_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        //Creates objects necessary for queries
        private StateDataClassesDataContext db;
        private DataQuery dataQuery;

        public Form1()
        {
            InitializeComponent();
            db = new StateDataClassesDataContext();
            dataQuery = new DataQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fills the combo box with state names on load
            PopulateChooseStateComboBox(dataQuery);
        }

        private void PopulateChooseStateComboBox(DataQuery dataQuery)
        {
            /* IQueryable is a modification of IEnumerable used in LINQ to SQL.
             The method retrieves an enumerated list of state names from the
             StateName column of the State table.*/
            IQueryable<string> results = dataQuery.GetStateNames();

            // This loop adds each state name into the items of the combo box.
            foreach ( string item in results )
            {
                ChooseStateComboBox.Items.Add( item );
            }
        }

        private void ChooseStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* When the user selects a new state from the combo box, this method sends that
             state name as a parameter to a LINQ query, which finds the matching state name
             in the database and retrieves the row as a State object.*/
            DatabaseQueryLibrary.State results = dataQuery.GetRowByState(ChooseStateComboBox.SelectedItem.ToString());

            /* If you're curious why the above uses a DatabaseQueryLibrary.State instead of just a State, 
             it is because God is dead and I have killed him.
             It's actually because the library has a different State class from the form and Visual Studio
             didn't want to deal with it. The big baby. */

            /* The following lines take the various parts of the State object and apply them
             to the matching TextBoxes in the form, displaying the information on each state.*/
            PopulationTextBox.Text = results.Population.ToString();
            CapitalTextBox.Text = results.Capitol;
            LargestCityTextBox.Text = results.LargestCity;
            SecondLargestTextBox.Text = results.SecondLargestCity;
            ThirdLargestTextBox.Text = results.ThirdLargestCity;
            StateFlagDescriptionTextBox.Text = results.FlagDescription;
            FlowerTextBox.Text = results.StateFlower;
            BirdTextBox.Text = results.StateBird;
            ColorsTextBox.Text = results.StateColors;
            IncomeTextBox.Text = results.MedianIncome?.ToString("C0");
            PercentComputerJobsTextBox.Text = results.PercentJobsComputerRelated.ToString() + "%";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
