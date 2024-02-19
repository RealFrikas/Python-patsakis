#include <iostream>
#include <string>

using namespace std;

enum State {
    START,
    X_COUNT,
    Y_COUNT,
    REJECT,
    END
};

string numbertostate(int statenum){
    string ansstate;
    switch(statenum){
        case 0:
        ansstate = "START";
        break;
        case 1:
        ansstate = "X_COUNT";
        break;
        case 2:
        ansstate = "Y_COUNT";
        break;
        case 3:
        ansstate = "REJECT";
        break;
        case 4:
        ansstate = "END";
        break;
    }
    return ansstate;
}

//code that tells the x y counter stuff
State transition(State currentState, char input) {
    switch(currentState) {
        case START:
            if(input == 'x') return X_COUNT;
            //case where input starts with y
            else if(input == 'y') {
                cout << "More Y than X while checking from left to right" << endl;
                return REJECT;
            }
        case X_COUNT:
            if(input == 'x') return X_COUNT;
            else if(input == 'y') return Y_COUNT;
            else {
                cout << "Not valid Symbol" << endl;
                return REJECT;
            }
        case Y_COUNT:
            if(input == 'x') return X_COUNT;
            else if(input == 'y') return Y_COUNT;
            else {
                cout << "Not valid Symbol" << endl;
                return REJECT;
            }    
    }
    return END;
}

bool isValidExpression(const string& expression) {
    State currentState = START;
    int xCount = 0;
    int yCount = 0;
    cout << "Checking from left to right for rule" << endl;
    for(char c : expression) {
        currentState = transition(currentState, c);
        if(currentState == X_COUNT) xCount++;
        else if(currentState == Y_COUNT) yCount++;
        else if(currentState == REJECT) break;
        if (yCount > xCount)
        {
            currentState = REJECT;
            cout << "More Y than X while checking from left to right" << endl;
            break;
        }   
    }

    //change state from count to end
    if (currentState != REJECT) {
            currentState = END;
    }

    //check if all characters have been checked
    if (expression[sizeof(expression) / sizeof(expression[0])] == '\0') {
        if (currentState != REJECT)
        {
            currentState = END;
        }
    }

    //no need to check for < cause one case is handled from left to right
    if (currentState != REJECT)
        {
        cout << "checking if there are equal number of X and Y" << endl;
        if (xCount > yCount)
        {
            currentState = REJECT;
            cout << "More X than Y exist" << endl;
        }
        cout << "X Count: " << xCount << ", Y Count: " << yCount << endl;
    }
    cout << "Final State: " << numbertostate(currentState) << endl;
    return currentState != REJECT && xCount == yCount;
}

int main() {
    string expression;
    cout << "Enter the expression:";
    cin >> expression;
    cout << endl;
    if(isValidExpression(expression)) {
        cout << "The expression is valid." << endl;
    } else {
        cout << "The expression is invalid." << endl;
    }
    system("pause");
    return 0;
}