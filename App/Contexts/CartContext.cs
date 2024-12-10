using NgopiSek_Desktop_App_V2.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.App.Contexts
{
    public class CartContext
    {
        public static List<M_Produk> KeranjangProduk = new List<M_Produk>();

        public static void AddToCart(M_Produk produk)
        {
            var existingProduct = KeranjangProduk.FirstOrDefault(p => p.id_produk == produk.id_produk);
            if (existingProduct != null)
            {
                if (existingProduct.stok_produk < produk.stok_produk)
                {
                    existingProduct.stok_produk++;
                }
                else
                {
                    MessageBox.Show($"Stok maksimum untuk {produk.nama_produk} telah tercapai.", "Stok Habis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                KeranjangProduk.Add(new M_Produk
                {
                    id_produk = produk.id_produk,
                    nama_produk = produk.nama_produk,
                    harga_produk = produk.harga_produk,
                    stok_produk = 1,
                    id_kategori = produk.id_kategori,
                    foto_produk = produk.foto_produk,
                    Kategori = produk.Kategori,
                });
            }
        }

        public static bool UpdateQuantityCart(int id_produk, int quantity, int maxStock)
        {
            if (quantity > maxStock)
            {
                MessageBox.Show($"Jumlah maksimum untuk produk ini adalah {maxStock}.", "Stok Terbatas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var cartItem = KeranjangProduk.FirstOrDefault(item => item.id_produk == id_produk);
            if (cartItem == null)
            {
                MessageBox.Show("Produk tidak ditemukan dalam keranjang.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (quantity < 1)
            {
                MessageBox.Show("Jumlah tidak boleh kurang dari 1.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            cartItem.stok_produk = quantity;
            return true;
        }


        public static int GetCartQuantity(int id_produk)
        {
            var cartItem = KeranjangProduk.FirstOrDefault(item => item.id_produk == id_produk);
            return cartItem != null ? cartItem.stok_produk : 0;
        }

        public static void RemoveFromCart(int id_produk)
        {
            var removeProduct = KeranjangProduk.FirstOrDefault(p => p.id_produk == id_produk);
            if (removeProduct != null)
            {
                KeranjangProduk.Remove(removeProduct);
            }
        }

        public static List<M_Produk> GetCartItems()
        {
            return KeranjangProduk;
        }

        public static bool IsCartEmpty()
        {
            return !KeranjangProduk.Any();
        }

        public static void ClearCart()
        {
            KeranjangProduk.Clear();
        }
    }
}