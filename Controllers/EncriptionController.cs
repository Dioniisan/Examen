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
			 string mensajes = "mensaje encriptado: " + cifra.encriptar(mensaje, pokemon) + " mensaje desencriptado " + cifra.desencriptar(mensaje, pokemon);

			return Ok(mensajes.ToString());
		}
	}
}
