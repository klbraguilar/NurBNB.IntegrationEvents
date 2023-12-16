using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
	public class CheckOutFinalizado
	{
		public Guid GuestId { get; set; }
		public Guid ReservaId { get; set; }
		public string ComentarioHuesped { get; set; }
		public DateTime FechaSalida { get; set; }
		public string Calificacion { get; set; }

	}
}
