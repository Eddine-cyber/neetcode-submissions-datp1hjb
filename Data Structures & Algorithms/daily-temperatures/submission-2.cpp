class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        int i = temperatures.size()-1;
        vector<pair<int, int>> temps_heap;
        vector<int> res(temperatures.size());
        temps_heap.push_back({temperatures[0], 0});
        for(int i = 1; i<temperatures.size(); i++){
            pair<int, int> current_temp = {temperatures[i], i};
            while(temps_heap.back().first < current_temp.first && temps_heap.size() > 0){
                res[temps_heap.back().second] = i - temps_heap.back().second;
                temps_heap.pop_back();
            }
            temps_heap.push_back(current_temp);
        }

        return res;

    }
};
