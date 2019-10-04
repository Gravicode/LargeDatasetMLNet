using LargeDatasetML.Models;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;

namespace LargeDatasetML
{
    public class ConsumeModel
    {
        // For more info on consuming ML.NET models, visit https://aka.ms/model-builder-consume
        // Method for consuming model in your app
        public static ModelOutput Predict(ModelInput input)
        {

            // Create new MLContext
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            string modelPath = AppDomain.CurrentDomain.BaseDirectory + "MLModel.zip";
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Use model to make prediction on input data
            ModelOutput result = predEngine.Predict(input);
            return result;
        }
    }
}
