using Lab8_Part2_MVC.Models;

namespace Lab8_Part2_MVC.ViewModels
{
    public class Product_Cust_ViewModel
    {
        // Customer Information
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }

        // Customer's Products
        public List<Product> Products { get; set; }
    }
}