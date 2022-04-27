﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Models
{
    public class SousProduitModel
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string LibelleCommercial { get; set; }
        public DateTime DateEffet { get; set; }
        public string Enseigne { get; set; }
        public ICollection<int>? Risques { get; set; }
        public bool GestionPrestation { get; set; }
        public bool GestionCotisation { get; set; }
        public ICollection<int>? Zones { get; set; }
        public int IdDevise { get; set; }
        public string Description { get; set; }
        public ICollection<int>? Garanties { get; set; }
        public ProduitModel? Produit { get; set; }
        public int? IdProduit { get; set; }
    }
}
 