using static System.Math;
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double x1 = 7;
double y1 = -5;
double z1 = 0;
double x2 = 1;
double y2 = -1;
double z2 = 9;

double A = x2 - x1;
double B = y2 - y1;
double C = z2 - z1;

double result = Sqrt((A * A + B * B + C * C));
Console.WriteLine(result);