using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing tickets
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Id of ticket.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Ticket's availability.
        /// </summary>
        public int Availability { get; set; }

        /// <summary>
        /// Ticket's cost.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Releted review id.
        /// </summary>
        public long Review_id { get; set; }

        /// <summary>
        /// Related passenger id.
        /// </summary>
        public long Passenger_id { get; set; }

        /// <summary>
        /// Related seat id.
        /// </summary>
        public long Seat_id { get; set; }

        /// <summary>
        /// Related route id.
        /// </summary>
        public long Route_id { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id">Id of ticket to be created.</param>
        /// <param name="availability">Availability of created tickets.</param>
        /// <param name="cost">Cost of ticket to be created.</param>
        /// <param name="review_id">Related review's id.</param>
        /// <param name="passenger_id">Related passanger's id.</param>
        /// <param name="seat_id">Realated seat's id.</param>
        /// <param name="route_id">Related route's id.</param>
        public Ticket( long id, int availability, double cost, long review_id, long passenger_id, long seat_id, long route_id)
        {
            Id = id;
            Availability = availability;  
            Cost = cost;
            Review_id = review_id;
            Passenger_id = passenger_id;
            Seat_id = seat_id;
            Route_id = route_id;
        }
    }
}
