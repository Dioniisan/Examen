using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CifradoPokemon.Controllers
{
	[ApiController]
	[Route("Examen")]
	public class EncriptionController : ControllerBase
	{

		Cifrado cifra = new Cifrado();

		[HttpPost]
		public IActionResult Post(string mensaje, string pokemon)
		{
			pokemon = RandomNombre.Randomizer();
			string eq = EqualStrings.makeStringEqual(mensaje,pokemon);
			string mensajes = "mensaje encriptado: " + cifra.encriptar(mensaje, eq) + " mensaje desencriptado " + cifra.desencriptar(mensaje, pokemon);

			return Ok(mensajes.ToString());
		}
	}
}
