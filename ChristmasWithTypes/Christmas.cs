using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public Christmas()
        {
        }
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable
        public enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; //TODO Make the property, "Day", type enum
        public string[] Presents;

    }
}
