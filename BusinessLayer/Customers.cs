using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class Customers
    {
        public IEnumerable<CustomersModel> Customer
        {
            get
            {
                List<CustomersModel> customers = new List<CustomersModel>();
                using (SqlConnection conn = new SqlConnection("Server = pc_babulale\\sqlexpress; database = RicoBarber; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllCustomers", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CustomersModel customer = new CustomersModel();
                        customer.CustomerId = Convert.ToInt32(rdr["CustomerId"]);
                        customer.CustomerName = rdr["CustomerName"].ToString();
                        customer.CustomerGender = rdr["CustomerGender"].ToString();
                        customer.DateCreated = (DateTime)rdr["DateCreated"];

                        customers.Add(customer);
                    }
                    
                }
                return customers;
            }
        }
    }
}
