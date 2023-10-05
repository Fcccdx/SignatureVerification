using SigStat.Common;
using SigStat.Common.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureVerification
{
    class ExtraFeatures : PipelineBase, ITransformation
    {
        public static readonly FeatureDescriptor<List<double>> Xdif = FeatureDescriptor.Get<List<double>>("Xdif");

        public static readonly FeatureDescriptor<List<double>> Ydif = FeatureDescriptor.Get<List<double>>("Ydif");

        public static readonly FeatureDescriptor<List<double>> Pdif = FeatureDescriptor.Get<List<double>>("Pdif");

        public static readonly FeatureDescriptor<List<double>> Sin = FeatureDescriptor.Get<List<double>>("Sin");

        public static readonly FeatureDescriptor<List<double>> Cos = FeatureDescriptor.Get<List<double>>("Cos");

        public List<PipelineInput> PipelineInputs => throw new NotImplementedException();

        public List<PipelineOutput> PipelineOutputs => throw new NotImplementedException();

        public void Transform(Signature signature)
        {
            throw new NotImplementedException();
        }
    }
}
