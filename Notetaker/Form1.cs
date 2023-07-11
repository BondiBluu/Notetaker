using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notetaker
{
    public partial class Form1 : Form
    {
        //backend for the Data Grid View that holds our previous notes
        DataTable notes = new DataTable();


        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //columns that wil show up on the data table
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            //setting the data table to point to the data grid view 
            savedNotesGrid.DataSource = notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                //save the current changes to overwrite the old ones
                notes.Rows[savedNotesGrid.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[savedNotesGrid.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = string.Empty;
            noteBox.Text = string.Empty;
            editing = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //bringing up the nodes we already have stored (setting the title box to the first index of the array)
            titleBox.Text = notes.Rows[savedNotesGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[savedNotesGrid.CurrentCell.RowIndex].ItemArray[1].ToString();

            //most likely going to make changes to the file you just loaded.
            editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //see if the user is clicking on a valid data cell to delete in the first place
            try
            {
               //deleting the current cell on the data table fom the savedNitesGrid
                notes.Rows[savedNotesGrid.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                //if the cell is invalid (null), print this so it won't crash.
                Console.WriteLine("Not a valid note");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //whenever we start a new note, empty the title and note area 
            titleBox.Text = string.Empty;
            noteBox.Text = string.Empty;
        }
    }
}
