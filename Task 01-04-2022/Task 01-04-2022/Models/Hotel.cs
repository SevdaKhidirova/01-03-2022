using System;
using System.Collections.Generic;
using System.Text;
using Task_01_04_2022.Exceptions;

namespace Task_01_04_2022.Models
{
    class Hotel
    {
        private string _Name;
        private Room[] Rooms=new Room[0];

        public Hotel(int size)
        {
            Rooms = new Room[size];
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.Length < 100)
                {
                    _Name = value;
                }
            }
        }
        public Hotel(string name)
        {
            Name = name;
        }


        public Room this[int index]
        {
            get { return Rooms[index]; }
            set
            {
                Rooms[index] = value;
            }
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
            
        }
        //Room room = new Room("Hotel", 23, 4, true,1);
        public void Reserve (int? Id)
        {
            bool IdStatus = false;
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i].Id == Id)
                {
                    IdStatus = true;
                    if (Rooms[i].IsAvaiable)
                    {
                        Rooms[i].IsAvaiable = false;
                        break;
                    }
                    else throw new NotAvailableException("this room is not aviable");
                }
            }
            if (IdStatus == false)
            {
                throw new NotFoundException("This room not found bro");
            }
        }

    }


}
/*Hotel class
- Name
- Rooms array - içində Room obyektləri saxlayır və private-dır.
- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.
- Hotel class-ı üçün bir indexer yazılır və bir hotel obyekti yaratdıqdan sonra 
hotel[n] yazdığımız zaman rooms arrayindəki n-ci element geriyə qaytarılmalıdır, həm get etmək həmdə set etmək olmalıdır.

- Name dəyəri olmadan bir Hotel obyekti yaratmaq olmaz.
- Reserve() - Parametr olaraq nullable int tipindən bir roomId qəbul edir 
göndərilən roomId-li otaq tapılır və IsAvailable dəyəri yoxlanılır əgər IsAvailable dəyəri false-dusa 
geriyə yuxarıda yaratdığınız NotAvailableException throw edir əgər true-dursa həmin room-un IsAvailable dəyəri false olur. 
Əgər otaq oteldə tapımazsa NotFoundException throw edilsin.*/