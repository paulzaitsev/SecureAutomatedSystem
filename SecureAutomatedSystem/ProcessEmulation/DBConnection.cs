﻿using System.Security.Cryptography;
using System.IO;

namespace SecureAutomatedSystem.ProcessEmulation {
   public static class DBConnection {
        private static databaseDataSet DBDataSet = new databaseDataSet();
        private static databaseDataSetTableAdapters.productTableAdapter ProductTableAdapter = new databaseDataSetTableAdapters.productTableAdapter();

        public static void PullNewProduct(Product NewProduct) {            
            databaseDataSet.productRow NewProductRow = DBDataSet.product.NewproductRow();
            NewProductRow.outer_diameter = NewProduct.OuterDiameter.ToString();
            NewProductRow.outer_radius = NewProduct.OuterRadius.ToString();
            NewProductRow.inner_diameter = NewProduct.InnerDiameter.ToString();
            NewProductRow.inner_radius = NewProduct.InnerRadius.ToString();
            NewProductRow.outer_pairing_radius = NewProduct.OuterPairingRadius.ToString();
            NewProductRow.wall_thickness = NewProduct.WallThickness.ToString();
            NewProductRow.top_thickness = NewProduct.TopThickness.ToString();
            NewProductRow.bottom_lowersection_height = NewProduct.BottomLowersectionHeight.ToString();
            NewProductRow.top_diameter = NewProduct.TopDiameter.ToString();
            NewProductRow.outer_pairing_radius_cylindrical_ogive = NewProduct.OuterPairingRadiusCyl.ToString();
            DBDataSet.product.AddproductRow(NewProductRow);
            ProductTableAdapter.Update(DBDataSet.product);
        }

        public static void PullNewProductWithEnctyprion(DES Encryptor, Product NewProduct) {
            databaseDataSet.productRow NewProductRow = DBDataSet.product.NewproductRow();
            NewProductRow.outer_diameter = EncryptParameter(Encryptor, NewProduct.OuterDiameter);
            NewProductRow.outer_radius = EncryptParameter(Encryptor, NewProduct.OuterRadius);
            NewProductRow.inner_diameter = EncryptParameter(Encryptor, NewProduct.InnerDiameter);
            NewProductRow.inner_radius = EncryptParameter(Encryptor, NewProduct.InnerRadius);
            NewProductRow.outer_pairing_radius = EncryptParameter(Encryptor, NewProduct.OuterPairingRadius);
            NewProductRow.wall_thickness = EncryptParameter(Encryptor, NewProduct.WallThickness);
            NewProductRow.top_thickness = EncryptParameter(Encryptor, NewProduct.TopThickness);
            NewProductRow.bottom_lowersection_height = EncryptParameter(Encryptor, NewProduct.BottomLowersectionHeight);
            NewProductRow.top_diameter = EncryptParameter(Encryptor, NewProduct.TopDiameter);
            NewProductRow.outer_pairing_radius_cylindrical_ogive = EncryptParameter(Encryptor, NewProduct.OuterPairingRadiusCyl);
            DBDataSet.product.AddproductRow(NewProductRow);
            ProductTableAdapter.Update(DBDataSet.product);
        }

        private static string EncryptParameter(DES Encryptor, float Parameter) {
            using (MemoryStream msEncrypt = new MemoryStream()) {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, Encryptor.CreateEncryptor(Encryptor.Key, Encryptor.IV), CryptoStreamMode.Write)) {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                        swEncrypt.Write(Parameter);
                    }
                    return System.Text.Encoding.UTF8.GetString(msEncrypt.ToArray());
                }
            }
        }
    }
}
