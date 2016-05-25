using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SecureAutomatedSystem.ProcessEmulation {
    [Serializable]
    public class Product {
        [XmlAttributeAttribute("outer_diameter")]
        public float OuterDiameter { get; set; }

        [XmlAttributeAttribute("outer_radius")]
        public float OuterRadius { get; set; }

        [XmlAttributeAttribute("inner_diameter")]
        public float InnerDiameter { get; set; }

        [XmlAttributeAttribute("inner_radius")]
        public float InnerRadius { get; set; }

        [XmlAttributeAttribute("outer_pairing_radius")]
        public float OuterPairingRadius { get; set; }

        [XmlAttributeAttribute("wall_thickness")]
        public float WallThickness { get; set; }

        [XmlAttributeAttribute("top_thickness")]
        public float TopThickness { get; set; }

        [XmlAttributeAttribute("bottom_lowersection_height")]
        public float BottomLowersectionHeight { get; set; }

        [XmlAttributeAttribute("top_diameter")]
        public float TopDiameter { get; set; }

        [XmlAttributeAttribute("outer_pairing_radius_cyl")]
        public float OuterPairingRadiusCylindricalOgive { get; set; }

        public Product() { }

        public Product(float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10) {
            OuterDiameter = p1;
            OuterRadius = p2;
            InnerDiameter = p3;
            InnerRadius = p4;
            OuterPairingRadius = p5;
            WallThickness = p6;
            TopThickness = p7;
            BottomLowersectionHeight = p8;
            TopDiameter = p9;
            OuterPairingRadiusCylindricalOgive = p10;
        }

        public void Assign(Product source) {
            if (source != null) {
                this.OuterDiameter = source.OuterDiameter;
                this.OuterRadius = source.OuterRadius;
                this.InnerDiameter = source.InnerDiameter;
                this.InnerRadius = source.InnerRadius;
                this.OuterPairingRadius = source.OuterPairingRadius;
                this.WallThickness = source.WallThickness;
                this.TopThickness = source.TopThickness;
                this.BottomLowersectionHeight = source.BottomLowersectionHeight;
                this.TopDiameter = source.TopDiameter;
                this.OuterPairingRadiusCylindricalOgive = source.OuterPairingRadiusCylindricalOgive;
            }
        }


        public override string ToString() { //?
            return string.Format("OuterDiameter = {0} \nOuterRadius = {1} \nInnerDiameter = {2}" +
                                 "\nInnerRadius = {3} \nOuterPairingRadius = {4} \nWallThickness = {5}" +
                                 "\nTopThickness = {6} \nBottomLowersectionHeight = {7} \nTopDiameter = {8}" +
                                 "\nOuterPairingRadiusCylindrical = {9}", OuterDiameter, OuterRadius, InnerDiameter,
                InnerRadius, OuterPairingRadius, WallThickness, TopThickness, BottomLowersectionHeight,
                TopDiameter, OuterPairingRadiusCylindricalOgive);
        }

        public void DeserializeFromXml(string xmlFileName) {
            XmlSerializer mySerializer = new XmlSerializer(typeof (Product));
            using (FileStream myFileStream = new FileStream(xmlFileName, FileMode.Open)) {
                this.Assign((Product) mySerializer.Deserialize(myFileStream));
            }
        }

        public void SerializeToXml(string xmlFileName) {
            XmlSerializer serializer = new XmlSerializer(typeof (Product));
            using (FileStream fs = new FileStream(xmlFileName, FileMode.OpenOrCreate)) {
                serializer.Serialize(fs, this);
            }
        }
    }
}
