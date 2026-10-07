public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
         if (prices == null || n == 0) return 0;
        
        int minPrice = prices[0];
        int maxProfit = 0;

        for(int i = 1; i < n; i++){
            if(prices[i] < minPrice) {
                minPrice = prices[i];
            }
            int profit = prices[i] - minPrice;
            if(profit > maxProfit) maxProfit = profit;
        }
        return maxProfit;
    }
}
