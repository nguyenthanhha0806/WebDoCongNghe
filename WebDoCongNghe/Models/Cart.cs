using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDoCongNghe.Models
{
    public class CartItem
    {
        public SanPham sanPham { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        private List<CartItem> lineCollection = new List<CartItem>();

        public void AddItem(SanPham sp, int quantity)
        {
            CartItem line = lineCollection.Where(p => p.sanPham.MaSP == sp.MaSP).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartItem
                {
                    sanPham = sp,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
                if (line.Quantity <= 0)
                {
                    lineCollection.RemoveAll(l => l.sanPham.MaSP == sp.MaSP);
                }
            }
        }
        public void UpdateItem(SanPham sp, int quantity)
        {
            CartItem line = lineCollection
                .Where(p => p.sanPham.MaSP == sp.MaSP)
                .FirstOrDefault();

            if (line != null)
            {
                if (quantity > 0)
                {
                    line.Quantity = quantity;
                }
                else
                {
                    lineCollection.RemoveAll(l => l.sanPham.MaSP == sp.MaSP);
                }
            }
        }
        public void RemoveLine(SanPham sp)
        {
            lineCollection.RemoveAll(l => l.sanPham.MaSP == sp.MaSP);
        }

        public int? ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.sanPham.GiaSale * e.Quantity);

        }
        public int? ComputeTotalProduct()
        {
            return lineCollection.Sum(e => e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartItem> Lines
        {
            get { return lineCollection; }
        }
    }
}
