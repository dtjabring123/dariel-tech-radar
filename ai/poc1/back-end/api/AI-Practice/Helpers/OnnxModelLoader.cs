using AI_Practice.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System.Collections.Generic;

namespace AI_Practice.Helpers
{
    public class OnnxModelLoader
    {
        private InferenceSession _session;

        public OnnxModelLoader(string modelPath)
        {
            _session = new InferenceSession(modelPath);
        }

        public float Predict( float[] input)
        {
            var normalizedImput = Normalize(input);
            var inputTensor = normalizedImput.ToTensor();
        
            var unsqueezedTensor = inputTensor.Reshape([1, input.Length]);


            var output = _session.Run(ConvertTensorToNamedOnnxValue(unsqueezedTensor, "onnx::Unsqueeze_0"));
            var prediction = output[0].AsEnumerable<float>().First();

            return prediction < 0 ? 0 : prediction;
        }

        public IReadOnlyCollection<NamedOnnxValue> ConvertTensorToNamedOnnxValue(Tensor<float> tensor, string inputName)
        {
            var namedOnnxValue = NamedOnnxValue.CreateFromTensor(inputName, tensor);
            return new List<NamedOnnxValue> { namedOnnxValue };
        }

        public float[] Normalize(float[] vector)
        {
            double norm = Math.Sqrt(vector.Sum(x => x * x));
            return vector.Select(x => (float)(x / norm)).ToArray();
        }
    }
}
