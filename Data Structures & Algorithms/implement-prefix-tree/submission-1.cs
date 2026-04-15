public class PrefixTree {

    Dictionary<char, PrefixTree> dict;
    bool endOfWord;

    public PrefixTree() {
        dict = new Dictionary<char, PrefixTree>();
        endOfWord = false;
    }
    
    public void Insert(string word) {
        char current;
        int i = 0;
        PrefixTree currentTree = this;
        Dictionary<char, PrefixTree> currentDict = currentTree.dict;
        while(i < word.Length){
            current = word[i];
            PrefixTree newPrefixTree;
            if(! currentDict.ContainsKey(current)){
                newPrefixTree = new PrefixTree();
                currentDict[current] = newPrefixTree;
            }
            else newPrefixTree = currentDict[current];

            if(i == word.Length-1){
                newPrefixTree.endOfWord = true;
            }
            currentDict = newPrefixTree.dict;
            currentTree = newPrefixTree;
            i++;
        }
        
    }
    
    public bool Search(string word) {
        char current;
        int i = 0;
        PrefixTree currentTree = this;
        while(i < word.Length){
            current = word[i];
            if(! currentTree.dict.ContainsKey(current)){
                return false;
            }
            currentTree = currentTree.dict[current];
            i++;
        }
        return true && currentTree.endOfWord;   
    }
    
    public bool StartsWith(string prefix) {
        char current;
        int i = 0;
        PrefixTree currentTree = this;
        while(i < prefix.Length){
            current = prefix[i];
            if(! currentTree.dict.ContainsKey(current)){
                return false;
            }
            currentTree = currentTree.dict[current];
            i++;
        }
        return true;
    }
}
