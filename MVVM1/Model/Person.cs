using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;

namespace MVVM1.Model
{
    public class Person: INotifyPropertyChanged
    {
        private string fname;
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value; OnPropertyChanged(Fname);
            }
        }
        private string lname;
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value; OnPropertyChanged(Lname);
            }
        }
        private string fullname;

        

        public string Fullname
        {
            get
            {
                return fullname = Fname + "" + Lname;
            }
            set
            {
                fullname = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
            
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));
        }
    }
}
