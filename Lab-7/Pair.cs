using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;


class Pair
  {
     protected double _first;
     protected double _second;

     public Pair(double initFirst, double initSecond)
     {
         _first = initFirst;
         _second = initSecond;
     }

     public double First
     {
         get
         {
             return _first;
         }
         set
         {
             _first = value;
         }
     }
     public double Second
     {
         get
         {
             return _second;
         }
         set
         {
             _second = value;
         }
     }
     public bool Compare(Pair value)
     {
         if (First > value.First || (First == value.First && Second > value.Second)) return true;
         else return false;
     }
     public bool Compare(int firstNumber, int secondNumber)
     {
         if (First > firstNumber || (First == firstNumber && Second > secondNumber)) return true;
         else return false;
     }
 }

