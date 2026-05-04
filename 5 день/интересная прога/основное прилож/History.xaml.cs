using System.Linq;
using System.Windows;

namespace Master_floor
{
    public partial class History : Window
    {
        private TestBaseEntities databaseContext = new TestBaseEntities();

        public History(int partnerIdentifier)
        {
            InitializeComponent();
            LoadSalesHistory(partnerIdentifier);
        }

        private void LoadSalesHistory(int partnerIdentifier)
        {
            var salesData = databaseContext.Partners_product
                .Where(sale => sale.ID_Partner == partnerIdentifier)
                .Select(sale => new
                {
                    ProductName = sale.Product.Наименование_продукции,
                    Quantity = sale.Количество_продукции,
                    SaleDate = sale.Дата_продажи
                }).ToList();

            dgHistory.ItemsSource = salesData;
        }
    }
}
