using MiniBank.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using MiniBank.Repository.Interfaces;

namespace MiniBank.Repository
{
    public class SqlClientCustomerRepository : Repositroy<Customer>, ICustomerRepository
    {
        public SqlClientCustomerRepository() : base("Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCMFH20NC;Trusted_Connection=true;TrustServerCertificate=true")
        {
        }
    }
}
