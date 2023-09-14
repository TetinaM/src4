using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data
{
    public class Hotel
    {
        private List<Room> rooms;
        private List<Reservation> reservations;

        public Hotel()
        {
            rooms = new List<Room>();
            reservations = new List<Reservation>();
        }


        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        // Метод для создания новой резервации
        public void MakeReservation(string guestName, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            // Поиск комнаты по номеру
            Room room = rooms.Find(r => r.RoomNumber == roomNumber);

            if (room != null && room.IsAvailable)
            {
                // Создание новой резервации
                Reservation reservation = new Reservation(guestName, room, checkInDate, checkOutDate);
                reservations.Add(reservation);

                // Установка статуса комнаты на "забронирована"
                room.IsAvailable = false;

                Console.WriteLine($"Резервация для {guestName} на комнату {roomNumber} успешно создана.");
            }
            else
            {
                Console.WriteLine($"Комната {roomNumber} недоступна или не существует.");
            }
        }

        // Метод для проверки доступности комнат на определенные даты
        public List<Room> CheckAvailability(DateTime checkInDate, DateTime checkOutDate)
        {
            List<Room> availableRooms = new List<Room>();

            foreach (Room room in rooms)
            {
                if (room.IsAvailable)
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }

       
    }
}
