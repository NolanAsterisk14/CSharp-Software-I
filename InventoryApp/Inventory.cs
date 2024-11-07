using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int productID)
        {
            try
            {
                Product product = LookupProduct(productID);
                Products.Remove(product);
            }
            catch
            {
                return false;
            }
            return true;
        }
        
        public Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(product => product.ProductID == productID);
        }

        public void UpdateProduct(int productID, Product product)
        {
            int productIndex = Products.IndexOf(LookupProduct(productID));
            Products[productIndex] = product;
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Part LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(part => part.PartID == partID);
        }

        public void UpdatePart(int partID, Part part)
        {
            int partIndex = AllParts.IndexOf(LookupPart(partID));
            AllParts[partIndex] = part;
        }
    }
}
