using Core.Helpers.Enums;
using Core.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Models
{
    public class Room
    {


        // - Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda avtomatik
     
        public int Id { get; } = 1;
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCount { get; set; }
        public RoomCapacity PersonCapacity { get; set; }
        public bool IsAvialable {  get; set; }=true;
        public Room ID { get; internal set; }


        //ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.
        public string ShowInfo()
        {
            return $"Room ID: {Id}, Name: {Name}, Price: {Price:C}, Capacity: {PersonCapacity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }


        // ps: Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz
        public Room(int ID,string name, double price,int personCount, RoomCapacity personcapacity)
        {
            
            ID= Id++;
            Name = name;
            Price = price;
            PersonCount=personCount;
            PersonCapacity = personcapacity;
        }

    }

  
}
