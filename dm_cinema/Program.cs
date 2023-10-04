// See https://aka.ms/new-console-template for more information

using dm_cinema;
Acteur monActeur = new Acteur(1942, "1A", "Ford ", "Harisson ");
Film monFilm = new Film(1982, "Science-Fiction","1SF", ": L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner",monActeur);


Console.WriteLine(monFilm.ToString());