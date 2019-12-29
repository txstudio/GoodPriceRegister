using GoodPriceApi.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodPriceApi.Services
{
    public sealed class GoodPriceService
    {
        private readonly GoodPriceContext _context;

        public GoodPriceService(GoodPriceContext context)
        {
            this._context = context;

            if(this._context.Goods.Count() == 0)
            {
                this._context.Goods.Add(
                    new Good() { Id = 1, Name = "Microsoft Surface Pro 7", Price = 71500M }
                );
                this._context.Goods.Add(
                    new Good() { Id = 2, Name = "Google Pixel 3", Price = 21500M }
                );
                this._context.Goods.Add(
                    new Good() { Id = 3, Name = "Apple Macbook", Price = 61500M }
                );
                this._context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Good>> GetListAsync()
        {
            return await this._context.Goods.ToListAsync();
        }

        public async Task<Good> GetAsync(int Id)
        {
            return await this._context.Goods.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<int> CreateAsync(Good good)
        {
            await this._context.Goods.AddAsync(good);
            await this._context.SaveChangesAsync();

            return good.Id;
        }

        public async Task<bool> UpdateAsync(Good good)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Good>> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
