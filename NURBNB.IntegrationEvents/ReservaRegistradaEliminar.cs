using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
	public class ReservaRegistradaEliminar
	{
		public Guid ReservaId { get; set; }
		public DateTime FechaLlegada { get; private set; }
		public DateTime FechaSalida { get; private set; }
		public DateTime GuestId { get; private set; }
	}
}
