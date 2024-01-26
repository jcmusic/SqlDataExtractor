using System.Data;
using System;

namespace YuStashSageX3_ETL.Models
{
    public interface ICreatable<T>
    {
        T Create(IDataRecord record, Guid transactionId);
    }
}