
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
        [Display(Name="taraara")]
        public string Hersteller { get; set; }
        public string Lieferant_1 { get; set; }
        public string Lieferant_2 { get; set; }
        public string Lieferant_3 { get; set; }
        public string Lieferant_4 { get; set; }
        public string Lieferant_5 { get; set; }
        public string Lieferant_6 { get; set; }
        public string Lieferant_7 { get; set; }

        public string PositionsName { get; set; }
        public string KurzName { get; set; }
        public string LangName { get; set; }
        public string Kategorie { get; set; }
        public string HerstellerArtikelNummer { get; set; }
        public string LieferantenArtikelNummer_1 { get; set; }
        public string LieferantenArtikelNummer_2 { get; set; }
        public double EinheitsPreis_1_Netto { get; set; }
        public double EinheitsPreis_2_Netto { get; set; }
        public string PE { get; set; }
        public string VPE { get; set; }
        public string Einheit { get; set; }
		public double Rabatt { get; set; }
        public double RabattierterNettoPreis { get; set; }
        public string AlternativArtikelNummer { get; set; }
        public double VK_10 { get; set; }
        public double VK_15 { get; set; }
        public double VK_20 { get; set; }
        public string Bemerkungen { get; set; }
        public string InternerLink { get; set; }
        public string ExternerLink { get; set; }
        public double Hoehe { get; set; }
        public double Breite { get; set; }
        public double Tiefe { get; set; }
        public double UmgebungstemperaturBetrieb { get; set; }
        public string LieferZeit { get; set; }
		public string QStatus { get; set; }
        public string LagerPlatz { get; set; }
       
    }
}