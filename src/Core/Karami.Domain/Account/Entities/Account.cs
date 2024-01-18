#pragma warning disable CS0649

using Karami.Core.Domain.Contracts.Abstracts;
using Karami.Core.Domain.Enumerations;

namespace Karami.Domain.Service.Entities;

public class Account : Entity<string>
{
    //Value Objects

    /*---------------------------------------------------------------*/
    
    //Relations

    /*---------------------------------------------------------------*/

    //EF Core
    private Account() {}

    /*---------------------------------------------------------------*/
    
    //Behaviors

    /// <summary>
    /// 
    /// </summary>
    public void Active()
    {
        IsActive = IsActive.Active;
        
        /*AddEvent(
            new AccountActived {
                Id = Id ,
                IsActive = IsActive == IsActive.Active,
                UpdatedAt_EnglishDate = 
            }
        );*/
    }
    
    /// <summary>
    /// 
    /// </summary>
    public void InActive()
    {
        IsActive = IsActive.InActive;
        
        /*AddEvent(
            new TemplateInActived {
                Id       = Id ,
                IsActive = IsActive == IsActive.Active
            }
        );*/
    }
}