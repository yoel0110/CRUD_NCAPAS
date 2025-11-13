
using AccessDataLayer;
using System.Data;
namespace DomainLayer
{
    public class CN_Product
    {
        private CD_Products _objectCD = new CD_Products();
        public DataTable DisplayProducts() {
            DataTable dt = new DataTable();
            dt = _objectCD.Reads();
            return dt;
        }
        public void InsertProduct(string nombre, string desc, string marca, string precio, string stock)
        {
            _objectCD.Insert(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void UpdateProduct(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            _objectCD.Update(nombre, desc, marca, Convert.ToDouble(precio),
                Convert.ToInt32(stock), Convert.ToInt32(id));
        }
        public void DeleteProduct(int id)
        {
            _objectCD.Delete(id);
        }
    }
}
