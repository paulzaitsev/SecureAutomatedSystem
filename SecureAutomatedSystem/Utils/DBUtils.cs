using System;
using System.CodeDom;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using SecureAutomatedSystem.Charts.LineCurves;
using SecureAutomatedSystem.ProcessEmulation;

namespace SecureAutomatedSystem.Utils {
    public static class DBUtils {
        private static databaseDataSet dataSet = new databaseDataSet();

        private static databaseDataSetTableAdapters.productTableAdapter productTableAdapter = new databaseDataSetTableAdapters.productTableAdapter();

        delegate string AssignDelgate(float value);

        public static void PullNewProduct(Product newProduct) {
            dataSet.product.AddproductRow(CreateDataRow(newProduct, AssignParameter));
            productTableAdapter.Update(dataSet.product);
        }

        public static void PullNewProductWithEnctyprion(Product newProduct, string key) {
            dataSet.product.AddproductRow(CreateDataRow(newProduct, x => AssignParameter(x, key)));
            productTableAdapter.Update(dataSet.product);
        }

        private static databaseDataSet.productRow CreateDataRow(Product newProduct, AssignDelgate assign) {
            databaseDataSet.productRow newProductRow = dataSet.product.NewproductRow();
            newProductRow.outer_diameter = assign(newProduct.OuterDiameter);
            newProductRow.outer_radius = assign(newProduct.OuterRadius);
            newProductRow.inner_diameter = assign(newProduct.InnerDiameter);
            newProductRow.inner_radius = assign(newProduct.InnerRadius);
            newProductRow.outer_pairing_radius = assign(newProduct.OuterPairingRadius);
            newProductRow.wall_thickness = assign(newProduct.WallThickness);
            newProductRow.top_thickness = assign(newProduct.TopThickness);
            newProductRow.bottom_lowersection_height = assign(newProduct.BottomLowersectionHeight);
            newProductRow.top_diameter = assign(newProduct.TopDiameter);
            newProductRow.outer_pairing_radius_cylindrical_ogive = assign(newProduct.OuterPairingRadiusCylindricalOgive);
            return newProductRow;
        }

        static string AssignParameter(float value) {
            return value.ToString();
        }

        static string AssignParameter(float value, string key) {
            return CryptoUtils.EncryptParameter(value, key);
        }
        #region ChartDataBinding
        public static void BindToData(this LineCurvesChart lcChart, string fieldName, string key) {
            lcChart.Series["Series1"].Points.Clear();
            lcChart.Series["Series2"].Points.Clear();
            Product perfect = new Product();
            perfect.DeserializeFromXml("SuggestedParams.xml");
            foreach (databaseDataSet.productRow dataRow in dataSet.product) {
                var valueX = dataRow["id"];
                var valueY = dataRow[fieldName];

                double realX = Double.Parse(valueX.ToString());
                double realY = Double.Parse(valueY.ToString());

                lcChart.Series["Series1"].Points.Add(new DataPoint(realX, realY));

                var suggestedValue = ReflectionUtils. GetValue(perfect, FieldnameToPropertyName(fieldName));
                double suggestedParam = Double.Parse(suggestedValue.ToString());

                lcChart.Series["Series2"].Points.Add(new DataPoint(realX, suggestedParam));
            }
        }

        static string FieldnameToPropertyName(string fieldName) {
            if (!string.IsNullOrEmpty(fieldName)) {
                string[] separatedValues = fieldName.Split('_');
                var sb = new StringBuilder();
                foreach (var value in separatedValues) {
                    char stChar = value[0];
                    string validValue = stChar + value. Remove(0, 1);
                    validValue = Char.ToUpper(stChar) + validValue. Substring(1);
                    sb. Append(validValue);
                }
                return sb.ToString();
            }
            return string.Empty;
        }

        #endregion
    }
}
