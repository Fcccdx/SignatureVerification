using SignatureVerification;
using SigStat.Common;
using SigStat.Common.Framework.Samplers;
using SigStat.Common.Loaders;
using SigStat.Common.Model;
using SigStat.Common.PipelineItems.Transforms.Preprocessing;
using System;
using System.Collections.Generic;

namespace Temalabor2021
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadSignaturesExample();
            //UseBenchmarkExample();
        }

        /*
        private static void UseBenchmarkExample()
        {
            Console.WriteLine("C:/Users/nemet/Downloads/SVC2004.zip");
            var path = Console.ReadLine();

            var benchmark = new VerifierBenchmark()
            {
                Loader = new Svc2004Loader(path, true),
                Verifier = new Verifier()
                {
                    Classifier = new SegmentDTW() //értelemszerűen a saját, általatok létrehozott osztályozó
                    {
                        Features1 = new List<FeatureDescriptor>() { ExtraFeatures.Xdif, ExtraFeatures.Ydif, ExtraFeatures.Pdif, ExtraFeatures.Sin, ExtraFeatures.Cos }
                    }
                },
                Sampler = new FirstNSampler()
            };

            BenchmarkResults result = benchmark.Execute(true);

            Console.WriteLine($"AER: {result.FinalResult.Aer}");
            Console.WriteLine($"FAR: {result.FinalResult.Far}");
            Console.WriteLine($"FRR: {result.FinalResult.Frr}");
        }
        */
        private static void LoadSignaturesExample()
        {
            Console.WriteLine("C:/Users/nemet/Downloads/SVC2004.zip");
            var path = Console.ReadLine();
            Svc2004Loader loader = new Svc2004Loader(path, true);
            var signers = new List<Signer>(loader.EnumerateSigners());
            var signaturesOfUser1 = signers[0].Signatures;
            var signature = signaturesOfUser1[0];

            Console.WriteLine($"A(z) {signature.Signer.ID}. aláíró {signature.ID}. aláírása:");
            Console.WriteLine("X \t Y \t P \t T \t");

            var x = signature.GetFeature(Features.X);
            var y = signature.GetFeature(Features.Y);
            var t = signature.GetFeature(Features.T);
            var p = signature.GetFeature(Features.Pressure);
            var xdif = signature.GetFeature(ExtraFeatures.Xdif);

            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"{x[i]} \t {y[i]} \t {p[i]} \t {t[i]} \t {xdif[i]}");
            }
        }
    }
}