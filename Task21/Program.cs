﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату точки А по оси Х:  ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки А по оси Y: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки А по оси Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Х: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Y: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));

Console.WriteLine("Расстояние между точками A и B = " + Math.Round(distance, 2));