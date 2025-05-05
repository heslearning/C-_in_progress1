using System;

namespace Photo
{
    class Photo
    {
        private double Length;
        private double Width;

        public Photo(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double length_gs
        {
            get {return Length;}
        }  

        public double width_gs
        {
            get {return Width;}
        } 

        public virtual string GetPhotoDetails()
        {
            return $"Photo Length {length_gs} Width {width_gs}.";
        }  

    }










}