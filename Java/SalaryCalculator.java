public class SalaryCalculator {
    public double multiplierPerDaysSkipped(int daysSkipped) {
        boolean a = daysSkipped>5;
        return a ? 0.85:1.0;
    }
    public int multiplierPerProductsSold(int productsSold) {
        boolean b = productsSold>20;
        return b ? 13:10;
    }
    public double bonusForProductSold(int productsSold) {
        boolean c = productsSold>20;
        return c ? productsSold*13:productsSold*10;
    }
    public double finalSalary(int daysSkipped, int productsSold) {
        var total = 1000.00*multiplierPerDaysSkipped(daysSkipped)+bonusForProductSold(productsSold);
        boolean d = total <= 2000.00;
        return d ? total:2000.00;
    } 
}
