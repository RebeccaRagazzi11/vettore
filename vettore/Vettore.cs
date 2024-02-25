using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettore
{
    internal class Vettore
    { 
        public Vettore (double x, double y)
        {
            this.X = x;
            this.Y = y;

        }
        public double X { get; set; }   
        public double Y { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1}", X, Y);

        }
        public static Vettore Parse (string v)
        {
            string[] parts = v.Split(';');
            return new Vettore(double.Parse(parts[0]), double.Parse(parts[1]));
        }
        public static Vettore operator + (Vettore v1, Vettore v2)
        {
            return new Vettore (v1.X+v2.X, v1.Y+v2.Y);
        }
        public static Vettore operator - (Vettore v1, Vettore v2 )
        {
            return new Vettore (v1.X-v2.X, v1.Y-v2.Y);
        }
        public static Vettore operator * (Vettore v1, Vettore v2)
        {
            return new Vettore (v1.X*v2.X, v1.Y*v2.Y);
        }
        public static Vettore operator * (Vettore v, double s) // v*s
        {
            return new Vettore (v.X* s , v.Y*s );
        }
        public static Vettore operator / (Vettore v, double s) // v/s
        {
            return new Vettore (v.X/s,v.Y/s );  
        }

        public static Vettore operator + (Vettore v) // +v
        {
            return v;
        }
        public static Vettore operator - (Vettore v ) // -v
        {
            return new Vettore(-v.X, -v.Y); 

        }
      
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            return !(v1 == v2);
        }
        public static bool operator == (Vettore v1, Vettore v2)
        {
           if(object.ReferenceEquals(v1,null ))
                return object.ReferenceEquals(v2,null);
           else if (object.ReferenceEquals(v2,null )) return false;
           else return v1.X==v2.X && v1.Y==v2.Y;    
        }

    }
}
