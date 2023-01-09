﻿namespace LaMiaPizzeriaModel.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Prezzo { get; set; }


        public Pizza(int id, string name, string description, string image, int prezzo)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Prezzo = prezzo;
        }
    }
}