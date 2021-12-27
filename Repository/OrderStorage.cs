using library.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace library.Repository
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public OrderStorage() => Connection.Open();

        public void Create(Order order)
        {
            Orders.Add(order.OrderId, order);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Order Read(int orderId)
        {
            return Orders[orderId];
        }

        public Order Update(int orderId, Order newOrder)
        {
            Orders[orderId] = newOrder;
            return Orders[orderId];
        }

        public bool Delete(int orderId)
        {
            return Orders.Remove(orderId);
        }
    }
}