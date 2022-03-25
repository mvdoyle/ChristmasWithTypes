using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable-DONE

        //TODO Make the property, "Day", type enum-DONE
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    }
}
