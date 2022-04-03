using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_04_2022.Models
{
    class Room
    {
        private static int _Id;
        private string _Name;
        private double _Price;
        private int _PersonCapacity;
        private bool _IsAviable=true;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public  string Name
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
        public double Price
        {
            get { return _Price; }
            set
            {
                if (value > 0)
                {
                    _Price = value;
                }
            }
        }
        public int PersonCapacity
        {
            get { return _PersonCapacity; }
            set
            {
                if (value > 0)
                {
                    _PersonCapacity = value;
                }
            }
        }
        public bool IsAvaiable
        {
            get { return _IsAviable; }
            set { _IsAviable = value; }
        }

        public Room(string name,double price,int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            // isAviable = true;
            _Id = id();
        }

        public int id()
        {
            _Id++;
            return _Id;
        }
        public string ShowInfo()
        {
            return $"{Name}  -  {Price}  - {PersonCapacity}  - {_IsAviable} "; 
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}

/*Room class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda (ctor-da) avtomatik bir vahid artacaq.
- Name
- Price
- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
- IsAvailable - otağın rezervasiya olunub olunmadığını göstərir, default olaraq true olmalıdır.
- ShowInfo() - Otağın bütün məlumatlarını göstərir
- ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.
- Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz*/