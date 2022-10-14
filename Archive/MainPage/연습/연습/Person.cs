using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습;


    public class Person : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; onPropertyChanged(nameof(Name)); }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; onPropertyChanged(nameof(Email)); }
        }
        string memo;
        public string Memo
        {
            get { return memo; }
            set { memo = value; onPropertyChanged(nameof(Memo)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void UpdateData()
        {
            Name = "gggg";
            Email = "sdsdsd";
            Memo = "mdskdslkc";
        }

    }

