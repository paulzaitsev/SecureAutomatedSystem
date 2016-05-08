using System;
using System.Threading.Tasks;
using System.Security.Cryptography;
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem.ProcessEmulation{
    public class Emulator {
        private float delay;

        public float ProducerDelay {
            get { return delay; }
            set {
                if (value < 1)
                    delay = 1;
                else
                    delay = value;
            }
        }

        public bool SaveInDB { get; set; }
        public bool EncryptData { get; set; }
        public bool InWork { get; private set; }
        public Product CurrentProduct { get; private set; }
        public Product Benchmark { get; private set; }
        private static readonly Product DefaultBenchmark = new Product(10, 5, 10, 5, 7, 7, 7, 10, 10, 8);
        public EventHandler ProductProduced;

        public Emulator() : this(1, false, false, DefaultBenchmark) {
        }

        public Emulator(float Delay, bool ProducerSaveInDB, bool ProducerEncryptData, Product ProductBenchmark) {
            ProducerDelay = Delay;
            SaveInDB = ProducerSaveInDB;
            EncryptData = ProducerEncryptData;
            Benchmark = ProductBenchmark;
            AppRunner.EncryptionKey = "";
        }

        public async void StartProducing() {
            InWork = true;
            Random rnd = new Random(DateTime.Now.Millisecond);
            while (InWork) {
                CurrentProduct = ProduceNewProduct(rnd);
                ProductProduced(this, EventArgs.Empty);
                if (SaveInDB) {
                    SaveData();
                }
                await Task.Delay((int) ProducerDelay*1000);
            }
        }

        public void StopProducing() {
            InWork = false;
        }

        private Product ProduceNewProduct(Random randomGeneratorVariable) {
            float outerDiameter = Benchmark.OuterDiameter + (float)((randomGeneratorVariable.Next(100)-50.0)/50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float outerRadius = outerDiameter / 2; 
            float innerDiameter = Benchmark.InnerDiameter + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float innerRadius = innerDiameter / 2; 
            float outerPairingRadius = Benchmark.OuterPairingRadius + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float wallThickness = Benchmark.WallThickness + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float topThickness = Benchmark.TopThickness + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float bottomLowersectionHeight = Benchmark.BottomLowersectionHeight + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2; 
            float topDiameter = Benchmark.TopDiameter + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2;
            float outerPairingRadiusCyl = Benchmark.OuterPairingRadiusCyl + (float)((randomGeneratorVariable.Next(100) - 50.0) / 50.0) + (float)randomGeneratorVariable.NextDouble()/2;

            return new Product(outerDiameter, outerRadius, innerDiameter, innerRadius, outerPairingRadius, wallThickness, topThickness, bottomLowersectionHeight, topDiameter, outerPairingRadiusCyl);
        }

        private void SaveData() {
            if (!EncryptData || AppRunner.EncryptionKey.Length != 8) {
                DBUtils.PullNewProduct(CurrentProduct);
            }
            else {
                DBUtils. PullNewProductWithEnctyprion(CurrentProduct, AppRunner.EncryptionKey);
            }            
        }
    }
}
