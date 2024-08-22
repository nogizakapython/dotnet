#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int num1,num2;
    int d,c;
    cin >> num1 >> num2;
    if(num1 > 3){
        d = num1 - 3;
    } else {
        d = 0;
    }
    c = 500 + d * num2;
    cout << c << endl;
    return 0;
}
