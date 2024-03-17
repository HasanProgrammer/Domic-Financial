#pragma warning disable CS0649

using Domic.Core.Domain.Contracts.Abstracts;
using Domic.Core.Domain.Contracts.Interfaces;
using Domic.Core.Domain.ValueObjects;
using Domic.Domain.Commons.ValueObjects;
using Domic.Domain.Transaction.Enumerations;
using Domic.Domain.Transaction.Events;

namespace Domic.Domain.Transaction.Entities;

public class Transaction : Entity<string>
{
    public string AccountId { get; private set; }
    public string TransactionId { get; private set; }
    public TransactionType TransactionType { get; private set; }
    
    /*---------------------------------------------------------------*/
    
    //Value Objects
    
    public Amount IncreasedAmount { get; private set; }
    public Amount DecreasedAmount { get; private set; }

    /*---------------------------------------------------------------*/
    
    //Relations
    
    public Account.Entities.Account Account { get; set; }
    
    public Transaction Parent { get; set; }

    /*---------------------------------------------------------------*/

    //EF Core
    private Transaction() {}
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="globalUniqueIdGenerator"></param>
    /// <param name="dateTime"></param>
    /// <param name="accountId"></param>
    /// <param name="transactionId"></param>
    /// <param name="increasedAmount"></param>
    /// <param name="decreasedAmount"></param>
    /// <param name="transactionType"></param>
    /// <param name="createdBy"></param>
    /// <param name="createdRole"></param>
    public Transaction(IGlobalUniqueIdGenerator globalUniqueIdGenerator, IDateTime dateTime, string accountId,
        string transactionId, long? increasedAmount, long? decreasedAmount, TransactionType transactionType, 
        string createdBy, string createdRole
    )
    {
        var uniqueId = globalUniqueIdGenerator.GetRandom(6);
        var nowDateTime = DateTime.Now;
        var nowPersianDateTime = dateTime.ToPersianShortDate(nowDateTime);

        Id = uniqueId;
        AccountId = accountId;
        TransactionId = transactionId;
        CreatedBy = createdBy;
        CreatedRole = createdRole;
        
        if(increasedAmount is not null)
            IncreasedAmount = new Amount(increasedAmount);
        
        if(decreasedAmount is not null)
            DecreasedAmount = new Amount(decreasedAmount);
        
        CreatedAt = new CreatedAt(nowDateTime, nowPersianDateTime);
        
        AddEvent(
            new TransactionCreated {
                Id = uniqueId,
                AccountId = accountId,
                TransactionId = transactionId,
                TransactionType = transactionType,
                IncreasedAmount = increasedAmount,
                DecreasedAmount = decreasedAmount,
                CreatedBy = createdBy,
                CreatedRole = createdRole,
                CreatedAt_EnglishDate = nowDateTime,
                CreatedAt_PersianDate = nowPersianDateTime
            }
        );
    }

    /*---------------------------------------------------------------*/
    
    //Behaviors
}