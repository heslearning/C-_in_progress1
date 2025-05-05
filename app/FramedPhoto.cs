using System;
using System.Data;

namespace Photo
{
    class FramedPhoto: Photo
    {
        private string Material;
        private string Style;
    

    public FramedPhoto(double width, double length, string material, string style): base(width, length)
    {
        Material = material;
        Style = style;
    }

     public override string GetPhotoDetails()
        {
            return $"Framed Photo Length {length_gs} Width {width_gs} Material {Material} Style {Style}.";
        }


    }

}