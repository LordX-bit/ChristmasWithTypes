using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int null { get; set; } //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Days{
        Monday,Tuesday,Wensday,Thursday,Friday,Saturday,Sunday };

    }
}
