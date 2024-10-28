using Core.Helpers.Enums;
using Core.Helpers.Exceptions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class AppDbContext
    {
        // Hotel List- içində Hotel obyektləri saxlayır və private-dır
        private static List<Hotel> hotels = new List<Hotel>();
        public static void CreatHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public static void CreatHotel(params Hotel[] addedhotels)
        {
            for (int i = 0; i < addedhotels.Length; i++)
            {
                hotels.Add(addedhotels[i]);
            }
        }

       
        //- Rooms List - içində Room obyektləri saxlayır və private-dır.
        public static List<Room> rooms = new List<Room>();

        public static bool IsAvialable { get; private set; }
        public static int? PersonCount { get; private set; }
        public static Room Id { get; private set; }

        //- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.

        public static void AddRoom(Room room)
        {
            rooms.Add(room);
            
        }
        public static void  AddedRooms(params Room[] addedrooms)
        {
            for (int i = 0;i<addedrooms.Length;i++)
            {
                rooms.Add(addedrooms[i]);
            }
        }
        //-FindAllRoom()-Parametr olaraq bir şərt qebul edecek ve gelen serte uygun olaraq otaqlari geriye qaytaracaq;
        public static Room FindAllRoom(int id)
        {
            return rooms.Find(x => x.Id == id);

        }

        // - MakeReservation() - Parametr olaraq nullable int tipindən bir roomId ve musteri sayi qəbul edir
        //əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda göndərilən roomId-li otaq tapılır
        //IsAvailable dəyəri ve Personal Capacity yoxlanılır
        //əgər IsAvailable dəyəri false-dusa geriyə yuxarıda yaratdığınız NotAvailableException qaytarılır
        //əgər true-dursa Personal Capacityde uygun gelirse həmin room-un IsAvailable dəyəri true olur.


        public void MakeReservation(int? roomid, int? personcount)    
        {
            bool isReserved = false;
            for (int i = 0; i < rooms.Count; i++) ;
            {
                try
                {
                    foreach (Room room in rooms)
                    {
                        if (room.Id == roomid)
                        {
                            Console.WriteLine(room.ID); 
                        }
                    }
                }
                catch (NullReferanceException ex)
                {

                    Console.WriteLine("Bu id-li otaq tapilmadi."+ex.Message);
                }

                try
                {
                    foreach (Room room in rooms)
                    {
                        if(isReserved)
                        {
                            if (personcount == PersonCount)
                            {
                                Console.WriteLine("Bu otaq bosdur.");
                            }
                        }
                    }
                } 
                catch (NotAvailableException ex)
                {

                    Console.WriteLine("Bu otaq doludur. "+ex.Message); 
                }
               
            }
        }

      
    }
}
