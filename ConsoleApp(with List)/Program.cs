using Core.Data;
using Core.Models;

namespace ConsoleApp_with_List_
{
    internal class Program
    {
        private static readonly bool f1;
        private static int switch_on;
        private static bool addedhotels;
        private static bool hotels;

        public static string name { get; private set; }

        static void Main(string[] args)
        {
            bool f = false;
            string options;

            do
            {
                Console.WriteLine("-------------------------------------MENU--------------------------------------");
                Console.WriteLine("1-Sisteme giris\r\n0-Sistemden Cixis");
                Console.WriteLine("Seciminizi daxil edin:");

                options = Console.ReadLine();

                switch (options)
                {
                    case "1":


                        
                        
                            Console.Clear();
                            bool f1=true;
                            Console.WriteLine("--Sisteme giris etdiniz.Asagidaki Shortcut-lar movcuddur.");
                            Console.WriteLine("1-Hotel yarat (Hotel yarat secdikden sonra bir otel yaradirsiz. eyni adda hotel ola bilmez :D");
                            Console.WriteLine("2-Butun Hotelleri gormek\n3-Hotel sec (hotelin adini daxil ederek secilecek)\n0-Exit");


                        do
                        {
                            bool HotelList = false;
                            Console.WriteLine("Seciminiz girin:");
                            string options1 = Console.ReadLine();
                            switch (options1)

                            {
                                case "1":
                                    Console.WriteLine("Yaratmaq istediyiniz Hotel adini daxil edin:");
                                    string name = Console.ReadLine();
                                    Hotel hotel = new Hotel(name);
                                    AppDbContext.CreatHotel(hotel);
                                    Console.WriteLine("Hotel Yaradildi.");
                                    break;
                                case "2":
                                    Console.WriteLine(hotels);
                                    break;
                                case "3":
                                    Console.WriteLine("Secdiyiniz Hotelin Adini yazin: ");
                                    //var hotel.Name = Console.ReadLine();
                                    break;
                                case "0":
                                    f1 = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Option...");
                                    break;

                            }
                        } while (true);
                            
                      





                        break;

                    case "0":
                        f = true;
                        break;


                    default:
                        Console.WriteLine("Invalid Option...");
                        break;
                }
            } while (!f);



        }
    }
}
