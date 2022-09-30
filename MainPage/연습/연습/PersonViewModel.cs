using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace 연습;


    public class PersonViewModel : INotifyPropertyChanged
    {
        public Person person { get; } = new Person();
        public PersonViewModel()
        {
            PostPeople = new Command(AddPerson);

        }
        public ICommand PostPeople { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void AddPerson()
        {

            person.UpdateData();


        }

    }

   

