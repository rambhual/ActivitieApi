using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Activities.Domain.Entities;
using Activities.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var customer = new Customer();
            context.Customers.Add(customer);
            Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
