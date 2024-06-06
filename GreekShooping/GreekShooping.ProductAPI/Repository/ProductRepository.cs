﻿using AutoMapper;
using GreekShooping.ProductAPI.Data.ValueObjects;
using GreekShooping.ProductAPI.Model;
using GreekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GreekShooping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly PostgreSQLContext _context;
        private IMapper _mapper;

        public ProductRepository(PostgreSQLContext Context, IMapper Mapper)
        {
            _context = Context;
            _mapper = Mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();

            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();

            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO vo)
        {
            Product product = _mapper.Map<Product>(vo);

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Update(ProductVO vo)
        {
            Product product = _mapper.Map<Product>(vo);

            _context.Products.Update(product);

            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                
                if (product == null) return false;

                _context.Products.Remove(product);
                
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
