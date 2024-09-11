using AI_Practice
.Models;
namespace AI_Practice.Services
{
    public interface IClaimsForecastService
    {
        public ClaimPrediction Predict(WeatherInput weatherInput);
    }
}
