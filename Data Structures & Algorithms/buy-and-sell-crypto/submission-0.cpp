class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        vector<int> accumulate(n);
        accumulate[0] = 0;
        int a = 0;
        for(int i=1; i< n; i++ ){
            a = accumulate[i-1] + prices[i] - prices[i-1];
            accumulate[i] = max(0, a);
        }
        int max = 0;
        for(int i = 0; i<n ; i++){
            if(accumulate[i] > max){max = accumulate[i];}
        }
        return max;
    }
};
