using ClearArchitecture.Domain.Primitives;
using ClearArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearArchitecture.Domain.Customers
{
    public sealed class Customer : AggregateRoot
    {
        public Customer() { }

        public Customer(Guid id, string name, string lastName, string email, PhoneNumber phoneNumber, Address address, bool active)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Active = active;
        }

        public Guid Id { get; private set; } //Can only be changed within this class
        public string Name { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string FullName => $"{Name} {LastName}";
        public string Email { get; private set; } = string.Empty;
        public PhoneNumber PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public bool Active {  get; private set; }
    }
}
