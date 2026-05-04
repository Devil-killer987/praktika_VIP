namespace Master_floor
{
    public static class DiscountCalculator
    {
        public static string CalculateDiscount(double totalSales)
        {
            // Определение процента скидки на основе объема продаж
            if (totalSales < 10000)
            {
                return "0%";
            }
            else if (totalSales >= 10000 && totalSales < 50000)
            {
                return "5%";
            }
            else if (totalSales >= 50000 && totalSales < 300000)
            {
                return "10%";
            }
            else
            {
                return "15%";
            }
        }
    }
}
