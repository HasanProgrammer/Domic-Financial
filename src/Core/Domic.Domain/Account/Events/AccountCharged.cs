using Domic.Core.Domain.Attributes;
using Domic.Core.Domain.Contracts.Abstracts;
using Domic.Core.Domain.Enumerations;

namespace Domic.Domain.Account.Events;

[EventConfig(ExchangeType = Exchange.FanOut, Exchange = "Financial_Account_Exchange")]
public class AccountCharged : UpdateDomainEvent<string>
{
    public long Value { get; init; }
}