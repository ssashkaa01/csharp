using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._09._2019
{

    // Квадрат
    class Square
    {
        private double a;

        public Square()
        {
            a = 0;
        }

        public Square(double a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return $"It`s Square, where side - {a}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Square s = (Square)obj;
                return (s.a == this.a);
            }
        }

        public override int GetHashCode()
        {
            return (Convert.ToInt32(a) << 2) ^ 2;
        }

        public static Square operator ++(Square s)
        {
            s.a++;

            return s;
        }

        public static Square operator --(Square s)
        {
            if (s.a >= 1)
            {
                s.a--;
                return s;
            }

            throw new Exception("size < 1");
        }

        public static Square operator -(Square r1, Square r2)
        {
            Square n = new Square();

            n.a = r1.a - r2.a;

            if (n.a >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Square operator +(Square r1, Square r2)
        {
            Square n = new Square();

            n.a = r1.a + r2.a;

            if (n.a >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Square operator /(Square r1, Square r2)
        {
            Square n = new Square();

            n.a = r1.a / r2.a;

            if (n.a >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Square operator *(Square r1, Square r2)
        {
            Square n = new Square();

            n.a = r1.a * r2.a;

            if (n.a >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static bool operator false(Square s)
        {
            return (s.a <= 0);
        }

        public static bool operator true(Square s)
        {
            return (s.a > 0);
        }

        public static bool operator >(Square s1, Square s2)
        {
            return (s1.a > s2.a);
        }

        public static bool operator <(Square s1, Square s2)
        {
            return (s1.a < s2.a);
        }

        public static bool operator >=(Square s1, Square s2)
        {
            return (s1.a >= s2.a);
        }

        public static bool operator <=(Square s1, Square s2)
        {
            return (s1.a <= s2.a);
        }

        public static bool operator ==(Square s1, Square s2)
        {
            return (s1.a == s2.a);
        }

        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.a, s.a);
        }

        public static explicit operator int(Square s)
        {
            return Convert.ToInt32(s.a);
        }
    }

    // Прямокутник
    class Rectangle
    {
        private double a;
        private double b;

        public Rectangle()
        {
            a = 0;
            b = 0;
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return $"It`s Rectangle, where side - {a} & {b}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Rectangle s = (Rectangle)obj;
                return (s.a == this.a) && (s.b == this.b);
            }
        }

        public override int GetHashCode()
        {
            return (Convert.ToInt32(a) << 2) ^ 2;
        }

        public static Rectangle operator ++(Rectangle r)
        {
            r.a++;
            r.b++;

            return r;
        }

        public static Rectangle operator --(Rectangle r)
        {
            if (r.a >= 1 && r.b >= 1)
            {
                r.a--;
                r.b--;
                return r;
            }

            throw new Exception("size < 1");
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle n = new Rectangle();

            n.a = r1.a + r2.a;
            n.b = r1.b + r2.b;

            if (n.a >= 0 && n.b >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle n = new Rectangle();

            n.a = r1.a - r2.a;
            n.b = r1.b - r2.b;

            if (n.a >= 0 && n.b >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle n = new Rectangle();

            n.a = r1.a * r2.a;
            n.b = r1.b * r2.b;

            if (n.a >= 0 && n.b >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle n = new Rectangle();

            n.a = r1.a / r2.a;
            n.b = r1.b / r2.b;

            if (n.a >= 0 && n.b >= 0)
            {
                return n;
            }

            throw new Exception("result < 0");
        }

        public static bool operator false(Rectangle s)
        {
            return (s.a <= 0) && (s.b <= 0);
        }

        public static bool operator true(Rectangle s)
        {
            return (s.a > 0) && (s.a > 0);
        }

        public static bool operator >(Rectangle s1, Rectangle s2)
        {
            return (s1.a > s2.a) && (s1.b > s2.b);
        }

        public static bool operator <(Rectangle s1, Rectangle s2)
        {
            return (s1.a < s2.a) && (s1.b < s2.b);
        }

        public static bool operator >=(Rectangle s1, Rectangle s2)
        {
            return (s1.a >= s2.a) && (s1.b >= s2.b);
        }

        public static bool operator <=(Rectangle s1, Rectangle s2)
        {
            return (s1.a <= s2.a) && (s1.b <= s2.b);
        }

        public static bool operator ==(Rectangle s1, Rectangle s2)
        {
            return (s1.a == s2.a) && (s1.b == s2.b);
        }

        public static bool operator !=(Rectangle s1, Rectangle s2)
        {
            return !(s1 == s2);
        }

        public static explicit operator Square(Rectangle s)
        {
            return new Square(s.a);
        }

        public static implicit operator int(Rectangle s)
        {
            return Convert.ToInt32(s.a + s.b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(1);
            s++;
            Console.WriteLine(s.ToString());

            Rectangle r = new Rectangle(4,3);
            Console.WriteLine(r.ToString());

            Square s2 = (Square)r;
            Rectangle r2 = (Rectangle)s2;
            Console.WriteLine(r2.ToString());

            int r3 = (int)r2;
            Console.WriteLine(r3);

            int s3 = (int)s2;
            Console.WriteLine(s3);
        }
    }
}
