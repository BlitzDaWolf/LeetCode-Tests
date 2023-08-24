import java.util.Stack;

public class MyStack {
    Stack<Integer> stack;

    public MyStack() {
        stack = new Stack<Integer>();
    }
    
    public void push(int x) {
        stack.push(x);
    }
    
    public int pop(){
        return stack.pop();
    }
    
    public int top() {
        return stack.peek();
    }
    
    public boolean empty() {
        return stack.size() == 0;
    }
}
