﻿//
// Домашнее задание к занятию 13. Наследование.
//
// Задача 1. Задан класс Building, который описывает здание. Класс содержит следующие элементы:
// - адрес здания;
// - длина здания;
// - ширина здания;
// - высота здания.
//
// В классе Building нужно реализовать следующие методы:
// - конструктор с 4 параметрами;
// - свойства get/set для доступа к полям класса;
// - метод Print(), который выводит информацию о здании.
// 
// Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
// В классе MultiBuilding реализовать следующие элементы:
// - конструктор с 5 параметрами – реализует вызов конструктора базового класса
// - свойство get/set доступа к внутреннему полю класса;
// - метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
// 
// Класс MultiBuilding сделать таким, что не может быть унаследован.

using DZ13;
Building building = new Building("Москва",-12,12,9);
Console.WriteLine(building.Print());
Console.WriteLine();
MultiBuilding multiBuilding = new MultiBuilding ("Санкт-Петербург", 80, 18, 12, 12);
Console.WriteLine(multiBuilding.Print());
Console.ReadKey();

