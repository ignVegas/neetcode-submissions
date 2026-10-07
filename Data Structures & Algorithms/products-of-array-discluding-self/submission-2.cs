public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] product = new int[n];

        product[0] = 1;
        for(int i = 1; i < n; i++) {
            product[i] = product[i - 1] * nums[i - 1];
        }  

        int suffixProduct = 1;
        for (int i = n - 1; i >= 0; i--) {
        product[i] = product[i] * suffixProduct;
        suffixProduct *= nums[i];

        }
    
        return product;

    }
}
