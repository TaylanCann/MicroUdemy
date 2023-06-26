using FreeCourse.Services.Basket.Dtos;
using FreeCourse.Shared.Dtos;
using System.Text.Json;

namespace FreeCourse.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> Delete(int userId)
        {
           var status = await _redisService.GetDb().KeyDeleteAsync(userId.ToString());
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket not found",404);
        }

        public async Task<Response<BasketDto>> GetBasket(int userId)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(userId.ToString());

            if (String.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDto>.Fail("Basket not found",404);
            }

            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket),200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketDto)
        {
            var status = await _redisService.GetDb().StringSetAsync(basketDto.UserId.ToString(), JsonSerializer.Serialize(basketDto));
            
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket could not update or save",500);
        }
    }
}
