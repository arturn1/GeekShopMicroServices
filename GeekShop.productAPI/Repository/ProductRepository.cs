
using AutoMapper;
using GeekShop.ProductAPI.Context;
using GeekShop.ProductAPI.Data.ValueObjects;
using GeekShop.ProductAPI.Models;
using GeekShop.ProductAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public ProductRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<ProductEntity> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(Guid id)
        {
            ProductEntity product =
                await _context.Products.Where(p => p.Id == id)
                .FirstAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO vo)
        {
            ProductEntity product = _mapper.Map<ProductEntity>(vo);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<ProductVO> Update(ProductVO vo)
        {
            ProductEntity product = _mapper.Map<ProductEntity>(vo);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                ProductEntity product =
                await _context.Products.Where(p => p.Id == id)
                    .FirstAsync();
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
