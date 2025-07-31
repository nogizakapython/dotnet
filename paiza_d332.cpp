#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int num1,num2;
    int total;
    cin >> num1;
    cin >> num2;
    total = num1 + num2;
    if(total >= 1000 ){
        cout << total -100 << endl;
    } else {
        cout << total << endl;
    }
    return 0;
}
