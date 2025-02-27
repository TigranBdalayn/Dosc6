
// Task 2:  3D Vector Class with Overloaded Operators
// Task: Create a Vector3D class representing a three-dimensional vector. Implement the following:
// 1. Override ToString()
// Format: "(X, Y, Z)"
// 2. Overload Arithmetic Operators
// + to add vectors.
// - to subtract vectors.
// * to multiply by a scalar.
// / to divide by a scalar (handle division by zero).
// 3. Overload Equality Operators (==, !=)
// Two vectors are equal if all components are equal.
// 4. Implement Equals() and GetHashCode() Consistently
// 5. Overload true and false Operators
// A vector is "true" if it's non-zero, otherwise "false".
// 6. Overload >, <, >=, <= Based on Magnitude

using System;

class Vector3D {

    double X;
    double Y;
    double Z;

    public  Vector3D (double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    } 
    public void Display () {
        Console.WriteLine ($"\nX = {X}\nY = {Y}\nZ = {Z}\n");
    }
    public override string ToString () {
        return $"{X}, {Y}, {Z}";
    }
    public static Vector3D operator + (Vector3D a, Vector3D b) {
        return new Vector3D (a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }
    public static Vector3D operator - (Vector3D a, Vector3D b) {
        return new Vector3D (a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    public static Vector3D operator * (Vector3D a, Vector3D b) {
        return new Vector3D (a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }
    public static Vector3D operator / (Vector3D a, Vector3D b) {
        return new Vector3D (a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    }
    public static bool operator == (Vector3D a, Vector3D b) {
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }
    public static bool operator != (Vector3D a, Vector3D b) {
        return !(a.X == b.X && a.Y == b.Y && a.Z == b.Z);
    }
    public override bool Equals (object obj) {
        
        if (obj is Vector3D other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        return false;
    }
    public override int GetHashCode () {
        return HashCode.Combine (X, Y, Z);
    }

    public double Magnitude () {
        return Math.Sqrt (X * X + Y * Y + Z * Z);
    }
    public static bool operator true (Vector3D v) {
        return v.Magnitude() > 0;
    }
    public static bool operator false (Vector3D v) {
        return v.Magnitude () == 0;
    }
    public static bool operator > (Vector3D a, Vector3D b) {
        return a.Magnitude() > b.Magnitude ();
    }
    public static bool operator < (Vector3D a, Vector3D b) {
        return a.Magnitude () < b.Magnitude ();
    }
    public static bool operator >= (Vector3D a, Vector3D b) {
        return a.Magnitude() >= b.Magnitude ();
    }
    public static bool operator <= (Vector3D a, Vector3D b) {
        return a.Magnitude() >= b.Magnitude();
    }
}
class Program {
    static void Main (string[] args) {
        Vector3D a = new Vector3D (100, 200, 300);
        Vector3D b = new Vector3D (10, 20, 30);
        a.Display();
        b.Display();
        a -= b;
        a.Display();
        a += b;
        a.Display();
        a *= b;
        a.Display();
        a /= b;
        a.Display();
        Console.WriteLine (a > b);
        Console.WriteLine (a < b);
        Console.WriteLine (a >= b);
        Console.WriteLine (a <= b);
        Console.WriteLine (a.Equals(b));


        

    }
}