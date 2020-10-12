using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
            Photo photoOriginal = new Photo();
            MattePhoto photoMatte = new MattePhoto();
            FramedPhoto photoFramed = new FramedPhoto();

            photoOriginal.PhotoWidth = 12;
            photoOriginal.PhotoHeight = 15;
            Console.WriteLine(photoOriginal.ToString());

            photoMatte.PhotoWidth = 10;
            photoMatte.PhotoHeight = 12;
            photoMatte.Color = "green";
            Console.WriteLine(photoMatte.ToString());

            photoFramed.PhotoWidth = 8;
            photoFramed.PhotoHeight = 10;
            photoFramed.Material = "wood";
            photoFramed.Style = "modern";
            Console.WriteLine(photoFramed.ToString());
        }
    }
}
