using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities.UserAccount;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly GaolosDbContext _context;


        public CreditCardRepository(GaolosDbContext context)
        {
            _context = context;
        }
        public void AddCreditCard(CreditCard creditCard)
        {
            if (creditCard == null) throw new ArgumentNullException(nameof(creditCard));

            creditCard.CreditCardId = Guid.NewGuid();
            _context.CreditCards.Add(creditCard);
        }

     

        public Task<CreditCard> GetCreditCardAsync(Guid userId, Guid creditCardId)
        {
            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            if (creditCardId == Guid.Empty) throw new ArgumentNullException(nameof(creditCardId));

        #pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
            return _context.CreditCards
                .FirstOrDefaultAsync(c => c.UserId == userId && c.CreditCardId == creditCardId);
        #pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
        }

        public async Task<IEnumerable<CreditCard>> GetCreditCardsForUserAsync(Guid userId)
        {
            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            return await _context.CreditCards.Where(c => c.UserId == userId).ToListAsync();
        }

        public void DeleteCreditCard(CreditCard creditCard)
        {
            _context.CreditCards.Remove(creditCard);
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void UpdateCreditCard(CreditCard creditCard)
        {
            //no code 
        }

        public async Task<bool> CreditCardExistsAsync(Guid creditCardId)
        {
            if (creditCardId == Guid.Empty) throw new ArgumentNullException(nameof(creditCardId));
            return await _context.CreditCards.AnyAsync(c => c.CreditCardId == creditCardId);
        }

        public Task<CreditCard> GetPrimaryCreditCardAsync(Guid userId)
        {
            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));

        #pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
            return _context.CreditCards
                .FirstOrDefaultAsync(c => c.UserId == userId && c.isPrimary);
        #pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
        }
    }
}
