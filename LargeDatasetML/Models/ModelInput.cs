using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LargeDatasetML.Models
{
    public class ModelInput
    {
        [ColumnName("WBC"), LoadColumn(0)]
        public float WBC { get; set; }


        [LoadColumn(1, 175)]
        [VectorType(175)]
        public float[] FeatureVector;
    }
}
