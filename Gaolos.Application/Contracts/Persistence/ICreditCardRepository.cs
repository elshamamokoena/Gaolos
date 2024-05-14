using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface ICreditCardRepository
    {
        Task<IEnumerable<CreditCard>> GetCreditCardsForUserAsync(Guid userId);
        Task<CreditCard> GetCreditCardAsync(Guid userId ,Guid creditCardId);
        Task<CreditCard> GetPrimaryCreditCardAsync(Guid userId);
        void AddCreditCard(CreditCard creditCard);
        void UpdateCreditCard(CreditCard creditCard);
        void DeleteCreditCard(CreditCard creditCard);
        Task<bool> CreditCardExistsAsync(Guid creditCardId);
        Task<bool> SaveAsync();
    }
}
