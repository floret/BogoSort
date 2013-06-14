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
            //Sort using bogo sort
            Random rand = new Random();
            bool perfectMatch=false;
            Random rng = new Random();   // i.e., java.util.Random.
            int o = 0;

           
            //attempt sattolo's algorithm (shuffles the elements in an array.).     
            int n = array.Count();
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;      // n is now the last pertinent index;
                // swap array[n] with array[k] (does nothing if k == n).
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            do
            {
                o = 2;                   
                //end sattalo
                int numLength = array.Length;
                //see if the array is sorted.
                for (int i = 1; (i <= (numLength - 1)); i++)//!these for loops are broken
                {
                    for (int j = 0; j < (numLength - 1); j++)
                    {
                        if (array[j + 1] > array[j])//if the element after the current element is bigger than the current element.
                        {
                            
                        }
                        else
                        {
                            o = 1;
                            break;
                        }
                    }
                    //if (array[i-1] > array[i])//if the element after the current element is bigger than the current element.
                    //{
                    //    o = 1;
                    //}     
                }
                if (o == 2)
                { perfectMatch = true; }
            }
            while (perfectMatch == false);
            //
            if (perfectMatch == true)
            {
                lbxSorted.Items.Clear();//clears the sorted listbox.
                foreach (int item in array)//adds the elements of the array one for one to the sorted listbox.
                {
                    lbxSorted.Items.Add(item);//adds a single item to the listbox.
                }
            }            
        }
    }
}