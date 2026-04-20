public class Solution {  
    private List<string> res = new();
    public List<string> GenerateParenthesis(int n) {
        StringBuilder sb = new();
        backtrack(0, 0, sb, n);
        return res;
    }
    private void backtrack(int sum, int nbrOpenUnclosed, StringBuilder curr, int n){
        if(sum == 0) {
            nbrOpenUnclosed++;
            curr.Append('(');
            sum++;
        }
        if(sum == n){
            int nbrOpenUnclosedCopy_ = nbrOpenUnclosed;
            while(nbrOpenUnclosed > 0){
                curr.Append(')');
                nbrOpenUnclosed--;
            }
            res.Add(curr.ToString());
            while(nbrOpenUnclosedCopy_ > 0){
                curr.Remove(curr.Length - 1, 1);
                nbrOpenUnclosedCopy_--;
            }
            return;
        }

        // nbrOpenUnclosed and sum must be fix in the node 
        int nbrOpenUnclosedCopy = nbrOpenUnclosed;
        // left branche
        if(nbrOpenUnclosed>0){
            nbrOpenUnclosed--;
            curr.Append(')');
            backtrack(sum, nbrOpenUnclosed, curr, n);
            curr.Remove(curr.Length - 1, 1);
        }
        // right branche
        curr.Append('(');
        nbrOpenUnclosedCopy++; 
        sum++;
        backtrack(sum, nbrOpenUnclosedCopy, curr, n);
        sum--;
        curr.Remove(curr.Length - 1, 1);
    }
}
