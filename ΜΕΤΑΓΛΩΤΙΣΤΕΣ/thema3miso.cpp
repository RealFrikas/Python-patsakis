#include <iostream>
#include <string>

using namespace std;

/*
    G→ (M)
    M→ ΥΖ
    Υ→ a | b | G
    Ζ→ *M | -M | +M| ε

    *,+,-,( -→  a,b,(
    ),a,b   -→  *,+,-,)
*/
bool isValidExpression(string& word){
    char prev = '\0';
    for(char c : word) {
        if(prev != '\0'){
            if (prev == '*' || prev == '-' || prev == '+' || prev == '(')
            {
                if (c != 'a' && c != 'b' && c != '(')
                {
                    return false;
                }  
            }else if (prev == 'a' || prev == 'b' || prev == ')')
            {
                if (c != '*' && c != '-' && c != '+' && c != ')')
                {
                    return false;
                }
            }  
        } else if (c != '(') {
            return false;
        }
        prev = c;
    }
    return true;
}

int main(){
    
    string expression;
    cout << "Enter the expression:";
    cin >> expression;
    cout << endl;

    if(isValidExpression(expression)) {
        cout << "The expression is valid." << endl;
        //print tree
    } else {
        cout << "The expression is invalid." << endl;
    }

    system("pause");
    return 0;
}