using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog122_S24_L12_ListView_Sal
{
    public class Data
    {
        public static string BusinessName = "Mike's Sandwich Shop";
        //Observable Collection
        public static ObservableCollection<string> names = new ObservableCollection<string>();

        string myName = "Will";

        // Static Constructor
        static Data()
        {
            MessageBox.Show("This just ran");
            names.Add("Rafael");
            names.Add("Charles");
            names.Add("Toivo");
            names.Add("Will");
        }

        public static void AddName(string name)
        {
            names.Add(name);
        }



    } // class


} // namespace
