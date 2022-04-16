using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random randomGenerator = new Random();

            List<Flight> flights_1 = new List<Flight>()
            {
                new Flight() { Origin="WAW", Destination="BCN", Number="FR-4758", Duration = TimeSpan.FromMinutes(147), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="WAW", Destination="BER", Number="FR-7872", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
            };

            List<Flight> flights_2 = new List<Flight>()
            {
                new Flight() { Origin="BCN", Destination="MAD", Number="FR-4779", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="MAD", Destination="LHR", Number="LH-1835", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="FCO", Destination="CDG", Number="W-63901", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
            };

            List<Flight> flights_3 = new List<Flight>()
            {
                new Flight() { Origin="CGN", Destination="VIE", Number="LO-385", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="KRK", Destination="NAP", Number="KL-921", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="MUC", Destination="BER", Number="EK-39", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="LHR", Destination="EDI", Number="W-63901", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
            };

            List<Flight> flights_4 = new List<Flight>()
            {
                new Flight() { Origin="CGN", Destination="VIE", Number="LO-375", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="LHR", Destination="EDI", Number="W-68971", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
            };

            List<Flight> flights_5 = new List<Flight>()
            {
                new Flight() { Origin="KRK", Destination="VIE", Number="EK-78", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
                new Flight() { Origin="WAW", Destination="EDI", Number="KL-993", Duration = TimeSpan.FromMinutes(randomGenerator.Next(18, 265)), DepartureTime = DateTime.FromFileTime(randomGenerator.Next()) },
            };

            this.DataContext = new List<Plane>()
            {
                new Plane() { Brand = "Boeing 737", Registration = "OHR-428", Capacity = randomGenerator.Next(130, 340), Weight=randomGenerator.Next(130, 340), Flights = flights_1 },
                new Plane() { Brand = "Boeing 777", Registration = "GTO-179", Capacity = randomGenerator.Next(130, 340), Weight=randomGenerator.Next(130, 340), Flights = flights_2 },
                new Plane() { Brand = "Airbus A319", Registration = "SP-FXM", Capacity = randomGenerator.Next(130, 340), Weight=randomGenerator.Next(130, 340), Flights = flights_3 },
                new Plane() { Brand = "Airbus A380", Registration = "D-TRYZ", Capacity = randomGenerator.Next(130, 340), Weight=randomGenerator.Next(130, 340), Flights = flights_4 },
                new Plane() { Brand = "Cesna 172", Registration = "G-KATM", Capacity = randomGenerator.Next(1, 2), Weight=randomGenerator.Next(8, 18), Flights = flights_5 },
                new Plane() { Brand = "Cessna Citation", Registration = "EC-TER", Capacity = randomGenerator.Next(2, 8), Weight=randomGenerator.Next(15, 35), Flights = flights_1 },
            };
        }
    }
}
