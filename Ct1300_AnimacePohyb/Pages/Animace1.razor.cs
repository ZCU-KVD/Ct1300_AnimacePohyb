using Ct1300_AnimacePohyb.Models;

namespace Ct1300_AnimacePohyb.Pages
{
	public partial class Animace1
	{
		protected override void OnInitialized()
		{
			InicializaceHry();
			base.OnInitialized();
		}
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender && Postava != null)
			{
				// Spustí animaci po načtení komponenty
				//Postava?.Presun();
				await Task.Run(Postava.Presun);
				StateHasChanged(); //prekreslení komponenty
			}
			await base.OnAfterRenderAsync(firstRender);
		}

		private Postava? Postava { get; set; }

		private void InicializaceHry()
		{
			Postava = null;
			// Inicializace postavy
			Postava = new Postava("Maxipes", 150, "Img/Pes.png");
			Postava.PridejPozici(pozX: 45, pozY: 300,pruhlednost: 100,velikostObrProcenta: 70);
			Postava.PridejPozici(pozX: 450, pozY: 270, pruhlednost: 100, velikostObrProcenta: 20);
			Postava.PridejPozici(pozX: 840, pozY: 340, pruhlednost: 100, velikostObrProcenta: 80);
			Postava.PridejPozici(pozX: 110, pozY: 430, pruhlednost: 100, velikostObrProcenta: 100);
		}
	}
}
