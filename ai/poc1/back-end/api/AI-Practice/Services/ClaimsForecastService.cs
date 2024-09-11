using AI_Practice.Helpers;
using AI_Practice.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace AI_Practice.Services
{
    public class ClaimsForecastService : IClaimsForecastService
    {
        private readonly OnnxModelLoader _modelLoader;

        public ClaimsForecastService()
        {  
            _modelLoader = new OnnxModelLoader(Path.Combine(Directory.GetCurrentDirectory(), "onnx\\model.onnx"));
        }

        public ClaimPrediction Predict(WeatherInput input)
        {
            try
            {
                if (input.BrightonWeatherInput.Length != 16 || input.LondonWeatherInput.Length != 16)
                {
                    throw new ArgumentException($"Inputs must have a length of 16.");
                }

                float brightonClaimPrediction = input.BrightonWeatherInput.Length == 0 ? 0 : _modelLoader.Predict(input.BrightonWeatherInput);
                float londoneClaimPrediction = input.LondonWeatherInput.Length == 0 ? 0 : _modelLoader.Predict(input.LondonWeatherInput);

                ClaimPrediction claimPrediction = new ClaimPrediction { BrightonPredictedClaims = (int)MathF.Ceiling(brightonClaimPrediction), LondonPredictedClaims = (int)MathF.Ceiling(londoneClaimPrediction) };
                return claimPrediction;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
