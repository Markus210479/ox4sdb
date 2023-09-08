
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ox4sDatabase.Shared
{
    [Serializable]
    public class Article
    {
        [Key]
        public Guid Id { get; set; }

        public string Hersteller { get; set; }

        [Display(Name = "Lieferant 1")]
        public string Lieferant_1 { get; set; }

        [Display(Name = "Lieferant 2")]
        public string Lieferant_2 { get; set; }

        [Display(Name = "Lieferant 3")]
        public string Lieferant_3 { get; set; }

        [Display(Name = "Lieferant 4")]
        public string Lieferant_4 { get; set; }

        [Display(Name = "Lieferant 5")]
        public string Lieferant_5 { get; set; }

        [Display(Name = "Lieferant 6")]
        public string Lieferant_6 { get; set; }

        [Display(Name = "Lieferant 7")]
        public string Lieferant_7 { get; set; }

        [Display(Name = "Positionsname")]
        public string PositionsName { get; set; }

        [Display(Name = "Kurzname")]
        public string KurzName { get; set; }

        [Display(Name = "Langname")]
        public string LangName { get; set; }
        public string Kategorie { get; set; }

        [Display(Name = "Herstellerartikelnummer")]
        public string HerstellerArtikelNummer { get; set; }

        [Display(Name = "Lieferantenartikelnummer 1")]
        public string LieferantenArtikelNummer_1 { get; set; }

        [Display(Name = "Lieferantenartikelnummer 2")]
        public string LieferantenArtikelNummer_2 { get; set; }

        [Display(Name = "Einheitspreis 1 netto")]
        public double EinheitsPreis_1_Netto { get; set; }

        [Display(Name = "Einheitspreis 2 netto")]
        public double EinheitsPreis_2_Netto { get; set; }

        public string PE { get; set; }

        public string VPE { get; set; }
        
        public string Einheit { get; set; }
		
        public double Rabatt { get; set; }

        [Display(Name = "rabattierter Nettopreis")]
        public double RabattierterNettoPreis { get; set; }

        [Display(Name = "alternative Artikelnummer")]
        public string AlternativArtikelNummer { get; set; }

        public double VK_10 { get; set; }

        public double VK_15 { get; set; }

        public double VK_20 { get; set; }

        public string Bemerkungen { get; set; }

        [Display(Name = "interner Link")]
        public string InternerLink { get; set; }

        [Display(Name = "externer Link")]
        public string ExternerLink { get; set; }

        [Display(Name = "Höhe")]
        public double Hoehe { get; set; }

        public double Breite { get; set; }
        public double Tiefe { get; set; }

        [Display(Name = "Umgebungstemperatur Betrieb")]
        public double UmgebungstemperaturBetrieb { get; set; }

        [Display(Name = "Lieferzeit")]
        public string LieferZeit { get; set; }

        [Display(Name = "Q-Status")]
        public string QStatus { get; set; }

        public string LagerPlatz { get; set; }
       
    }
}