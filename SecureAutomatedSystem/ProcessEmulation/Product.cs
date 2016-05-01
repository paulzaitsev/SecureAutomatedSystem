namespace SecureAutomatedSystem.ProcessEmulation {
    public class Product {
        public float OuterDiameter { get; private set; }
        public float OuterRadius { get; private set; }
        public float InnerDiameter { get; private set; }
        public float InnerRadius { get; private set; }
        public float OuterPairingRadius { get; private set; }
        public float WallThickness { get; private set; }
        public float TopThickness { get; private set; }
        public float BottomLowersectionHeight { get; private set; }
        public float TopDiameter { get; private set; }
        public float OuterPairingRadiusCyl { get; private set; }

        public Product(float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9,
            float p10) {
            OuterDiameter = p1;
            OuterRadius = p2;
            InnerDiameter = p3;
            InnerRadius = p4;
            OuterPairingRadius = p5;
            WallThickness = p6;
            TopThickness = p7;
            BottomLowersectionHeight = p8;
            TopDiameter = p9;
            OuterPairingRadiusCyl = p10;
        }

        public override string ToString() {
            return string.Format("OuterDiameter = {0} \nOuterRadius = {1} \nInnerDiameter = {2}" +
                                "\nInnerRadius = {3} \nOuterPairingRadius = {4} \nWallThickness = {5}" +
                                "\nTopThickness = {6} \nBottomLowersectionHeight = {7} \nTopDiameter = {8}" +
                                "\nOuterPairingRadiusCylindrical = {9}", OuterDiameter, OuterRadius, InnerDiameter,
                                InnerRadius, OuterPairingRadius, WallThickness, TopThickness, BottomLowersectionHeight,
                                TopDiameter, OuterPairingRadiusCyl);
        }
    }
}
