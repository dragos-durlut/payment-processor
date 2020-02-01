﻿using System.Threading.Tasks;

namespace PaymentProcessor.Models.Entity.Repository
{
    public interface IPaymentRepository
    {
        Task<Payment> GetById(long id);
    }
}