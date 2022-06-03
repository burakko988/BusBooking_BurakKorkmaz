using BiletRezervasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Concrete.EFcore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BookingContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Cities.Count()==0)
                {
                    context.Cities.AddRange(Cities);
                }
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }
                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }
                if (context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(Buses);
                }
            }
            context.SaveChanges();
        }
        private static City[] Cities =
        {
            new City() {CityId=1,CityName="Adana"},
            new City() {CityId=2,CityName="Adıyaman"},
            new City() {CityId=3,CityName="Afyon"},
            new City() {CityId=4,CityName="Ağrı"},
            new City() {CityId=5,CityName="Amasya"},
            new City() {CityId=6,CityName="Ankara"},
            new City() {CityId=7,CityName="Antalya"},
            new City() {CityId=8,CityName="Artvin"},
            new City() {CityId=9,CityName="Aydın"},
            new City() {CityId=10,CityName="Balıkesir"},
            new City() {CityId=11,CityName="Bilecik"},
            new City() {CityId=12,CityName="Bingöl"},
            new City() {CityId=13,CityName="Bitlis"},
            new City() {CityId=14,CityName="Bolu"},
            new City() {CityId=15,CityName="Burdur"},
            new City() {CityId=16,CityName="Bursa"},
            new City() {CityId=17,CityName="Çanakkale"},
            new City() {CityId=18,CityName="Çankırı"},
            new City() {CityId=19,CityName="Çorum"},
            new City() {CityId=20,CityName="Denizli"},
            new City() {CityId=21,CityName="Diyarbakır"},
            new City() {CityId=22,CityName="Edirne"},
            new City() {CityId=23,CityName="Elazığ"},
            new City() {CityId=24,CityName="Erzincan"},
            new City() {CityId=25,CityName="Erzurum"},
            new City() {CityId=26,CityName="Eskişehir"},
            new City() {CityId=27,CityName="Gaziantep"},
            new City() {CityId=28,CityName="Giresun"},
            new City() {CityId=29,CityName="Gümüşhane"},
            new City() {CityId=30,CityName="Hakkari"},
            new City() {CityId=31,CityName="Hatay"},
            new City() {CityId=32,CityName="Isparta"},
            new City() {CityId=33,CityName="Mersin"},
            new City() {CityId=34,CityName="İstanbul"},
            new City() {CityId=35,CityName="İzmir"},
            new City() {CityId=36,CityName="Kars"},
            new City() {CityId=37,CityName="Kastamonu"},
            new City() {CityId=38,CityName="Kayseri"},
            new City() {CityId=39,CityName="Kırklareli"},
            new City() {CityId=40,CityName="Kırşehir"},
            new City() {CityId=41,CityName="Kocaeli"},
            new City() {CityId=42,CityName="Konya"},
            new City() {CityId=43,CityName="Kütahya"},
            new City() {CityId=44,CityName="Malatya"},
            new City() {CityId=45,CityName="Manisa"},
            new City() {CityId=46,CityName="Kahramanmaraş"},
            new City() {CityId=47,CityName="Mardin"},
            new City() {CityId=48,CityName="Muğla"},
            new City() {CityId=49,CityName="Muş"},
            new City() {CityId=50,CityName="Nevşehir"},
            new City() {CityId=51,CityName="Niğde"},
            new City() {CityId=52,CityName="Ordu"},
            new City() {CityId=53,CityName="Rize"},
            new City() {CityId=54,CityName="Sakarya"},
            new City() {CityId=55,CityName="Samsun"},
            new City() {CityId=56,CityName="Siirt"},
            new City() {CityId=57,CityName="Sinop"},
            new City() {CityId=58,CityName="Sivas"},
            new City() {CityId=59,CityName="Tekirdağ"},
            new City() {CityId=60,CityName="Tokat"},
            new City() {CityId=61,CityName="Trabzon"},
            new City() {CityId=62,CityName="Tunceli"},
            new City() {CityId=63,CityName="Şanlıurfa"},
            new City() {CityId=64,CityName="Uşak"},
            new City() {CityId=65,CityName="Van"},
            new City() {CityId=66,CityName="Yozgat"},
            new City() {CityId=67,CityName="Zonguldak"},
            new City() {CityId=68,CityName="Aksaray"},
            new City() {CityId=69,CityName="Bayburt"},
            new City() {CityId=70,CityName="Karaman"},
            new City() {CityId=71,CityName="Kırıkkale"},
            new City() {CityId=72,CityName="Batman"},
            new City() {CityId=73,CityName="Şırnak"},
            new City() {CityId=74,CityName="Bartın"},
            new City() {CityId=75,CityName="Ardahan"},
            new City() {CityId=76,CityName="Iğdır"},
            new City() {CityId=77,CityName="Yalova"},
            new City() {CityId=78,CityName="Karabük"},
            new City() {CityId=79,CityName="Kilis"},
            new City() {CityId=80,CityName="Osmaniye"},
            new City() {CityId=81,CityName="Düzce"}
        };
        private static Bus[] Buses =
        {
            new Bus() {BusId=1,BusPlaque="01 VE 06",BusSeatCapacity=44, BusDriverFullName="Burak Korkmaz"},
            new Bus() {BusId=2,BusPlaque="06 DB 11",BusSeatCapacity=36, BusDriverFullName="Burak Korkmaz"},
            new Bus() {BusId=3,BusPlaque="11 VE 16",BusSeatCapacity=48, BusDriverFullName="Burak Korkmaz" },
            new Bus() {BusId=4,BusPlaque="16 VE 21",BusSeatCapacity=56, BusDriverFullName="Burak Korkmaz" },
            new Bus() {BusId=5,BusPlaque="21 VE 26",BusSeatCapacity=40, BusDriverFullName="Burak Korkmaz"},
            new Bus() {BusId=6,BusPlaque="26 VE 31",BusSeatCapacity=40, BusDriverFullName="Burak Korkmaz"}
        };
        public static Route[] Routes =
        {
            new Route() {RouteId=1,FirstTerminal="Adana",Terminal1="Konya" ,Terminal2="Balıkesir",LastTerminal="Ankara", Date="2022-05-14", Hour="12:00",Price=100,BusId=1},
            new Route() {RouteId=2,FirstTerminal="Ankara",Terminal1="Bursa" ,Terminal2="Balıkesir",Terminal3="Ağrı",Terminal4="Kastamonu", Terminal5="Malatya", LastTerminal="Bilecik", Date="2022-05-14", Hour="10:00",Price=150,BusId=2},
            new Route() {RouteId=3,FirstTerminal="Bilecik",Terminal1="Burdur" ,Terminal2="Balıkesir",Terminal3="Muğla",Terminal4="Antalya", LastTerminal="Bursa", Date="2022-05-14", Hour="18:00",Price=200,BusId=3},
            new Route() {RouteId=4,FirstTerminal="Bursa",Terminal1="Burdur" ,Terminal2="Balıkesir", LastTerminal="İstanbul", Date="14.05.2022", Hour="17:00",Price=250,BusId=4},
            new Route() {RouteId=5,FirstTerminal="Denizli",Terminal1="İzmir" ,Terminal2="Balıkesir",Terminal3="Konya", LastTerminal="Eskişehir", Date="2022-05-14", Hour="16:00",Price=300,BusId=5},
            new Route() {RouteId=6,FirstTerminal="Eskişehir",Terminal1="Burdur" ,Terminal2="Balıkesir",Terminal3="Düzce",Terminal4="Osmaniye", Terminal5="Karabük", LastTerminal="Hatay", Date="2022-05-14", Hour="15:00",Price=350,BusId=6}

        };

        public static Ticket[] Tickets =
            {
            new Ticket() {PassengerFirstName="İsmail", PassgerLastName="Korkmaz", PassengerMail="isrkmaz@gmail.com", PassengerPhone="5451111111",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=1,BoardingPoint="Adana",Destination="Ankara", RouteId=1,BusId=1,PnrNo="1234"},
            new Ticket() {PassengerFirstName="Burak", PassgerLastName="Korkmaz", PassengerMail="ailkorkmaz@gmail.com", PassengerPhone="5451117111",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=2,BoardingPoint="Konya",Destination="Balıkesir", RouteId=1,BusId=1,PnrNo="1235"},
            new Ticket() {PassengerFirstName="Oğuz", PassgerLastName="Varlı", PassengerMail="ismailmaz@gmail.com", PassengerPhone="5451116111",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=5,BoardingPoint="Adana",Destination="Ankara", RouteId=1,BusId=1,PnrNo="1236"},
            new Ticket() {PassengerFirstName="Mete", PassgerLastName="Ölmez", PassengerMail="ismailkorkz@gmail.com", PassengerPhone="5451115111",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=6,BoardingPoint="Adana",Destination="Balıkesir", RouteId=1,BusId=1,PnrNo="1237"},
            new Ticket() {PassengerFirstName="Abdullah", PassgerLastName="Kerimov", PassengerMail="ismailorkmaz@gmail.com", PassengerPhone="5451111119",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=13,BoardingPoint="Burdur",Destination="Balıkesir", RouteId=2,BusId=2,PnrNo="1238"},
            new Ticket() {PassengerFirstName="Ahmet", PassgerLastName="Yılaz", PassengerMail="ismaiasdf@gmail.com", PassengerPhone="5451111118",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=14,BoardingPoint="Burdur",Destination="Balıkesir", RouteId=2,BusId=2,PnrNo="1239"},
            new Ticket() {PassengerFirstName="Selin", PassgerLastName="Yüzen", PassengerMail="isqwerrkmaz@gmail.com", PassengerPhone="5451111117",PassengerIdentity="11111111111",PassengerGender="Kadın", SeatNo=15,BoardingPoint="Burdur",Destination="Bursa", RouteId=3,BusId=3,PnrNo="12312"},
            new Ticket() {PassengerFirstName="Şevval", PassgerLastName="Dalcı", PassengerMail="ismqwerrkmaz@gmail.com", PassengerPhone="5451111116",PassengerIdentity="11111111111",PassengerGender="Kadın", SeatNo=16,BoardingPoint="Burdur",Destination="Bursa", RouteId=3,BusId=3,PnrNo="12313"},
            new Ticket() {PassengerFirstName="Ayşe", PassgerLastName="Basar", PassengerMail="ismailkodfghaz@gmail.com", PassengerPhone="5451111115",PassengerIdentity="11111111111",PassengerGender="Kadın", SeatNo=17,BoardingPoint="Burdur",Destination="İstanbul", RouteId=4,BusId=4,PnrNo="12314"},
            new Ticket() {PassengerFirstName="Merve", PassgerLastName="Kontor", PassengerMail="iszxcvlkorkmaz@gmail.com", PassengerPhone="5451111114",PassengerIdentity="11111111111",PassengerGender="Kadın", SeatNo=18,BoardingPoint="Burdur",Destination="İstanbul", RouteId=4,BusId=4,PnrNo="12315"},
            new Ticket() {PassengerFirstName="Beyza", PassgerLastName="Mel", PassengerMail="ismailkoradsgf@gmail.com", PassengerPhone="5451111113",PassengerIdentity="11111111111",PassengerGender="Kadın", SeatNo=9,BoardingPoint="Denizli",Destination="Eskişehir", RouteId=5,BusId=5,PnrNo="12316"},
            new Ticket() {PassengerFirstName="İsmail", PassgerLastName="Camcı", PassengerMail="ismqwerlkorkmaz@gmail.com", PassengerPhone="5451111112",PassengerIdentity="11111111111",PassengerGender="Erkek", SeatNo=19,BoardingPoint="İzmir",Destination="Eskişehir", RouteId=6,BusId=6,PnrNo="12317"}

        };
    }
}
