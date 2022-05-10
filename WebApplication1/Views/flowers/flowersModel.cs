using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Views.flowers
{
    public class flowersModel
    {
        public int Id { get; set; }

        public String FName { get; set; }

        public String Flowering { get; set; }

        public String Colours { get; set; }

        public int Size { get; set; }

        public flowersModel(int id, string fName, string flowering, string colours, int size)
        {
            Id = id;
            FName = fName;
            Flowering = flowering;
            Colours = colours;
            Size = size;
        }

    }

}