using _03PC_ShoppingMongo2.DTOs.SliderDTOs;
using _03PC_ShoppingMongo2.Entities;
using _03PC_ShoppingMongo2.Settings;
using AutoMapper;
using MongoDB.Driver;

namespace _03PC_ShoppingMongo2.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;

        public SliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var slider = _mapper.Map<Slider>(createSliderDto);
            await _sliderCollection.InsertOneAsync(slider);
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _sliderCollection.DeleteOneAsync(x => x.SliderId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var sliders = await _sliderCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(sliders);
        }

        public async Task<GetSliderDto> GetSliderByIdAsync(string id)
        {
            var slider = await _sliderCollection.Find(x => x.SliderId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSliderDto>(slider);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var slider = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x => x.SliderId == updateSliderDto.SliderId, slider);
        }
    }
}
