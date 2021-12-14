﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_5
{
    class Triad
    {
        int one;//первое число
        int second;//второе число
        int third;//третье число
        public int One //Первое число
        {
            get
            {
                return one;
            }
            set
            {
                one = value;

            }
        }

        public int Second //Второе число
        {
            get
            {
                return second;
            }
            set
            {
                second = value;

            }
        }
        public int Third //Третье число
        {
            get
            {
                return third;
            }
            set
            {
                third = value;

            }
        }
        public Triad Plus1(int One, int Second, int Third)
        {
            Triad plus = new Triad();

            {
                plus.One = One + 1;
                plus.Second = Second + 1;
                plus.Third = Third + 1;

            }
            return plus;
        }

        public static Triad operator ++(Triad c1)
        {
            Triad rezult = new Triad();
            rezult.One = c1.One + 1;
            rezult.Second = c1.Second + 1;
            rezult.Third = c1.Third + 1;
            return rezult;
        }
        public static Triad operator +(Triad c1, int val)
        {
            Triad rezult = new Triad();
            rezult.One = c1.One + c1.Second + c1.Third + val;
            return rezult;
        }
    }
}
//        public bool SetParams()
//        {
//            {
//                One = One + 10;
//                Second = Second + 10;
//                Third = Third + 10;
//                return true;
//            }
//        }
//        public void SetParams(int One, int Second, int Third, out string _rez1)
//        {
//            int _One = 0;
//            int _Second = 0;
//            int _Third = 0;
//            _rez1 = null;

//            if (One != 0)
//            {
//                _One = One + 10;
//            }
//            else _One = 0;
//            if (Second != 0)
//            {
//                _Second = Second + 10;
//            }
//            else _Second = 0;
//            if (Third != 0)
//            {
//                _Third = Third + 10;
//            }
//            else _Third = 0;
//            _rez1 = _One.ToString() + ";" + _Second.ToString() + ";" + _Third.ToString();

//        }
//    }
//}

