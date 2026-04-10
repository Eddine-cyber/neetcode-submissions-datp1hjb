class Solution {
public:
    int carFleet(int target, vector<int>& position, vector<int>& speed) {
        int n = position.size();
        vector<float> times(n);
        for(int i =0; i<n; i++){
            times[i] = float(target - position[i])/float(speed[i]);
        }
        vector<int> idx = argsort(position);
        vector<float> times_sorted(n);
        for(int i=0; i<n; i++){
            times_sorted[i] = times[idx[i]];
        }
        int res = 1;
        float current = times_sorted[n-1];
        for(int i = n-2; i>=0; i--){
            if(current < times_sorted[i]){
                res++;
                current = times_sorted[i];
            }
        }

        return res;

    }
    // Argsort : retourne les indices qui trieraient T par ordre croissant
    std::vector<int> argsort(std::vector<int>& T) {
        std::vector<int> idx(T.size());
        std::iota(idx.begin(), idx.end(), 0); // idx = {0, 1, 2, ..., n-1}
        std::sort(idx.begin(), idx.end(),
                [&T](int i, int j) { return T[i] < T[j]; });
        return idx;
}
};
