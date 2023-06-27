using System.Diagnostics.Contracts;

namespace SalesCalculator;
public class SalesCounter {
    private List<Sale> _sales;
    
    public SalesCounter(List<Sale> sales) {
        this._sales = sales;
    }

    // 점포별 매출을 구한다.
    public Dictionary<string, int> GetPerStoreSales() {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (Sale sale in _sales) {
            if (dict.ContainsKey(sale.ShopName!)) {
                dict[sale.ShopName!] += sale.Amount;
            } else {
                dict[sale.ShopName!] = sale.Amount;
            }
        }

        return dict;
    }
}