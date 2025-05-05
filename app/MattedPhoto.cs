using System;

namespace Photo
{

    class MattedPhoto: Photo
    {
        private string color;

        public MattedPhoto(double length, double width, string color): base(length, width)
        {
            this.color = color;
        }

        public override string GetPhotoDetails()
        {
            return $"Matted Photo Length {length_gs} Width {width_gs} Colour {color}.";
        }
    }






}