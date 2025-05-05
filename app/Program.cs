namespace Photo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keep this line intact
            Console.WriteLine("===========================");
            const int NORMAL_PHOTO = 1;
            const int MATTED_PHOTO = 2;
            const int FRAMED_PHOTO = 3;

            const int NUM_OPTIONS = 3;

            // Enter in information about the photo
            Console.WriteLine("Please choose the type of photo (1-3):");
            Console.WriteLine("1. A normal photo.");
            Console.WriteLine("2. A matted photo.");
            Console.WriteLine("3. A framed photo.");
            int choice = Int32.Parse(Console.ReadLine());

            if ((choice > 0) && (choice <= NUM_OPTIONS))
            {

                Console.WriteLine("Please enter in the photo's length:");
                double length = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in the photo's width:");
                double width = Double.Parse(Console.ReadLine());

                // Create a photo based on input
                switch (choice)
                {
                    case NORMAL_PHOTO:
                        Photo photo = new Photo(length, width);
                        Console.WriteLine(photo.GetPhotoDetails());
                        break;
                    case MATTED_PHOTO:
                        Console.WriteLine("Please enter in the mat's colour:");
                        String mattedColour = Console.ReadLine();
                        MattedPhoto mattedPhoto = new MattedPhoto(length, width, mattedColour);
                        Console.WriteLine(mattedPhoto.GetPhotoDetails());
                        break;
                    case FRAMED_PHOTO:
                        Console.WriteLine("Please enter in the frame's material:");
                        String frameMaterial = Console.ReadLine();
                        Console.WriteLine("Please enter in the frame's type:");
                        String frameType = Console.ReadLine();
                        FramedPhoto framedPhoto = new FramedPhoto(length, width, frameMaterial, frameType);
                        Console.WriteLine(framedPhoto.GetPhotoDetails());
                        break;
                    default:
                        // should not execute 
                        Console.WriteLine("Error - Invalid photo type.");
                        break;

                }

            } else
            {
                // should not execute 
                Console.WriteLine("Error - Invalid photo type.");
            }
            // Keep this line intact
            Console.WriteLine("===========================");

        }
    }
}