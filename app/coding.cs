// using System.Net;

// namespace coding
// {

//     abstract class Shape
//     {
//         private string color;

//         public Shape(string color)
//         {
//             this.color = color;
//         }

//         public string Color_name
//         {
//             get {return color;}
//             set {
//                 if (value=="Red")
//                 throw new Exception("The color can't be red.");
//                 else
//                     color = value;
//             }

//         }

//         public abstract double GetPerimeter();
//         public abstract double GetArea();
//         public virtual string Describe()
//         {
//             return $"This shape with {Color_name} suits well";
//         }



//     }


//     class Triangle:Shape
//     {
//         private double Side;

//         public Triangle(double side, string color): base(color)
//         {
//             Side = side;
//         }

//         public double Side_req
//         {
//             get {return Side;}
//             set {if (Side<0)
//             throw new Exception("Side can not be negative.");
//             else    
//                 Side = value;
//             }

//         }

//         public override double GetPerimeter()
//         {
//             return 3*Side;
//         }

//         public override double GetArea()
//         {
//             return (Math.Sqrt(3)/4)*Side*Side;
//         }
//         public override string Describe()
//         {
//             return $"This is Triangle with {Color_name} coolor";
//         }
//     }


//     class Circle:Shape
//     {
//         private double Radius;

//         public Circle(double radius, string color):base(color)
//         {
//             Radius = radius;
//         }
//         public override double GetPerimeter()
//         {
//             return Math.PI*2*Radius;
//         }

//         public override double GetArea()
//         {
//             return Math.PI*Radius*Radius;
//         }

//         public double Radius_gs
//         {
//             get {return Radius;}
//             set {
//                 if (value<0)
//                 throw new Exception("The vlue can not be negative.");
//                 else    
//                     Radius=value;
//                 }
//         }

//     }

//     class Rectangle:Shape
//     {

//         private double Side;
//         public Rectangle(double side, string color): base(color)
//         {
//             Side = side;
//         }

//         public double Rectangle_gs
//         {
//             get {return Side;}
//             set {if (value<0)
//                 throw new Exception("The value can not be negative.");
//                 else
//                     Side=value;
//                 }
//         }

//         public override double GetArea()
//         {
//             return Side*Side;
//         }

//         public override double GetPerimeter()
//         {
//             return 4*Side;
//         }


//     }
    

//     class Program
//     {

//         static void Main(string[] args)
//         {
//             Triangle shape1 = new Triangle(7, "blue");
//             Console.WriteLine($"Triangle's feature: {shape1.GetArea()}");
//             Console.WriteLine($"Triangle's feature: {shape1.GetPerimeter()}");
//             Console.WriteLine($"Triangle's feature: {shape1.Describe()}");

//             Circle shape2 = new Circle(4, "red");
//             Console.WriteLine($"Circle's feature: {shape2.GetArea()}");
//             Console.WriteLine($"Circle's feature: {shape2.GetPerimeter()}");

//             Rectangle shape3 = new Rectangle(11, "purple");
//             Console.WriteLine($"Rectangle's feature: {shape3.GetArea()}");
//             Console.WriteLine($"Rectangle's feature: {shape3.GetPerimeter()}");

//         }
//     }












// }