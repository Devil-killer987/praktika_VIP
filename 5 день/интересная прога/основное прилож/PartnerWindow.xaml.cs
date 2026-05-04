using System;
using System.Windows;

namespace Master_floor
{
    public partial class PartnerWindow : Window
    {
        private TestBaseEntities databaseContext = new TestBaseEntities();
        private Partner currentPartner;

        public PartnerWindow(Partner partner)
        {
            InitializeComponent();
            currentPartner = partner;

            if (currentPartner != null)
            {
                // Заполнение полей при редактировании
                tbName.Text = currentPartner.Наименование_партнера;
                tbType.Text = currentPartner.Тип_партнера;
                tbDirector.Text = currentPartner.Директор;
                
                // Извлечение числового значения рейтинга
                string ratingValue = currentPartner.Рейтинг.ToString();
                if (ratingValue.Contains("Рейтинг: "))
                    ratingValue = ratingValue.Replace("Рейтинг: ", "");
                tbRating.Text = ratingValue;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentPartner == null) // Режим создания нового партнера
                {
                    var newPartner = new Partner
                    {
                        Наименование_партнера = tbName.Text,
                        Тип_партнера = tbType.Text,
                        Директор = tbDirector.Text,
                        Рейтинг = double.Parse(tbRating.Text)
                    };
                    databaseContext.Partners.Add(newPartner);
                }
                else // Режим редактирования существующего
                {
                    var existingPartner = databaseContext.Partners.Find(currentPartner.ID);
                    existingPartner.Наименование_партнера = tbName.Text;
                    existingPartner.Тип_партнера = tbType.Text;
                    existingPartner.Директор = tbDirector.Text;
                    existingPartner.Рейтинг = double.Parse(tbRating.Text);
                }

                databaseContext.SaveChanges();
                DialogResult = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Произошла ошибка при сохранении: " + error.Message, 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
