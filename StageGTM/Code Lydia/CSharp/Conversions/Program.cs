using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat500 = new Auto();
            if (fiat500 is Auto) Console.WriteLine("La fiat500 est une auto");
            if (fiat500 is vehicule) Console.WriteLine("La fiat500 est un véhiecule");
            if (fiat500 is Moto) Console.WriteLine("La fiat500 n'est pas une moto");

            vehicule porche = new Auto();// a cause de l'héritage porch est déclarée comme un véhicule et se comporte comme un auto, mais s'en est as une

            ((Auto)porche).Rouler();           //conversion 1: conversion en Auto 
            Auto a = porche as Auto;           //conversion 2: si la conversion n'est pas possible a=null
            string s = porche.ToString();      //conversion 3: une méthode 
                                               // int.Parse //convertir une chaine de caractère en entier
                                               //  Convert.ToDateTime(DateTime.Now); //convertir un string en decimal
           DateTime d = Convert.ToDateTime("11/12/2017"); //conversion 4

            Console.Read();
        }
    }
    class Auto : vehicule
    {
        public void Rouler() { Console.WriteLine("L'auto roule"); }
    }
    class vehicule { }
    class Moto : vehicule { }

}
