using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListGroup : ContentPage
    {
        private List<PersonList> _listOfPeople;
        public List<PersonList> ListOfPeople { get { return _listOfPeople; } set { _listOfPeople = value; base.OnPropertyChanged(); } }


        public ListGroup()
        {
            InitializeComponent();
            var sList = new PersonList()
            {
                new Person() { FirstName = "Sally", LastName = "Sampson" },
                new Person() { FirstName = "Taylor", LastName = "Swift" },
                new Person() { FirstName = "John", LastName = "Smith" }
            };
                    sList.Heading = "S";

                    var dList = new PersonList()
            {
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };
                    dList.Heading = "D";

                    var jList = new PersonList()
            {
                new Person() { FirstName = "Billy", LastName = "Joel" }
            };
                    jList.Heading = "J";

                    var list = new List<PersonList>()
            {
                sList,
                dList,
                jList
            };
            Console.WriteLine(list);
            ListOfPeople = list;
        }
    }
}