using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Master_floor
{
    public partial class MainWindow : Window
    {
        private TestBaseEntities databaseContext = new TestBaseEntities();

        public MainWindow()
        {
            InitializeComponent();
            RefreshPartnerList();
        }

        public void RefreshPartnerList()
        {
            var partnerDisplayList = new List<Partner>();
            var allPartners = databaseContext.Partners.ToList();

            foreach (var partner in allPartners)
            {
                // Подсчет общего количества реализованной продукции
                var totalQuantity = databaseContext.Partners_product
                    .Where(sale => sale.ID_Partner == partner.ID)
                    .Sum(sale => (double?)sale.Количество_продукции) ?? 0;

                // Получение скидки через отдельный метод
                string discountValue = DiscountCalculator.CalculateDiscount(totalQuantity);

                partnerDisplayList.Add(new Partner 
                { 
                    ID = partner.ID, 
                    Директор = partner.Директор, 
                    Наименование_партнера = partner.Наименование_партнера, 
                    Рейтинг = "Рейтинг: " + partner.Рейтинг, 
                    Телефон_партнера = partner.Телефон_партнера, 
                    Тип_партнера = partner.Тип_партнера, 
                    Скидка = discountValue 
                });
            }

            listPartner.ItemsSource = partnerDisplayList;
        }

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            var partnerEditor = new PartnerWindow(null);
            if (partnerEditor.ShowDialog() == true) 
                RefreshPartnerList();
        }

        private void PartnerList_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listPartner.SelectedItem is Partner selectedPartner)
            {
                var partnerEditor = new PartnerWindow(selectedPartner);
                if (partnerEditor.ShowDialog() == true) 
                    RefreshPartnerList();
            }
        }

        private void DeletePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            if (listPartner.SelectedItem is Partner selectedPartner)
            {
                var confirmation = MessageBox.Show("Вы действительно хотите удалить данного партнера?", 
                    "Подтверждение удаления", MessageBoxButton.YesNo);
                    
                if (confirmation == MessageBoxResult.Yes)
                {
                    var partnerToRemove = databaseContext.Partners.Find(selectedPartner.ID);
                    databaseContext.Partners.Remove(partnerToRemove);
                    databaseContext.SaveChanges();
                    RefreshPartnerList();
                }
            }
        }

        private void ShowSalesHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (listPartner.SelectedItem is Partner selectedPartner)
            {
                var historyWindow = new History(selectedPartner.ID);
                historyWindow.ShowDialog();
            }
        }
    }
}
