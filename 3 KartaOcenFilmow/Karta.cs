﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_KartaOcenFilmow
{
    internal class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }

        // Stan (zmienne - pola)
        List<float> oceny;

        //  Zachowania (metody)

        /// <summary>
        /// Dodaje nową ocene do listy ocen
        /// </summary>
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }

        /// <summary>
        /// Obliczanie sredniej z listy ocen
        /// </summary>
        /// <returns>srednia ocena</returns>

        public float ObliczSrednia()
        {
            float suma = 0;
            float srednia = 0;
            foreach (var ocena in oceny)
            {
                suma += ocena;
            }

            srednia = suma / oceny.Count;

            return srednia;

           // return oceny.Average();

        }

        /// <summary>
        /// Dostajemy najmniesza ocene
        /// </summary>
        /// <returns>najmniejsza ocena</returns>
        public float NajnizszaOcena()
        {
            //float min = float.MaxValue;

            //foreach (var ocena in oceny)
            //{
            //    if (min > ocena)
            //    {
            //        min = ocena;
            //    }
            //}
            //return min;

            return oceny.Min();
        }

        /// <summary>
        /// Dostajemy najwieksza ocene
        /// </summary>
        /// <returns>najwieksza ocena</returns>
        public float NajwyzszaOcena()
        {
           return oceny.Max();
        }

    }
}
