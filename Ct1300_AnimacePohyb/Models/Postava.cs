namespace Ct1300_AnimacePohyb.Models
{
	public class Postava
	{
		public Postava(string jmeno, int width, string obrazek)
		{
			Jmeno = jmeno;
			Width = width;
			Obrazek = obrazek;
		}
		#region Atributy
		public string Jmeno { get; }
		public int Width { get; }
		public string Obrazek { get; }

		private List<Souradnice> SouradniceList { get; set; } = new List<Souradnice>();


		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, int pruhlednost, int velikostObrProcenta)
		{
			var souradnice = new Souradnice(pozX, pozY, pruhlednost, velikostObrProcenta);
			SouradniceList.Add(souradnice);
		}
		#endregion
	}
}
