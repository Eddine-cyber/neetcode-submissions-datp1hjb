class MinStack {
public:
    vector<int> pile;
    vector<int> sorted_pile;
    MinStack() {
    }
    
    void push(int val) {
        pile.push_back(val);
        if(sorted_pile.size() == 0){
            sorted_pile.push_back(val);
        }
        else{
            sorted_pile.push_back(min(val, sorted_pile.back()));}
    }
    
    void pop() {
        pile.pop_back();
        sorted_pile.pop_back();
    }
    
    int top() {
        return pile.back();
    }
    
    int getMin() {
        return sorted_pile.back();
    }
};
