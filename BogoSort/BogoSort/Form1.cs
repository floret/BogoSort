using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogoSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxUnsorted.Items.Add(txbInput.Text);//Adds the contents of txbInput to lbxUnsorted
            txbInput.Text = "";//clears the textbox.
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxUnsorted.Items.Remove(lbxUnsorted.SelectedItem);//Removes the selected item in lbxUnsorted
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] array = new int[lbxUnsorted.Items.Count];//creates new instance of the array called array.

            for (int i = 0; i < lbxUnsorted.Items.Count; i++)//iterates for the lenght of 
            {
                object s = lbxUnsorted.Items[i];//sets s to the items in the unsorted listbox.
                array[i] = Convert.ToInt32(s);//casts the objects to integers.
            }
            lbxSorted.Items.Clear();//clears the sorted listbox.
            //Sort using bogo sort
            Random rand = new Random();
            bool perfectMatch=false;
            do
            {
                
                perfectMatch = true;
            }
            while (perfectMatch != true);
            //
            foreach (int item in array)//adds the elements of the array one for one to the sorted listbox.
            {
                lbxSorted.Items.Add(item);//adds a single item to the listbox.
            }
        }
    }
}
 //           //sorting using bubble sort algorithim.
 //           bool flag = true;//boolean value that indicates that the numbers are swapped or not.
 //           int temp;
 //           int numLength = array.Length;

 //           for (int i = 1; (i <= (numLength - 1)) && flag; i++)//
 //           {
 //               flag = false;//sets the swapped indicator to false.
 //               for (int j = 0; j < (numLength - 1); j++)
 //               {
 //                   if (array[j + 1] > array[j])//if the element after the current element is bigger than the current element.
 //                   {
 //                       temp = array[j];            //Swaps
 //                       array[j] = array[j + 1];    //the 
 //                       array[j + 1] = temp;        //elements
 //                       flag = true;//sets the swapped indicator to true.
 //                   }
 //               }
 //           }