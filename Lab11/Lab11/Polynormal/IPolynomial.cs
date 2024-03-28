﻿//Описать интерфейс IPolinomial, соответствующий многочленам. Он должен содержать методы IsAbove и IsBelow, проверяющие, является ли 
//указанная точка на плоскости строго выше или ниже графика многочлена соответственно.
//Описать классы Linear и Quadratic, реализующие этот интерфейс. Параметры многочленов должны задаваться при создании экземпляров.
//Написать метод IsBetween, принимающий два многочлена и координаты точки и проверяющий, находится ли точка выше первого и ниже 
//второго многочлена.
//Написать программу, использующую этот метод.
namespace Lab11.Polynormal
{
    internal interface IPolynomial
    {
        public bool IsAbove(Point point);
        public bool IsBelow(Point point);
    }
}
